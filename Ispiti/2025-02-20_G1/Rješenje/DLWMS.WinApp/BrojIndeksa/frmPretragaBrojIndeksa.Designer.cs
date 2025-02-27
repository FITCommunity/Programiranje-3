namespace DLWMS.WinApp.IB230269
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
            dgwPretraga = new DataGridView();
            IndeksImePrezime = new DataGridViewTextBoxColumn();
            Godina = new DataGridViewTextBoxColumn();
            Stipendija = new DataGridViewTextBoxColumn();
            MjesecniIznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            Ukloni = new DataGridViewButtonColumn();
            cbGodina = new ComboBox();
            cbStipendija = new ComboBox();
            btnDodajStipendiju = new Button();
            btnStipendijaPoGodinama = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwPretraga).BeginInit();
            SuspendLayout();
            // 
            // dgwPretraga
            // 
            dgwPretraga.AllowUserToAddRows = false;
            dgwPretraga.AllowUserToDeleteRows = false;
            dgwPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwPretraga.Columns.AddRange(new DataGridViewColumn[] { IndeksImePrezime, Godina, Stipendija, MjesecniIznos, Ukupno, Ukloni });
            dgwPretraga.Location = new Point(12, 70);
            dgwPretraga.Name = "dgwPretraga";
            dgwPretraga.ReadOnly = true;
            dgwPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwPretraga.Size = new Size(776, 217);
            dgwPretraga.TabIndex = 0;
            dgwPretraga.CellContentClick += dgwPretraga_CellContentClick;
            dgwPretraga.CellContentDoubleClick += dgwPretraga_CellContentDoubleClick;
            // 
            // IndeksImePrezime
            // 
            IndeksImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IndeksImePrezime.DataPropertyName = "IndeksImePrezime";
            IndeksImePrezime.HeaderText = "(Indeks) Ime i Prezime";
            IndeksImePrezime.Name = "IndeksImePrezime";
            IndeksImePrezime.ReadOnly = true;
            // 
            // Godina
            // 
            Godina.DataPropertyName = "Godina";
            Godina.HeaderText = "Godina";
            Godina.Name = "Godina";
            Godina.ReadOnly = true;
            // 
            // Stipendija
            // 
            Stipendija.DataPropertyName = "Stipendija";
            Stipendija.HeaderText = "Stipendija";
            Stipendija.Name = "Stipendija";
            Stipendija.ReadOnly = true;
            // 
            // MjesecniIznos
            // 
            MjesecniIznos.DataPropertyName = "Iznos";
            MjesecniIznos.HeaderText = "Mjesecni iznos";
            MjesecniIznos.Name = "MjesecniIznos";
            MjesecniIznos.ReadOnly = true;
            // 
            // Ukupno
            // 
            Ukupno.DataPropertyName = "Ukupno";
            Ukupno.HeaderText = "Ukupno";
            Ukupno.Name = "Ukupno";
            Ukupno.ReadOnly = true;
            // 
            // Ukloni
            // 
            Ukloni.HeaderText = "";
            Ukloni.Name = "Ukloni";
            Ukloni.ReadOnly = true;
            Ukloni.Resizable = DataGridViewTriState.True;
            Ukloni.SortMode = DataGridViewColumnSortMode.Automatic;
            Ukloni.Text = "Ukloni";
            Ukloni.UseColumnTextForButtonValue = true;
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024", "2025" });
            cbGodina.Location = new Point(12, 41);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(154, 23);
            cbGodina.TabIndex = 1;
            cbGodina.SelectionChangeCommitted += cbGodina_SelectionChangeCommitted;
            // 
            // cbStipendija
            // 
            cbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStipendija.FormattingEnabled = true;
            cbStipendija.Location = new Point(172, 41);
            cbStipendija.Name = "cbStipendija";
            cbStipendija.Size = new Size(145, 23);
            cbStipendija.TabIndex = 1;
            cbStipendija.SelectionChangeCommitted += cbStipendija_SelectionChangeCommitted;
            // 
            // btnDodajStipendiju
            // 
            btnDodajStipendiju.Location = new Point(500, 41);
            btnDodajStipendiju.Name = "btnDodajStipendiju";
            btnDodajStipendiju.Size = new Size(131, 23);
            btnDodajStipendiju.TabIndex = 2;
            btnDodajStipendiju.Text = "Dodaj stipendiju";
            btnDodajStipendiju.UseVisualStyleBackColor = true;
            btnDodajStipendiju.Click += btnDodajStipendiju_Click;
            // 
            // btnStipendijaPoGodinama
            // 
            btnStipendijaPoGodinama.Location = new Point(637, 41);
            btnStipendijaPoGodinama.Name = "btnStipendijaPoGodinama";
            btnStipendijaPoGodinama.Size = new Size(151, 23);
            btnStipendijaPoGodinama.TabIndex = 2;
            btnStipendijaPoGodinama.Text = "Stipendija po godinama";
            btnStipendijaPoGodinama.UseVisualStyleBackColor = true;
            btnStipendijaPoGodinama.Click += btnStipendijaPoGodinama_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 3;
            label1.Text = "Godina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 23);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "Stipendija:";
            // 
            // frmPretragaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 299);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStipendijaPoGodinama);
            Controls.Add(btnDodajStipendiju);
            Controls.Add(cbStipendija);
            Controls.Add(cbGodina);
            Controls.Add(dgwPretraga);
            Name = "frmPretragaBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmPretragaIB230269_Load;
            ((System.ComponentModel.ISupportInitialize)dgwPretraga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwPretraga;
        private ComboBox cbGodina;
        private ComboBox cbStipendija;
        private Button btnDodajStipendiju;
        private Button btnStipendijaPoGodinama;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn IndeksImePrezime;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Stipendija;
        private DataGridViewTextBoxColumn MjesecniIznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewButtonColumn Ukloni;
    }
}