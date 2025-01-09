namespace FIT.WinForms.IspitBrojIndeksa
{
    partial class frmNovaDrzavaBrojIndeksa
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
            lblZastava = new Label();
            pbZastava = new PictureBox();
            lblNaziv = new Label();
            txtNaziv = new TextBox();
            chbAktivna = new CheckBox();
            btnSacuvaj = new Button();
            errorProvider = new ErrorProvider(components);
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblZastava
            // 
            lblZastava.AutoSize = true;
            lblZastava.Location = new Point(12, 9);
            lblZastava.Name = "lblZastava";
            lblZastava.Size = new Size(50, 15);
            lblZastava.TabIndex = 0;
            lblZastava.Text = "Zastava:";
            // 
            // pbZastava
            // 
            pbZastava.BorderStyle = BorderStyle.FixedSingle;
            pbZastava.Location = new Point(12, 27);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(301, 145);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 1;
            pbZastava.TabStop = false;
            pbZastava.DoubleClick += ZastavaPictureBoxDoubleClick;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(12, 175);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(39, 15);
            lblNaziv.TabIndex = 2;
            lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(12, 193);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(301, 23);
            txtNaziv.TabIndex = 3;
            // 
            // chbAktivna
            // 
            chbAktivna.AutoSize = true;
            chbAktivna.Location = new Point(12, 222);
            chbAktivna.Name = "chbAktivna";
            chbAktivna.Size = new Size(66, 19);
            chbAktivna.TabIndex = 4;
            chbAktivna.Text = "Aktivna";
            chbAktivna.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(238, 238);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += SacuvajBtnClick;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "zastava";
            openFileDialog.Filter = "JPEG|*.jpeg";
            // 
            // frmNovaDrzavaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 272);
            ControlBox = false;
            Controls.Add(btnSacuvaj);
            Controls.Add(chbAktivna);
            Controls.Add(txtNaziv);
            Controls.Add(lblNaziv);
            Controls.Add(pbZastava);
            Controls.Add(lblZastava);
            Name = "frmNovaDrzavaBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o drzavi";
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblZastava;
        private PictureBox pbZastava;
        private Label lblNaziv;
        private TextBox txtNaziv;
        private CheckBox chbAktivna;
        private Button btnSacuvaj;
        private ErrorProvider errorProvider;
        private OpenFileDialog openFileDialog;
    }
}