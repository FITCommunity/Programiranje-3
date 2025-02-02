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
            lblImeIliPrezime = new Label();
            cbDrzava = new ComboBox();
            txtImeIliPrezime = new TextBox();
            cbSpol = new ComboBox();
            lblDrzava = new Label();
            lblSpol = new Label();
            dgvStudenti = new DataGridView();
            StudentIndeksImePrezime = new DataGridViewTextBoxColumn();
            StudentDrzava = new DataGridViewTextBoxColumn();
            StudentGrad = new DataGridViewTextBoxColumn();
            StudentSpol = new DataGridViewTextBoxColumn();
            StudentAktivan = new DataGridViewCheckBoxColumn();
            StudentRazmjeneBtn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // lblImeIliPrezime
            // 
            lblImeIliPrezime.AutoSize = true;
            lblImeIliPrezime.Location = new Point(12, 9);
            lblImeIliPrezime.Name = "lblImeIliPrezime";
            lblImeIliPrezime.Size = new Size(111, 20);
            lblImeIliPrezime.TabIndex = 0;
            lblImeIliPrezime.Text = "Ime ili prezime:";
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(311, 31);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(210, 28);
            cbDrzava.TabIndex = 1;
            cbDrzava.SelectionChangeCommitted += FilterStudents;
            // 
            // txtImeIliPrezime
            // 
            txtImeIliPrezime.Location = new Point(12, 32);
            txtImeIliPrezime.Name = "txtImeIliPrezime";
            txtImeIliPrezime.Size = new Size(293, 27);
            txtImeIliPrezime.TabIndex = 2;
            txtImeIliPrezime.TextChanged += FilterStudents;
            // 
            // cbSpol
            // 
            cbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpol.FormattingEnabled = true;
            cbSpol.Location = new Point(527, 31);
            cbSpol.Name = "cbSpol";
            cbSpol.Size = new Size(210, 28);
            cbSpol.TabIndex = 3;
            cbSpol.SelectionChangeCommitted += FilterStudents;
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Location = new Point(311, 8);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(58, 20);
            lblDrzava.TabIndex = 4;
            lblDrzava.Text = "Drzava:";
            // 
            // lblSpol
            // 
            lblSpol.AutoSize = true;
            lblSpol.Location = new Point(527, 9);
            lblSpol.Name = "lblSpol";
            lblSpol.Size = new Size(42, 20);
            lblSpol.TabIndex = 5;
            lblSpol.Text = "Spol:";
            // 
            // dgvStudenti
            // 
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { StudentIndeksImePrezime, StudentDrzava, StudentGrad, StudentSpol, StudentAktivan, StudentRazmjeneBtn });
            dgvStudenti.Location = new Point(12, 65);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.Size = new Size(1050, 305);
            dgvStudenti.TabIndex = 6;
            dgvStudenti.CellClick += StudentiDgvCellClick;
            dgvStudenti.CellDoubleClick += StudentiDgvCellDoubleClick;
            // 
            // StudentIndeksImePrezime
            // 
            StudentIndeksImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentIndeksImePrezime.DataPropertyName = "IndeksImePrezime";
            StudentIndeksImePrezime.HeaderText = "(Indeks) Ime i prezime";
            StudentIndeksImePrezime.MinimumWidth = 6;
            StudentIndeksImePrezime.Name = "StudentIndeksImePrezime";
            // 
            // StudentDrzava
            // 
            StudentDrzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentDrzava.DataPropertyName = "Drzava";
            StudentDrzava.HeaderText = "Drzava";
            StudentDrzava.MinimumWidth = 6;
            StudentDrzava.Name = "StudentDrzava";
            // 
            // StudentGrad
            // 
            StudentGrad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentGrad.DataPropertyName = "Grad";
            StudentGrad.HeaderText = "Grad";
            StudentGrad.MinimumWidth = 6;
            StudentGrad.Name = "StudentGrad";
            // 
            // StudentSpol
            // 
            StudentSpol.DataPropertyName = "Spol";
            StudentSpol.HeaderText = "Spol";
            StudentSpol.MinimumWidth = 6;
            StudentSpol.Name = "StudentSpol";
            StudentSpol.Width = 125;
            // 
            // StudentAktivan
            // 
            StudentAktivan.DataPropertyName = "Aktivan";
            StudentAktivan.HeaderText = "Aktivan";
            StudentAktivan.MinimumWidth = 6;
            StudentAktivan.Name = "StudentAktivan";
            StudentAktivan.Width = 125;
            // 
            // StudentRazmjeneBtn
            // 
            StudentRazmjeneBtn.HeaderText = "";
            StudentRazmjeneBtn.MinimumWidth = 6;
            StudentRazmjeneBtn.Name = "StudentRazmjeneBtn";
            StudentRazmjeneBtn.Text = "Razmjene";
            StudentRazmjeneBtn.UseColumnTextForButtonValue = true;
            StudentRazmjeneBtn.Width = 125;
            // 
            // frmPretragaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 382);
            Controls.Add(dgvStudenti);
            Controls.Add(lblSpol);
            Controls.Add(lblDrzava);
            Controls.Add(cbSpol);
            Controls.Add(txtImeIliPrezime);
            Controls.Add(cbDrzava);
            Controls.Add(lblImeIliPrezime);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmPretragaBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPretragaBrojIndeksa";
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImeIliPrezime;
        private ComboBox cbDrzava;
        private TextBox txtImeIliPrezime;
        private ComboBox cbSpol;
        private Label lblDrzava;
        private Label lblSpol;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn StudentIndeksImePrezime;
        private DataGridViewTextBoxColumn StudentDrzava;
        private DataGridViewTextBoxColumn StudentGrad;
        private DataGridViewTextBoxColumn StudentSpol;
        private DataGridViewCheckBoxColumn StudentAktivan;
        private DataGridViewButtonColumn StudentRazmjeneBtn;
    }
}