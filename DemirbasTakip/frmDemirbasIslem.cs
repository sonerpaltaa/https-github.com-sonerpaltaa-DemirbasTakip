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
    public partial class frmDemirbasIslem : Form
    {
        public frmDemirbasIslem()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        DataSet ds, ds1,ds2;
        SqlDataAdapter da, da1,da2;
        string departmanID, demirbasID,personelID,kullaniciID;
        public void VTbaglan()
        {
            baglanti = new SqlConnection("Data Source=SONERPALTA\\SQLEXPRESS;Initial Catalog=DemirbasTakip;Integrated Security=True");
            baglanti.Open();
        }
        public void VTkapat()
        {
            baglanti.Close();
        }
        public void GuncelleAdet()
        {
            VTbaglan();
            string sorgu = "UPDATE tblDemirbas SET Adet=@adet WHERE DemirbasID=@demirbasID ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@adet", (stok-Alinanadet));
            komut.Parameters.AddWithValue("@demirbasID", demirbasID);
            komut.ExecuteNonQuery();
            VTkapat();
        }
        public void dgwDepDoldur()
        {
            VTbaglan();
            da = new SqlDataAdapter("SELECT O.DepartmanID,DepartmanAdi,ODT.PersonelID,PersonelAdi,PersonelSoyadi,k.KullaniciID FROM tblDepartman O INNER JOIN tbldepDemirbasAtama ODT ON O.DepartmanID = ODT.DepartmanID INNER JOIN tblPersonel P ON ODT.PersonelID = P.PersonelID INNER JOIN tblKullanicilar k ON ODT.KullaniciID = k.KullaniciID", baglanti);
            ds = new DataSet();
            da.Fill(ds, "tblDepartman");
            dgwDepartman.DataSource = ds.Tables["tblDepartman"];
            VTkapat();
        }
        public void dgwDemirbasDoldur()
        {
            VTbaglan();
            da1 = new SqlDataAdapter("SELECT DemirbasID,DemirbasAdi,Fiyat,Adet FROM tblDemirbas", baglanti);
            ds1 = new DataSet();
            da1.Fill(ds1, "tblDemirbas");
            dgwDemirbas.DataSource = ds1.Tables["tblDemirbas"];
            VTkapat();
        }
        public void dgwDepSecimiDoldur()
        {
            VTbaglan();
            da2 = new SqlDataAdapter("SELECT D.DemirbasID,DemirbasAdi,AlinanAdet FROM tbldepDemirbasAtama ODT INNER JOIN tblDemirbas D ON ODT.DemirbasID=D.DemirbasID INNER JOIN tblDepartman O ON ODT.DepartmanID=O.DepartmanID WHERE ODT.DepartmanID= '"+ departmanID.ToString() +"'", baglanti);
            ds2 = new DataSet();
            da2.Fill(ds2, "tbldepDemirbasAtama");
            dgwDemirbasListesi.DataSource = ds2.Tables["tbldepDemirbasAtama"];
            VTkapat();
        }
        void KayıtSil(int numara)
        {
           
            
                VTbaglan();
                string sql = "DELETE FROM tbldepDemirbasAtama WHERE DemirbasID=@numara";
                komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@numara", numara);

                komut.ExecuteNonQuery();
                VTkapat();


           

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dgwDemirbasListesi.SelectedRows)  //Seçili Satırları Silme
            {

                int numara = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(numara);
            }
            dgwDepSecimiDoldur();
        }

        private void frmDemirbasIslem_Load(object sender, EventArgs e)
        {
            dgwDepartman.AllowUserToAddRows = false;
            dgwDemirbas.AllowUserToAddRows = false;
            dgwDepDoldur();
            dgwDemirbasDoldur();
            dgwDepSecimiDoldur();          
        }

       

        int Alinanadet,stok;
        private void btnDemirbasIslemKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                if (txtDIAdet.Text.Trim() == "") errorProvider1.SetError(txtDIAdet, "Boş geçilmez");
                else errorProvider1.SetError(txtDIAdet, "");
                */
                if (txtDIAdet.Text.Trim() != "")
                {
                    Alinanadet = int.Parse(txtDIAdet.Text);
                    if (Alinanadet > stok)
                    {
                        MessageBox.Show("Girilen değer stok miktarından fazla.Daha az bir değer giriniz...");
                    }
                    else
                    {
                        VTbaglan();
                        komut = new SqlCommand("insert into tbldepDemirbasAtama(DepartmanID,DemirbasID,AlinanAdet,PersonelID,KullaniciID,VerilisTarih)values(@departmanID,@demirbasID,@alinanAdet,@personelID,@kullaniciID,@verilistarih)", baglanti);
                        komut.Parameters.AddWithValue("@departmanID", departmanID);
                        komut.Parameters.AddWithValue("@demirbasID", demirbasID);
                        komut.Parameters.AddWithValue("@alinanAdet", Alinanadet);
                        komut.Parameters.AddWithValue("@personelID", personelID);
                        komut.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                        komut.Parameters.AddWithValue("@verilistarih", dtpAlimTarihi.Value);
                        komut.ExecuteNonQuery();
                        GuncelleAdet();
                        dgwDemirbasDoldur();
                        dgwDepSecimiDoldur();
                        VTkapat();
                        MessageBox.Show("Departmana Demirbaş Atandı...");
                        txtDIAdet.Text = "";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hatalı İşlem Yaptınız.Tekrar deneyiniz...");
            }
        }

        private void btnDemirbasBack_Click(object sender, EventArgs e)
        {
            frmAnaMenu frmanamenu = new frmAnaMenu(this);
            frmanamenu.Show();
        }

        private void dgwDepartman_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtdepAdi.Text = ds.Tables["tblDepartman"].Rows[e.RowIndex]["PersonelAdi"].ToString();
            departmanID = ds.Tables["tblDepartman"].Rows[e.RowIndex]["DepartmanID"].ToString();
            personelID = ds.Tables["tblDepartman"].Rows[e.RowIndex]["PersonelID"].ToString();
            kullaniciID = ds.Tables["tblDepartman"].Rows[e.RowIndex]["KullaniciID"].ToString();
            dgwDepSecimiDoldur();
        }

        private void dgwDemirbas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtDemirbasAdi.Text = ds1.Tables["tblDemirbas"].Rows[e.RowIndex]["DemirbasAdi"].ToString();
            demirbasID = ds1.Tables["tblDemirbas"].Rows[e.RowIndex]["DemirbasID"].ToString();
            stok = Convert.ToInt32(ds1.Tables["tblDemirbas"].Rows[e.RowIndex]["Adet"]);
        }

        private void txtDIAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Sayı Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
