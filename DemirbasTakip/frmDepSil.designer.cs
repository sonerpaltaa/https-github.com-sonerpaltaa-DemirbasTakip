namespace DemirbasTakip
{
    partial class frmDepSil
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
            this.lblOdaESGodaAdi3 = new System.Windows.Forms.Label();
            this.btnDepESGsil = new System.Windows.Forms.Button();
            this.gbOdaSilme = new System.Windows.Forms.GroupBox();
            this.cboOdaESGodaAdiSil = new System.Windows.Forms.ComboBox();
            this.btnOdaEkleSilBack = new System.Windows.Forms.Button();
            this.gbOdaSilme.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOdaESGodaAdi3
            // 
            this.lblOdaESGodaAdi3.AutoSize = true;
            this.lblOdaESGodaAdi3.Location = new System.Drawing.Point(6, 37);
            this.lblOdaESGodaAdi3.Name = "lblOdaESGodaAdi3";
            this.lblOdaESGodaAdi3.Size = new System.Drawing.Size(102, 13);
            this.lblOdaESGodaAdi3.TabIndex = 17;
            this.lblOdaESGodaAdi3.Text = "DEPARTMAN ADI :";
            // 
            // btnDepESGsil
            // 
            this.btnDepESGsil.Location = new System.Drawing.Point(231, 34);
            this.btnDepESGsil.Name = "btnDepESGsil";
            this.btnDepESGsil.Size = new System.Drawing.Size(75, 23);
            this.btnDepESGsil.TabIndex = 18;
            this.btnDepESGsil.Text = "SİL";
            this.btnDepESGsil.UseVisualStyleBackColor = true;
            this.btnDepESGsil.Click += new System.EventHandler(this.btnDepESGsil_Click);
            // 
            // gbOdaSilme
            // 
            this.gbOdaSilme.Controls.Add(this.cboOdaESGodaAdiSil);
            this.gbOdaSilme.Controls.Add(this.lblOdaESGodaAdi3);
            this.gbOdaSilme.Controls.Add(this.btnDepESGsil);
            this.gbOdaSilme.Location = new System.Drawing.Point(12, 67);
            this.gbOdaSilme.Name = "gbOdaSilme";
            this.gbOdaSilme.Size = new System.Drawing.Size(468, 100);
            this.gbOdaSilme.TabIndex = 27;
            this.gbOdaSilme.TabStop = false;
            this.gbOdaSilme.Text = "DEPARTMAN SİLME";
            // 
            // cboOdaESGodaAdiSil
            // 
            this.cboOdaESGodaAdiSil.FormattingEnabled = true;
            this.cboOdaESGodaAdiSil.Location = new System.Drawing.Point(114, 34);
            this.cboOdaESGodaAdiSil.Name = "cboOdaESGodaAdiSil";
            this.cboOdaESGodaAdiSil.Size = new System.Drawing.Size(111, 21);
            this.cboOdaESGodaAdiSil.TabIndex = 19;
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
            // frmDepSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 207);
            this.ControlBox = false;
            this.Controls.Add(this.gbOdaSilme);
            this.Controls.Add(this.btnOdaEkleSilBack);
            this.Name = "frmDepSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman Sil";
            this.Load += new System.EventHandler(this.frmOdaSil_Load);
            this.gbOdaSilme.ResumeLayout(false);
            this.gbOdaSilme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdaEkleSilBack;
        private System.Windows.Forms.Label lblOdaESGodaAdi3;
        private System.Windows.Forms.Button btnDepESGsil;
        private System.Windows.Forms.GroupBox gbOdaSilme;
        private System.Windows.Forms.ComboBox cboOdaESGodaAdiSil;
    }
}