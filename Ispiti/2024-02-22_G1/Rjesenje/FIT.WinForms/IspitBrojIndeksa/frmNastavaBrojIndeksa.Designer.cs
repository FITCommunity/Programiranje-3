namespace FIT.WinForms.IspitBrojIndeksa
{
    partial class frmNastavaBrojIndeksa
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
            lblNazivProstorije = new Label();
            lblPredmet = new Label();
            cbPredmet = new ComboBox();
            lblDan = new Label();
            cbDan = new ComboBox();
            cbVrijeme = new ComboBox();
            lblVrijeme = new Label();
            btnDodaj = new Button();
            dgvNastave = new DataGridView();
            NastavaPredmet = new DataGridViewTextBoxColumn();
            NastavaDan = new DataGridViewTextBoxColumn();
            NastavaVrijeme = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvNastave).BeginInit();
            SuspendLayout();
            // 
            // lblNazivProstorije
            // 
            lblNazivProstorije.AutoSize = true;
            lblNazivProstorije.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNazivProstorije.Location = new Point(12, 23);
            lblNazivProstorije.Name = "lblNazivProstorije";
            lblNazivProstorije.Size = new Size(83, 32);
            lblNazivProstorije.TabIndex = 0;
            lblNazivProstorije.Text = "label1";
            // 
            // lblPredmet
            // 
            lblPredmet.AutoSize = true;
            lblPredmet.Location = new Point(12, 86);
            lblPredmet.Name = "lblPredmet";
            lblPredmet.Size = new Size(55, 15);
            lblPredmet.TabIndex = 1;
            lblPredmet.Text = "Predmet:";
            // 
            // cbPredmet
            // 
            cbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPredmet.FormattingEnabled = true;
            cbPredmet.Location = new Point(12, 104);
            cbPredmet.Name = "cbPredmet";
            cbPredmet.Size = new Size(219, 23);
            cbPredmet.TabIndex = 2;
            // 
            // lblDan
            // 
            lblDan.AutoSize = true;
            lblDan.Location = new Point(237, 86);
            lblDan.Name = "lblDan";
            lblDan.Size = new Size(31, 15);
            lblDan.TabIndex = 3;
            lblDan.Text = "Dan:";
            // 
            // cbDan
            // 
            cbDan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDan.FormattingEnabled = true;
            cbDan.Items.AddRange(new object[] { "Ponedeljak", "Utorak", "Srijeda", "Cetvrtak", "Petak", "Subota", "Nedelja" });
            cbDan.Location = new Point(237, 104);
            cbDan.Name = "cbDan";
            cbDan.Size = new Size(129, 23);
            cbDan.TabIndex = 4;
            // 
            // cbVrijeme
            // 
            cbVrijeme.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVrijeme.FormattingEnabled = true;
            cbVrijeme.Items.AddRange(new object[] { "08 - 10", "10 - 12", "12 - 14", "14 - 16" });
            cbVrijeme.Location = new Point(373, 104);
            cbVrijeme.Name = "cbVrijeme";
            cbVrijeme.Size = new Size(129, 23);
            cbVrijeme.TabIndex = 6;
            // 
            // lblVrijeme
            // 
            lblVrijeme.AutoSize = true;
            lblVrijeme.Location = new Point(373, 86);
            lblVrijeme.Name = "lblVrijeme";
            lblVrijeme.Size = new Size(50, 15);
            lblVrijeme.TabIndex = 5;
            lblVrijeme.Text = "Vrijeme:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(508, 104);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += DodajBtnClick;
            // 
            // dgvNastave
            // 
            dgvNastave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNastave.Columns.AddRange(new DataGridViewColumn[] { NastavaPredmet, NastavaDan, NastavaVrijeme });
            dgvNastave.Location = new Point(12, 133);
            dgvNastave.Name = "dgvNastave";
            dgvNastave.RowTemplate.Height = 25;
            dgvNastave.Size = new Size(571, 170);
            dgvNastave.TabIndex = 8;
            // 
            // NastavaPredmet
            // 
            NastavaPredmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NastavaPredmet.DataPropertyName = "Predmet";
            NastavaPredmet.HeaderText = "Predmet";
            NastavaPredmet.Name = "NastavaPredmet";
            // 
            // NastavaDan
            // 
            NastavaDan.DataPropertyName = "Dan";
            NastavaDan.HeaderText = "Dan";
            NastavaDan.Name = "NastavaDan";
            // 
            // NastavaVrijeme
            // 
            NastavaVrijeme.DataPropertyName = "Vrijeme";
            NastavaVrijeme.HeaderText = "Vrijeme";
            NastavaVrijeme.Name = "NastavaVrijeme";
            // 
            // frmNastavaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 316);
            Controls.Add(dgvNastave);
            Controls.Add(btnDodaj);
            Controls.Add(cbVrijeme);
            Controls.Add(lblVrijeme);
            Controls.Add(cbDan);
            Controls.Add(lblDan);
            Controls.Add(cbPredmet);
            Controls.Add(lblPredmet);
            Controls.Add(lblNazivProstorije);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNastavaBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nastava";
            ((System.ComponentModel.ISupportInitialize)dgvNastave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNazivProstorije;
        private Label lblPredmet;
        private ComboBox cbPredmet;
        private Label lblDan;
        private ComboBox cbDan;
        private ComboBox cbVrijeme;
        private Label lblVrijeme;
        private Button btnDodaj;
        private DataGridView dgvNastave;
        private DataGridViewTextBoxColumn NastavaPredmet;
        private DataGridViewTextBoxColumn NastavaDan;
        private DataGridViewTextBoxColumn NastavaVrijeme;
    }
}