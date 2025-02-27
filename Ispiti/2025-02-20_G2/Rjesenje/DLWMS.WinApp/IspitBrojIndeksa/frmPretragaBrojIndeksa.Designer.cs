namespace DLWMS.WinApp.IspitBrojIndeksa
{
    partial class frmPretragaBrojIndeksa
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
            lblGodina = new Label();
            cbGodina = new ComboBox();
            cbCertifikatGodina = new ComboBox();
            lblCertifikatGodina = new Label();
            btnCertifikatiPoGodinama = new Button();
            btnAddCertifikat = new Button();
            dgvStudentiCertifikati = new DataGridView();
            StudentCertifikatIndeksImePrezime = new DataGridViewTextBoxColumn();
            StudentCertifikatGodina = new DataGridViewTextBoxColumn();
            StudentCertifikatNaziv = new DataGridViewTextBoxColumn();
            StudentCertifikatMjesecniIznos = new DataGridViewTextBoxColumn();
            StudentCertifikatUkupniIznos = new DataGridViewTextBoxColumn();
            StudentCertifikatUkloniBtn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudentiCertifikati).BeginInit();
            SuspendLayout();
            // 
            // lblGodina
            // 
            lblGodina.AutoSize = true;
            lblGodina.Location = new Point(12, 9);
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
            cbGodina.Location = new Point(12, 32);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(151, 28);
            cbGodina.TabIndex = 1;
            cbGodina.SelectionChangeCommitted += GodineComboBoxSelectionChangeCommitted;
            // 
            // cbCertifikatGodina
            // 
            cbCertifikatGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCertifikatGodina.FormattingEnabled = true;
            cbCertifikatGodina.Location = new Point(169, 32);
            cbCertifikatGodina.Name = "cbCertifikatGodina";
            cbCertifikatGodina.Size = new Size(476, 28);
            cbCertifikatGodina.TabIndex = 3;
            cbCertifikatGodina.SelectionChangeCommitted += CertifikatGodinaSelectionChangeCommitted;
            // 
            // lblCertifikatGodina
            // 
            lblCertifikatGodina.AutoSize = true;
            lblCertifikatGodina.Location = new Point(169, 9);
            lblCertifikatGodina.Name = "lblCertifikatGodina";
            lblCertifikatGodina.Size = new Size(72, 20);
            lblCertifikatGodina.TabIndex = 2;
            lblCertifikatGodina.Text = "Certifikat:";
            // 
            // btnCertifikatiPoGodinama
            // 
            btnCertifikatiPoGodinama.Location = new Point(890, 31);
            btnCertifikatiPoGodinama.Name = "btnCertifikatiPoGodinama";
            btnCertifikatiPoGodinama.Size = new Size(221, 29);
            btnCertifikatiPoGodinama.TabIndex = 4;
            btnCertifikatiPoGodinama.Text = "Certifikati po godinama";
            btnCertifikatiPoGodinama.UseVisualStyleBackColor = true;
            btnCertifikatiPoGodinama.Click += CertifikatiPoGodinamaBtnClick;
            // 
            // btnAddCertifikat
            // 
            btnAddCertifikat.Location = new Point(753, 31);
            btnAddCertifikat.Name = "btnAddCertifikat";
            btnAddCertifikat.Size = new Size(131, 29);
            btnAddCertifikat.TabIndex = 5;
            btnAddCertifikat.Text = "Dodaj certifikat";
            btnAddCertifikat.UseVisualStyleBackColor = true;
            btnAddCertifikat.Click += AddCertifikatBtnClick;
            // 
            // dgvStudentiCertifikati
            // 
            dgvStudentiCertifikati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentiCertifikati.Columns.AddRange(new DataGridViewColumn[] { StudentCertifikatIndeksImePrezime, StudentCertifikatGodina, StudentCertifikatNaziv, StudentCertifikatMjesecniIznos, StudentCertifikatUkupniIznos, StudentCertifikatUkloniBtn });
            dgvStudentiCertifikati.Location = new Point(12, 66);
            dgvStudentiCertifikati.Name = "dgvStudentiCertifikati";
            dgvStudentiCertifikati.RowHeadersWidth = 51;
            dgvStudentiCertifikati.Size = new Size(1099, 372);
            dgvStudentiCertifikati.TabIndex = 6;
            dgvStudentiCertifikati.CellClick += StudentiCertifikatiDgvCellClick;
            dgvStudentiCertifikati.CellDoubleClick += StudentiCertifikatiDgvCellDoubleClick;
            // 
            // StudentCertifikatIndeksImePrezime
            // 
            StudentCertifikatIndeksImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentCertifikatIndeksImePrezime.DataPropertyName = "Student";
            StudentCertifikatIndeksImePrezime.HeaderText = "(Indeks) Ime i prezime";
            StudentCertifikatIndeksImePrezime.MinimumWidth = 6;
            StudentCertifikatIndeksImePrezime.Name = "StudentCertifikatIndeksImePrezime";
            // 
            // StudentCertifikatGodina
            // 
            StudentCertifikatGodina.DataPropertyName = "Godina";
            StudentCertifikatGodina.HeaderText = "Godina";
            StudentCertifikatGodina.MinimumWidth = 6;
            StudentCertifikatGodina.Name = "StudentCertifikatGodina";
            StudentCertifikatGodina.Width = 125;
            // 
            // StudentCertifikatNaziv
            // 
            StudentCertifikatNaziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentCertifikatNaziv.DataPropertyName = "CertifikatGodina";
            StudentCertifikatNaziv.HeaderText = "Certifikat";
            StudentCertifikatNaziv.MinimumWidth = 6;
            StudentCertifikatNaziv.Name = "StudentCertifikatNaziv";
            // 
            // StudentCertifikatMjesecniIznos
            // 
            StudentCertifikatMjesecniIznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentCertifikatMjesecniIznos.DataPropertyName = "MjesecniIznos";
            StudentCertifikatMjesecniIznos.HeaderText = "Mjesecni iznos";
            StudentCertifikatMjesecniIznos.MinimumWidth = 6;
            StudentCertifikatMjesecniIznos.Name = "StudentCertifikatMjesecniIznos";
            // 
            // StudentCertifikatUkupniIznos
            // 
            StudentCertifikatUkupniIznos.DataPropertyName = "UkupniIznos";
            StudentCertifikatUkupniIznos.HeaderText = "Ukupni iznos";
            StudentCertifikatUkupniIznos.MinimumWidth = 6;
            StudentCertifikatUkupniIznos.Name = "StudentCertifikatUkupniIznos";
            StudentCertifikatUkupniIznos.Width = 125;
            // 
            // StudentCertifikatUkloniBtn
            // 
            StudentCertifikatUkloniBtn.HeaderText = "";
            StudentCertifikatUkloniBtn.MinimumWidth = 6;
            StudentCertifikatUkloniBtn.Name = "StudentCertifikatUkloniBtn";
            StudentCertifikatUkloniBtn.Text = "Ukloni";
            StudentCertifikatUkloniBtn.UseColumnTextForButtonValue = true;
            StudentCertifikatUkloniBtn.Width = 125;
            // 
            // frmPretragaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 450);
            Controls.Add(dgvStudentiCertifikati);
            Controls.Add(btnAddCertifikat);
            Controls.Add(btnCertifikatiPoGodinama);
            Controls.Add(cbCertifikatGodina);
            Controls.Add(lblCertifikatGodina);
            Controls.Add(cbGodina);
            Controls.Add(lblGodina);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmPretragaBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPretragaBrojIndeksa";
            ((System.ComponentModel.ISupportInitialize)dgvStudentiCertifikati).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGodina;
        private ComboBox cbGodina;
        private ComboBox cbCertifikatGodina;
        private Label lblCertifikatGodina;
        private Button btnCertifikatiPoGodinama;
        private Button btnAddCertifikat;
        private DataGridView dgvStudentiCertifikati;
        private DataGridViewTextBoxColumn StudentCertifikatIndeksImePrezime;
        private DataGridViewTextBoxColumn StudentCertifikatGodina;
        private DataGridViewTextBoxColumn StudentCertifikatNaziv;
        private DataGridViewTextBoxColumn StudentCertifikatMjesecniIznos;
        private DataGridViewTextBoxColumn StudentCertifikatUkupniIznos;
        private DataGridViewButtonColumn StudentCertifikatUkloniBtn;
    }
}