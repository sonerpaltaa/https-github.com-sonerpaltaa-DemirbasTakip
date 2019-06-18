namespace DemirbasTakip
{
    partial class frmKullanici
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
            this.PersonelekleDataGrid = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Kadi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ekleButon = new System.Windows.Forms.Button();
            this.btnAdminBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.usernamesil = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PersComboList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelekleDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonelekleDataGrid
            // 
            this.PersonelekleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonelekleDataGrid.Location = new System.Drawing.Point(6, 52);
            this.PersonelekleDataGrid.Name = "PersonelekleDataGrid";
            this.PersonelekleDataGrid.Size = new System.Drawing.Size(263, 174);
            this.PersonelekleDataGrid.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(366, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(366, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(366, 121);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(366, 147);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // Kadi
            // 
            this.Kadi.AutoSize = true;
            this.Kadi.Location = new System.Drawing.Point(297, 50);
            this.Kadi.Name = "Kadi";
            this.Kadi.Size = new System.Drawing.Size(48, 13);
            this.Kadi.TabIndex = 6;
            this.Kadi.Text = "Personel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yetki:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "EMAİL";
            // 
            // ekleButon
            // 
            this.ekleButon.Location = new System.Drawing.Point(378, 173);
            this.ekleButon.Name = "ekleButon";
            this.ekleButon.Size = new System.Drawing.Size(75, 23);
            this.ekleButon.TabIndex = 12;
            this.ekleButon.Text = "EKLE";
            this.ekleButon.UseVisualStyleBackColor = true;
            this.ekleButon.Click += new System.EventHandler(this.ekleButon_Click);
            // 
            // btnAdminBack
            // 
            this.btnAdminBack.FlatAppearance.BorderSize = 0;
            this.btnAdminBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminBack.Image = global::DemirbasTakip.Properties.Resources.back;
            this.btnAdminBack.Location = new System.Drawing.Point(21, 12);
            this.btnAdminBack.Name = "btnAdminBack";
            this.btnAdminBack.Size = new System.Drawing.Size(34, 33);
            this.btnAdminBack.TabIndex = 29;
            this.btnAdminBack.UseVisualStyleBackColor = true;
            this.btnAdminBack.Click += new System.EventHandler(this.btnAdminBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PersComboList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PersonelekleDataGrid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ekleButon);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.Kadi);
            this.groupBox1.Location = new System.Drawing.Point(73, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 255);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Ekleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Personel Tablosu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.usernamesil);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(587, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 283);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Silme";
            // 
            // usernamesil
            // 
            this.usernamesil.Location = new System.Drawing.Point(241, 249);
            this.usernamesil.Name = "usernamesil";
            this.usernamesil.Size = new System.Drawing.Size(150, 23);
            this.usernamesil.TabIndex = 13;
            this.usernamesil.Text = "SEÇİLİ KULLANICIYI SİL";
            this.usernamesil.UseVisualStyleBackColor = true;
            this.usernamesil.Click += new System.EventHandler(this.usernamesil_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(321, 207);
            this.dataGridView2.TabIndex = 0;
            // 
            // PersComboList
            // 
            this.PersComboList.FormattingEnabled = true;
            this.PersComboList.Location = new System.Drawing.Point(366, 42);
            this.PersComboList.Name = "PersComboList";
            this.PersComboList.Size = new System.Drawing.Size(121, 21);
            this.PersComboList.TabIndex = 14;
            // 
            // frmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdminBack);
            this.Name = "frmKullanici";
            this.Text = "frmKullanici";
            this.Load += new System.EventHandler(this.frmKullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonelekleDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonelekleDataGrid;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label Kadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ekleButon;
        private System.Windows.Forms.Button btnAdminBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button usernamesil;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox PersComboList;
    }
}