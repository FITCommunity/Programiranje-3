namespace DLWMS.WinApp.IB230269
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
            components = new System.ComponentModel.Container();
            btnSacuvaj = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbStudent = new ComboBox();
            cbGodina = new ComboBox();
            cbStipendija = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(238, 125);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 0;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Student:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Godina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 1;
            label3.Text = "Stipendija:";
            // 
            // cbStudent
            // 
            cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(87, 38);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(226, 23);
            cbStudent.TabIndex = 2;
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024", "2025" });
            cbGodina.Location = new Point(87, 67);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(226, 23);
            cbGodina.TabIndex = 2;
            cbGodina.SelectionChangeCommitted += cbGodina_SelectionChangeCommitted_1;
            // 
            // cbStipendija
            // 
            cbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStipendija.FormattingEnabled = true;
            cbStipendija.Location = new Point(87, 96);
            cbStipendija.Name = "cbStipendija";
            cbStipendija.Size = new Size(226, 23);
            cbStipendija.TabIndex = 2;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmStipendijaAddEditBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 155);
            Controls.Add(cbStipendija);
            Controls.Add(cbGodina);
            Controls.Add(cbStudent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSacuvaj);
            Name = "frmStipendijaAddEditBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodijela stipendije";
            Load += frmStipendijaAddEditIB230269_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSacuvaj;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbStudent;
        private ComboBox cbGodina;
        private ComboBox cbStipendija;
        private ErrorProvider errorProvider1;
    }
}