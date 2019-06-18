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
    public partial class frmStokEkle : Form
    {
        public frmStokEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;
      

        public void HarfGirisiKontrol(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Harf Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SayiGirisiKontrol(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Sayı Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void VTbaglan()
        {
            baglanti = new SqlConnection("Data Source=SONERPALTA\\SQLEXPRESS;Initial Catalog=DemirbasTakip;Integrated Security=True");
            baglanti.Open();
        }

        public void VTkapat()
        {
            baglanti.Close();
        }

        private void frmStokEkle_Load(object sender, EventArgs e)
        {
            VTbaglan();
            komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM tblDemirbasTurleri";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lboxDemirbasTuruID.Items.Add(dr["DemirbasTuruID"]);
                lboxDemirbasTuruAdi.Items.Add(dr["DemirbasTuruAdi"]);
            }
            VTkapat();
        }

       


        private void btnSEekle_Click(object sender, EventArgs e)
        {
            try
            {
               
                {
                    VTbaglan();
                    komut = new SqlCommand("insert into tblDemirbas(DemirbasAdi,Fiyat,AlimTarihi,DemirbasTuruID,Adet)values(@Dadi,@fiyat,@alimTarihi,@DturID,@adet)", baglanti);
                    komut.Parameters.AddWithValue("@Dadi", txtSEdemirbasAdi.Text);
                    komut.Parameters.AddWithValue("@fiyat", txtSEfiyat.Text);
                    komut.Parameters.AddWithValue("@alimTarihi", dtpAlimTarihi.Value);
                    komut.Parameters.AddWithValue("@DturID", txtDemirbasTuruID.Text);
                    komut.Parameters.AddWithValue("@adet", txtSEadet.Text);
                    komut.ExecuteNonQuery();
                    VTkapat();
                    MessageBox.Show("Demirbaş başarıyla eklendi.");
                    txtSEdemirbasAdi.Text = "";
                    txtSEfiyat.Text = "";
                    txtDemirbasTuruID.Text = "";
                    txtSEadet.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Kayıtlı Demirbaş...");
                VTkapat();
            }
        }

        private void lboxDemirbasTuruID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDemirbasTuruID.Text = lboxDemirbasTuruID.SelectedItem.ToString();
        }

        private void btnAdminBack_Click(object sender, EventArgs e)
        {
            frmAdmin frmadmin = new frmAdmin();
            frmadmin.Show();
            this.Hide();
        }

      
    }
}
