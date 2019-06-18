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
    public partial class frmTur : Form
    {
        public frmTur()
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
       

        private void TurBtn_Click(object sender, EventArgs e)
        {
            VTbaglan();
            komut = new SqlCommand("insert into tblDemirbasTurleri(DemirbasTuruAdi)values(@demirbasTuradi)", baglanti);
            komut.Parameters.AddWithValue("@demirbasTuradi", textBox1.Text);
           
            komut.ExecuteNonQuery();
            VTkapat();
            MessageBox.Show("Başarılı.");
        }

        private void btnAramalarBack_Click(object sender, EventArgs e)
        {
            frmAnaMenu anaMenu = new frmAnaMenu();
            anaMenu.Show();
            this.Hide();
        }

        void ComboboxDoldur()
        {
            VTbaglan();
            komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM tblDemirbasTurleri";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboSilTur.Items.Add(dr["DemirbasTuruAdi"]);
            }
            VTkapat();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            VTbaglan();
            string sorgu = "DELETE FROM tblDemirbasTurleri WHERE DemirbasTuruAdi=@demAdi ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@demAdi", comboSilTur.Text);
            komut.ExecuteNonQuery();
            VTkapat();
            MessageBox.Show("Kayıt Başarıyla Silindi.");
            comboSilTur.Text = "";
            comboSilTur.Items.Clear();
            ComboboxDoldur();
        }

        private void frmTur_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();        }
    }
}
