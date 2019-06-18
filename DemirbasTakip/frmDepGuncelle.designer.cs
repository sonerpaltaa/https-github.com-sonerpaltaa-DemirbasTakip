namespace DemirbasTakip
{
    partial class frmDepGuncelle
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
            this.txtOdaESGyeniOdaAdi = new System.Windows.Forms.TextBox();
            this.lblOdaESGyeniOdaAdi = new System.Windows.Forms.Label();
            this.lblOdaESGodaAdi2 = new System.Windows.Forms.Label();
            this.btnDepESGguncelle = new System.Windows.Forms.Button();
            this.gbOdaGuncelleme = new System.Windows.Forms.GroupBox();
            this.cboOdaESGodaAdiGuncel = new System.Windows.Forms.ComboBox();
            this.btnOdaEkleSilBack = new System.Windows.Forms.Button();
            this.gbOdaGuncelleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOdaESGyeniOdaAdi
            // 
            this.txtOdaESGyeniOdaAdi.Location = new System.Drawing.Point(419, 33);
            this.txtOdaESGyeniOdaAdi.Name = "txtOdaESGyeniOdaAdi";
            this.txtOdaESGyeniOdaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtOdaESGyeniOdaAdi.TabIndex = 21;
            // 
            // lblOdaESGyeniOdaAdi
            // 
            this.lblOdaESGyeniOdaAdi.AutoSize = true;
            this.lblOdaESGyeniOdaAdi.Location = new System.Drawing.Point(286, 36);
            this.lblOdaESGyeniOdaAdi.Name = "lblOdaESGyeniOdaAdi";
            this.lblOdaESGyeniOdaAdi.Size = new System.Drawing.Size(127, 13);
            this.lblOdaESGyeniOdaAdi.TabIndex = 20;
            this.lblOdaESGyeniOdaAdi.Text = "YENİDEPARTMAN ADI :";
            // 
            // lblOdaESGodaAdi2
            // 
            this.lblOdaESGodaAdi2.AutoSize = true;
            this.lblOdaESGodaAdi2.Location = new System.Drawing.Point(6, 33);
            this.lblOdaESGodaAdi2.Name = "lblOdaESGodaAdi2";
            this.lblOdaESGodaAdi2.Size = new System.Drawing.Size(102, 13);
            this.lblOdaESGodaAdi2.TabIndex = 22;
            this.lblOdaESGodaAdi2.Text = "DEPARTMAN ADI :";
            // 
            // btnDepESGguncelle
            // 
            this.btnDepESGguncelle.Location = new System.Drawing.Point(444, 59);
            this.btnDepESGguncelle.Name = "btnDepESGguncelle";
            this.btnDepESGguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnDepESGguncelle.TabIndex = 24;
            this.btnDepESGguncelle.Text = "GÜNCELLE";
            this.btnDepESGguncelle.UseVisualStyleBackColor = true;
            this.btnDepESGguncelle.Click += new System.EventHandler(this.btnDepESGguncelle_Click);
            // 
            // gbOdaGuncelleme
            // 
            this.gbOdaGuncelleme.Controls.Add(this.cboOdaESGodaAdiGuncel);
            this.gbOdaGuncelleme.Controls.Add(this.txtOdaESGyeniOdaAdi);
            this.gbOdaGuncelleme.Controls.Add(this.lblOdaESGyeniOdaAdi);
            this.gbOdaGuncelleme.Controls.Add(this.btnDepESGguncelle);
            this.gbOdaGuncelleme.Controls.Add(this.lblOdaESGodaAdi2);
            this.gbOdaGuncelleme.Location = new System.Drawing.Point(20, 76);
            this.gbOdaGuncelleme.Name = "gbOdaGuncelleme";
            this.gbOdaGuncelleme.Size = new System.Drawing.Size(565, 161);
            this.gbOdaGuncelleme.TabIndex = 26;
            this.gbOdaGuncelleme.TabStop = false;
            this.gbOdaGuncelleme.Text = "DEPARTMAN GÜNCELLEME";
            // 
            // cboOdaESGodaAdiGuncel
            // 
            this.cboOdaESGodaAdiGuncel.FormattingEnabled = true;
            this.cboOdaESGodaAdiGuncel.Location = new System.Drawing.Point(114, 30);
            this.cboOdaESGodaAdiGuncel.Name = "cboOdaESGodaAdiGuncel";
            this.cboOdaESGodaAdiGuncel.Size = new System.Drawing.Size(163, 21);
            this.cboOdaESGodaAdiGuncel.TabIndex = 25;
            // 
            // btnOdaEkleSilBack
            // 
            this.btnOdaEkleSilBack.FlatAppearance.BorderSize = 0;
            this.btnOdaEkleSilBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaEkleSilBack.Image = global::DemirbasTakip.Properties.Resources.back;
            this.btnOdaEkleSilBack.Location = new System.Drawing.Point(12, 12);
            this.btnOdaEkleSilBack.Name = "btnOdaEkleSilBack";
            this.btnOdaEkleSilBack.Size = new System.Drawing.Size(34, 33);
            this.btnOdaEkleSilBack.TabIndex = 2;
            this.btnOdaEkleSilBack.UseVisualStyleBackColor = true;
            this.btnOdaEkleSilBack.Click += new System.EventHandler(this.btnOdaEkleSilBack_Click);
            // 
            // frmDepGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 289);
            this.ControlBox = false;
            this.Controls.Add(this.gbOdaGuncelleme);
            this.Controls.Add(this.btnOdaEkleSilBack);
            this.Name = "frmDepGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman Güncelle";
            this.Load += new System.EventHandler(this.frmDepGuncelle_Load);
            this.gbOdaGuncelleme.ResumeLayout(false);
            this.gbOdaGuncelleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdaEkleSilBack;
        private System.Windows.Forms.TextBox txtOdaESGyeniOdaAdi;
        private System.Windows.Forms.Label lblOdaESGyeniOdaAdi;
        private System.Windows.Forms.Label lblOdaESGodaAdi2;
        private System.Windows.Forms.Button btnDepESGguncelle;
        private System.Windows.Forms.GroupBox gbOdaGuncelleme;
        private System.Windows.Forms.ComboBox cboOdaESGodaAdiGuncel;
    }
}