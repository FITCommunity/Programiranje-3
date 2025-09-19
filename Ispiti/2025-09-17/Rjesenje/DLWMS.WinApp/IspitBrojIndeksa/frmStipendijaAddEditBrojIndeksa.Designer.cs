namespace DLWMS.WinApp.IspitBrojIndeksa
{
    partial class frmStipendijaAddEditBrojIndeksa
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
            lblStudent = new Label();
            cbStudent = new ComboBox();
            btnSacuvaj = new Button();
            lblGodina = new Label();
            cbGodina = new ComboBox();
            lblStipendija = new Label();
            cbStipendijaGodina = new ComboBox();
            SuspendLayout();
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(12, 9);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(63, 20);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "Student:";
            // 
            // cbStudent
            // 
            cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(91, 6);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(275, 28);
            cbStudent.TabIndex = 1;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(272, 108);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 2;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += SacuvajBtnClick;
            // 
            // lblGodina
            // 
            lblGodina.AutoSize = true;
            lblGodina.Location = new Point(12, 43);
            lblGodina.Name = "lblGodina";
            lblGodina.Size = new Size(60, 20);
            lblGodina.TabIndex = 0;
            lblGodina.Text = "Godina:";
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021" });
            cbGodina.Location = new Point(91, 40);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(275, 28);
            cbGodina.TabIndex = 1;
            cbGodina.SelectionChangeCommitted += GodinaComboBoxSelectionChangeCommitted;
            // 
            // lblStipendija
            // 
            lblStipendija.AutoSize = true;
            lblStipendija.Location = new Point(12, 77);
            lblStipendija.Name = "lblStipendija";
            lblStipendija.Size = new Size(79, 20);
            lblStipendija.TabIndex = 0;
            lblStipendija.Text = "Stipendija:";
            // 
            // cbStipendijaGodina
            // 
            cbStipendijaGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStipendijaGodina.FormattingEnabled = true;
            cbStipendijaGodina.Location = new Point(91, 74);
            cbStipendijaGodina.Name = "cbStipendijaGodina";
            cbStipendijaGodina.Size = new Size(275, 28);
            cbStipendijaGodina.TabIndex = 1;
            // 
            // frmStipendijaAddEditBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 152);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbStipendijaGodina);
            Controls.Add(lblStipendija);
            Controls.Add(cbGodina);
            Controls.Add(lblGodina);
            Controls.Add(cbStudent);
            Controls.Add(lblStudent);
            Name = "frmStipendijaAddEditBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodjela stipendije";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudent;
        private ComboBox cbStudent;
        private Button btnSacuvaj;
        private Label lblGodina;
        private ComboBox cbGodina;
        private Label lblStipendija;
        private ComboBox cbStipendijaGodina;
    }
}