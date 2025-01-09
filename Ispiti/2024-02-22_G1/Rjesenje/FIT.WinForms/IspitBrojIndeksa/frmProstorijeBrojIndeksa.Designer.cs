namespace FIT.WinForms.IspitBrojIndeksa
{
    partial class frmProstorijeBrojIndeksa
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
            btnNovaProstorija = new Button();
            btnPrintaj = new Button();
            dgvProstorije = new DataGridView();
            ProstorijaLogo = new DataGridViewImageColumn();
            ProstorijaNaziv = new DataGridViewTextBoxColumn();
            ProstorijaOznaka = new DataGridViewTextBoxColumn();
            ProstorijaKapacitet = new DataGridViewTextBoxColumn();
            ProstorijaBrojPredmeta = new DataGridViewTextBoxColumn();
            ProstorijaNastavaBtn = new DataGridViewButtonColumn();
            ProstorijaPrisustvoBtn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProstorije).BeginInit();
            SuspendLayout();
            // 
            // btnNovaProstorija
            // 
            btnNovaProstorija.Location = new Point(666, 24);
            btnNovaProstorija.Name = "btnNovaProstorija";
            btnNovaProstorija.Size = new Size(122, 23);
            btnNovaProstorija.TabIndex = 0;
            btnNovaProstorija.Text = "Nova prostorija";
            btnNovaProstorija.UseVisualStyleBackColor = true;
            btnNovaProstorija.Click += NovaProstorijaBtnClick;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(666, 242);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(122, 23);
            btnPrintaj.TabIndex = 1;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += PrintajBtnClick;
            // 
            // dgvProstorije
            // 
            dgvProstorije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProstorije.Columns.AddRange(new DataGridViewColumn[] { ProstorijaLogo, ProstorijaNaziv, ProstorijaOznaka, ProstorijaKapacitet, ProstorijaBrojPredmeta, ProstorijaNastavaBtn, ProstorijaPrisustvoBtn });
            dgvProstorije.Location = new Point(12, 53);
            dgvProstorije.Name = "dgvProstorije";
            dgvProstorije.RowTemplate.Height = 25;
            dgvProstorije.Size = new Size(776, 183);
            dgvProstorije.TabIndex = 2;
            dgvProstorije.CellClick += ProstorijeDgvCellClick;
            dgvProstorije.CellDoubleClick += ProstorijeDgvCellDoubleClick;
            // 
            // ProstorijaLogo
            // 
            ProstorijaLogo.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ProstorijaLogo.DataPropertyName = "Logo";
            ProstorijaLogo.HeaderText = "Logo";
            ProstorijaLogo.ImageLayout = DataGridViewImageCellLayout.Stretch;
            ProstorijaLogo.Name = "ProstorijaLogo";
            ProstorijaLogo.Width = 40;
            // 
            // ProstorijaNaziv
            // 
            ProstorijaNaziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProstorijaNaziv.DataPropertyName = "Naziv";
            ProstorijaNaziv.HeaderText = "Naziv";
            ProstorijaNaziv.Name = "ProstorijaNaziv";
            // 
            // ProstorijaOznaka
            // 
            ProstorijaOznaka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProstorijaOznaka.DataPropertyName = "Oznaka";
            ProstorijaOznaka.HeaderText = "Oznaka";
            ProstorijaOznaka.Name = "ProstorijaOznaka";
            // 
            // ProstorijaKapacitet
            // 
            ProstorijaKapacitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProstorijaKapacitet.DataPropertyName = "Kapacitet";
            ProstorijaKapacitet.HeaderText = "Kapacitet";
            ProstorijaKapacitet.Name = "ProstorijaKapacitet";
            // 
            // ProstorijaBrojPredmeta
            // 
            ProstorijaBrojPredmeta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProstorijaBrojPredmeta.DataPropertyName = "BrojPredmeta";
            ProstorijaBrojPredmeta.HeaderText = "Br. predmeta";
            ProstorijaBrojPredmeta.Name = "ProstorijaBrojPredmeta";
            // 
            // ProstorijaNastavaBtn
            // 
            ProstorijaNastavaBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProstorijaNastavaBtn.HeaderText = "";
            ProstorijaNastavaBtn.Name = "ProstorijaNastavaBtn";
            ProstorijaNastavaBtn.Text = "Nastava";
            ProstorijaNastavaBtn.UseColumnTextForButtonValue = true;
            // 
            // ProstorijaPrisustvoBtn
            // 
            ProstorijaPrisustvoBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProstorijaPrisustvoBtn.HeaderText = "";
            ProstorijaPrisustvoBtn.Name = "ProstorijaPrisustvoBtn";
            ProstorijaPrisustvoBtn.Text = "Prisustvo";
            ProstorijaPrisustvoBtn.UseColumnTextForButtonValue = true;
            // 
            // frmProstorijeBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 277);
            Controls.Add(dgvProstorije);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaProstorija);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmProstorijeBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prostorije";
            ((System.ComponentModel.ISupportInitialize)dgvProstorije).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovaProstorija;
        private Button btnPrintaj;
        private DataGridView dgvProstorije;
        private DataGridViewImageColumn ProstorijaLogo;
        private DataGridViewTextBoxColumn ProstorijaNaziv;
        private DataGridViewTextBoxColumn ProstorijaOznaka;
        private DataGridViewTextBoxColumn ProstorijaKapacitet;
        private DataGridViewTextBoxColumn ProstorijaBrojPredmeta;
        private DataGridViewButtonColumn ProstorijaNastavaBtn;
        private DataGridViewButtonColumn ProstorijaPrisustvoBtn;
    }
}