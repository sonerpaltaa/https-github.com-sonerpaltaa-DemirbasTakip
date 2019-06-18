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
    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu(Form f)
        {
            InitializeComponent();
            f.Close();
        }

        public frmAnaMenu()
        {
        }

        SqlConnection baglanti;
        SqlCommand sc;
        DataTable dt;
        SqlDataReader okuyucu;
        public void VTbaglan()
        {
            baglanti = new SqlConnection("Data Source=SONERPALTA\\SQLEXPRESS;Initial Catalog=DemirbasTakip;Integrated Security=True");
            baglanti.Open();
        }

        public void VTkapat()
        {
            baglanti.Close();
        }




        private void frmAnaMenu_Load(object sender, EventArgs e)
        {


            VTbaglan();
            string k = frmGiris.kadi;
            string s = frmGiris.sifre;
            sc = new SqlCommand("SELECT YetkiID FROM tblKullanicilar WHERE KullaniciAdi='" + k + "' AND Sifre='" + s + "'", baglanti);
            okuyucu = sc.ExecuteReader();
            dt = new DataTable();
            while (okuyucu.Read())
            {
                string yetki = okuyucu[0].ToString();
                if (yetki == "True") 
                   btnAdmin.Enabled = true;
                else
                {
                    btnAdmin.Visible = false;
                    btnDepDemirbasIslemleri.Visible = false;
                    btnDepTanimlama.Visible = false;
                    btnArama.Visible = false;
                    
                }
            }
            VTkapat();
        }


        private void btnDepDemirbas_Click(object sender, EventArgs e)
        {
            frmDemirbasIslem frmdemirbasislem = new frmDemirbasIslem();
            frmdemirbasislem.Show();
            this.Hide();
        }

        private void btnDepTanimlama_Click(object sender, EventArgs e)
        {
            frmDepTanimlama frmdeptanimla = new frmDepTanimlama();
            frmdeptanimla.Show();
            this.Hide();
        }

       

        private void frmAnaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDemisbaslarim_Click(object sender, EventArgs e)
        {
            frmDemisbas demisbaslar = new frmDemisbas();
            demisbaslar.Show();
            this.Hide();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            frmAramalar frmaramalar = new frmAramalar();
            frmaramalar.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frmadmin = new frmAdmin();
            frmadmin.Show();
            this.Hide();
        }
    }
}
