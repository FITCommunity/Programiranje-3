namespace DLWMS.WinForms.BrojIndeksa
{
    partial class frmPorukeBrojIndeksa
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
            dgvPoruke = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Sadrzaj = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Validnost = new DataGridViewTextBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            btnNovaPoruka = new Button();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            label4 = new Label();
            btnDodaj = new Button();
            dtpValidan = new DateTimePicker();
            label3 = new Label();
            cmbPredmet = new ComboBox();
            label2 = new Label();
            txtBrojPoruka = new TextBox();
            label1 = new Label();
            btnPrintaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(12, 12);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(96, 15);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "Poruke studenta:";
            // 
            // dgvPoruke
            // 
            dgvPoruke.AllowUserToAddRows = false;
            dgvPoruke.AllowUserToDeleteRows = false;
            dgvPoruke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoruke.Columns.AddRange(new DataGridViewColumn[] { Predmet, Sadrzaj, Slika, Validnost, Brisi });
            dgvPoruke.Location = new Point(10, 36);
            dgvPoruke.Name = "dgvPoruke";
            dgvPoruke.RowTemplate.Height = 25;
            dgvPoruke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPoruke.Size = new Size(778, 251);
            dgvPoruke.TabIndex = 1;
            dgvPoruke.CellClick += dgvPoruke_CellClick;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            // 
            // Sadrzaj
            // 
            Sadrzaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sadrzaj.DataPropertyName = "Sadrzaj";
            Sadrzaj.HeaderText = "Sadrzaj";
            Sadrzaj.Name = "Sadrzaj";
            // 
            // Slika
            // 
            Slika.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Slika.DataPropertyName = "Slika";
            Slika.HeaderText = "Slika";
            Slika.Name = "Slika";
            Slika.Resizable = DataGridViewTriState.True;
            Slika.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Validnost
            // 
            Validnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Validnost.DataPropertyName = "Validnost";
            Validnost.HeaderText = "Validnost";
            Validnost.Name = "Validnost";
            // 
            // Brisi
            // 
            Brisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brisi.HeaderText = "";
            Brisi.Name = "Brisi";
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // btnNovaPoruka
            // 
            btnNovaPoruka.Location = new Point(676, 7);
            btnNovaPoruka.Name = "btnNovaPoruka";
            btnNovaPoruka.Size = new Size(112, 23);
            btnNovaPoruka.TabIndex = 2;
            btnNovaPoruka.Text = "Nova poruka";
            btnNovaPoruka.UseVisualStyleBackColor = true;
            btnNovaPoruka.Click += btnNovaPoruka_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(dtpValidan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbPredmet);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBrojPoruka);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 327);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 186);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje poruka:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(218, 37);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(552, 140);
            txtInfo.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 19);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 11;
            label4.Text = "Info:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(6, 154);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(206, 23);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dtpValidan
            // 
            dtpValidan.Location = new Point(6, 125);
            dtpValidan.Name = "dtpValidan";
            dtpValidan.Size = new Size(206, 23);
            dtpValidan.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 107);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 9;
            label3.Text = "Poruka je validna do:";
            // 
            // cmbPredmet
            // 
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(6, 81);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(206, 23);
            cmbPredmet.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Predmet:";
            // 
            // txtBrojPoruka
            // 
            txtBrojPoruka.Location = new Point(6, 37);
            txtBrojPoruka.Name = "txtBrojPoruka";
            txtBrojPoruka.Size = new Size(206, 23);
            txtBrojPoruka.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 5;
            label1.Text = "Broj poruka:";
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(713, 298);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(75, 23);
            btnPrintaj.TabIndex = 4;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // frmPorukeBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 525);
            Controls.Add(btnPrintaj);
            Controls.Add(groupBox1);
            Controls.Add(btnNovaPoruka);
            Controls.Add(dgvPoruke);
            Controls.Add(lblStudent);
            Name = "frmPorukeBrojIndeksa";
            Text = "Broj poruka: 0";
            Load += frmPorukeBrojIndeksa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudent;
        private DataGridView dgvPoruke;
        private Button btnNovaPoruka;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Sadrzaj;
        private DataGridViewImageColumn Slika;
        private DataGridViewTextBoxColumn Validnost;
        private DataGridViewButtonColumn Brisi;
        private GroupBox groupBox1;
        private Label label4;
        private Button btnDodaj;
        private DateTimePicker dtpValidan;
        private Label label3;
        private ComboBox cmbPredmet;
        private Label label2;
        private TextBox txtBrojPoruka;
        private Label label1;
        private Button btnPrintaj;
        private TextBox txtInfo;
    }
}