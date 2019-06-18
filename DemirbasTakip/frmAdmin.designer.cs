namespace DemirbasTakip
{
    partial class frmAdmin
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
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.btnStokGuncelle = new System.Windows.Forms.Button();
            this.btnDepEkle = new System.Windows.Forms.Button();
            this.btnDepSil = new System.Windows.Forms.Button();
            this.btnDepGuncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdminBack = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.Location = new System.Drawing.Point(12, 51);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(151, 101);
            this.btnStokEkle.TabIndex = 2;
            this.btnStokEkle.Text = "STOK EKLEME";
            this.btnStokEkle.UseVisualStyleBackColor = true;
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // btnStokGuncelle
            // 
            this.btnStokGuncelle.Location = new System.Drawing.Point(169, 51);
            this.btnStokGuncelle.Name = "btnStokGuncelle";
            this.btnStokGuncelle.Size = new System.Drawing.Size(129, 101);
            this.btnStokGuncelle.TabIndex = 3;
            this.btnStokGuncelle.Text = "STOK GÜNCELLE";
            this.btnStokGuncelle.UseVisualStyleBackColor = true;
            this.btnStokGuncelle.Click += new System.EventHandler(this.btnStokGuncelle_Click);
            // 
            // btnDepEkle
            // 
            this.btnDepEkle.Location = new System.Drawing.Point(304, 51);
            this.btnDepEkle.Name = "btnDepEkle";
            this.btnDepEkle.Size = new System.Drawing.Size(147, 44);
            this.btnDepEkle.TabIndex = 4;
            this.btnDepEkle.Text = "DEPARTMAN EKLE";
            this.btnDepEkle.UseVisualStyleBackColor = true;
            this.btnDepEkle.Click += new System.EventHandler(this.btnDepEkle_Click);
            // 
            // btnDepSil
            // 
            this.btnDepSil.Location = new System.Drawing.Point(304, 101);
            this.btnDepSil.Name = "btnDepSil";
            this.btnDepSil.Size = new System.Drawing.Size(147, 36);
            this.btnDepSil.TabIndex = 5;
            this.btnDepSil.Text = "DEPARTMAN SİL";
            this.btnDepSil.UseVisualStyleBackColor = true;
            this.btnDepSil.Click += new System.EventHandler(this.btnDepSil_Click);
            // 
            // btnDepGuncelle
            // 
            this.btnDepGuncelle.Location = new System.Drawing.Point(304, 143);
            this.btnDepGuncelle.Name = "btnDepGuncelle";
            this.btnDepGuncelle.Size = new System.Drawing.Size(147, 42);
            this.btnDepGuncelle.TabIndex = 6;
            this.btnDepGuncelle.Text = "DEPARTMAN GÜNCELLE";
            this.btnDepGuncelle.UseVisualStyleBackColor = true;
            this.btnDepGuncelle.Click += new System.EventHandler(this.btnDepGuncelle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "PERSONEL İŞLEMLERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "KULLANICI İŞLEMLERİ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdminBack
            // 
            this.btnAdminBack.FlatAppearance.BorderSize = 0;
            this.btnAdminBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminBack.Image = global::DemirbasTakip.Properties.Resources.back;
            this.btnAdminBack.Location = new System.Drawing.Point(12, 12);
            this.btnAdminBack.Name = "btnAdminBack";
            this.btnAdminBack.Size = new System.Drawing.Size(34, 33);
            this.btnAdminBack.TabIndex = 1;
            this.btnAdminBack.UseVisualStyleBackColor = true;
            this.btnAdminBack.Click += new System.EventHandler(this.btnAdminBack_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "DEMİRBAS TÜRÜ İŞLEMLERİ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDepGuncelle);
            this.Controls.Add(this.btnDepSil);
            this.Controls.Add(this.btnDepEkle);
            this.Controls.Add(this.btnStokGuncelle);
            this.Controls.Add(this.btnStokEkle);
            this.Controls.Add(this.btnAdminBack);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminBack;
        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.Button btnStokGuncelle;
        private System.Windows.Forms.Button btnDepEkle;
        private System.Windows.Forms.Button btnDepSil;
        private System.Windows.Forms.Button btnDepGuncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}