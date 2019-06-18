namespace DemirbasTakip
{
    partial class frmTur
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TurBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAramalarBack = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboSilTur = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 0;
            // 
            // TurBtn
            // 
            this.TurBtn.Location = new System.Drawing.Point(142, 69);
            this.TurBtn.Name = "TurBtn";
            this.TurBtn.Size = new System.Drawing.Size(75, 23);
            this.TurBtn.TabIndex = 1;
            this.TurBtn.Text = "Kaydet";
            this.TurBtn.UseVisualStyleBackColor = true;
            this.TurBtn.Click += new System.EventHandler(this.TurBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Demirbas Türü";
            // 
            // btnAramalarBack
            // 
            this.btnAramalarBack.FlatAppearance.BorderSize = 0;
            this.btnAramalarBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAramalarBack.Image = global::DemirbasTakip.Properties.Resources.back;
            this.btnAramalarBack.Location = new System.Drawing.Point(12, 12);
            this.btnAramalarBack.Name = "btnAramalarBack";
            this.btnAramalarBack.Size = new System.Drawing.Size(34, 33);
            this.btnAramalarBack.TabIndex = 4;
            this.btnAramalarBack.UseVisualStyleBackColor = true;
            this.btnAramalarBack.Click += new System.EventHandler(this.btnAramalarBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.TurBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 139);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demirbaş Türü Ekle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.comboSilTur);
            this.groupBox2.Location = new System.Drawing.Point(341, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 139);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sil";
            // 
            // comboSilTur
            // 
            this.comboSilTur.FormattingEnabled = true;
            this.comboSilTur.Location = new System.Drawing.Point(46, 42);
            this.comboSilTur.Name = "comboSilTur";
            this.comboSilTur.Size = new System.Drawing.Size(121, 21);
            this.comboSilTur.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(108, 69);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmTur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 390);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAramalarBack);
            this.Name = "frmTur";
            this.Text = "frmTur";
            this.Load += new System.EventHandler(this.frmTur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button TurBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAramalarBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox comboSilTur;
    }
}