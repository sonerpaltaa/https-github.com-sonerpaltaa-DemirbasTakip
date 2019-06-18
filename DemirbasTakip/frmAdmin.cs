using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemirbasTakip
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnAdminBack_Click(object sender, EventArgs e)
        {
            frmAnaMenu frmanamenu = new frmAnaMenu(this);
            frmanamenu.Show();
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            frmStokEkle frmstokekleme = new frmStokEkle();
            frmstokekleme.Show();
            this.Hide();
        }

        private void btnStokGuncelle_Click(object sender, EventArgs e)
        {
            frmStokGuncelleme frmStok = new frmStokGuncelleme();
            frmStok.Show();
            this.Hide();
        }

     
        private void btnDepGuncelle_Click(object sender, EventArgs e)
        {
            frmDepGuncelle depGuncelle = new frmDepGuncelle();
            depGuncelle.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKullanici frmuser = new frmKullanici();
            frmuser.Show();
            this.Hide();
        }

        private void btnDepEkle_Click(object sender, EventArgs e)
        {
            DepartmanEkle dep = new DepartmanEkle();
            dep.Show();
            this.Hide();
        }

        private void btnDepSil_Click(object sender, EventArgs e)
        {
            frmDepSil odasil = new frmDepSil();
            odasil.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTur frmtur = new frmTur();
            frmtur.Show();
            this.Hide();
        }
    }
}
