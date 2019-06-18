namespace DemirbasTakip
{
    partial class User
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
            this.btnDemisbaslarim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDemisbaslarim
            // 
            this.btnDemisbaslarim.Location = new System.Drawing.Point(210, 143);
            this.btnDemisbaslarim.Name = "btnDemisbaslarim";
            this.btnDemisbaslarim.Size = new System.Drawing.Size(158, 95);
            this.btnDemisbaslarim.TabIndex = 7;
            this.btnDemisbaslarim.Text = "DEMİRBAŞLARIM";
            this.btnDemisbaslarim.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 434);
            this.Controls.Add(this.btnDemisbaslarim);
            this.Name = "User";
            this.Text = "User";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDemisbaslarim;
    }
}