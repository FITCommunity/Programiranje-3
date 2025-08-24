namespace DLWMS.WinApp.IspitBrojIndeksa
{
    partial class frmRazmjeneBrojIndeksa
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
            lblDrzava = new Label();
            cbDrzava = new ComboBox();
            cbUniverzitet = new ComboBox();
            lblUniverzitet = new Label();
            lblBrojKredita = new Label();
            txtECTS = new TextBox();
            dtpPocetak = new DateTimePicker();
            dtpKraj = new DateTimePicker();
            btnSacuvaj = new Button();
            lblKraj = new Label();
            lblPocetak = new Label();
            dgvRazmjene = new DataGridView();
            gbGenerator = new GroupBox();
            txtInfo = new TextBox();
            lblInfo = new Label();
            btnGenerisi = new Button();
            gtxtECTS = new TextBox();
            txtBrojRazmjena = new TextBox();
            glblRazmjene = new Label();
            glblECTS = new Label();
            glblUniverzitet = new Label();
            gcbUniverzitet = new ComboBox();
            btnPotvrda = new Button();
            Univerzitet = new DataGridViewTextBoxColumn();
            Pocetak = new DataGridViewTextBoxColumn();
            Kraj = new DataGridViewTextBoxColumn();
            ECTS = new DataGridViewTextBoxColumn();
            Okoncana = new DataGridViewCheckBoxColumn();
            ObrisiBtn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).BeginInit();
            gbGenerator.SuspendLayout();
            SuspendLayout();
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Location = new Point(12, 9);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(58, 20);
            lblDrzava.TabIndex = 0;
            lblDrzava.Text = "Drzava:";
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(12, 32);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(283, 28);
            cbDrzava.TabIndex = 1;
            cbDrzava.SelectionChangeCommitted += DrzavaComboBoxSelectionChangeCommitted;
            // 
            // cbUniverzitet
            // 
            cbUniverzitet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUniverzitet.FormattingEnabled = true;
            cbUniverzitet.Location = new Point(301, 32);
            cbUniverzitet.Name = "cbUniverzitet";
            cbUniverzitet.Size = new Size(286, 28);
            cbUniverzitet.TabIndex = 2;
            // 
            // lblUniverzitet
            // 
            lblUniverzitet.AutoSize = true;
            lblUniverzitet.Location = new Point(301, 9);
            lblUniverzitet.Name = "lblUniverzitet";
            lblUniverzitet.Size = new Size(83, 20);
            lblUniverzitet.TabIndex = 3;
            lblUniverzitet.Text = "Univerzitet:";
            // 
            // lblBrojKredita
            // 
            lblBrojKredita.AutoSize = true;
            lblBrojKredita.Location = new Point(593, 9);
            lblBrojKredita.Name = "lblBrojKredita";
            lblBrojKredita.Size = new Size(89, 20);
            lblBrojKredita.TabIndex = 4;
            lblBrojKredita.Text = "Broj kredita:";
            // 
            // txtECTS
            // 
            txtECTS.Location = new Point(593, 32);
            txtECTS.Name = "txtECTS";
            txtECTS.Size = new Size(125, 27);
            txtECTS.TabIndex = 5;
            // 
            // dtpPocetak
            // 
            dtpPocetak.Location = new Point(724, 33);
            dtpPocetak.Name = "dtpPocetak";
            dtpPocetak.Size = new Size(250, 27);
            dtpPocetak.TabIndex = 6;
            dtpPocetak.Value = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // dtpKraj
            // 
            dtpKraj.Location = new Point(980, 33);
            dtpKraj.Name = "dtpKraj";
            dtpKraj.Size = new Size(250, 27);
            dtpKraj.TabIndex = 7;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(1236, 34);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 8;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += SacuvajBtnClick;
            // 
            // lblKraj
            // 
            lblKraj.AutoSize = true;
            lblKraj.Location = new Point(980, 10);
            lblKraj.Name = "lblKraj";
            lblKraj.Size = new Size(103, 20);
            lblKraj.TabIndex = 9;
            lblKraj.Text = "Kraj razmjene:";
            // 
            // lblPocetak
            // 
            lblPocetak.AutoSize = true;
            lblPocetak.Location = new Point(724, 9);
            lblPocetak.Name = "lblPocetak";
            lblPocetak.Size = new Size(128, 20);
            lblPocetak.TabIndex = 10;
            lblPocetak.Text = "Pocetak razmjene:";
            // 
            // dgvRazmjene
            // 
            dgvRazmjene.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRazmjene.Columns.AddRange(new DataGridViewColumn[] { Univerzitet, Pocetak, Kraj, ECTS, Okoncana, ObrisiBtn });
            dgvRazmjene.Location = new Point(12, 66);
            dgvRazmjene.Name = "dgvRazmjene";
            dgvRazmjene.RowHeadersWidth = 51;
            dgvRazmjene.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRazmjene.Size = new Size(1316, 225);
            dgvRazmjene.TabIndex = 11;
            dgvRazmjene.CellClick += RazmjeneDgvCellClick;
            // 
            // gbGenerator
            // 
            gbGenerator.Controls.Add(txtInfo);
            gbGenerator.Controls.Add(lblInfo);
            gbGenerator.Controls.Add(btnGenerisi);
            gbGenerator.Controls.Add(gtxtECTS);
            gbGenerator.Controls.Add(txtBrojRazmjena);
            gbGenerator.Controls.Add(glblRazmjene);
            gbGenerator.Controls.Add(glblECTS);
            gbGenerator.Controls.Add(glblUniverzitet);
            gbGenerator.Controls.Add(gcbUniverzitet);
            gbGenerator.Location = new Point(12, 332);
            gbGenerator.Name = "gbGenerator";
            gbGenerator.Size = new Size(1318, 214);
            gbGenerator.TabIndex = 12;
            gbGenerator.TabStop = false;
            gbGenerator.Text = "Generator razmjena";
            // 
            // txtInfo
            // 
            txtInfo.BackColor = SystemColors.Window;
            txtInfo.Location = new Point(309, 47);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.ScrollBars = ScrollBars.Both;
            txtInfo.Size = new Size(1003, 161);
            txtInfo.TabIndex = 16;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(309, 23);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(38, 20);
            lblInfo.TabIndex = 15;
            lblInfo.Text = "Info:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(6, 133);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(286, 29);
            btnGenerisi.TabIndex = 14;
            btnGenerisi.Text = "Generisi razmjene >>>>>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += GenerisiBtnClick;
            // 
            // gtxtECTS
            // 
            gtxtECTS.Location = new Point(148, 100);
            gtxtECTS.Name = "gtxtECTS";
            gtxtECTS.Size = new Size(144, 27);
            gtxtECTS.TabIndex = 10;
            // 
            // txtBrojRazmjena
            // 
            txtBrojRazmjena.Location = new Point(6, 100);
            txtBrojRazmjena.Name = "txtBrojRazmjena";
            txtBrojRazmjena.Size = new Size(136, 27);
            txtBrojRazmjena.TabIndex = 9;
            // 
            // glblRazmjene
            // 
            glblRazmjene.AutoSize = true;
            glblRazmjene.Location = new Point(6, 77);
            glblRazmjene.Name = "glblRazmjene";
            glblRazmjene.Size = new Size(104, 20);
            glblRazmjene.TabIndex = 8;
            glblRazmjene.Text = "Broj razmjena:";
            // 
            // glblECTS
            // 
            glblECTS.AutoSize = true;
            glblECTS.Location = new Point(148, 77);
            glblECTS.Name = "glblECTS";
            glblECTS.Size = new Size(89, 20);
            glblECTS.TabIndex = 6;
            glblECTS.Text = "Broj kredita:";
            // 
            // glblUniverzitet
            // 
            glblUniverzitet.AutoSize = true;
            glblUniverzitet.Location = new Point(6, 23);
            glblUniverzitet.Name = "glblUniverzitet";
            glblUniverzitet.Size = new Size(83, 20);
            glblUniverzitet.TabIndex = 5;
            glblUniverzitet.Text = "Univerzitet:";
            // 
            // gcbUniverzitet
            // 
            gcbUniverzitet.DropDownStyle = ComboBoxStyle.DropDownList;
            gcbUniverzitet.FormattingEnabled = true;
            gcbUniverzitet.Location = new Point(6, 46);
            gcbUniverzitet.Name = "gcbUniverzitet";
            gcbUniverzitet.Size = new Size(286, 28);
            gcbUniverzitet.TabIndex = 4;
            // 
            // btnPotvrda
            // 
            btnPotvrda.Location = new Point(1236, 297);
            btnPotvrda.Name = "btnPotvrda";
            btnPotvrda.Size = new Size(94, 29);
            btnPotvrda.TabIndex = 13;
            btnPotvrda.Text = "Potvrda";
            btnPotvrda.UseVisualStyleBackColor = true;
            btnPotvrda.Click += PotvrdaBtnClick;
            // 
            // Univerzitet
            // 
            Univerzitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Univerzitet.DataPropertyName = "Univerzitet";
            Univerzitet.HeaderText = "Univerzitet";
            Univerzitet.MinimumWidth = 6;
            Univerzitet.Name = "Univerzitet";
            // 
            // Pocetak
            // 
            Pocetak.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pocetak.DataPropertyName = "Pocetak";
            Pocetak.HeaderText = "Pocetak";
            Pocetak.MinimumWidth = 6;
            Pocetak.Name = "Pocetak";
            // 
            // Kraj
            // 
            Kraj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kraj.DataPropertyName = "Kraj";
            Kraj.HeaderText = "Kraj";
            Kraj.MinimumWidth = 6;
            Kraj.Name = "Kraj";
            // 
            // ECTS
            // 
            ECTS.DataPropertyName = "ECTS";
            ECTS.HeaderText = "ECTS";
            ECTS.MinimumWidth = 6;
            ECTS.Name = "ECTS";
            ECTS.Width = 125;
            // 
            // Okoncana
            // 
            Okoncana.DataPropertyName = "Okoncano";
            Okoncana.HeaderText = "Okoncana";
            Okoncana.MinimumWidth = 6;
            Okoncana.Name = "Okoncana";
            Okoncana.Width = 125;
            // 
            // ObrisiBtn
            // 
            ObrisiBtn.HeaderText = "";
            ObrisiBtn.MinimumWidth = 6;
            ObrisiBtn.Name = "ObrisiBtn";
            ObrisiBtn.Text = "Obrisi";
            ObrisiBtn.UseColumnTextForButtonValue = true;
            ObrisiBtn.Width = 125;
            // 
            // frmRazmjeneBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 558);
            Controls.Add(btnPotvrda);
            Controls.Add(gbGenerator);
            Controls.Add(dgvRazmjene);
            Controls.Add(lblPocetak);
            Controls.Add(lblKraj);
            Controls.Add(btnSacuvaj);
            Controls.Add(dtpKraj);
            Controls.Add(dtpPocetak);
            Controls.Add(txtECTS);
            Controls.Add(lblBrojKredita);
            Controls.Add(lblUniverzitet);
            Controls.Add(cbUniverzitet);
            Controls.Add(cbDrzava);
            Controls.Add(lblDrzava);
            Name = "frmRazmjeneBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRazmjeneBrojIndeksa";
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).EndInit();
            gbGenerator.ResumeLayout(false);
            gbGenerator.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDrzava;
        private ComboBox cbDrzava;
        private ComboBox cbUniverzitet;
        private Label lblUniverzitet;
        private Label lblBrojKredita;
        private TextBox txtECTS;
        private DateTimePicker dtpPocetak;
        private DateTimePicker dtpKraj;
        private Button btnSacuvaj;
        private Label lblKraj;
        private Label lblPocetak;
        private DataGridView dgvRazmjene;
        private GroupBox gbGenerator;
        private Button btnPotvrda;
        private TextBox txtInfo;
        private Label lblInfo;
        private Button btnGenerisi;
        private TextBox gtxtECTS;
        private TextBox txtBrojRazmjena;
        private Label glblRazmjene;
        private Label glblECTS;
        private Label glblUniverzitet;
        private ComboBox gcbUniverzitet;
        private DataGridViewTextBoxColumn Univerzitet;
        private DataGridViewTextBoxColumn Pocetak;
        private DataGridViewTextBoxColumn Kraj;
        private DataGridViewTextBoxColumn ECTS;
        private DataGridViewCheckBoxColumn Okoncana;
        private DataGridViewButtonColumn ObrisiBtn;
    }
}