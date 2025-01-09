namespace FIT.WinForms.IspitBrojIndeksa
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
            lblSpol = new Label();
            cbSpol = new ComboBox();
            lblOd = new Label();
            dtpOd = new DateTimePicker();
            dtpDo = new DateTimePicker();
            lblDo = new Label();
            dgvStudenti = new DataGridView();
            StudentIndeks = new DataGridViewTextBoxColumn();
            StudentImePrezime = new DataGridViewTextBoxColumn();
            StudentProsjek = new DataGridViewTextBoxColumn();
            StudentDatumRodenja = new DataGridViewTextBoxColumn();
            StudentAktivan = new DataGridViewCheckBoxColumn();
            StudentUvjerenjeBtn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // lblSpol
            // 
            lblSpol.AutoSize = true;
            lblSpol.Location = new Point(12, 20);
            lblSpol.Name = "lblSpol";
            lblSpol.Size = new Size(30, 15);
            lblSpol.TabIndex = 0;
            lblSpol.Text = "Spol";
            // 
            // cbSpol
            // 
            cbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpol.FormattingEnabled = true;
            cbSpol.Location = new Point(48, 17);
            cbSpol.Name = "cbSpol";
            cbSpol.Size = new Size(121, 23);
            cbSpol.TabIndex = 1;
            cbSpol.SelectedIndexChanged += SpolComboBoxSelectedIndexChanged;
            // 
            // lblOd
            // 
            lblOd.AutoSize = true;
            lblOd.Location = new Point(175, 20);
            lblOd.Name = "lblOd";
            lblOd.Size = new Size(109, 15);
            lblOd.TabIndex = 2;
            lblOd.Text = "roden u periodu od";
            // 
            // dtpOd
            // 
            dtpOd.Location = new Point(290, 17);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(251, 23);
            dtpOd.TabIndex = 3;
            dtpOd.Value = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            dtpOd.ValueChanged += OdDoDateTimePickersValueChanged;
            // 
            // dtpDo
            // 
            dtpDo.Location = new Point(583, 17);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(251, 23);
            dtpDo.TabIndex = 4;
            dtpDo.ValueChanged += OdDoDateTimePickersValueChanged;
            // 
            // lblDo
            // 
            lblDo.AutoSize = true;
            lblDo.Location = new Point(547, 20);
            lblDo.Name = "lblDo";
            lblDo.Size = new Size(21, 15);
            lblDo.TabIndex = 5;
            lblDo.Text = "do";
            // 
            // dgvStudenti
            // 
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { StudentIndeks, StudentImePrezime, StudentProsjek, StudentDatumRodenja, StudentAktivan, StudentUvjerenjeBtn });
            dgvStudenti.Location = new Point(12, 46);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.RowTemplate.Height = 25;
            dgvStudenti.Size = new Size(822, 194);
            dgvStudenti.TabIndex = 6;
            dgvStudenti.CellClick += StudentiDgvCellClick;
            // 
            // StudentIndeks
            // 
            StudentIndeks.DataPropertyName = "Indeks";
            StudentIndeks.HeaderText = "Broj indeksa";
            StudentIndeks.Name = "StudentIndeks";
            // 
            // StudentImePrezime
            // 
            StudentImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentImePrezime.DataPropertyName = "ImePrezime";
            StudentImePrezime.HeaderText = "Ime i prezime";
            StudentImePrezime.Name = "StudentImePrezime";
            // 
            // StudentProsjek
            // 
            StudentProsjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentProsjek.DataPropertyName = "Prosjek";
            StudentProsjek.HeaderText = "Prosjek";
            StudentProsjek.Name = "StudentProsjek";
            // 
            // StudentDatumRodenja
            // 
            StudentDatumRodenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StudentDatumRodenja.DataPropertyName = "DatumRodjenja";
            StudentDatumRodenja.HeaderText = "Datum rodenja";
            StudentDatumRodenja.Name = "StudentDatumRodenja";
            StudentDatumRodenja.Width = 111;
            // 
            // StudentAktivan
            // 
            StudentAktivan.DataPropertyName = "Aktivan";
            StudentAktivan.HeaderText = "Aktivan";
            StudentAktivan.Name = "StudentAktivan";
            // 
            // StudentUvjerenjeBtn
            // 
            StudentUvjerenjeBtn.HeaderText = "";
            StudentUvjerenjeBtn.Name = "StudentUvjerenjeBtn";
            StudentUvjerenjeBtn.Text = "Uvjerenja";
            StudentUvjerenjeBtn.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 252);
            Controls.Add(dgvStudenti);
            Controls.Add(lblDo);
            Controls.Add(dtpDo);
            Controls.Add(dtpOd);
            Controls.Add(lblOd);
            Controls.Add(cbSpol);
            Controls.Add(lblSpol);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmPretragaBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga studenata";
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSpol;
        private ComboBox cbSpol;
        private Label lblOd;
        private DateTimePicker dtpOd;
        private DateTimePicker dtpDo;
        private Label lblDo;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn StudentIndeks;
        private DataGridViewTextBoxColumn StudentImePrezime;
        private DataGridViewTextBoxColumn StudentProsjek;
        private DataGridViewTextBoxColumn StudentDatumRodenja;
        private DataGridViewCheckBoxColumn StudentAktivan;
        private DataGridViewButtonColumn StudentUvjerenjeBtn;
    }
}