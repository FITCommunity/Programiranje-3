namespace DLWMS.WinApp.IB200234
{
    partial class frmRazmjeneIB200234
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbDrzava = new ComboBox();
            cmbUniverziteti = new ComboBox();
            dtpPocetak = new DateTimePicker();
            dtpKraj = new DateTimePicker();
            btnSacuvaj = new Button();
            dgvRazmjene = new DataGridView();
            UniverzitetDrzava = new DataGridViewTextBoxColumn();
            Pocetak = new DataGridViewTextBoxColumn();
            Kraj = new DataGridViewTextBoxColumn();
            ECTS = new DataGridViewTextBoxColumn();
            Okoncana = new DataGridViewCheckBoxColumn();
            btnObrisi = new DataGridViewButtonColumn();
            btnPotvrda = new Button();
            txtKrediti = new TextBox();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            label9 = new Label();
            btnGenerisi = new Button();
            txtBrojKredita = new TextBox();
            label8 = new Label();
            txtBrojRazmjena = new TextBox();
            label7 = new Label();
            cmbGenerisiUniverzitete = new ComboBox();
            label6 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Drzava: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 17);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Univerzitet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(560, 17);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Broj kredita:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(683, 17);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 3;
            label4.Text = "Pocetak razmjene:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(885, 17);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 4;
            label5.Text = "Pocetak razmjene:";
            // 
            // cmbDrzava
            // 
            cmbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(25, 49);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(257, 28);
            cmbDrzava.TabIndex = 5;
            // 
            // cmbUniverziteti
            // 
            cmbUniverziteti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUniverziteti.FormattingEnabled = true;
            cmbUniverziteti.Location = new Point(291, 49);
            cmbUniverziteti.Name = "cmbUniverziteti";
            cmbUniverziteti.Size = new Size(257, 28);
            cmbUniverziteti.TabIndex = 6;
            // 
            // dtpPocetak
            // 
            dtpPocetak.Location = new Point(683, 50);
            dtpPocetak.Name = "dtpPocetak";
            dtpPocetak.Size = new Size(180, 27);
            dtpPocetak.TabIndex = 7;
            // 
            // dtpKraj
            // 
            dtpKraj.Location = new Point(885, 50);
            dtpKraj.Name = "dtpKraj";
            dtpKraj.Size = new Size(180, 27);
            dtpKraj.TabIndex = 8;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(1104, 45);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(115, 29);
            btnSacuvaj.TabIndex = 9;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // dgvRazmjene
            // 
            dgvRazmjene.AllowUserToAddRows = false;
            dgvRazmjene.AllowUserToDeleteRows = false;
            dgvRazmjene.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRazmjene.Columns.AddRange(new DataGridViewColumn[] { UniverzitetDrzava, Pocetak, Kraj, ECTS, Okoncana, btnObrisi });
            dgvRazmjene.Location = new Point(29, 105);
            dgvRazmjene.Name = "dgvRazmjene";
            dgvRazmjene.ReadOnly = true;
            dgvRazmjene.RowHeadersWidth = 51;
            dgvRazmjene.Size = new Size(1190, 243);
            dgvRazmjene.TabIndex = 10;
            dgvRazmjene.CellContentClick += dgvRazmjene_CellContentClick;
            // 
            // UniverzitetDrzava
            // 
            UniverzitetDrzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UniverzitetDrzava.DataPropertyName = "UniverzitetDrzava";
            UniverzitetDrzava.HeaderText = "Univerzitet";
            UniverzitetDrzava.MinimumWidth = 6;
            UniverzitetDrzava.Name = "UniverzitetDrzava";
            UniverzitetDrzava.ReadOnly = true;
            // 
            // Pocetak
            // 
            Pocetak.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pocetak.DataPropertyName = "PocetakRazmjene";
            Pocetak.HeaderText = "Pocetak";
            Pocetak.MinimumWidth = 6;
            Pocetak.Name = "Pocetak";
            Pocetak.ReadOnly = true;
            // 
            // Kraj
            // 
            Kraj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kraj.DataPropertyName = "KrajRazmjene";
            Kraj.HeaderText = "Kraj";
            Kraj.MinimumWidth = 6;
            Kraj.Name = "Kraj";
            Kraj.ReadOnly = true;
            // 
            // ECTS
            // 
            ECTS.DataPropertyName = "Kredit";
            ECTS.HeaderText = "ECTS";
            ECTS.MinimumWidth = 6;
            ECTS.Name = "ECTS";
            ECTS.ReadOnly = true;
            ECTS.Width = 125;
            // 
            // Okoncana
            // 
            Okoncana.DataPropertyName = "Okoncana";
            Okoncana.HeaderText = "Okoncana";
            Okoncana.MinimumWidth = 6;
            Okoncana.Name = "Okoncana";
            Okoncana.ReadOnly = true;
            Okoncana.Width = 125;
            // 
            // btnObrisi
            // 
            btnObrisi.HeaderText = "";
            btnObrisi.MinimumWidth = 6;
            btnObrisi.Name = "btnObrisi";
            btnObrisi.ReadOnly = true;
            btnObrisi.Text = "Brisi";
            btnObrisi.UseColumnTextForButtonValue = true;
            btnObrisi.Width = 222;
            // 
            // btnPotvrda
            // 
            btnPotvrda.Location = new Point(1104, 367);
            btnPotvrda.Name = "btnPotvrda";
            btnPotvrda.Size = new Size(115, 29);
            btnPotvrda.TabIndex = 11;
            btnPotvrda.Text = "Potvrda";
            btnPotvrda.UseVisualStyleBackColor = true;
            btnPotvrda.Click += btnPotvrda_Click;
            // 
            // txtKrediti
            // 
            txtKrediti.Location = new Point(560, 50);
            txtKrediti.Name = "txtKrediti";
            txtKrediti.Size = new Size(103, 27);
            txtKrediti.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(txtBrojKredita);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtBrojRazmjena);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbGenerisiUniverzitete);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(29, 408);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1190, 281);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generisi razmjene";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(349, 74);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(818, 182);
            txtInfo.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(349, 41);
            label9.Name = "label9";
            label9.Size = new Size(38, 20);
            label9.TabIndex = 18;
            label9.Text = "Info:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(19, 227);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(259, 29);
            btnGenerisi.TabIndex = 17;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // txtBrojKredita
            // 
            txtBrojKredita.Location = new Point(175, 160);
            txtBrojKredita.Name = "txtBrojKredita";
            txtBrojKredita.Size = new Size(103, 27);
            txtBrojKredita.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(175, 127);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 15;
            label8.Text = "Broj kredita:";
            // 
            // txtBrojRazmjena
            // 
            txtBrojRazmjena.Location = new Point(19, 160);
            txtBrojRazmjena.Name = "txtBrojRazmjena";
            txtBrojRazmjena.Size = new Size(103, 27);
            txtBrojRazmjena.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 127);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 13;
            label7.Text = "Broj razmjena:";
            // 
            // cmbGenerisiUniverzitete
            // 
            cmbGenerisiUniverzitete.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenerisiUniverzitete.FormattingEnabled = true;
            cmbGenerisiUniverzitete.Location = new Point(19, 73);
            cmbGenerisiUniverzitete.Name = "cmbGenerisiUniverzitete";
            cmbGenerisiUniverzitete.Size = new Size(257, 28);
            cmbGenerisiUniverzitete.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 41);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 7;
            label6.Text = "Univerzitet:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmRazmjeneIB200234
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 674);
            Controls.Add(groupBox1);
            Controls.Add(txtKrediti);
            Controls.Add(btnPotvrda);
            Controls.Add(dgvRazmjene);
            Controls.Add(btnSacuvaj);
            Controls.Add(dtpKraj);
            Controls.Add(dtpPocetak);
            Controls.Add(cmbUniverziteti);
            Controls.Add(cmbDrzava);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRazmjeneIB200234";
            Text = "frmRazmjeneIB200234";
            Load += frmRazmjeneIB200234_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbDrzava;
        private ComboBox cmbUniverziteti;
        private DateTimePicker dtpPocetak;
        private DateTimePicker dtpKraj;
        private Button btnSacuvaj;
        private DataGridView dgvRazmjene;
        private Button btnPotvrda;
        private TextBox txtKrediti;
        private GroupBox groupBox1;
        private ComboBox cmbGenerisiUniverzitete;
        private Label label6;
        private TextBox txtInfo;
        private Label label9;
        private Button btnGenerisi;
        private TextBox txtBrojKredita;
        private Label label8;
        private TextBox txtBrojRazmjena;
        private Label label7;
        private DataGridViewTextBoxColumn UniverzitetDrzava;
        private DataGridViewTextBoxColumn Pocetak;
        private DataGridViewTextBoxColumn Kraj;
        private DataGridViewTextBoxColumn ECTS;
        private DataGridViewCheckBoxColumn Okoncana;
        private DataGridViewButtonColumn btnObrisi;
        private ErrorProvider err;
    }
}