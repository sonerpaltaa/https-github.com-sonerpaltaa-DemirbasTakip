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
    public partial class frmDemisbas : Form
    {
        public frmDemisbas()
        {
            InitializeComponent();

        }

        SqlCommand komut;
        DataSet ds;
        SqlDataAdapter sda;
        
       
        
        SqlConnection baglanti;
        private object frm;

        public void VTbaglan()
        {

            baglanti.Open();
        }

        public void VTkapat()
        {
            baglanti.Close();
        }

        private void frmDemisbas_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=SONERPALTA\\SQLEXPRESS;Initial Catalog=DemirbasTakip;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {                  
                string sql = @"SELECT D.DemirbasID,DemirbasAdi,AlinanAdet,VerilisTarih
                               FROM tbldepDemirbasAtama ODT
                               INNER JOIN tblDemirbas D ON ODT.DemirbasID = D.DemirbasID
                               INNER JOIN tblPersonel P ON P.PersonelID=ODT.PersonelID 
                               where odt.KullaniciID = @kullaniciID";
                komut = new SqlCommand();
                komut.CommandText = sql;
                komut.Parameters.Add(new SqlParameter("@kullaniciID", SistemParametre.SistemKullanci));
                komut.Connection = baglanti;

                sda = new SqlDataAdapter();
                sda.SelectCommand = komut;

                ds = new DataSet();
                VTbaglan();
                sda.Fill(ds, "tbldepDemirbasAtama");
                VTkapat();
                dataGridView1.DataSource = ds.Tables["tbldepDemirbasAtama"];


            }
            catch (Exception ex)
            {
                VTkapat();
                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void btnAdminBack_Click(object sender, EventArgs e)
        {
            frmAnaMenu frmAna = new frmAnaMenu();
            frmAna.Show();
            this.Hide();
        }
    }
}
