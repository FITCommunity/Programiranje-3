namespace FIT.WinForms.IspitBrojIndeksa
{
    partial class frmNovoUvjerenjeBrojIndeksa
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
            cbVrstaUvjerenja = new ComboBox();
            lblVrstaUvjerenja = new Label();
            lblSvrhaIzdavanja = new Label();
            txtSvrhaIzdavanja = new TextBox();
            pbUplatnica = new PictureBox();
            btnSacuvaj = new Button();
            lblUplatnica = new Label();
            errorProvider = new ErrorProvider(components);
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // cbVrstaUvjerenja
            // 
            cbVrstaUvjerenja.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVrstaUvjerenja.FormattingEnabled = true;
            cbVrstaUvjerenja.Items.AddRange(new object[] { "Uvjerenje o položenim ispitima", "Uvjerenje o statusu studenta " });
            cbVrstaUvjerenja.Location = new Point(12, 27);
            cbVrstaUvjerenja.Name = "cbVrstaUvjerenja";
            cbVrstaUvjerenja.Size = new Size(234, 23);
            cbVrstaUvjerenja.TabIndex = 3;
            // 
            // lblVrstaUvjerenja
            // 
            lblVrstaUvjerenja.AutoSize = true;
            lblVrstaUvjerenja.Location = new Point(12, 9);
            lblVrstaUvjerenja.Name = "lblVrstaUvjerenja";
            lblVrstaUvjerenja.Size = new Size(87, 15);
            lblVrstaUvjerenja.TabIndex = 2;
            lblVrstaUvjerenja.Text = "Vrsta uvjerenja:";
            // 
            // lblSvrhaIzdavanja
            // 
            lblSvrhaIzdavanja.AutoSize = true;
            lblSvrhaIzdavanja.Location = new Point(12, 66);
            lblSvrhaIzdavanja.Name = "lblSvrhaIzdavanja";
            lblSvrhaIzdavanja.Size = new Size(91, 15);
            lblSvrhaIzdavanja.TabIndex = 4;
            lblSvrhaIzdavanja.Text = "Svrha izdavanja:";
            // 
            // txtSvrhaIzdavanja
            // 
            txtSvrhaIzdavanja.Location = new Point(12, 84);
            txtSvrhaIzdavanja.Multiline = true;
            txtSvrhaIzdavanja.Name = "txtSvrhaIzdavanja";
            txtSvrhaIzdavanja.Size = new Size(234, 233);
            txtSvrhaIzdavanja.TabIndex = 5;
            // 
            // pbUplatnica
            // 
            pbUplatnica.BorderStyle = BorderStyle.FixedSingle;
            pbUplatnica.Location = new Point(279, 27);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(441, 255);
            pbUplatnica.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUplatnica.TabIndex = 6;
            pbUplatnica.TabStop = false;
            pbUplatnica.DoubleClick += UplatnicaPictureBoxDoubleClick;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(645, 294);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 7;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += SacuvajBtnClick;
            // 
            // lblUplatnica
            // 
            lblUplatnica.AutoSize = true;
            lblUplatnica.Location = new Point(279, 9);
            lblUplatnica.Name = "lblUplatnica";
            lblUplatnica.Size = new Size(113, 15);
            lblUplatnica.TabIndex = 8;
            lblUplatnica.Text = "Skenirana uplatnica:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "uplatnica";
            openFileDialog.Filter = "JPEG|*.jpeg";
            // 
            // frmNovoUvjerenjeBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 330);
            Controls.Add(lblUplatnica);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbUplatnica);
            Controls.Add(txtSvrhaIzdavanja);
            Controls.Add(lblSvrhaIzdavanja);
            Controls.Add(cbVrstaUvjerenja);
            Controls.Add(lblVrstaUvjerenja);
            Name = "frmNovoUvjerenjeBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novi zahtjev za izdavanjem uvjerenja";
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbVrstaUvjerenja;
        private Label lblVrstaUvjerenja;
        private Label lblSvrhaIzdavanja;
        private TextBox txtSvrhaIzdavanja;
        private PictureBox pbUplatnica;
        private Button btnSacuvaj;
        private Label lblUplatnica;
        private ErrorProvider errorProvider;
        private OpenFileDialog openFileDialog;
    }
}