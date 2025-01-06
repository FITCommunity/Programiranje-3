namespace FIT.WinForms.IspitBrojIndeksa
{
    partial class frmGradoviBrojIndeksa
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
            pbZastava = new PictureBox();
            lblNazivDrzave = new Label();
            lblNaziv = new Label();
            txtNazivGrada = new TextBox();
            btnDodaj = new Button();
            dgvGradovi = new DataGridView();
            gbGenerator = new GroupBox();
            txtInfo = new TextBox();
            lblInfo = new Label();
            btnGenerisi = new Button();
            chbAktivan = new CheckBox();
            txtBrojGradova = new TextBox();
            lblBrojGradova = new Label();
            GradNaziv = new DataGridViewTextBoxColumn();
            GradStatus = new DataGridViewCheckBoxColumn();
            GradPromjeniStatusBtn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            gbGenerator.SuspendLayout();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.BorderStyle = BorderStyle.FixedSingle;
            pbZastava.Location = new Point(12, 12);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(173, 90);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            // 
            // lblNazivDrzave
            // 
            lblNazivDrzave.AutoSize = true;
            lblNazivDrzave.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNazivDrzave.Location = new Point(191, 40);
            lblNazivDrzave.Name = "lblNazivDrzave";
            lblNazivDrzave.Size = new Size(78, 32);
            lblNazivDrzave.TabIndex = 1;
            lblNazivDrzave.Text = "label1";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(12, 114);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(149, 15);
            lblNaziv.TabIndex = 2;
            lblNaziv.Text = "Unesite naziv novog grada:";
            // 
            // txtNazivGrada
            // 
            txtNazivGrada.Location = new Point(169, 111);
            txtNazivGrada.Name = "txtNazivGrada";
            txtNazivGrada.Size = new Size(206, 23);
            txtNazivGrada.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(381, 111);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += DodajBtnClick;
            // 
            // dgvGradovi
            // 
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { GradNaziv, GradStatus, GradPromjeniStatusBtn });
            dgvGradovi.Location = new Point(12, 140);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.RowTemplate.Height = 25;
            dgvGradovi.Size = new Size(444, 150);
            dgvGradovi.TabIndex = 5;
            dgvGradovi.CellClick += GradoviDgvCellClick;
            // 
            // gbGenerator
            // 
            gbGenerator.Controls.Add(txtInfo);
            gbGenerator.Controls.Add(lblInfo);
            gbGenerator.Controls.Add(btnGenerisi);
            gbGenerator.Controls.Add(chbAktivan);
            gbGenerator.Controls.Add(txtBrojGradova);
            gbGenerator.Controls.Add(lblBrojGradova);
            gbGenerator.Location = new Point(12, 320);
            gbGenerator.Name = "gbGenerator";
            gbGenerator.Size = new Size(444, 135);
            gbGenerator.TabIndex = 6;
            gbGenerator.TabStop = false;
            gbGenerator.Text = "Generator";
            // 
            // txtInfo
            // 
            txtInfo.BackColor = SystemColors.Window;
            txtInfo.Location = new Point(6, 67);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.ScrollBars = ScrollBars.Both;
            txtInfo.Size = new Size(432, 62);
            txtInfo.TabIndex = 5;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(6, 49);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(31, 15);
            lblInfo.TabIndex = 4;
            lblInfo.Text = "Info:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(269, 16);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(75, 23);
            btnGenerisi.TabIndex = 3;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += GenerisiBtnClick;
            // 
            // chbAktivan
            // 
            chbAktivan.AutoSize = true;
            chbAktivan.Location = new Point(197, 19);
            chbAktivan.Name = "chbAktivan";
            chbAktivan.Size = new Size(66, 19);
            chbAktivan.TabIndex = 2;
            chbAktivan.Text = "Aktivan";
            chbAktivan.UseVisualStyleBackColor = true;
            // 
            // txtBrojGradova
            // 
            txtBrojGradova.Location = new Point(89, 16);
            txtBrojGradova.Name = "txtBrojGradova";
            txtBrojGradova.Size = new Size(84, 23);
            txtBrojGradova.TabIndex = 1;
            // 
            // lblBrojGradova
            // 
            lblBrojGradova.AutoSize = true;
            lblBrojGradova.Location = new Point(6, 19);
            lblBrojGradova.Name = "lblBrojGradova";
            lblBrojGradova.Size = new Size(77, 15);
            lblBrojGradova.TabIndex = 0;
            lblBrojGradova.Text = "Broj gradova:";
            // 
            // GradNaziv
            // 
            GradNaziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GradNaziv.DataPropertyName = "Naziv";
            GradNaziv.HeaderText = "Naziv grada";
            GradNaziv.Name = "GradNaziv";
            // 
            // GradStatus
            // 
            GradStatus.DataPropertyName = "Status";
            GradStatus.HeaderText = "Aktivan";
            GradStatus.Name = "GradStatus";
            GradStatus.Resizable = DataGridViewTriState.True;
            GradStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // GradPromjeniStatusBtn
            // 
            GradPromjeniStatusBtn.HeaderText = "";
            GradPromjeniStatusBtn.Name = "GradPromjeniStatusBtn";
            GradPromjeniStatusBtn.Text = "Promijeni status";
            GradPromjeniStatusBtn.UseColumnTextForButtonValue = true;
            // 
            // frmGradoviBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 467);
            Controls.Add(gbGenerator);
            Controls.Add(dgvGradovi);
            Controls.Add(btnDodaj);
            Controls.Add(txtNazivGrada);
            Controls.Add(lblNaziv);
            Controls.Add(lblNazivDrzave);
            Controls.Add(pbZastava);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGradoviBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o gradu";
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            gbGenerator.ResumeLayout(false);
            gbGenerator.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lblNazivDrzave;
        private Label lblNaziv;
        private TextBox txtNazivGrada;
        private Button btnDodaj;
        private DataGridView dgvGradovi;
        private GroupBox gbGenerator;
        private Label lblBrojGradova;
        private TextBox txtBrojGradova;
        private CheckBox chbAktivan;
        private Button btnGenerisi;
        private TextBox txtInfo;
        private Label lblInfo;
        private DataGridViewTextBoxColumn GradNaziv;
        private DataGridViewCheckBoxColumn GradStatus;
        private DataGridViewButtonColumn GradPromjeniStatusBtn;
    }
}