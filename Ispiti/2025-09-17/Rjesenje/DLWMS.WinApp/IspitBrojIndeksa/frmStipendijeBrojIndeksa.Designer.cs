namespace DLWMS.WinApp.IspitBrojIndeksa
{
    partial class frmStipendijeBrojIndeksa
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
            cbStipendija = new ComboBox();
            lblStipendija = new Label();
            cbGodina = new ComboBox();
            lblGodina = new Label();
            lblMjesecniIznos = new Label();
            txtMjesecniIznos = new TextBox();
            btnDodaj = new Button();
            dgvStipendijeGodine = new DataGridView();
            Godina = new DataGridViewTextBoxColumn();
            Stipendija = new DataGridViewTextBoxColumn();
            MjesecniIznos = new DataGridViewTextBoxColumn();
            UkupniIznos = new DataGridViewTextBoxColumn();
            Aktivna = new DataGridViewCheckBoxColumn();
            btnGenerisiStipendije = new Button();
            btnPotvrda = new Button();
            button3 = new Button();
            gbGenerator = new GroupBox();
            txtInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStipendijeGodine).BeginInit();
            gbGenerator.SuspendLayout();
            SuspendLayout();
            // 
            // cbStipendija
            // 
            cbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStipendija.FormattingEnabled = true;
            cbStipendija.Location = new Point(174, 32);
            cbStipendija.Name = "cbStipendija";
            cbStipendija.Size = new Size(156, 28);
            cbStipendija.TabIndex = 4;
            // 
            // lblStipendija
            // 
            lblStipendija.AutoSize = true;
            lblStipendija.Location = new Point(174, 9);
            lblStipendija.Name = "lblStipendija";
            lblStipendija.Size = new Size(79, 20);
            lblStipendija.TabIndex = 2;
            lblStipendija.Text = "Stipendija:";
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021" });
            cbGodina.Location = new Point(12, 32);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(156, 28);
            cbGodina.TabIndex = 5;
            // 
            // lblGodina
            // 
            lblGodina.AutoSize = true;
            lblGodina.Location = new Point(12, 9);
            lblGodina.Name = "lblGodina";
            lblGodina.Size = new Size(60, 20);
            lblGodina.TabIndex = 3;
            lblGodina.Text = "Godina:";
            // 
            // lblMjesecniIznos
            // 
            lblMjesecniIznos.AutoSize = true;
            lblMjesecniIznos.Location = new Point(337, 9);
            lblMjesecniIznos.Name = "lblMjesecniIznos";
            lblMjesecniIznos.Size = new Size(108, 20);
            lblMjesecniIznos.TabIndex = 2;
            lblMjesecniIznos.Text = "Mjesecni iznos:";
            // 
            // txtMjesecniIznos
            // 
            txtMjesecniIznos.Location = new Point(337, 33);
            txtMjesecniIznos.Name = "txtMjesecniIznos";
            txtMjesecniIznos.Size = new Size(156, 27);
            txtMjesecniIznos.TabIndex = 6;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(499, 32);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += DodajBtnClick;
            // 
            // dgvStipendijeGodine
            // 
            dgvStipendijeGodine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStipendijeGodine.Columns.AddRange(new DataGridViewColumn[] { Godina, Stipendija, MjesecniIznos, UkupniIznos, Aktivna });
            dgvStipendijeGodine.Location = new Point(12, 66);
            dgvStipendijeGodine.Name = "dgvStipendijeGodine";
            dgvStipendijeGodine.RowHeadersWidth = 51;
            dgvStipendijeGodine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStipendijeGodine.Size = new Size(776, 257);
            dgvStipendijeGodine.TabIndex = 8;
            dgvStipendijeGodine.CellDoubleClick += StipendijeGodineDgvCellDoubleClick;
            // 
            // Godina
            // 
            Godina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Godina.DataPropertyName = "Godina";
            Godina.HeaderText = "Godina";
            Godina.MinimumWidth = 6;
            Godina.Name = "Godina";
            // 
            // Stipendija
            // 
            Stipendija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stipendija.DataPropertyName = "StipendijeBrojIndeksa";
            Stipendija.HeaderText = "Stipendija";
            Stipendija.MinimumWidth = 6;
            Stipendija.Name = "Stipendija";
            // 
            // MjesecniIznos
            // 
            MjesecniIznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MjesecniIznos.DataPropertyName = "MjesecniIznos";
            MjesecniIznos.HeaderText = "Mjesecni iznos";
            MjesecniIznos.MinimumWidth = 6;
            MjesecniIznos.Name = "MjesecniIznos";
            // 
            // UkupniIznos
            // 
            UkupniIznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UkupniIznos.DataPropertyName = "Ukupno";
            UkupniIznos.HeaderText = "Ukupni iznos";
            UkupniIznos.MinimumWidth = 6;
            UkupniIznos.Name = "UkupniIznos";
            // 
            // Aktivna
            // 
            Aktivna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivna.DataPropertyName = "Aktivna";
            Aktivna.HeaderText = "Aktivna";
            Aktivna.MinimumWidth = 6;
            Aktivna.Name = "Aktivna";
            // 
            // btnGenerisiStipendije
            // 
            btnGenerisiStipendije.Location = new Point(12, 329);
            btnGenerisiStipendije.Name = "btnGenerisiStipendije";
            btnGenerisiStipendije.Size = new Size(241, 29);
            btnGenerisiStipendije.TabIndex = 7;
            btnGenerisiStipendije.Text = "Generisi stipendije >>>>>>";
            btnGenerisiStipendije.UseVisualStyleBackColor = true;
            btnGenerisiStipendije.Click += GenerisiStipendijeBtnClick;
            // 
            // btnPotvrda
            // 
            btnPotvrda.Location = new Point(694, 329);
            btnPotvrda.Name = "btnPotvrda";
            btnPotvrda.Size = new Size(94, 29);
            btnPotvrda.TabIndex = 7;
            btnPotvrda.Text = "Potvrda";
            btnPotvrda.UseVisualStyleBackColor = true;
            btnPotvrda.Click += PotvrdaBtnClick;
            // 
            // button3
            // 
            button3.Location = new Point(207, 626);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Dodaj";
            button3.UseVisualStyleBackColor = true;
            // 
            // gbGenerator
            // 
            gbGenerator.Controls.Add(txtInfo);
            gbGenerator.Location = new Point(12, 364);
            gbGenerator.Name = "gbGenerator";
            gbGenerator.Size = new Size(776, 206);
            gbGenerator.TabIndex = 9;
            gbGenerator.TabStop = false;
            gbGenerator.Text = "Generator info";
            // 
            // txtInfo
            // 
            txtInfo.BackColor = SystemColors.Window;
            txtInfo.Location = new Point(6, 26);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.ScrollBars = ScrollBars.Both;
            txtInfo.Size = new Size(764, 174);
            txtInfo.TabIndex = 6;
            // 
            // frmStipendijeBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 582);
            Controls.Add(gbGenerator);
            Controls.Add(dgvStipendijeGodine);
            Controls.Add(button3);
            Controls.Add(btnPotvrda);
            Controls.Add(btnGenerisiStipendije);
            Controls.Add(btnDodaj);
            Controls.Add(txtMjesecniIznos);
            Controls.Add(cbStipendija);
            Controls.Add(lblMjesecniIznos);
            Controls.Add(lblStipendija);
            Controls.Add(cbGodina);
            Controls.Add(lblGodina);
            Name = "frmStipendijeBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje stipendijama";
            ((System.ComponentModel.ISupportInitialize)dgvStipendijeGodine).EndInit();
            gbGenerator.ResumeLayout(false);
            gbGenerator.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbStipendija;
        private Label lblStipendija;
        private ComboBox cbGodina;
        private Label lblGodina;
        private Label lblMjesecniIznos;
        private TextBox txtMjesecniIznos;
        private Button btnDodaj;
        private DataGridView dgvStipendijeGodine;
        private Button btnGenerisiStipendije;
        private Button btnPotvrda;
        private Button button3;
        private GroupBox gbGenerator;
        private TextBox txtInfo;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Stipendija;
        private DataGridViewTextBoxColumn MjesecniIznos;
        private DataGridViewTextBoxColumn UkupniIznos;
        private DataGridViewCheckBoxColumn Aktivna;
    }
}