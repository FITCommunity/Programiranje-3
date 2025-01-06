namespace FIT.WinForms.IspitBrojIndeksa
{
    partial class frmNovaPorukaBrojIndeksa
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
            dtpValidnost = new DateTimePicker();
            lblValidnaDo = new Label();
            cbPredmet = new ComboBox();
            lblPredmet = new Label();
            cbHitnost = new ComboBox();
            lblHitnost = new Label();
            lblSadrzaj = new Label();
            txtSadrzaj = new TextBox();
            lblSlika = new Label();
            pbSlika = new PictureBox();
            openFileDialog = new OpenFileDialog();
            errorProvider = new ErrorProvider(components);
            btnSacuvaj = new Button();
            btnOdustani = new Button();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(12, 71);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(200, 23);
            dtpValidnost.TabIndex = 10;
            // 
            // lblValidnaDo
            // 
            lblValidnaDo.AutoSize = true;
            lblValidnaDo.Location = new Point(12, 53);
            lblValidnaDo.Name = "lblValidnaDo";
            lblValidnaDo.Size = new Size(117, 15);
            lblValidnaDo.TabIndex = 9;
            lblValidnaDo.Text = "Poruka je validna do:";
            // 
            // cbPredmet
            // 
            cbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPredmet.FormattingEnabled = true;
            cbPredmet.Location = new Point(12, 27);
            cbPredmet.Name = "cbPredmet";
            cbPredmet.Size = new Size(200, 23);
            cbPredmet.TabIndex = 8;
            // 
            // lblPredmet
            // 
            lblPredmet.AutoSize = true;
            lblPredmet.Location = new Point(12, 9);
            lblPredmet.Name = "lblPredmet";
            lblPredmet.Size = new Size(110, 15);
            lblPredmet.TabIndex = 7;
            lblPredmet.Text = "Odaberite predmet:";
            // 
            // cbHitnost
            // 
            cbHitnost.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHitnost.FormattingEnabled = true;
            cbHitnost.Items.AddRange(new object[] { "Visoka", "Srednja", "Niska" });
            cbHitnost.Location = new Point(12, 115);
            cbHitnost.Name = "cbHitnost";
            cbHitnost.Size = new Size(200, 23);
            cbHitnost.TabIndex = 12;
            // 
            // lblHitnost
            // 
            lblHitnost.AutoSize = true;
            lblHitnost.Location = new Point(12, 97);
            lblHitnost.Name = "lblHitnost";
            lblHitnost.Size = new Size(89, 15);
            lblHitnost.TabIndex = 11;
            lblHitnost.Text = "Hitnost poruke:";
            // 
            // lblSadrzaj
            // 
            lblSadrzaj.AutoSize = true;
            lblSadrzaj.Location = new Point(12, 141);
            lblSadrzaj.Name = "lblSadrzaj";
            lblSadrzaj.Size = new Size(87, 15);
            lblSadrzaj.TabIndex = 13;
            lblSadrzaj.Text = "Sadrzaj poruke:";
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(12, 159);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(200, 130);
            txtSadrzaj.TabIndex = 14;
            // 
            // lblSlika
            // 
            lblSlika.AutoSize = true;
            lblSlika.Location = new Point(262, 9);
            lblSlika.Name = "lblSlika";
            lblSlika.Size = new Size(34, 15);
            lblSlika.TabIndex = 15;
            lblSlika.Text = "Slika:";
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(262, 27);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(297, 262);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 16;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += SlikaPictureBoxDoubleClick;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "slika";
            openFileDialog.Filter = "JPEG|*.jpeg";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(484, 311);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 17;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += SacuvajBtnClick;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(385, 311);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(75, 23);
            btnOdustani.TabIndex = 18;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += OdustaniBtnClick;
            // 
            // frmNovaPorukaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 342);
            ControlBox = false;
            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbSlika);
            Controls.Add(lblSlika);
            Controls.Add(txtSadrzaj);
            Controls.Add(lblSadrzaj);
            Controls.Add(cbHitnost);
            Controls.Add(lblHitnost);
            Controls.Add(dtpValidnost);
            Controls.Add(lblValidnaDo);
            Controls.Add(cbPredmet);
            Controls.Add(lblPredmet);
            Name = "frmNovaPorukaBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Poruka";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpValidnost;
        private Label lblValidnaDo;
        private ComboBox cbPredmet;
        private Label lblPredmet;
        private ComboBox cbHitnost;
        private Label lblHitnost;
        private Label lblSadrzaj;
        private TextBox txtSadrzaj;
        private Label lblSlika;
        private PictureBox pbSlika;
        private OpenFileDialog openFileDialog;
        private ErrorProvider errorProvider;
        private Button btnSacuvaj;
        private Button btnOdustani;
    }
}