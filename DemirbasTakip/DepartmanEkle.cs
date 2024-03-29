﻿using System;
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
    public partial class DepartmanEkle : Form
    {
        public DepartmanEkle()
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

        private void DepartmanEkle_Load(object sender, EventArgs e)
        {
        }

        private void btnDepESGekle_Click(object sender, EventArgs e)
        {
            VTbaglan();
            komut = new SqlCommand("insert into tblDepartman(DepartmanAdi) values (@depAdi)", baglanti);
            komut.Parameters.AddWithValue("@depAdi", txtDepESGdepAdi.Text);
           
            komut.ExecuteNonQuery();
            VTkapat();
            MessageBox.Show("Departman başarıyla eklendi.");
        }

        private void btnAdminBack_Click(object sender, EventArgs e)
        {
            frmAdmin frmadmin = new frmAdmin();
            frmadmin.Show();
            this.Hide();
        }
    }
}
