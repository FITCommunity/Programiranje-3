namespace FIT.WinForms.IspitBrojIndeksa
{
    partial class frmPrisustvoBrojIndeksa
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
            lblNazivProstorije = new Label();
            lblKapacitet = new Label();
            cbNastava = new ComboBox();
            lblNastava = new Label();
            cbStudent = new ComboBox();
            lblStudent = new Label();
            btnDodaj = new Button();
            dgvPrisustva = new DataGridView();
            PrisustvoNastava = new DataGridViewTextBoxColumn();
            PrisustvoStudent = new DataGridViewTextBoxColumn();
            gbGenerator = new GroupBox();
            txtInfo = new TextBox();
            lblInfo = new Label();
            btnGenerisi = new Button();
            txtBrojZapisa = new TextBox();
            lblBrojZapisa = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrisustva).BeginInit();
            gbGenerator.SuspendLayout();
            SuspendLayout();
            // 
            // lblNazivProstorije
            // 
            lblNazivProstorije.AutoSize = true;
            lblNazivProstorije.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNazivProstorije.Location = new Point(12, 9);
            lblNazivProstorije.Name = "lblNazivProstorije";
            lblNazivProstorije.Size = new Size(90, 37);
            lblNazivProstorije.TabIndex = 0;
            lblNazivProstorije.Text = "label1";
            // 
            // lblKapacitet
            // 
            lblKapacitet.AutoSize = true;
            lblKapacitet.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKapacitet.Location = new Point(499, 9);
            lblKapacitet.Name = "lblKapacitet";
            lblKapacitet.Size = new Size(90, 37);
            lblKapacitet.TabIndex = 1;
            lblKapacitet.Text = "label1";
            // 
            // cbNastava
            // 
            cbNastava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNastava.FormattingEnabled = true;
            cbNastava.Location = new Point(12, 86);
            cbNastava.Name = "cbNastava";
            cbNastava.Size = new Size(243, 23);
            cbNastava.TabIndex = 4;
            cbNastava.SelectedIndexChanged += NastavaComboBoxSelectedIndexChanged;
            // 
            // lblNastava
            // 
            lblNastava.AutoSize = true;
            lblNastava.Location = new Point(12, 68);
            lblNastava.Name = "lblNastava";
            lblNastava.Size = new Size(52, 15);
            lblNastava.TabIndex = 3;
            lblNastava.Text = "Nastava:";
            // 
            // cbStudent
            // 
            cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(261, 86);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(243, 23);
            cbStudent.TabIndex = 6;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(261, 68);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(51, 15);
            lblStudent.TabIndex = 5;
            lblStudent.Text = "Student:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(514, 85);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += DodajBtnClick;
            // 
            // dgvPrisustva
            // 
            dgvPrisustva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrisustva.Columns.AddRange(new DataGridViewColumn[] { PrisustvoNastava, PrisustvoStudent });
            dgvPrisustva.Location = new Point(12, 115);
            dgvPrisustva.Name = "dgvPrisustva";
            dgvPrisustva.RowTemplate.Height = 25;
            dgvPrisustva.Size = new Size(577, 150);
            dgvPrisustva.TabIndex = 8;
            // 
            // PrisustvoNastava
            // 
            PrisustvoNastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PrisustvoNastava.DataPropertyName = "Nastava";
            PrisustvoNastava.HeaderText = "Predmet, prostorija, vrijeme";
            PrisustvoNastava.Name = "PrisustvoNastava";
            // 
            // PrisustvoStudent
            // 
            PrisustvoStudent.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PrisustvoStudent.DataPropertyName = "Student";
            PrisustvoStudent.HeaderText = "Student";
            PrisustvoStudent.Name = "PrisustvoStudent";
            // 
            // gbGenerator
            // 
            gbGenerator.Controls.Add(txtInfo);
            gbGenerator.Controls.Add(lblInfo);
            gbGenerator.Controls.Add(btnGenerisi);
            gbGenerator.Controls.Add(txtBrojZapisa);
            gbGenerator.Controls.Add(lblBrojZapisa);
            gbGenerator.Location = new Point(12, 284);
            gbGenerator.Name = "gbGenerator";
            gbGenerator.Size = new Size(577, 154);
            gbGenerator.TabIndex = 9;
            gbGenerator.TabStop = false;
            gbGenerator.Text = "Generator";
            // 
            // txtInfo
            // 
            txtInfo.BackColor = SystemColors.Window;
            txtInfo.Location = new Point(6, 68);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.ScrollBars = ScrollBars.Both;
            txtInfo.Size = new Size(565, 80);
            txtInfo.TabIndex = 4;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(6, 50);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(31, 15);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "Info:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(181, 19);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(75, 23);
            btnGenerisi.TabIndex = 2;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += GenerisiBtnClick;
            // 
            // txtBrojZapisa
            // 
            txtBrojZapisa.Location = new Point(110, 20);
            txtBrojZapisa.Name = "txtBrojZapisa";
            txtBrojZapisa.Size = new Size(65, 23);
            txtBrojZapisa.TabIndex = 1;
            // 
            // lblBrojZapisa
            // 
            lblBrojZapisa.AutoSize = true;
            lblBrojZapisa.Location = new Point(6, 23);
            lblBrojZapisa.Name = "lblBrojZapisa";
            lblBrojZapisa.Size = new Size(66, 15);
            lblBrojZapisa.TabIndex = 0;
            lblBrojZapisa.Text = "Broj zapisa:";
            // 
            // frmPrisustvoBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(gbGenerator);
            Controls.Add(dgvPrisustva);
            Controls.Add(btnDodaj);
            Controls.Add(cbStudent);
            Controls.Add(lblStudent);
            Controls.Add(cbNastava);
            Controls.Add(lblNastava);
            Controls.Add(lblKapacitet);
            Controls.Add(lblNazivProstorije);
            Name = "frmPrisustvoBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evidencija nastave";
            ((System.ComponentModel.ISupportInitialize)dgvPrisustva).EndInit();
            gbGenerator.ResumeLayout(false);
            gbGenerator.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNazivProstorije;
        private Label lblKapacitet;
        private ComboBox cbNastava;
        private Label lblNastava;
        private ComboBox cbStudent;
        private Label lblStudent;
        private Button btnDodaj;
        private DataGridView dgvPrisustva;
        private GroupBox gbGenerator;
        private Button btnGenerisi;
        private TextBox txtBrojZapisa;
        private Label lblBrojZapisa;
        private TextBox txtInfo;
        private Label lblInfo;
        private DataGridViewTextBoxColumn PrisustvoNastava;
        private DataGridViewTextBoxColumn PrisustvoStudent;
    }
}