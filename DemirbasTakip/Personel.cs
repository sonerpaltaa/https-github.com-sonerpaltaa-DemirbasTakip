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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlCommand komut;
   
   
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
            string kayit = "SELECT PersonelAdi,PersonelSoyadi,PersonelID from tblPersonel";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            VTkapat();


        }

        void KayıtSil(int numara)
        {
            try
            {
                VTbaglan();
                string sql = "DELETE FROM tblPersonel WHERE PersonelID=@numara";
                komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@numara", numara);

                komut.ExecuteNonQuery();
                VTkapat();


            }
            catch
            {
                MessageBox.Show("Personel silinemiyor. Üzerine kayıtlı kullanıcı Var.");
            }
            VTkapat();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VTbaglan();
            komut = new SqlCommand("insert into tblPersonel(PersonelAdi,PersonelSoyadi)values(@padi,@psadi)", baglanti);
            komut.Parameters.AddWithValue("@padi", textBox1.Text);
            komut.Parameters.AddWithValue("@psadi", textBox2.Text);
           
            komut.ExecuteNonQuery();
            VTkapat();
            MessageBox.Show("Personel başarıyla eklendi.");
        }

        private void btnAdminBack_Click(object sender, EventArgs e)
        {
            frmAdmin frmadmin = new frmAdmin();
            frmadmin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {

                int numara = Convert.ToInt32(drow.Cells[2].Value);
                KayıtSil(numara);
            }
            dgwPersonelDoldur();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            dgwPersonelDoldur();
        }
    }
}
