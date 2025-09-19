namespace DLWMS.WinApp.IspitBrojIndeksa
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
            lblGodina = new Label();
            cbGodina = new ComboBox();
            lblStipendijaGodina = new Label();
            cbStipendijaGodina = new ComboBox();
            btnStipendijePoGodinama = new Button();
            btnDodajStipendiju = new Button();
            dgvStudentiStipendije = new DataGridView();
            IndeksImePrezime = new DataGridViewTextBoxColumn();
            Godina = new DataGridViewTextBoxColumn();
            Stipendija = new DataGridViewTextBoxColumn();
            MjesecniIznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            BtnUkloni = new DataGridViewButtonColumn();
            chbToggle = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudentiStipendije).BeginInit();
            SuspendLayout();
            // 
            // lblGodina
            // 
            lblGodina.AutoSize = true;
            lblGodina.Location = new Point(12, 9);
            lblGodina.Name = "lblGodina";
            lblGodina.Size = new Size(60, 20);
            lblGodina.TabIndex = 0;
            lblGodina.Text = "Godina:";
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021" });
            cbGodina.Location = new Point(12, 32);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(156, 28);
            cbGodina.TabIndex = 1;
            cbGodina.SelectionChangeCommitted += ComboBoxGodinaSelectionChangeCommitted;
            // 
            // lblStipendijaGodina
            // 
            lblStipendijaGodina.AutoSize = true;
            lblStipendijaGodina.Location = new Point(174, 9);
            lblStipendijaGodina.Name = "lblStipendijaGodina";
            lblStipendijaGodina.Size = new Size(79, 20);
            lblStipendijaGodina.TabIndex = 0;
            lblStipendijaGodina.Text = "Stipendija:";
            // 
            // cbStipendijaGodina
            // 
            cbStipendijaGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStipendijaGodina.FormattingEnabled = true;
            cbStipendijaGodina.Location = new Point(174, 32);
            cbStipendijaGodina.Name = "cbStipendijaGodina";
            cbStipendijaGodina.Size = new Size(156, 28);
            cbStipendijaGodina.TabIndex = 1;
            cbStipendijaGodina.SelectionChangeCommitted += ComboBoxStipendijaGodinaSelectionChangeCommitted;
            // 
            // btnStipendijePoGodinama
            // 
            btnStipendijePoGodinama.Location = new Point(809, 32);
            btnStipendijePoGodinama.Name = "btnStipendijePoGodinama";
            btnStipendijePoGodinama.Size = new Size(197, 29);
            btnStipendijePoGodinama.TabIndex = 2;
            btnStipendijePoGodinama.Text = "Stipendije po godinama";
            btnStipendijePoGodinama.UseVisualStyleBackColor = true;
            btnStipendijePoGodinama.Click += StipendijePoGodinamaBtnClick;
            // 
            // btnDodajStipendiju
            // 
            btnDodajStipendiju.Location = new Point(663, 32);
            btnDodajStipendiju.Name = "btnDodajStipendiju";
            btnDodajStipendiju.Size = new Size(140, 29);
            btnDodajStipendiju.TabIndex = 3;
            btnDodajStipendiju.Text = "Dodaj stipendiju";
            btnDodajStipendiju.UseVisualStyleBackColor = true;
            btnDodajStipendiju.Click += DodajStipendijuBtnClick;
            // 
            // dgvStudentiStipendije
            // 
            dgvStudentiStipendije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentiStipendije.Columns.AddRange(new DataGridViewColumn[] { IndeksImePrezime, Godina, Stipendija, MjesecniIznos, Ukupno, BtnUkloni });
            dgvStudentiStipendije.Location = new Point(12, 66);
            dgvStudentiStipendije.Name = "dgvStudentiStipendije";
            dgvStudentiStipendije.RowHeadersWidth = 51;
            dgvStudentiStipendije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentiStipendije.Size = new Size(994, 372);
            dgvStudentiStipendije.TabIndex = 4;
            dgvStudentiStipendije.CellClick += DgvStudentiStipendijeCellClick;
            dgvStudentiStipendije.CellDoubleClick += StudentiStipendijeDgvCellDoubleClick;
            // 
            // IndeksImePrezime
            // 
            IndeksImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IndeksImePrezime.DataPropertyName = "IndeksImePrezime";
            IndeksImePrezime.HeaderText = "(Indeks) Ime i prezime";
            IndeksImePrezime.MinimumWidth = 6;
            IndeksImePrezime.Name = "IndeksImePrezime";
            // 
            // Godina
            // 
            Godina.DataPropertyName = "Godina";
            Godina.HeaderText = "Godina";
            Godina.MinimumWidth = 6;
            Godina.Name = "Godina";
            Godina.Width = 125;
            // 
            // Stipendija
            // 
            Stipendija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stipendija.DataPropertyName = "Stipendija";
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
            // Ukupno
            // 
            Ukupno.DataPropertyName = "Ukupno";
            Ukupno.HeaderText = "Ukupno";
            Ukupno.MinimumWidth = 6;
            Ukupno.Name = "Ukupno";
            Ukupno.Width = 125;
            // 
            // BtnUkloni
            // 
            BtnUkloni.HeaderText = "";
            BtnUkloni.MinimumWidth = 6;
            BtnUkloni.Name = "BtnUkloni";
            BtnUkloni.Text = "Ukloni";
            BtnUkloni.UseColumnTextForButtonValue = true;
            BtnUkloni.Width = 125;
            // 
            // chbToggle
            // 
            chbToggle.AutoSize = true;
            chbToggle.Location = new Point(336, 32);
            chbToggle.Name = "chbToggle";
            chbToggle.Size = new Size(266, 24);
            chbToggle.TabIndex = 5;
            chbToggle.Text = "Toggle aktivne/nekativne stipendije";
            chbToggle.UseVisualStyleBackColor = true;
            chbToggle.Click += ToggleCheckBoxClick;
            // 
            // frmPretragaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 450);
            Controls.Add(chbToggle);
            Controls.Add(dgvStudentiStipendije);
            Controls.Add(btnDodajStipendiju);
            Controls.Add(btnStipendijePoGodinama);
            Controls.Add(cbStipendijaGodina);
            Controls.Add(lblStipendijaGodina);
            Controls.Add(cbGodina);
            Controls.Add(lblGodina);
            Name = "frmPretragaBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPretragaBrojIndeksa";
            ((System.ComponentModel.ISupportInitialize)dgvStudentiStipendije).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGodina;
        private ComboBox cbGodina;
        private Label lblStipendijaGodina;
        private ComboBox cbStipendijaGodina;
        private Button btnStipendijePoGodinama;
        private Button btnDodajStipendiju;
        private DataGridView dgvStudentiStipendije;
        private DataGridViewTextBoxColumn IndeksImePrezime;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Stipendija;
        private DataGridViewTextBoxColumn MjesecniIznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewButtonColumn BtnUkloni;
        private CheckBox chbToggle;
    }
}