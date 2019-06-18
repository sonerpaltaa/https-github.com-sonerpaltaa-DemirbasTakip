namespace DemirbasTakip
{
    partial class frmAnaMenu
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
            this.btnDepDemirbasIslemleri = new System.Windows.Forms.Button();
            this.btnDepTanimlama = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnDemisbaslarim = new System.Windows.Forms.Button();
            this.btnArama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDepDemirbasIslemleri
            // 
            this.btnDepDemirbasIslemleri.Location = new System.Drawing.Point(144, 79);
            this.btnDepDemirbasIslemleri.Name = "btnDepDemirbasIslemleri";
            this.btnDepDemirbasIslemleri.Size = new System.Drawing.Size(154, 100);
            this.btnDepDemirbasIslemleri.TabIndex = 2;
            this.btnDepDemirbasIslemleri.Text = "DEPARTMAN DEMİRBAŞ İŞLEMLERİ";
            this.btnDepDemirbasIslemleri.UseVisualStyleBackColor = true;
            this.btnDepDemirbasIslemleri.Click += new System.EventHandler(this.btnDepDemirbas_Click);
            // 
            // btnDepTanimlama
            // 
            this.btnDepTanimlama.Location = new System.Drawing.Point(144, 278);
            this.btnDepTanimlama.Name = "btnDepTanimlama";
            this.btnDepTanimlama.Size = new System.Drawing.Size(154, 92);
            this.btnDepTanimlama.TabIndex = 3;
            this.btnDepTanimlama.Text = "DEPARTMAN ATAMA";
            this.btnDepTanimlama.UseVisualStyleBackColor = true;
            this.btnDepTanimlama.Click += new System.EventHandler(this.btnDepTanimlama_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(304, 185);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(155, 87);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "ADMİN";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnDemisbaslarim
            // 
            this.btnDemisbaslarim.Location = new System.Drawing.Point(144, 185);
            this.btnDemisbaslarim.Name = "btnDemisbaslarim";
            this.btnDemisbaslarim.Size = new System.Drawing.Size(154, 87);
            this.btnDemisbaslarim.TabIndex = 6;
            this.btnDemisbaslarim.Text = "DEMİRBAŞLARIM";
            this.btnDemisbaslarim.UseVisualStyleBackColor = true;
            this.btnDemisbaslarim.Click += new System.EventHandler(this.btnDemisbaslarim_Click);
            // 
            // btnArama
            // 
            this.btnArama.Location = new System.Drawing.Point(1, 185);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(137, 87);
            this.btnArama.TabIndex = 8;
            this.btnArama.Text = "ARAMALAR";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 518);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.btnDemisbaslarim);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnDepTanimlama);
            this.Controls.Add(this.btnDepDemirbasIslemleri);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA MENÜ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAnaMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmAnaMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDepDemirbasIslemleri;
        private System.Windows.Forms.Button btnDepTanimlama;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnDemisbaslarim;
        private System.Windows.Forms.Button btnArama;
    }
}