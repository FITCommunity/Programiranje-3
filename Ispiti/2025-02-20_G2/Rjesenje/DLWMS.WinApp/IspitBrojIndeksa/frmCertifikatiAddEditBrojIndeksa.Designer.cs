namespace DLWMS.WinApp.IspitBrojIndeksa
{
    partial class frmCertifikatiAddEditBrojIndeksa
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
            cbCertifikatGodina = new ComboBox();
            lblCertifikatGodina = new Label();
            cbGodina = new ComboBox();
            lblGodina = new Label();
            cbStudent = new ComboBox();
            lblStudent = new Label();
            btnSacuvaj = new Button();
            SuspendLayout();
            // 
            // cbCertifikatGodina
            // 
            cbCertifikatGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCertifikatGodina.FormattingEnabled = true;
            cbCertifikatGodina.Location = new Point(88, 81);
            cbCertifikatGodina.Name = "cbCertifikatGodina";
            cbCertifikatGodina.Size = new Size(357, 28);
            cbCertifikatGodina.TabIndex = 7;
            // 
            // lblCertifikatGodina
            // 
            lblCertifikatGodina.AutoSize = true;
            lblCertifikatGodina.Location = new Point(10, 81);
            lblCertifikatGodina.Name = "lblCertifikatGodina";
            lblCertifikatGodina.Size = new Size(72, 20);
            lblCertifikatGodina.TabIndex = 6;
            lblCertifikatGodina.Text = "Certifikat:";
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021" });
            cbGodina.Location = new Point(88, 46);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(357, 28);
            cbGodina.TabIndex = 5;
            cbGodina.SelectionChangeCommitted += GodinaComboBoxSelectionChangeCommitted;
            // 
            // lblGodina
            // 
            lblGodina.AutoSize = true;
            lblGodina.Location = new Point(10, 49);
            lblGodina.Name = "lblGodina";
            lblGodina.Size = new Size(60, 20);
            lblGodina.TabIndex = 4;
            lblGodina.Text = "Godina:";
            // 
            // cbStudent
            // 
            cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(88, 12);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(357, 28);
            cbStudent.TabIndex = 9;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(10, 12);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(63, 20);
            lblStudent.TabIndex = 8;
            lblStudent.Text = "Student:";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(351, 115);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 10;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += SacuvajBtnClick;
            // 
            // frmCertifikatiAddEditBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 158);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbStudent);
            Controls.Add(lblStudent);
            Controls.Add(cbCertifikatGodina);
            Controls.Add(lblCertifikatGodina);
            Controls.Add(cbGodina);
            Controls.Add(lblGodina);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCertifikatiAddEditBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Certifikati";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCertifikatGodina;
        private Label lblCertifikatGodina;
        private ComboBox cbGodina;
        private Label lblGodina;
        private ComboBox cbStudent;
        private Label lblStudent;
        private Button btnSacuvaj;
    }
}