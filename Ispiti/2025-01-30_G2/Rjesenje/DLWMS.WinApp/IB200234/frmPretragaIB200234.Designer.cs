namespace DLWMS.WinApp.IB200234
{
    partial class frmPretragaIB200234
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
            label1 = new Label();
            label2 = new Label();
            cmbDrzave = new ComboBox();
            cmbSpol = new ComboBox();
            cbAktivan = new CheckBox();
            dgvStudenti = new DataGridView();
            StudentInfo = new DataGridViewTextBoxColumn();
            GradDrzavaID = new DataGridViewTextBoxColumn();
            Spol = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            btnRazmjena = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Drzava:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 20);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Spol:";
            // 
            // cmbDrzave
            // 
            cmbDrzave.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzave.FormattingEnabled = true;
            cmbDrzave.Location = new Point(17, 48);
            cmbDrzave.Name = "cmbDrzave";
            cmbDrzave.Size = new Size(266, 28);
            cmbDrzave.TabIndex = 2;
            cmbDrzave.SelectedIndexChanged += cmbDrzave_SelectedIndexChanged;
            // 
            // cmbSpol
            // 
            cmbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Location = new Point(337, 48);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(161, 28);
            cmbSpol.TabIndex = 3;
            cmbSpol.SelectedIndexChanged += cmbSpol_SelectedIndexChanged;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(587, 45);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(80, 24);
            cbAktivan.TabIndex = 4;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            cbAktivan.CheckedChanged += cbAktivan_CheckedChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { StudentInfo, GradDrzavaID, Spol, Aktivan, btnRazmjena });
            dgvStudenti.Location = new Point(19, 105);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.Size = new Size(952, 319);
            dgvStudenti.TabIndex = 5;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            dgvStudenti.CellContentDoubleClick += dgvStudenti_CellContentDoubleClick;
            // 
            // StudentInfo
            // 
            StudentInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentInfo.DataPropertyName = "StudentInfo";
            StudentInfo.HeaderText = "(Indeks) Ime Prezime";
            StudentInfo.MinimumWidth = 6;
            StudentInfo.Name = "StudentInfo";
            StudentInfo.ReadOnly = true;
            // 
            // GradDrzavaID
            // 
            GradDrzavaID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GradDrzavaID.DataPropertyName = "GradDrzavaID";
            GradDrzavaID.HeaderText = "(Grad) Drzava Id";
            GradDrzavaID.MinimumWidth = 6;
            GradDrzavaID.Name = "GradDrzavaID";
            GradDrzavaID.ReadOnly = true;
            // 
            // Spol
            // 
            Spol.DataPropertyName = "Spol";
            Spol.HeaderText = "Spol";
            Spol.MinimumWidth = 6;
            Spol.Name = "Spol";
            Spol.ReadOnly = true;
            Spol.Width = 125;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // btnRazmjena
            // 
            btnRazmjena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnRazmjena.HeaderText = "";
            btnRazmjena.MinimumWidth = 6;
            btnRazmjena.Name = "btnRazmjena";
            btnRazmjena.ReadOnly = true;
            btnRazmjena.Text = "Razmjena";
            btnRazmjena.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB200234
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 450);
            Controls.Add(dgvStudenti);
            Controls.Add(cbAktivan);
            Controls.Add(cmbSpol);
            Controls.Add(cmbDrzave);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB200234";
            Text = "frmPretragaIB200234";
            Load += frmPretragaIB200234_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbDrzave;
        private ComboBox cmbSpol;
        private CheckBox cbAktivan;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn StudentInfo;
        private DataGridViewTextBoxColumn GradDrzavaID;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnRazmjena;
    }
}