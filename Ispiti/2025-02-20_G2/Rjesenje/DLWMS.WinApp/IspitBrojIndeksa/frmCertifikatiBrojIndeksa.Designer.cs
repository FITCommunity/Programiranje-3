namespace DLWMS.WinApp.IspitBrojIndeksa
{
    partial class frmCertifikatiBrojIndeksa
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
            cbCertifikat = new ComboBox();
            lblCertifikat = new Label();
            cbGodina = new ComboBox();
            lblGodina = new Label();
            txtMjesecniIznos = new TextBox();
            lblMjesecniIznos = new Label();
            btnDodaj = new Button();
            dgvCertifikatiGodine = new DataGridView();
            btnGenerisi = new Button();
            btnIzvjestaj = new Button();
            gbGenerator = new GroupBox();
            txtInfo = new TextBox();
            CertifikatGodinaGodina = new DataGridViewTextBoxColumn();
            CertifikatGodinaNaziv = new DataGridViewTextBoxColumn();
            CertifikatGodinaMjesecniIznos = new DataGridViewTextBoxColumn();
            CertifikatGodinaUkupniIznos = new DataGridViewTextBoxColumn();
            CertifikatGodinaAktivan = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCertifikatiGodine).BeginInit();
            gbGenerator.SuspendLayout();
            SuspendLayout();
            // 
            // cbCertifikat
            // 
            cbCertifikat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCertifikat.FormattingEnabled = true;
            cbCertifikat.Location = new Point(169, 32);
            cbCertifikat.Name = "cbCertifikat";
            cbCertifikat.Size = new Size(476, 28);
            cbCertifikat.TabIndex = 7;
            // 
            // lblCertifikat
            // 
            lblCertifikat.AutoSize = true;
            lblCertifikat.Location = new Point(169, 9);
            lblCertifikat.Name = "lblCertifikat";
            lblCertifikat.Size = new Size(72, 20);
            lblCertifikat.TabIndex = 6;
            lblCertifikat.Text = "Certifikat:";
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021" });
            cbGodina.Location = new Point(12, 32);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(151, 28);
            cbGodina.TabIndex = 5;
            // 
            // lblGodina
            // 
            lblGodina.AutoSize = true;
            lblGodina.Location = new Point(12, 9);
            lblGodina.Name = "lblGodina";
            lblGodina.Size = new Size(60, 20);
            lblGodina.TabIndex = 4;
            lblGodina.Text = "Godina:";
            // 
            // txtMjesecniIznos
            // 
            txtMjesecniIznos.Location = new Point(651, 32);
            txtMjesecniIznos.Name = "txtMjesecniIznos";
            txtMjesecniIznos.Size = new Size(162, 27);
            txtMjesecniIznos.TabIndex = 8;
            // 
            // lblMjesecniIznos
            // 
            lblMjesecniIznos.AutoSize = true;
            lblMjesecniIznos.Location = new Point(651, 9);
            lblMjesecniIznos.Name = "lblMjesecniIznos";
            lblMjesecniIznos.Size = new Size(154, 20);
            lblMjesecniIznos.TabIndex = 9;
            lblMjesecniIznos.Text = "Mjesecni iznos (BAM):";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(819, 32);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 10;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += DodajBtnClick;
            // 
            // dgvCertifikatiGodine
            // 
            dgvCertifikatiGodine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCertifikatiGodine.Columns.AddRange(new DataGridViewColumn[] { CertifikatGodinaGodina, CertifikatGodinaNaziv, CertifikatGodinaMjesecniIznos, CertifikatGodinaUkupniIznos, CertifikatGodinaAktivan });
            dgvCertifikatiGodine.Location = new Point(12, 66);
            dgvCertifikatiGodine.Name = "dgvCertifikatiGodine";
            dgvCertifikatiGodine.RowHeadersWidth = 51;
            dgvCertifikatiGodine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCertifikatiGodine.Size = new Size(895, 254);
            dgvCertifikatiGodine.TabIndex = 11;
            dgvCertifikatiGodine.CellDoubleClick += CertifikatiGodineDgvCellDoubleClick;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(12, 326);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(229, 29);
            btnGenerisi.TabIndex = 12;
            btnGenerisi.Text = "Generisi certifikate >>>>>>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += GenerisiBtnClick;
            // 
            // btnIzvjestaj
            // 
            btnIzvjestaj.Location = new Point(739, 326);
            btnIzvjestaj.Name = "btnIzvjestaj";
            btnIzvjestaj.Size = new Size(168, 29);
            btnIzvjestaj.TabIndex = 12;
            btnIzvjestaj.Text = "Izvjestaj";
            btnIzvjestaj.UseVisualStyleBackColor = true;
            btnIzvjestaj.Click += IzvjestajBtnClick;
            // 
            // gbGenerator
            // 
            gbGenerator.Controls.Add(txtInfo);
            gbGenerator.Location = new Point(12, 361);
            gbGenerator.Name = "gbGenerator";
            gbGenerator.Size = new Size(895, 236);
            gbGenerator.TabIndex = 13;
            gbGenerator.TabStop = false;
            gbGenerator.Text = "Generator info";
            // 
            // txtInfo
            // 
            txtInfo.BackColor = SystemColors.Window;
            txtInfo.Location = new Point(6, 26);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.ScrollBars = ScrollBars.Both;
            txtInfo.Size = new Size(883, 204);
            txtInfo.TabIndex = 0;
            // 
            // CertifikatGodinaGodina
            // 
            CertifikatGodinaGodina.DataPropertyName = "Godina";
            CertifikatGodinaGodina.HeaderText = "Godina";
            CertifikatGodinaGodina.MinimumWidth = 6;
            CertifikatGodinaGodina.Name = "CertifikatGodinaGodina";
            CertifikatGodinaGodina.SortMode = DataGridViewColumnSortMode.NotSortable;
            CertifikatGodinaGodina.Width = 125;
            // 
            // CertifikatGodinaNaziv
            // 
            CertifikatGodinaNaziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CertifikatGodinaNaziv.DataPropertyName = "Certifikat";
            CertifikatGodinaNaziv.HeaderText = "Certifikat";
            CertifikatGodinaNaziv.MinimumWidth = 6;
            CertifikatGodinaNaziv.Name = "CertifikatGodinaNaziv";
            CertifikatGodinaNaziv.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // CertifikatGodinaMjesecniIznos
            // 
            CertifikatGodinaMjesecniIznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            CertifikatGodinaMjesecniIznos.DataPropertyName = "MjesecniIznos";
            CertifikatGodinaMjesecniIznos.HeaderText = "Mjesecni iznos";
            CertifikatGodinaMjesecniIznos.MinimumWidth = 6;
            CertifikatGodinaMjesecniIznos.Name = "CertifikatGodinaMjesecniIznos";
            CertifikatGodinaMjesecniIznos.SortMode = DataGridViewColumnSortMode.NotSortable;
            CertifikatGodinaMjesecniIznos.Width = 111;
            // 
            // CertifikatGodinaUkupniIznos
            // 
            CertifikatGodinaUkupniIznos.DataPropertyName = "UkupniIznos";
            CertifikatGodinaUkupniIznos.HeaderText = "Ukupni iznos";
            CertifikatGodinaUkupniIznos.MinimumWidth = 6;
            CertifikatGodinaUkupniIznos.Name = "CertifikatGodinaUkupniIznos";
            CertifikatGodinaUkupniIznos.SortMode = DataGridViewColumnSortMode.NotSortable;
            CertifikatGodinaUkupniIznos.Width = 125;
            // 
            // CertifikatGodinaAktivan
            // 
            CertifikatGodinaAktivan.DataPropertyName = "Aktivan";
            CertifikatGodinaAktivan.HeaderText = "Aktivan";
            CertifikatGodinaAktivan.MinimumWidth = 6;
            CertifikatGodinaAktivan.Name = "CertifikatGodinaAktivan";
            CertifikatGodinaAktivan.Width = 125;
            // 
            // frmCertifikatiBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 609);
            Controls.Add(gbGenerator);
            Controls.Add(btnIzvjestaj);
            Controls.Add(btnGenerisi);
            Controls.Add(dgvCertifikatiGodine);
            Controls.Add(btnDodaj);
            Controls.Add(lblMjesecniIznos);
            Controls.Add(txtMjesecniIznos);
            Controls.Add(cbCertifikat);
            Controls.Add(lblCertifikat);
            Controls.Add(cbGodina);
            Controls.Add(lblGodina);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmCertifikatiBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje certifikatima";
            ((System.ComponentModel.ISupportInitialize)dgvCertifikatiGodine).EndInit();
            gbGenerator.ResumeLayout(false);
            gbGenerator.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCertifikat;
        private Label lblCertifikat;
        private ComboBox cbGodina;
        private Label lblGodina;
        private TextBox txtMjesecniIznos;
        private Label lblMjesecniIznos;
        private Button btnDodaj;
        private DataGridView dgvCertifikatiGodine;
        private Button btnGenerisi;
        private Button btnIzvjestaj;
        private GroupBox gbGenerator;
        private TextBox txtInfo;
        private DataGridViewTextBoxColumn CertifikatGodinaGodina;
        private DataGridViewTextBoxColumn CertifikatGodinaNaziv;
        private DataGridViewTextBoxColumn CertifikatGodinaMjesecniIznos;
        private DataGridViewTextBoxColumn CertifikatGodinaUkupniIznos;
        private DataGridViewCheckBoxColumn CertifikatGodinaAktivan;
    }
}