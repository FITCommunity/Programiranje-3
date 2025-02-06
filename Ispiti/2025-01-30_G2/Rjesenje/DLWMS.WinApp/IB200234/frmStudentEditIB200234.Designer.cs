namespace DLWMS.WinApp.IB200234
{
    partial class frmStudentEditIB200234
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
            lblImePrezime = new Label();
            pbImage = new PictureBox();
            lblIndeks = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbDrzave = new ComboBox();
            cmbGradovi = new ComboBox();
            button1 = new Button();
            btnSacuvaj = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImePrezime.Location = new Point(355, 37);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(151, 60);
            lblImePrezime.TabIndex = 0;
            lblImePrezime.Text = "label1";
            // 
            // pbImage
            // 
            pbImage.Location = new Point(35, 37);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(266, 275);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 1;
            pbImage.TabStop = false;
            // 
            // lblIndeks
            // 
            lblIndeks.AutoSize = true;
            lblIndeks.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIndeks.Location = new Point(355, 124);
            lblIndeks.Name = "lblIndeks";
            lblIndeks.Size = new Size(104, 41);
            lblIndeks.TabIndex = 2;
            lblIndeks.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 215);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 3;
            label3.Text = "Drzave:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 267);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 4;
            label4.Text = "Grad:";
            // 
            // cmbDrzave
            // 
            cmbDrzave.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzave.FormattingEnabled = true;
            cmbDrzave.Location = new Point(449, 213);
            cmbDrzave.Name = "cmbDrzave";
            cmbDrzave.Size = new Size(248, 28);
            cmbDrzave.TabIndex = 5;
            cmbDrzave.SelectedIndexChanged += cmbDrzave_SelectedIndexChanged;
            // 
            // cmbGradovi
            // 
            cmbGradovi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGradovi.FormattingEnabled = true;
            cmbGradovi.Location = new Point(449, 264);
            cmbGradovi.Name = "cmbGradovi";
            cmbGradovi.Size = new Size(248, 28);
            cmbGradovi.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(35, 339);
            button1.Name = "button1";
            button1.Size = new Size(266, 29);
            button1.TabIndex = 7;
            button1.Text = "Ucitaj sliku";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(594, 339);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 8;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmStudentEditIB200234
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 450);
            Controls.Add(btnSacuvaj);
            Controls.Add(button1);
            Controls.Add(cmbGradovi);
            Controls.Add(cmbDrzave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblIndeks);
            Controls.Add(pbImage);
            Controls.Add(lblImePrezime);
            Name = "frmStudentEditIB200234";
            Text = "Podaci o studentu";
            Load += frmStudentEditIB200234_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImePrezime;
        private PictureBox pbImage;
        private Label lblIndeks;
        private Label label3;
        private Label label4;
        private ComboBox cmbDrzave;
        private ComboBox cmbGradovi;
        private Button button1;
        private Button btnSacuvaj;
        private OpenFileDialog openFileDialog1;
    }
}