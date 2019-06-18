namespace DemirbasTakip
{
    partial class frmStokEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lboxDemirbasTuruAdi = new System.Windows.Forms.ListBox();
            this.lboxDemirbasTuruID = new System.Windows.Forms.ListBox();
            this.txtSEfiyat = new System.Windows.Forms.TextBox();
            this.txtSEdemirbasAdi = new System.Windows.Forms.TextBox();
            this.lblSEfiyat = new System.Windows.Forms.Label();
            this.lblSEdemirbasAdi = new System.Windows.Forms.Label();
            this.dtpAlimTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtDemirbasTuruID = new System.Windows.Forms.TextBox();
            this.txtSEadet = new System.Windows.Forms.TextBox();
            this.lblSEadet = new System.Windows.Forms.Label();
            this.btnSEekle = new System.Windows.Forms.Button();
            this.lblSEalimTarihi = new System.Windows.Forms.Label();
            this.lblSEdemirbasTuru = new System.Windows.Forms.Label();
            this.btnAdminBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxDemirbasTuruAdi
            // 
            this.lboxDemirbasTuruAdi.Enabled = false;
            this.lboxDemirbasTuruAdi.FormattingEnabled = true;
            this.lboxDemirbasTuruAdi.Location = new System.Drawing.Point(481, 53);
            this.lboxDemirbasTuruAdi.Margin = new System.Windows.Forms.Padding(2);
            this.lboxDemirbasTuruAdi.Name = "lboxDemirbasTuruAdi";
            this.lboxDemirbasTuruAdi.Size = new System.Drawing.Size(90, 134);
            this.lboxDemirbasTuruAdi.TabIndex = 25;
            // 
            // lboxDemirbasTuruID
            // 
            this.lboxDemirbasTuruID.FormattingEnabled = true;
            this.lboxDemirbasTuruID.Location = new System.Drawing.Point(377, 53);
            this.lboxDemirbasTuruID.Margin = new System.Windows.Forms.Padding(2);
            this.lboxDemirbasTuruID.Name = "lboxDemirbasTuruID";
            this.lboxDemirbasTuruID.Size = new System.Drawing.Size(90, 134);
            this.lboxDemirbasTuruID.TabIndex = 24;
            this.lboxDemirbasTuruID.SelectedIndexChanged += new System.EventHandler(this.lboxDemirbasTuruID_SelectedIndexChanged);
            // 
            // txtSEfiyat
            // 
            this.txtSEfiyat.Location = new System.Drawing.Point(215, 99);
            this.txtSEfiyat.Name = "txtSEfiyat";
            this.txtSEfiyat.Size = new System.Drawing.Size(61, 20);
            this.txtSEfiyat.TabIndex = 23;
          
            // 
            // txtSEdemirbasAdi
            // 
            this.txtSEdemirbasAdi.Location = new System.Drawing.Point(215, 53);
            this.txtSEdemirbasAdi.Name = "txtSEdemirbasAdi";
            this.txtSEdemirbasAdi.Size = new System.Drawing.Size(146, 20);
            this.txtSEdemirbasAdi.TabIndex = 22;
            // 
            // lblSEfiyat
            // 
            this.lblSEfiyat.AutoSize = true;
            this.lblSEfiyat.Location = new System.Drawing.Point(103, 102);
            this.lblSEfiyat.Name = "lblSEfiyat";
            this.lblSEfiyat.Size = new System.Drawing.Size(43, 13);
            this.lblSEfiyat.TabIndex = 21;
            this.lblSEfiyat.Text = "FİYAT :";
            // 
            // lblSEdemirbasAdi
            // 
            this.lblSEdemirbasAdi.AutoSize = true;
            this.lblSEdemirbasAdi.Location = new System.Drawing.Point(103, 55);
            this.lblSEdemirbasAdi.Name = "lblSEdemirbasAdi";
            this.lblSEdemirbasAdi.Size = new System.Drawing.Size(90, 13);
            this.lblSEdemirbasAdi.TabIndex = 20;
            this.lblSEdemirbasAdi.Text = "DEMİRBAŞ ADI :";
            // 
            // dtpAlimTarihi
            // 
            this.dtpAlimTarihi.Location = new System.Drawing.Point(217, 137);
            this.dtpAlimTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpAlimTarihi.Name = "dtpAlimTarihi";
            this.dtpAlimTarihi.Size = new System.Drawing.Size(145, 20);
            this.dtpAlimTarihi.TabIndex = 32;
            // 
            // txtDemirbasTuruID
            // 
            this.txtDemirbasTuruID.Enabled = false;
            this.txtDemirbasTuruID.Location = new System.Drawing.Point(215, 225);
            this.txtDemirbasTuruID.Name = "txtDemirbasTuruID";
            this.txtDemirbasTuruID.Size = new System.Drawing.Size(61, 20);
            this.txtDemirbasTuruID.TabIndex = 31;
            // 
            // txtSEadet
            // 
            this.txtSEadet.Location = new System.Drawing.Point(217, 185);
            this.txtSEadet.Name = "txtSEadet";
            this.txtSEadet.Size = new System.Drawing.Size(60, 20);
            this.txtSEadet.TabIndex = 29;
            // 
            // lblSEadet
            // 
            this.lblSEadet.AutoSize = true;
            this.lblSEadet.Location = new System.Drawing.Point(103, 187);
            this.lblSEadet.Name = "lblSEadet";
            this.lblSEadet.Size = new System.Drawing.Size(36, 13);
            this.lblSEadet.TabIndex = 28;
            this.lblSEadet.Text = "ADET";
            // 
            // btnSEekle
            // 
            this.btnSEekle.Location = new System.Drawing.Point(124, 264);
            this.btnSEekle.Name = "btnSEekle";
            this.btnSEekle.Size = new System.Drawing.Size(220, 57);
            this.btnSEekle.TabIndex = 30;
            this.btnSEekle.Text = "EKLE";
            this.btnSEekle.UseVisualStyleBackColor = true;
            this.btnSEekle.Click += new System.EventHandler(this.btnSEekle_Click);
            // 
            // lblSEalimTarihi
            // 
            this.lblSEalimTarihi.AutoSize = true;
            this.lblSEalimTarihi.Location = new System.Drawing.Point(103, 141);
            this.lblSEalimTarihi.Name = "lblSEalimTarihi";
            this.lblSEalimTarihi.Size = new System.Drawing.Size(77, 13);
            this.lblSEalimTarihi.TabIndex = 27;
            this.lblSEalimTarihi.Text = "ALIM TARİHİ :";
            // 
            // lblSEdemirbasTuru
            // 
            this.lblSEdemirbasTuru.AutoSize = true;
            this.lblSEdemirbasTuru.Location = new System.Drawing.Point(103, 227);
            this.lblSEdemirbasTuru.Name = "lblSEdemirbasTuru";
            this.lblSEdemirbasTuru.Size = new System.Drawing.Size(114, 13);
            this.lblSEdemirbasTuru.TabIndex = 26;
            this.lblSEdemirbasTuru.Text = "DEMİRBAŞ TÜRÜ ID:";
            // 
            // btnAdminBack
            // 
            this.btnAdminBack.FlatAppearance.BorderSize = 0;
            this.btnAdminBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminBack.Image = global::DemirbasTakip.Properties.Resources.back;
            this.btnAdminBack.Location = new System.Drawing.Point(25, 12);
            this.btnAdminBack.Name = "btnAdminBack";
            this.btnAdminBack.Size = new System.Drawing.Size(34, 33);
            this.btnAdminBack.TabIndex = 33;
            this.btnAdminBack.UseVisualStyleBackColor = true;
            this.btnAdminBack.Click += new System.EventHandler(this.btnAdminBack_Click);
            // 
            // frmStokEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdminBack);
            this.Controls.Add(this.dtpAlimTarihi);
            this.Controls.Add(this.txtDemirbasTuruID);
            this.Controls.Add(this.txtSEadet);
            this.Controls.Add(this.lblSEadet);
            this.Controls.Add(this.btnSEekle);
            this.Controls.Add(this.lblSEalimTarihi);
            this.Controls.Add(this.lblSEdemirbasTuru);
            this.Controls.Add(this.lboxDemirbasTuruAdi);
            this.Controls.Add(this.lboxDemirbasTuruID);
            this.Controls.Add(this.txtSEfiyat);
            this.Controls.Add(this.txtSEdemirbasAdi);
            this.Controls.Add(this.lblSEfiyat);
            this.Controls.Add(this.lblSEdemirbasAdi);
            this.Name = "frmStokEkle";
            this.Text = "frmStokEkle";
            this.Load += new System.EventHandler(this.frmStokEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxDemirbasTuruAdi;
        private System.Windows.Forms.ListBox lboxDemirbasTuruID;
        private System.Windows.Forms.TextBox txtSEfiyat;
        private System.Windows.Forms.TextBox txtSEdemirbasAdi;
        private System.Windows.Forms.Label lblSEfiyat;
        private System.Windows.Forms.Label lblSEdemirbasAdi;
        private System.Windows.Forms.DateTimePicker dtpAlimTarihi;
        private System.Windows.Forms.TextBox txtDemirbasTuruID;
        private System.Windows.Forms.TextBox txtSEadet;
        private System.Windows.Forms.Label lblSEadet;
        private System.Windows.Forms.Button btnSEekle;
        private System.Windows.Forms.Label lblSEalimTarihi;
        private System.Windows.Forms.Label lblSEdemirbasTuru;
        private System.Windows.Forms.Button btnAdminBack;
    }
}