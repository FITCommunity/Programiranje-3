namespace DLWMS.WinForms.BrojIndeksa
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            dgvStudenti = new DataGridView();
            Indeks = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            DatumPolaganja = new DataGridViewTextBoxColumn();
            Poruke = new DataGridViewButtonColumn();
            label1 = new Label();
            cmbOcjenaOd = new ComboBox();
            cmbOcjenaDo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dtpDatumOd = new DateTimePicker();
            label4 = new Label();
            dtpDatumDo = new DateTimePicker();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Indeks, ImePrezime, Predmet, Ocjena, DatumPolaganja, Poruke });
            dgvStudenti.Location = new Point(12, 35);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.RowTemplate.Height = 25;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(783, 234);
            dgvStudenti.TabIndex = 0;
            dgvStudenti.CellClick += dgvStudenti_CellClick;
            // 
            // Indeks
            // 
            Indeks.DataPropertyName = "Indeks";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Indeks.DefaultCellStyle = dataGridViewCellStyle6;
            Indeks.HeaderText = "Indeks";
            Indeks.Name = "Indeks";
            Indeks.Width = 80;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ImePrezime.DefaultCellStyle = dataGridViewCellStyle7;
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.Name = "ImePrezime";
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Predmet.DefaultCellStyle = dataGridViewCellStyle8;
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            // 
            // Ocjena
            // 
            Ocjena.DataPropertyName = "Ocjena";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Ocjena.DefaultCellStyle = dataGridViewCellStyle9;
            Ocjena.HeaderText = "Ocjena";
            Ocjena.Name = "Ocjena";
            Ocjena.Width = 80;
            // 
            // DatumPolaganja
            // 
            DatumPolaganja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPolaganja.DataPropertyName = "DatumPolaganja";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DatumPolaganja.DefaultCellStyle = dataGridViewCellStyle10;
            DatumPolaganja.HeaderText = "DatumPolaganja";
            DatumPolaganja.Name = "DatumPolaganja";
            // 
            // Poruke
            // 
            Poruke.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Poruke.HeaderText = "";
            Poruke.Name = "Poruke";
            Poruke.Text = "Poruke";
            Poruke.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Ocjena od";
            // 
            // cmbOcjenaOd
            // 
            cmbOcjenaOd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOcjenaOd.FormattingEnabled = true;
            cmbOcjenaOd.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjenaOd.Location = new Point(79, 6);
            cmbOcjenaOd.Name = "cmbOcjenaOd";
            cmbOcjenaOd.Size = new Size(56, 23);
            cmbOcjenaOd.TabIndex = 2;
            cmbOcjenaOd.SelectedIndexChanged += cmbOcjenaOd_SelectedIndexChanged;
            // 
            // cmbOcjenaDo
            // 
            cmbOcjenaDo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOcjenaDo.FormattingEnabled = true;
            cmbOcjenaDo.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjenaDo.Location = new Point(168, 6);
            cmbOcjenaDo.Name = "cmbOcjenaDo";
            cmbOcjenaDo.Size = new Size(56, 23);
            cmbOcjenaDo.TabIndex = 4;
            cmbOcjenaDo.SelectedIndexChanged += cmbOcjenaDo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 9);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 3;
            label2.Text = "do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 9);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 5;
            label3.Text = "položena u periodu od";
            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Location = new Point(362, 6);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(200, 23);
            dtpDatumOd.TabIndex = 6;
            dtpDatumOd.ValueChanged += dtpDatumOd_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(568, 9);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 7;
            label4.Text = "do";
            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Location = new Point(595, 6);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(200, 23);
            dtpDatumDo.TabIndex = 8;
            dtpDatumDo.ValueChanged += dtpDatumDo_ValueChanged;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPretragaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 279);
            Controls.Add(dtpDatumDo);
            Controls.Add(label4);
            Controls.Add(dtpDatumOd);
            Controls.Add(label3);
            Controls.Add(cmbOcjenaDo);
            Controls.Add(label2);
            Controls.Add(cmbOcjenaOd);
            Controls.Add(label1);
            Controls.Add(dgvStudenti);
            Name = "frmPretragaBrojIndeksa";
            Text = "Pretraga studenata";
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudenti;
        private Label label1;
        private ComboBox cmbOcjenaOd;
        private ComboBox cmbOcjenaDo;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDatumOd;
        private Label label4;
        private DateTimePicker dtpDatumDo;
        private ErrorProvider err;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn DatumPolaganja;
        private DataGridViewButtonColumn Poruke;
    }
}