namespace FIT.WinForms.IspitBrojIndeksa
{
    partial class frmStudentInfoBrojIndeksa
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
            pbSlikaStudenta = new PictureBox();
            lblImePrezime = new Label();
            lblProsjek = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlikaStudenta).BeginInit();
            SuspendLayout();
            // 
            // pbSlikaStudenta
            // 
            pbSlikaStudenta.BorderStyle = BorderStyle.FixedSingle;
            pbSlikaStudenta.Location = new Point(12, 12);
            pbSlikaStudenta.Name = "pbSlikaStudenta";
            pbSlikaStudenta.Size = new Size(299, 275);
            pbSlikaStudenta.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlikaStudenta.TabIndex = 0;
            pbSlikaStudenta.TabStop = false;
            // 
            // lblImePrezime
            // 
            lblImePrezime.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImePrezime.Location = new Point(12, 290);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(299, 38);
            lblImePrezime.TabIndex = 1;
            lblImePrezime.Text = "label1";
            lblImePrezime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProsjek
            // 
            lblProsjek.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProsjek.Location = new Point(12, 328);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(299, 26);
            lblProsjek.TabIndex = 2;
            lblProsjek.Text = "label2";
            lblProsjek.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmStudentInfoBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 364);
            Controls.Add(lblProsjek);
            Controls.Add(lblImePrezime);
            Controls.Add(pbSlikaStudenta);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmStudentInfoBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStudentInfoBrojIndeksa";
            ((System.ComponentModel.ISupportInitialize)pbSlikaStudenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbSlikaStudenta;
        private Label lblImePrezime;
        private Label lblProsjek;
    }
}