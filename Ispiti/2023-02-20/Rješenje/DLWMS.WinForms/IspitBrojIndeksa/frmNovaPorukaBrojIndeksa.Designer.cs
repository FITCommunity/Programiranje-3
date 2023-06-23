namespace DLWMS.WinForms.BrojIndeksa
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
            label1 = new Label();
            cmbPredmet = new ComboBox();
            label2 = new Label();
            dtpValidan = new DateTimePicker();
            label3 = new Label();
            txtSadrzaj = new TextBox();
            label4 = new Label();
            pbSlika = new PictureBox();
            btnSacuvaj = new Button();
            btnOdustani = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Odaberite predmet:";
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(12, 27);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(220, 23);
            cmbPredmet.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 2;
            label2.Text = "Poruka je validna do:";
            // 
            // dtpValidan
            // 
            dtpValidan.Location = new Point(12, 71);
            dtpValidan.Name = "dtpValidan";
            dtpValidan.Size = new Size(220, 23);
            dtpValidan.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 4;
            label3.Text = "Sadržaj poruke:";
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(12, 115);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(220, 200);
            txtSadrzaj.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 9);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 6;
            label4.Text = "Slika:";
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(242, 27);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(290, 288);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 7;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pbSlika_DoubleClick;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(457, 321);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 8;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(376, 321);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(75, 23);
            btnOdustani.TabIndex = 9;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaPorukaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 355);
            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbSlika);
            Controls.Add(label4);
            Controls.Add(txtSadrzaj);
            Controls.Add(label3);
            Controls.Add(dtpValidan);
            Controls.Add(label2);
            Controls.Add(cmbPredmet);
            Controls.Add(label1);
            Name = "frmNovaPorukaBrojIndeksa";
            Text = "Poruka";
            Load += frmNovaPorukaBrojIndeksa_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbPredmet;
        private Label label2;
        private DateTimePicker dtpValidan;
        private Label label3;
        private TextBox txtSadrzaj;
        private Label label4;
        private PictureBox pbSlika;
        private Button btnSacuvaj;
        private Button btnOdustani;
        private ErrorProvider err;
    }
}