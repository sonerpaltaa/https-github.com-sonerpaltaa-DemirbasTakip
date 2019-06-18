namespace DemirbasTakip
{
    partial class frmDepTanimlama
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
            this.btnOTodaKaydet = new System.Windows.Forms.Button();
            this.btnTanimlamaBack = new System.Windows.Forms.Button();
            this.txtOTodaAdi = new System.Windows.Forms.TextBox();
            this.lblOTodaAdi = new System.Windows.Forms.Label();
            this.lblOTodaSorumlusu = new System.Windows.Forms.Label();
            this.txtOTOdaSorumlusu = new System.Windows.Forms.TextBox();
            this.dGWOda = new System.Windows.Forms.DataGridView();
            this.dGWPersonel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGWOda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOTodaKaydet
            // 
            this.btnOTodaKaydet.Location = new System.Drawing.Point(176, 322);
            this.btnOTodaKaydet.Name = "btnOTodaKaydet";
            this.btnOTodaKaydet.Size = new System.Drawing.Size(148, 66);
            this.btnOTodaKaydet.TabIndex = 6;
            this.btnOTodaKaydet.Text = "KAYDET";
            this.btnOTodaKaydet.UseVisualStyleBackColor = true;
            this.btnOTodaKaydet.Click += new System.EventHandler(this.btnOTodaKaydet_Click);
            // 
            // btnTanimlamaBack
            // 
            this.btnTanimlamaBack.FlatAppearance.BorderSize = 0;
            this.btnTanimlamaBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTanimlamaBack.Image = global::DemirbasTakip.Properties.Resources.back;
            this.btnTanimlamaBack.Location = new System.Drawing.Point(12, 12);
            this.btnTanimlamaBack.Name = "btnTanimlamaBack";
            this.btnTanimlamaBack.Size = new System.Drawing.Size(34, 33);
            this.btnTanimlamaBack.TabIndex = 1;
            this.btnTanimlamaBack.UseVisualStyleBackColor = true;
            this.btnTanimlamaBack.Click += new System.EventHandler(this.btnTanimlamaBack_Click);
            // 
            // txtOTodaAdi
            // 
            this.txtOTodaAdi.Enabled = false;
            this.txtOTodaAdi.Location = new System.Drawing.Point(108, 252);
            this.txtOTodaAdi.Name = "txtOTodaAdi";
            this.txtOTodaAdi.Size = new System.Drawing.Size(121, 20);
            this.txtOTodaAdi.TabIndex = 2;
            // 
            // lblOTodaAdi
            // 
            this.lblOTodaAdi.AutoSize = true;
            this.lblOTodaAdi.Location = new System.Drawing.Point(19, 259);
            this.lblOTodaAdi.Name = "lblOTodaAdi";
            this.lblOTodaAdi.Size = new System.Drawing.Size(83, 13);
            this.lblOTodaAdi.TabIndex = 4;
            this.lblOTodaAdi.Text = "Departman Adı :";
            // 
            // lblOTodaSorumlusu
            // 
            this.lblOTodaSorumlusu.AutoSize = true;
            this.lblOTodaSorumlusu.Location = new System.Drawing.Point(259, 255);
            this.lblOTodaSorumlusu.Name = "lblOTodaSorumlusu";
            this.lblOTodaSorumlusu.Size = new System.Drawing.Size(48, 13);
            this.lblOTodaSorumlusu.TabIndex = 5;
            this.lblOTodaSorumlusu.Text = "Personel";
            // 
            // txtOTOdaSorumlusu
            // 
            this.txtOTOdaSorumlusu.Enabled = false;
            this.txtOTOdaSorumlusu.Location = new System.Drawing.Point(313, 248);
            this.txtOTOdaSorumlusu.Name = "txtOTOdaSorumlusu";
            this.txtOTOdaSorumlusu.Size = new System.Drawing.Size(121, 20);
            this.txtOTOdaSorumlusu.TabIndex = 7;
            // 
            // dGWOda
            // 
            this.dGWOda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWOda.Location = new System.Drawing.Point(9, 60);
            this.dGWOda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGWOda.Name = "dGWOda";
            this.dGWOda.ReadOnly = true;
            this.dGWOda.RowTemplate.Height = 24;
            this.dGWOda.Size = new System.Drawing.Size(240, 140);
            this.dGWOda.TabIndex = 8;
            this.dGWOda.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWOda_RowEnter);
            // 
            // dGWPersonel
            // 
            this.dGWPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWPersonel.Location = new System.Drawing.Point(262, 60);
            this.dGWPersonel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGWPersonel.Name = "dGWPersonel";
            this.dGWPersonel.ReadOnly = true;
            this.dGWPersonel.RowTemplate.Height = 24;
            this.dGWPersonel.Size = new System.Drawing.Size(242, 140);
            this.dGWPersonel.TabIndex = 9;
            this.dGWPersonel.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWPersonel_RowEnter);
            // 
            // frmDepTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 461);
            this.ControlBox = false;
            this.Controls.Add(this.dGWPersonel);
            this.Controls.Add(this.dGWOda);
            this.Controls.Add(this.txtOTOdaSorumlusu);
            this.Controls.Add(this.btnOTodaKaydet);
            this.Controls.Add(this.lblOTodaSorumlusu);
            this.Controls.Add(this.lblOTodaAdi);
            this.Controls.Add(this.txtOTodaAdi);
            this.Controls.Add(this.btnTanimlamaBack);
            this.Name = "frmDepTanimlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman Tanımlama";
            this.Load += new System.EventHandler(this.frmOdaTanimlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGWOda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTanimlamaBack;
        private System.Windows.Forms.Button btnOTodaKaydet;
        private System.Windows.Forms.TextBox txtOTodaAdi;
        private System.Windows.Forms.Label lblOTodaAdi;
        private System.Windows.Forms.Label lblOTodaSorumlusu;
        private System.Windows.Forms.TextBox txtOTOdaSorumlusu;
        private System.Windows.Forms.DataGridView dGWOda;
        private System.Windows.Forms.DataGridView dGWPersonel;
    }
}