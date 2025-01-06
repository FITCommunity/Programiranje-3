namespace FIT.WinForms.IspitBrojIndeksa
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
            components = new System.ComponentModel.Container();
            lblPorukeOd = new Label();
            dgvPoruke = new DataGridView();
            PorukaPredmet = new DataGridViewTextBoxColumn();
            PorukaSadrzaj = new DataGridViewTextBoxColumn();
            PorukaSlika = new DataGridViewImageColumn();
            PorukaHitnost = new DataGridViewTextBoxColumn();
            PorukaValidnost = new DataGridViewTextBoxColumn();
            PorukaBrisiBtn = new DataGridViewButtonColumn();
            btnNovaPoruka = new Button();
            btnPrintaj = new Button();
            gbGenerator = new GroupBox();
            lblInfo = new Label();
            txtInfo = new TextBox();
            btnDodaj = new Button();
            dtpValidnost = new DateTimePicker();
            lblValidnaDo = new Label();
            cbPredmet = new ComboBox();
            lblPredmet = new Label();
            txtBrojPoruka = new TextBox();
            lblBrojPoruka = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).BeginInit();
            gbGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblPorukeOd
            // 
            lblPorukeOd.AutoSize = true;
            lblPorukeOd.Location = new Point(12, 18);
            lblPorukeOd.Name = "lblPorukeOd";
            lblPorukeOd.Size = new Size(38, 15);
            lblPorukeOd.TabIndex = 0;
            lblPorukeOd.Text = "label1";
            // 
            // dgvPoruke
            // 
            dgvPoruke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoruke.Columns.AddRange(new DataGridViewColumn[] { PorukaPredmet, PorukaSadrzaj, PorukaSlika, PorukaHitnost, PorukaValidnost, PorukaBrisiBtn });
            dgvPoruke.Location = new Point(12, 47);
            dgvPoruke.Name = "dgvPoruke";
            dgvPoruke.RowTemplate.Height = 25;
            dgvPoruke.Size = new Size(776, 150);
            dgvPoruke.TabIndex = 1;
            dgvPoruke.CellClick += PorukeDgvCellClick;
            // 
            // PorukaPredmet
            // 
            PorukaPredmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PorukaPredmet.DataPropertyName = "Predmet";
            PorukaPredmet.HeaderText = "Predmet";
            PorukaPredmet.Name = "PorukaPredmet";
            // 
            // PorukaSadrzaj
            // 
            PorukaSadrzaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PorukaSadrzaj.DataPropertyName = "Sadrzaj";
            PorukaSadrzaj.HeaderText = "Sadrzaj";
            PorukaSadrzaj.Name = "PorukaSadrzaj";
            // 
            // PorukaSlika
            // 
            PorukaSlika.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PorukaSlika.DataPropertyName = "Slika";
            PorukaSlika.HeaderText = "Slika";
            PorukaSlika.Name = "PorukaSlika";
            // 
            // PorukaHitnost
            // 
            PorukaHitnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PorukaHitnost.DataPropertyName = "Hitnost";
            PorukaHitnost.HeaderText = "Hitnost";
            PorukaHitnost.Name = "PorukaHitnost";
            // 
            // PorukaValidnost
            // 
            PorukaValidnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PorukaValidnost.DataPropertyName = "Validnost";
            PorukaValidnost.HeaderText = "Validnost";
            PorukaValidnost.Name = "PorukaValidnost";
            // 
            // PorukaBrisiBtn
            // 
            PorukaBrisiBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PorukaBrisiBtn.HeaderText = "";
            PorukaBrisiBtn.Name = "PorukaBrisiBtn";
            PorukaBrisiBtn.Text = "Brisi";
            PorukaBrisiBtn.UseColumnTextForButtonValue = true;
            // 
            // btnNovaPoruka
            // 
            btnNovaPoruka.Location = new Point(682, 18);
            btnNovaPoruka.Name = "btnNovaPoruka";
            btnNovaPoruka.Size = new Size(106, 23);
            btnNovaPoruka.TabIndex = 2;
            btnNovaPoruka.Text = "Nova poruka";
            btnNovaPoruka.UseVisualStyleBackColor = true;
            btnNovaPoruka.Click += NovaPorukaBtnClick;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(682, 203);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(106, 23);
            btnPrintaj.TabIndex = 3;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += PrintajBtnClick;
            // 
            // gbGenerator
            // 
            gbGenerator.Controls.Add(lblInfo);
            gbGenerator.Controls.Add(txtInfo);
            gbGenerator.Controls.Add(btnDodaj);
            gbGenerator.Controls.Add(dtpValidnost);
            gbGenerator.Controls.Add(lblValidnaDo);
            gbGenerator.Controls.Add(cbPredmet);
            gbGenerator.Controls.Add(lblPredmet);
            gbGenerator.Controls.Add(txtBrojPoruka);
            gbGenerator.Controls.Add(lblBrojPoruka);
            gbGenerator.Location = new Point(12, 244);
            gbGenerator.Name = "gbGenerator";
            gbGenerator.Size = new Size(776, 199);
            gbGenerator.TabIndex = 4;
            gbGenerator.TabStop = false;
            gbGenerator.Text = "Dodavanje poruka:";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(245, 34);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(31, 15);
            lblInfo.TabIndex = 9;
            lblInfo.Text = "Info:";
            // 
            // txtInfo
            // 
            txtInfo.BackColor = SystemColors.Window;
            txtInfo.Location = new Point(245, 52);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.ScrollBars = ScrollBars.Both;
            txtInfo.Size = new Size(525, 141);
            txtInfo.TabIndex = 8;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(6, 170);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(200, 23);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += DodajBtnClick;
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(6, 140);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(200, 23);
            dtpValidnost.TabIndex = 6;
            // 
            // lblValidnaDo
            // 
            lblValidnaDo.AutoSize = true;
            lblValidnaDo.Location = new Point(6, 122);
            lblValidnaDo.Name = "lblValidnaDo";
            lblValidnaDo.Size = new Size(117, 15);
            lblValidnaDo.TabIndex = 5;
            lblValidnaDo.Text = "Poruka je validna do:";
            // 
            // cbPredmet
            // 
            cbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPredmet.FormattingEnabled = true;
            cbPredmet.Location = new Point(6, 96);
            cbPredmet.Name = "cbPredmet";
            cbPredmet.Size = new Size(200, 23);
            cbPredmet.TabIndex = 4;
            // 
            // lblPredmet
            // 
            lblPredmet.AutoSize = true;
            lblPredmet.Location = new Point(6, 78);
            lblPredmet.Name = "lblPredmet";
            lblPredmet.Size = new Size(55, 15);
            lblPredmet.TabIndex = 2;
            lblPredmet.Text = "Predmet:";
            // 
            // txtBrojPoruka
            // 
            txtBrojPoruka.Location = new Point(6, 52);
            txtBrojPoruka.Name = "txtBrojPoruka";
            txtBrojPoruka.Size = new Size(200, 23);
            txtBrojPoruka.TabIndex = 1;
            // 
            // lblBrojPoruka
            // 
            lblBrojPoruka.AutoSize = true;
            lblBrojPoruka.Location = new Point(6, 34);
            lblBrojPoruka.Name = "lblBrojPoruka";
            lblBrojPoruka.Size = new Size(71, 15);
            lblBrojPoruka.TabIndex = 0;
            lblBrojPoruka.Text = "Broj poruka:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmPorukeBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 455);
            Controls.Add(gbGenerator);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaPoruka);
            Controls.Add(dgvPoruke);
            Controls.Add(lblPorukeOd);
            Name = "frmPorukeBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPorukeBrojIndeksa";
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).EndInit();
            gbGenerator.ResumeLayout(false);
            gbGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPorukeOd;
        private DataGridView dgvPoruke;
        private Button btnNovaPoruka;
        private Button btnPrintaj;
        private DataGridViewTextBoxColumn PorukaPredmet;
        private DataGridViewTextBoxColumn PorukaSadrzaj;
        private DataGridViewImageColumn PorukaSlika;
        private DataGridViewTextBoxColumn PorukaHitnost;
        private DataGridViewTextBoxColumn PorukaValidnost;
        private DataGridViewButtonColumn PorukaBrisiBtn;
        private GroupBox gbGenerator;
        private Label lblBrojPoruka;
        private TextBox txtBrojPoruka;
        private Label lblPredmet;
        private ComboBox cbPredmet;
        private Label lblValidnaDo;
        private DateTimePicker dtpValidnost;
        private Button btnDodaj;
        private Label lblInfo;
        private TextBox txtInfo;
        private ErrorProvider errorProvider;
    }
}