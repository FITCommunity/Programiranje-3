namespace FIT.WinForms.IspitBrojIndeksa
{
    partial class frmUvjerenjaBrojIndeksa
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
            btnNoviZahtjev = new Button();
            dgvUvjerenja = new DataGridView();
            UvjerenjeDatum = new DataGridViewTextBoxColumn();
            UvjerenjeVrsta = new DataGridViewTextBoxColumn();
            UvjerenjeSvrha = new DataGridViewTextBoxColumn();
            UvjerenjeUplatnica = new DataGridViewImageColumn();
            UvjerenjePrintano = new DataGridViewCheckBoxColumn();
            UvjerenjeBrisiBtn = new DataGridViewButtonColumn();
            UvjerenjePrintajBtn = new DataGridViewButtonColumn();
            gbGenerator = new GroupBox();
            txtInfo = new TextBox();
            lblInfo = new Label();
            lblBrojZahtjeva = new Label();
            lblSvrhaUvjerenja = new Label();
            btnDodaj = new Button();
            txtBrojZahtjeva = new TextBox();
            txtSvrhaIzdavanja = new TextBox();
            cbVrstaUvjerenja = new ComboBox();
            lblVrstaUvjerenja = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).BeginInit();
            gbGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnNoviZahtjev
            // 
            btnNoviZahtjev.Location = new Point(667, 21);
            btnNoviZahtjev.Name = "btnNoviZahtjev";
            btnNoviZahtjev.Size = new Size(121, 23);
            btnNoviZahtjev.TabIndex = 0;
            btnNoviZahtjev.Text = "Novi zahtjev";
            btnNoviZahtjev.UseVisualStyleBackColor = true;
            btnNoviZahtjev.Click += NoviZahtjevBtnClick;
            // 
            // dgvUvjerenja
            // 
            dgvUvjerenja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUvjerenja.Columns.AddRange(new DataGridViewColumn[] { UvjerenjeDatum, UvjerenjeVrsta, UvjerenjeSvrha, UvjerenjeUplatnica, UvjerenjePrintano, UvjerenjeBrisiBtn, UvjerenjePrintajBtn });
            dgvUvjerenja.Location = new Point(12, 50);
            dgvUvjerenja.Name = "dgvUvjerenja";
            dgvUvjerenja.RowTemplate.Height = 25;
            dgvUvjerenja.Size = new Size(776, 150);
            dgvUvjerenja.TabIndex = 1;
            dgvUvjerenja.CellClick += UvjerenjaDgvCellClick;
            // 
            // UvjerenjeDatum
            // 
            UvjerenjeDatum.DataPropertyName = "VrijemeKreiranja";
            UvjerenjeDatum.HeaderText = "Datum";
            UvjerenjeDatum.Name = "UvjerenjeDatum";
            // 
            // UvjerenjeVrsta
            // 
            UvjerenjeVrsta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UvjerenjeVrsta.DataPropertyName = "Vrsta";
            UvjerenjeVrsta.HeaderText = "Vrsta";
            UvjerenjeVrsta.Name = "UvjerenjeVrsta";
            // 
            // UvjerenjeSvrha
            // 
            UvjerenjeSvrha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UvjerenjeSvrha.DataPropertyName = "Svrha";
            UvjerenjeSvrha.HeaderText = "Svrha";
            UvjerenjeSvrha.Name = "UvjerenjeSvrha";
            // 
            // UvjerenjeUplatnica
            // 
            UvjerenjeUplatnica.DataPropertyName = "Uplatnica";
            UvjerenjeUplatnica.HeaderText = "Uplatnica";
            UvjerenjeUplatnica.Name = "UvjerenjeUplatnica";
            // 
            // UvjerenjePrintano
            // 
            UvjerenjePrintano.DataPropertyName = "Printano";
            UvjerenjePrintano.HeaderText = "Printano";
            UvjerenjePrintano.Name = "UvjerenjePrintano";
            // 
            // UvjerenjeBrisiBtn
            // 
            UvjerenjeBrisiBtn.HeaderText = "";
            UvjerenjeBrisiBtn.Name = "UvjerenjeBrisiBtn";
            UvjerenjeBrisiBtn.Text = "Brisi";
            UvjerenjeBrisiBtn.UseColumnTextForButtonValue = true;
            // 
            // UvjerenjePrintajBtn
            // 
            UvjerenjePrintajBtn.HeaderText = "";
            UvjerenjePrintajBtn.Name = "UvjerenjePrintajBtn";
            UvjerenjePrintajBtn.Text = "Printaj";
            UvjerenjePrintajBtn.UseColumnTextForButtonValue = true;
            // 
            // gbGenerator
            // 
            gbGenerator.Controls.Add(txtInfo);
            gbGenerator.Controls.Add(lblInfo);
            gbGenerator.Controls.Add(lblBrojZahtjeva);
            gbGenerator.Controls.Add(lblSvrhaUvjerenja);
            gbGenerator.Controls.Add(btnDodaj);
            gbGenerator.Controls.Add(txtBrojZahtjeva);
            gbGenerator.Controls.Add(txtSvrhaIzdavanja);
            gbGenerator.Controls.Add(cbVrstaUvjerenja);
            gbGenerator.Controls.Add(lblVrstaUvjerenja);
            gbGenerator.Location = new Point(12, 217);
            gbGenerator.Name = "gbGenerator";
            gbGenerator.Size = new Size(776, 189);
            gbGenerator.TabIndex = 2;
            gbGenerator.TabStop = false;
            gbGenerator.Text = "Dodavanje zahtjeva za izdavanjem uvjerenja";
            // 
            // txtInfo
            // 
            txtInfo.BackColor = SystemColors.Window;
            txtInfo.Location = new Point(7, 96);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.ScrollBars = ScrollBars.Both;
            txtInfo.Size = new Size(763, 87);
            txtInfo.TabIndex = 8;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(7, 78);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(31, 15);
            lblInfo.TabIndex = 7;
            lblInfo.Text = "Info:";
            // 
            // lblBrojZahtjeva
            // 
            lblBrojZahtjeva.AutoSize = true;
            lblBrojZahtjeva.Location = new Point(575, 30);
            lblBrojZahtjeva.Name = "lblBrojZahtjeva";
            lblBrojZahtjeva.Size = new Size(77, 15);
            lblBrojZahtjeva.TabIndex = 6;
            lblBrojZahtjeva.Text = "Broj zahtjeva:";
            // 
            // lblSvrhaUvjerenja
            // 
            lblSvrhaUvjerenja.AutoSize = true;
            lblSvrhaUvjerenja.Location = new Point(260, 30);
            lblSvrhaUvjerenja.Name = "lblSvrhaUvjerenja";
            lblSvrhaUvjerenja.Size = new Size(91, 15);
            lblSvrhaUvjerenja.TabIndex = 5;
            lblSvrhaUvjerenja.Text = "Svrha izdavanja:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(695, 48);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj=>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += DodajBtnClick;
            // 
            // txtBrojZahtjeva
            // 
            txtBrojZahtjeva.Location = new Point(575, 48);
            txtBrojZahtjeva.Name = "txtBrojZahtjeva";
            txtBrojZahtjeva.Size = new Size(100, 23);
            txtBrojZahtjeva.TabIndex = 3;
            // 
            // txtSvrhaIzdavanja
            // 
            txtSvrhaIzdavanja.Location = new Point(260, 48);
            txtSvrhaIzdavanja.Name = "txtSvrhaIzdavanja";
            txtSvrhaIzdavanja.Size = new Size(298, 23);
            txtSvrhaIzdavanja.TabIndex = 2;
            // 
            // cbVrstaUvjerenja
            // 
            cbVrstaUvjerenja.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVrstaUvjerenja.FormattingEnabled = true;
            cbVrstaUvjerenja.Items.AddRange(new object[] { "Uvjerenje o položenim ispitima", "Uvjerenje o statusu studenta " });
            cbVrstaUvjerenja.Location = new Point(6, 48);
            cbVrstaUvjerenja.Name = "cbVrstaUvjerenja";
            cbVrstaUvjerenja.Size = new Size(234, 23);
            cbVrstaUvjerenja.TabIndex = 1;
            // 
            // lblVrstaUvjerenja
            // 
            lblVrstaUvjerenja.AutoSize = true;
            lblVrstaUvjerenja.Location = new Point(6, 30);
            lblVrstaUvjerenja.Name = "lblVrstaUvjerenja";
            lblVrstaUvjerenja.Size = new Size(87, 15);
            lblVrstaUvjerenja.TabIndex = 0;
            lblVrstaUvjerenja.Text = "Vrsta uvjerenja:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmUvjerenjaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 418);
            Controls.Add(gbGenerator);
            Controls.Add(dgvUvjerenja);
            Controls.Add(btnNoviZahtjev);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUvjerenjaBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUvjerenjaBrojIndeksa";
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).EndInit();
            gbGenerator.ResumeLayout(false);
            gbGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNoviZahtjev;
        private DataGridView dgvUvjerenja;
        private GroupBox gbGenerator;
        private DataGridViewTextBoxColumn UvjerenjeDatum;
        private DataGridViewTextBoxColumn UvjerenjeVrsta;
        private DataGridViewTextBoxColumn UvjerenjeSvrha;
        private DataGridViewImageColumn UvjerenjeUplatnica;
        private DataGridViewCheckBoxColumn UvjerenjePrintano;
        private DataGridViewButtonColumn UvjerenjeBrisiBtn;
        private DataGridViewButtonColumn UvjerenjePrintajBtn;
        private Label lblVrstaUvjerenja;
        private ComboBox cbVrstaUvjerenja;
        private Button btnDodaj;
        private TextBox txtBrojZahtjeva;
        private TextBox txtSvrhaIzdavanja;
        private Label lblSvrhaUvjerenja;
        private Label lblBrojZahtjeva;
        private TextBox txtInfo;
        private Label lblInfo;
        private ErrorProvider errorProvider;
    }
}