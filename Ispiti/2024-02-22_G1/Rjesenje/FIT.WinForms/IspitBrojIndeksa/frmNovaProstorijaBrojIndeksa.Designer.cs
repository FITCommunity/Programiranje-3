namespace FIT.WinForms.IspitBrojIndeksa
{
    partial class frmNovaProstorijaBrojIndeksa
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
            lblLogo = new Label();
            pbLogo = new PictureBox();
            errorProvider = new ErrorProvider(components);
            openFileDialog = new OpenFileDialog();
            lblNaziv = new Label();
            txtNaziv = new TextBox();
            lblOznaka = new Label();
            txtOznaka = new TextBox();
            lblKapacitet = new Label();
            txtKapacitet = new TextBox();
            btnSacuvaj = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point(12, 20);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(37, 15);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Logo:";
            // 
            // pbLogo
            // 
            pbLogo.BorderStyle = BorderStyle.FixedSingle;
            pbLogo.Location = new Point(12, 38);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(179, 161);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            pbLogo.DoubleClick += LogoPictureBoxDoubleClick;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "logo";
            openFileDialog.Filter = "JPEG|*jpeg";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(229, 38);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(39, 15);
            lblNaziv.TabIndex = 2;
            lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(229, 56);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(277, 23);
            txtNaziv.TabIndex = 3;
            // 
            // lblOznaka
            // 
            lblOznaka.AutoSize = true;
            lblOznaka.Location = new Point(230, 100);
            lblOznaka.Name = "lblOznaka";
            lblOznaka.Size = new Size(49, 15);
            lblOznaka.TabIndex = 4;
            lblOznaka.Text = "Oznaka:";
            // 
            // txtOznaka
            // 
            txtOznaka.Location = new Point(229, 118);
            txtOznaka.Name = "txtOznaka";
            txtOznaka.Size = new Size(127, 23);
            txtOznaka.TabIndex = 5;
            // 
            // lblKapacitet
            // 
            lblKapacitet.AutoSize = true;
            lblKapacitet.Location = new Point(379, 100);
            lblKapacitet.Name = "lblKapacitet";
            lblKapacitet.Size = new Size(59, 15);
            lblKapacitet.TabIndex = 6;
            lblKapacitet.Text = "Kapacitet:";
            // 
            // txtKapacitet
            // 
            txtKapacitet.Location = new Point(379, 118);
            txtKapacitet.Name = "txtKapacitet";
            txtKapacitet.Size = new Size(127, 23);
            txtKapacitet.TabIndex = 7;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(431, 176);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 8;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += SacuvajBtnClick;
            // 
            // frmNovaProstorijaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 212);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtKapacitet);
            Controls.Add(lblKapacitet);
            Controls.Add(txtOznaka);
            Controls.Add(lblOznaka);
            Controls.Add(txtNaziv);
            Controls.Add(lblNaziv);
            Controls.Add(pbLogo);
            Controls.Add(lblLogo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNovaProstorijaBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o prostoriji";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogo;
        private PictureBox pbLogo;
        private ErrorProvider errorProvider;
        private OpenFileDialog openFileDialog;
        private Label lblNaziv;
        private Label lblKapacitet;
        private TextBox txtOznaka;
        private Label lblOznaka;
        private TextBox txtNaziv;
        private TextBox txtKapacitet;
        private Button btnSacuvaj;
    }
}