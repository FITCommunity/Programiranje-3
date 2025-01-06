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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblSemestar = new Label();
            cbSemestar = new ComboBox();
            cbUloga = new ComboBox();
            lblUloga = new Label();
            lblOd = new Label();
            dgvStudenti = new DataGridView();
            StudentIndeks = new DataGridViewTextBoxColumn();
            StudentImePrezimeGodine = new DataGridViewTextBoxColumn();
            StudentDatumRodenja = new DataGridViewTextBoxColumn();
            StudentProsjek = new DataGridViewTextBoxColumn();
            StudentUloga = new DataGridViewTextBoxColumn();
            StudentAktivan = new DataGridViewCheckBoxColumn();
            StudentPorukeBtn = new DataGridViewButtonColumn();
            dtpOd = new DateTimePicker();
            dtpDo = new DateTimePicker();
            lblDo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // lblSemestar
            // 
            lblSemestar.AutoSize = true;
            lblSemestar.Location = new Point(12, 9);
            lblSemestar.Name = "lblSemestar";
            lblSemestar.Size = new Size(55, 15);
            lblSemestar.TabIndex = 0;
            lblSemestar.Text = "Semestar";
            // 
            // cbSemestar
            // 
            cbSemestar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSemestar.FormattingEnabled = true;
            cbSemestar.Location = new Point(73, 6);
            cbSemestar.Name = "cbSemestar";
            cbSemestar.Size = new Size(121, 23);
            cbSemestar.TabIndex = 1;
            cbSemestar.SelectionChangeCommitted += ComboBoxSelectionChangeCommitted;
            // 
            // cbUloga
            // 
            cbUloga.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUloga.FormattingEnabled = true;
            cbUloga.Location = new Point(243, 6);
            cbUloga.Name = "cbUloga";
            cbUloga.Size = new Size(121, 23);
            cbUloga.TabIndex = 3;
            cbUloga.SelectionChangeCommitted += ComboBoxSelectionChangeCommitted;
            // 
            // lblUloga
            // 
            lblUloga.AutoSize = true;
            lblUloga.Location = new Point(200, 9);
            lblUloga.Name = "lblUloga";
            lblUloga.Size = new Size(37, 15);
            lblUloga.TabIndex = 2;
            lblUloga.Text = "uloga";
            // 
            // lblOd
            // 
            lblOd.AutoSize = true;
            lblOd.Location = new Point(370, 9);
            lblOd.Name = "lblOd";
            lblOd.Size = new Size(112, 15);
            lblOd.TabIndex = 4;
            lblOd.Text = "roden u periodu od:";
            // 
            // dgvStudenti
            // 
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { StudentIndeks, StudentImePrezimeGodine, StudentDatumRodenja, StudentProsjek, StudentUloga, StudentAktivan, StudentPorukeBtn });
            dgvStudenti.Location = new Point(12, 35);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.RowTemplate.Height = 25;
            dgvStudenti.Size = new Size(914, 150);
            dgvStudenti.TabIndex = 5;
            dgvStudenti.CellClick += StudentiDgvCellClick;
            // 
            // StudentIndeks
            // 
            StudentIndeks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentIndeks.DataPropertyName = "Indeks";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StudentIndeks.DefaultCellStyle = dataGridViewCellStyle1;
            StudentIndeks.HeaderText = "Indeks";
            StudentIndeks.Name = "StudentIndeks";
            // 
            // StudentImePrezimeGodine
            // 
            StudentImePrezimeGodine.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentImePrezimeGodine.DataPropertyName = "ImePrezimeGodine";
            StudentImePrezimeGodine.HeaderText = "Ime i prezime";
            StudentImePrezimeGodine.Name = "StudentImePrezimeGodine";
            // 
            // StudentDatumRodenja
            // 
            StudentDatumRodenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentDatumRodenja.DataPropertyName = "DatumRodjenja";
            StudentDatumRodenja.HeaderText = "Datum rodenja";
            StudentDatumRodenja.Name = "StudentDatumRodenja";
            // 
            // StudentProsjek
            // 
            StudentProsjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentProsjek.DataPropertyName = "Prosjek";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StudentProsjek.DefaultCellStyle = dataGridViewCellStyle2;
            StudentProsjek.HeaderText = "Prosjecna ocjena";
            StudentProsjek.Name = "StudentProsjek";
            // 
            // StudentUloga
            // 
            StudentUloga.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentUloga.DataPropertyName = "Uloga";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StudentUloga.DefaultCellStyle = dataGridViewCellStyle3;
            StudentUloga.HeaderText = "Uloga";
            StudentUloga.Name = "StudentUloga";
            // 
            // StudentAktivan
            // 
            StudentAktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentAktivan.DataPropertyName = "Aktivan";
            StudentAktivan.HeaderText = "Aktivan";
            StudentAktivan.Name = "StudentAktivan";
            // 
            // StudentPorukeBtn
            // 
            StudentPorukeBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentPorukeBtn.HeaderText = "";
            StudentPorukeBtn.Name = "StudentPorukeBtn";
            StudentPorukeBtn.Text = "Poruke";
            StudentPorukeBtn.UseColumnTextForButtonValue = true;
            // 
            // dtpOd
            // 
            dtpOd.Location = new Point(488, 6);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(200, 23);
            dtpOd.TabIndex = 6;
            dtpOd.Value = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            dtpOd.ValueChanged += DateTimePickersValueChanged;
            // 
            // dtpDo
            // 
            dtpDo.Location = new Point(724, 6);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(200, 23);
            dtpDo.TabIndex = 7;
            dtpDo.ValueChanged += DateTimePickersValueChanged;
            // 
            // lblDo
            // 
            lblDo.AutoSize = true;
            lblDo.Location = new Point(694, 9);
            lblDo.Name = "lblDo";
            lblDo.Size = new Size(24, 15);
            lblDo.TabIndex = 8;
            lblDo.Text = "do:";
            // 
            // frmPretragaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 194);
            Controls.Add(lblDo);
            Controls.Add(dtpDo);
            Controls.Add(dtpOd);
            Controls.Add(dgvStudenti);
            Controls.Add(lblOd);
            Controls.Add(cbUloga);
            Controls.Add(lblUloga);
            Controls.Add(cbSemestar);
            Controls.Add(lblSemestar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmPretragaBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga studenata";
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSemestar;
        private ComboBox cbSemestar;
        private ComboBox cbUloga;
        private Label lblUloga;
        private Label lblOd;
        private DataGridView dgvStudenti;
        private DateTimePicker dtpOd;
        private DateTimePicker dtpDo;
        private Label lblDo;
        private DataGridViewTextBoxColumn StudentIndeks;
        private DataGridViewTextBoxColumn StudentImePrezimeGodine;
        private DataGridViewTextBoxColumn StudentDatumRodenja;
        private DataGridViewTextBoxColumn StudentProsjek;
        private DataGridViewTextBoxColumn StudentUloga;
        private DataGridViewCheckBoxColumn StudentAktivan;
        private DataGridViewButtonColumn StudentPorukeBtn;
    }
}