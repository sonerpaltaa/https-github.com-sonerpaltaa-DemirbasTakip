using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemirbasTakip
{
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlCommand komut;
        DataTable dt;
        DataSet ds;
        SqlDataAdapter sda;
        SqlDataReader dr;

        string personelAdi, demirbasID, personelID, personelSoyadi;

        public void VTbaglan()
        {
            baglanti = new SqlConnection("Data Source=SONERPALTA\\SQLEXPRESS;Initial Catalog=DemirbasTakip;Integrated Security=True");
            baglanti.Open();
        }
        public void VTkapat()
        {
            baglanti.Close();
        }

        public void dgwPersonelDoldur()
        {
            VTbaglan();
            string kayit = "SELECT * from tblPersonel";
            
            SqlCommand komut = new SqlCommand(kayit, baglanti);
          
            SqlDataAdapter da = new SqlDataAdapter(komut);
           
            DataTable dt = new DataTable();
            da.Fill(dt);
          
            PersonelekleDataGrid.DataSource = dt;
         
            VTkapat();

        }

        public void dgwKullaniciDoldur()
        {
            VTbaglan();
            string kayit = "SELECT KullaniciID,KullaniciAdi,e_mail,yetkiID from tblKullanicilar";
          
            SqlCommand komut = new SqlCommand(kayit, baglanti);
         
            SqlDataAdapter da = new SqlDataAdapter(komut);
           
            DataTable dt = new DataTable();
            da.Fill(dt);
          
            dataGridView2.DataSource = dt;
           
            VTkapat();
        }

        void KayıtSil(int numara)
        {
            try
            {
                VTbaglan();
                string sql = "DELETE FROM tblKullanicilar WHERE KullaniciID=@numara";
                komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@numara", numara);

                komut.ExecuteNonQuery();
                VTkapat();

            
            }
            catch
            {
                MessageBox.Show("Kullanıcının üzerine zimmetli demirbaşlar var.");
            }
            VTkapat();
            
        }
        private void frmKullanici_Load(object sender, EventArgs e)
        {
            
            dgwPersonelDoldur();
            dgwKullaniciDoldur();
            ComboboxDoldur();
        }

        void ComboboxDoldur()
        {
            VTbaglan();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM tblPersonel";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                PersComboList.Items.Add(dr["PersonelAdi"]);
               
            }
            VTkapat();
        }

        private void ekleButon_Click(object sender, EventArgs e)
        {
            VTbaglan();
           
            komut = new SqlCommand("insert into tblKullanicilar(PersonelID,KullaniciAdi,YetkiID,Sifre,e_mail)values(@persid,@username,@yetki,@sifre,@email)", baglanti);
            komut.Parameters.AddWithValue("@persid", PersComboList.Text);
            komut.Parameters.AddWithValue("@username", textBox2.Text);
            komut.Parameters.AddWithValue("@yetki", textBox3.Text);
            komut.Parameters.AddWithValue("@sifre", textBox4.Text);
            komut.Parameters.AddWithValue("@email", textBox5.Text);
            komut.ExecuteNonQuery();
            VTkapat();
            MessageBox.Show("Kullanıcı başarıyla eklendi.");
            dgwKullaniciDoldur();
           
        }

    

        private void btnAdminBack_Click(object sender, EventArgs e)
        {
            frmAdmin frmadmin = new frmAdmin();
            frmadmin.Show();
            this.Hide();

        }

        

        private void usernamesil_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow drow in dataGridView2.SelectedRows)  //Seçili Satırları Silme
            {

                int numara = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(numara);
            }
            dgwKullaniciDoldur();
        }
       
       
    }
    }

