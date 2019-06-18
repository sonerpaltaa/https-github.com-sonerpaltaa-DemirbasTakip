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
    public partial class frmDepGuncelle : Form
    {
        public frmDepGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;

        public void VTbaglan()
        {
            baglanti = new SqlConnection("Data Source=SONERPALTA\\SQLEXPRESS;Initial Catalog=DemirbasTakip;Integrated Security=True");
            baglanti.Open();
        }

        public void VTkapat()
        {
            baglanti.Close();
        }

        void ComboboxDoldur()
        {            
            VTbaglan();
            komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM tblDepartman";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
            
                cboOdaESGodaAdiGuncel.SelectedItem = null;
                cboOdaESGodaAdiGuncel.Items.Add(dr["DepartmanAdi"]);
            }
            VTkapat();
        }

        private void frmDepGuncelle_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();
        }

        private void btnDepESGguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                VTbaglan();
                string sorgu = "UPDATE tblDepartman SET DepartmanAdi=@depAdi WHERE DepartmanAdi=@EdepAdi ";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@depAdi", txtOdaESGyeniOdaAdi.Text);
                komut.Parameters.AddWithValue("@EdepAdi", cboOdaESGodaAdiGuncel.Text);
                komut.ExecuteNonQuery();
                VTkapat();
                MessageBox.Show("Kayıt Başarıyla Güncellendi.");
               
                ComboboxDoldur();
            }
            catch
            {
                MessageBox.Show("Hatalı İşlem...");
            }
        }

        private void btnOdaEkleSilBack_Click(object sender, EventArgs e)
        {
            frmAdmin frmadmin = new frmAdmin();
            frmadmin.Show();
            this.Hide();      
        }     
    }
}
