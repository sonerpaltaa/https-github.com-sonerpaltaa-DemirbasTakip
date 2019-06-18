namespace DemirbasTakip
{
    partial class DepartmanEkle
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
            this.txtOdaESGodaAdi = new System.Windows.Forms.TextBox();
            this.lblDepESGdepAdi = new System.Windows.Forms.Label();
            this.btnDepESGekle = new System.Windows.Forms.Button();
            this.btnAdminBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOdaESGodaAdi
            // 
            this.txtOdaESGodaAdi.Location = new System.Drawing.Point(170, 57);
            this.txtOdaESGodaAdi.Name = "txtOdaESGodaAdi";
            this.txtOdaESGodaAdi.Size = new System.Drawing.Size(132, 20);
            this.txtOdaESGodaAdi.TabIndex = 22;
            // 
            // lblDepESGdepAdi
            // 
            this.lblDepESGdepAdi.AutoSize = true;
            this.lblDepESGdepAdi.Location = new System.Drawing.Point(65, 60);
            this.lblDepESGdepAdi.Name = "lblDepESGdepAdi";
            this.lblDepESGdepAdi.Size = new System.Drawing.Size(99, 13);
            this.lblDepESGdepAdi.TabIndex = 21;
            this.lblDepESGdepAdi.Text = "DEPARTMAN ADI:";
            // 
            // btnDepESGekle
            // 
            this.btnDepESGekle.Location = new System.Drawing.Point(227, 83);
            this.btnDepESGekle.Name = "btnDepESGekle";
            this.btnDepESGekle.Size = new System.Drawing.Size(75, 23);
            this.btnDepESGekle.TabIndex = 23;
            this.btnDepESGekle.Text = "EKLE";
            this.btnDepESGekle.UseVisualStyleBackColor = true;
            this.btnDepESGekle.Click += new System.EventHandler(this.btnDepESGekle_Click);
            // 
            // btnAdminBack
            // 
            this.btnAdminBack.FlatAppearance.BorderSize = 0;
            this.btnAdminBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminBack.Image = global::DemirbasTakip.Properties.Resources.back;
            this.btnAdminBack.Location = new System.Drawing.Point(12, 12);
            this.btnAdminBack.Name = "btnAdminBack";
            this.btnAdminBack.Size = new System.Drawing.Size(34, 33);
            this.btnAdminBack.TabIndex = 28;
            this.btnAdminBack.UseVisualStyleBackColor = true;
            this.btnAdminBack.Click += new System.EventHandler(this.btnAdminBack_Click);
            // 
            // DepartmanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 173);
            this.Controls.Add(this.btnAdminBack);
            this.Controls.Add(this.txtOdaESGodaAdi);
            this.Controls.Add(this.lblDepESGdepAdi);
            this.Controls.Add(this.btnDepESGekle);
            this.Name = "DepartmanEkle";
            this.Text = "DepartmanEkle";
            this.Load += new System.EventHandler(this.DepartmanEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOdaESGodaAdi;
        private System.Windows.Forms.Label lblDepESGdepAdi;
        private System.Windows.Forms.Button btnDepESGekle;
        private System.Windows.Forms.Button btnAdminBack;
    }
}