namespace DLWMS.WinApp.IspitBrojIndeksa
{
    partial class frmStudentEditBrojIndeksa
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
            pbSlika = new PictureBox();
            btnUcitajSliku = new Button();
            lblImePrezime = new Label();
            lblIndeks = new Label();
            openFileDialog = new OpenFileDialog();
            lblDrzava = new Label();
            cbDrzava = new ComboBox();
            lblGrad = new Label();
            cbGrad = new ComboBox();
            btnSacuvaj = new Button();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(218, 250);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // btnUcitajSliku
            // 
            btnUcitajSliku.Location = new Point(12, 268);
            btnUcitajSliku.Name = "btnUcitajSliku";
            btnUcitajSliku.Size = new Size(218, 29);
            btnUcitajSliku.TabIndex = 1;
            btnUcitajSliku.Text = "Ucitaj sliku";
            btnUcitajSliku.UseVisualStyleBackColor = true;
            btnUcitajSliku.Click += UcitajSlikuBtnClick;
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblImePrezime.Location = new Point(236, 21);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(104, 41);
            lblImePrezime.TabIndex = 2;
            lblImePrezime.Text = "label1";
            // 
            // lblIndeks
            // 
            lblIndeks.AutoSize = true;
            lblIndeks.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblIndeks.Location = new Point(236, 84);
            lblIndeks.Name = "lblIndeks";
            lblIndeks.Size = new Size(104, 41);
            lblIndeks.TabIndex = 3;
            lblIndeks.Text = "label2";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Location = new Point(236, 149);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(58, 20);
            lblDrzava.TabIndex = 6;
            lblDrzava.Text = "Drzava:";
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(300, 149);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(210, 28);
            cbDrzava.TabIndex = 5;
            cbDrzava.SelectionChangeCommitted += cbDrzava_SelectionChangeCommitted;
            // 
            // lblGrad
            // 
            lblGrad.AutoSize = true;
            lblGrad.Location = new Point(236, 192);
            lblGrad.Name = "lblGrad";
            lblGrad.Size = new Size(44, 20);
            lblGrad.TabIndex = 8;
            lblGrad.Text = "Grad:";
            // 
            // cbGrad
            // 
            cbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrad.FormattingEnabled = true;
            cbGrad.Location = new Point(300, 192);
            cbGrad.Name = "cbGrad";
            cbGrad.Size = new Size(210, 28);
            cbGrad.TabIndex = 7;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(416, 268);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 9;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += SacuvajBtnClick;
            // 
            // frmStudentEditBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 320);
            Controls.Add(btnSacuvaj);
            Controls.Add(lblGrad);
            Controls.Add(cbGrad);
            Controls.Add(lblDrzava);
            Controls.Add(cbDrzava);
            Controls.Add(lblIndeks);
            Controls.Add(lblImePrezime);
            Controls.Add(btnUcitajSliku);
            Controls.Add(pbSlika);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmStudentEditBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o studentu";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Button btnUcitajSliku;
        private Label lblImePrezime;
        private Label lblIndeks;
        private OpenFileDialog openFileDialog;
        private Label lblDrzava;
        private ComboBox cbDrzava;
        private Label lblGrad;
        private ComboBox cbGrad;
        private Button btnSacuvaj;
    }
}