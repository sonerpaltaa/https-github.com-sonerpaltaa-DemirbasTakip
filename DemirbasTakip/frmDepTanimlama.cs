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
    public partial class frmDepTanimlama : Form
    {
        public frmDepTanimlama()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlCommand komut;
        DataSet ds,ds1;
        SqlDataAdapter da,da1;
        public void VTbaglan()
        {
            baglanti = new SqlConnection("Data Source=SONERPALTA\\SQLEXPRESS;Initial Catalog=DemirbasTakip;Integrated Security=True");
            baglanti.Open();
        }

        public void VTkapat()
        {
            baglanti.Close();
        }
        private void btnTanimlamaBack_Click(object sender, EventArgs e)
        {
            frmAnaMenu frmanamenu = new frmAnaMenu(this);
            frmanamenu.Show();
            
        }

        private void frmOdaTanimlama_Load(object sender, EventArgs e)
        {
            dGWOda.AllowUserToAddRows = false;
            dGWPersonel.AllowUserToAddRows = false;
            VTbaglan();
            da = new SqlDataAdapter("SELECT DepartmanID,DepartmanAdi FROM tblDepartman", baglanti);
            ds = new DataSet();
            da.Fill(ds, "tblDepartman");
            dGWOda.DataSource = ds.Tables["tblDepartman"];
            VTkapat();

            VTbaglan();
            da1 = new SqlDataAdapter(" SELECT p.PersonelID,PersonelAdi,PersonelSoyadi,k.KullaniciID FROM tblPersonel p INNER JOIN tblKullanicilar k ON k.PersonelID=p.PersonelID", baglanti);
            ds1 = new DataSet();
            da1.Fill(ds1, "tblPersonel");
            dGWPersonel.DataSource = ds1.Tables["tblPersonel"];
            VTkapat();
        }
        string PersonelID,OdaID,KullaniciID;
        

        private void btnOTodaKaydet_Click(object sender, EventArgs e)
        {
            VTbaglan();
            komut = new SqlCommand("insert into tbldepDemirbasAtama(DepartmanID,PersonelId,KullaniciID)values(@odaID,@personelID,@kullaniciID)", baglanti);
            komut.Parameters.AddWithValue("@odaID", OdaID);
            komut.Parameters.AddWithValue("@personelID", PersonelID);
            komut.Parameters.AddWithValue("@kullaniciID", KullaniciID);
            komut.ExecuteNonQuery();
            VTkapat();
            MessageBox.Show("Personel a Atandı.");
        }

        private void dGWOda_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtOTodaAdi.Text=ds.Tables["tblDepartman"].Rows[e.RowIndex]["DepartmanAdi"].ToString();
            OdaID = ds.Tables["tblDepartman"].Rows[e.RowIndex]["DepartmanID"].ToString();
        }

        private void dGWPersonel_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtOTOdaSorumlusu.Text = ds1.Tables["tblPersonel"].Rows[e.RowIndex]["PersonelAdi"].ToString();
            PersonelID = ds1.Tables["tblPersonel"].Rows[e.RowIndex]["PersonelID"].ToString();
            KullaniciID = ds1.Tables["tblPersonel"].Rows[e.RowIndex]["KullaniciID"].ToString();
        }     
    }
}
