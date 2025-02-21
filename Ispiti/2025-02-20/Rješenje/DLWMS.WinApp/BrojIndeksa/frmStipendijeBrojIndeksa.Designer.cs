namespace DLWMS.WinApp.IB230269
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
            cbGodina = new ComboBox();
            cbStipendija = new ComboBox();
            tbMjesecniIznos = new TextBox();
            tbGenerisiInfo = new TextBox();
            dgwStipendije = new DataGridView();
            Godina = new DataGridViewTextBoxColumn();
            Stipendija = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            Aktivna = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnDodaj = new Button();
            btnGenerisiStipendije = new Button();
            btnPotvrda = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgwStipendije).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024", "2025" });
            cbGodina.Location = new Point(12, 35);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(150, 23);
            cbGodina.TabIndex = 0;
            // 
            // cbStipendija
            // 
            cbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStipendija.FormattingEnabled = true;
            cbStipendija.Location = new Point(168, 35);
            cbStipendija.Name = "cbStipendija";
            cbStipendija.Size = new Size(156, 23);
            cbStipendija.TabIndex = 0;
            // 
            // tbMjesecniIznos
            // 
            tbMjesecniIznos.Location = new Point(330, 35);
            tbMjesecniIznos.Name = "tbMjesecniIznos";
            tbMjesecniIznos.Size = new Size(159, 23);
            tbMjesecniIznos.TabIndex = 1;
            // 
            // tbGenerisiInfo
            // 
            tbGenerisiInfo.Enabled = false;
            tbGenerisiInfo.Location = new Point(6, 22);
            tbGenerisiInfo.Multiline = true;
            tbGenerisiInfo.Name = "tbGenerisiInfo";
            tbGenerisiInfo.ScrollBars = ScrollBars.Vertical;
            tbGenerisiInfo.Size = new Size(686, 160);
            tbGenerisiInfo.TabIndex = 1;
            // 
            // dgwStipendije
            // 
            dgwStipendije.AllowUserToAddRows = false;
            dgwStipendije.AllowUserToDeleteRows = false;
            dgwStipendije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwStipendije.Columns.AddRange(new DataGridViewColumn[] { Godina, Stipendija, Iznos, Ukupno, Aktivna });
            dgwStipendije.Location = new Point(12, 64);
            dgwStipendije.Name = "dgwStipendije";
            dgwStipendije.ReadOnly = true;
            dgwStipendije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwStipendije.Size = new Size(698, 150);
            dgwStipendije.TabIndex = 2;
            dgwStipendije.MouseDoubleClick += DgwStipendije_MouseDoubleClick;
            // 
            // Godina
            // 
            Godina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Godina.DataPropertyName = "Godina";
            Godina.HeaderText = "Godina";
            Godina.Name = "Godina";
            Godina.ReadOnly = true;
            // 
            // Stipendija
            // 
            Stipendija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stipendija.DataPropertyName = "Stipendija";
            Stipendija.HeaderText = "Stipendija";
            Stipendija.Name = "Stipendija";
            Stipendija.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Mjesečni iznos";
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // Ukupno
            // 
            Ukupno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ukupno.DataPropertyName = "Ukupno";
            Ukupno.HeaderText = "Ukupni iznos";
            Ukupno.Name = "Ukupno";
            Ukupno.ReadOnly = true;
            // 
            // Aktivna
            // 
            Aktivna.DataPropertyName = "Aktivna";
            Aktivna.HeaderText = "Aktivna";
            Aktivna.Name = "Aktivna";
            Aktivna.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 3;
            label1.Text = "Godina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 17);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Stipendija";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 17);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 3;
            label3.Text = "Mjesečni iznos (BAM):";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(495, 35);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(96, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnGenerisiStipendije
            // 
            btnGenerisiStipendije.Location = new Point(12, 220);
            btnGenerisiStipendije.Name = "btnGenerisiStipendije";
            btnGenerisiStipendije.Size = new Size(181, 23);
            btnGenerisiStipendije.TabIndex = 4;
            btnGenerisiStipendije.Text = "Generiši stipendije >>>>>";
            btnGenerisiStipendije.UseVisualStyleBackColor = true;
            btnGenerisiStipendije.Click += btnGenerisi_click;
            // 
            // btnPotvrda
            // 
            btnPotvrda.Location = new Point(635, 220);
            btnPotvrda.Name = "btnPotvrda";
            btnPotvrda.Size = new Size(75, 23);
            btnPotvrda.TabIndex = 4;
            btnPotvrda.Text = "Potvrda";
            btnPotvrda.UseVisualStyleBackColor = true;
            btnPotvrda.Click += btnPotvrda_click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbGenerisiInfo);
            groupBox1.Location = new Point(12, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(698, 188);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator info";
            // 
            // frmStipendijeBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnPotvrda);
            Controls.Add(btnGenerisiStipendije);
            Controls.Add(btnDodaj);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgwStipendije);
            Controls.Add(tbMjesecniIznos);
            Controls.Add(cbStipendija);
            Controls.Add(cbGodina);
            Name = "frmStipendijeBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje stipendijama";
            Load += frmStipendijeIB230269_Load;
            ((System.ComponentModel.ISupportInitialize)dgwStipendije).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbGodina;
        private ComboBox cbStipendija;
        private TextBox tbMjesecniIznos;
        private TextBox tbGenerisiInfo;
        private DataGridView dgwStipendije;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDodaj;
        private Button btnGenerisiStipendije;
        private Button btnPotvrda;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Stipendija;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewCheckBoxColumn Aktivna;
    }
}