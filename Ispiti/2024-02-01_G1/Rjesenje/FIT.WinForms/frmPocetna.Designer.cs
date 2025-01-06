namespace FIT.WinForms
{
    partial class frmPocetna
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
            lblKonekcijaInfo = new Label();
            btnIzvjestaj = new Button();
            btnDrzaveIGradovi = new Button();
            btnPretraga = new Button();
            SuspendLayout();
            // 
            // lblKonekcijaInfo
            // 
            lblKonekcijaInfo.AutoSize = true;
            lblKonekcijaInfo.Font = new Font("Segoe UI", 15F);
            lblKonekcijaInfo.Location = new Point(100, 72);
            lblKonekcijaInfo.Name = "lblKonekcijaInfo";
            lblKonekcijaInfo.Size = new Size(0, 28);
            lblKonekcijaInfo.TabIndex = 0;
            // 
            // btnIzvjestaj
            // 
            btnIzvjestaj.Location = new Point(138, 115);
            btnIzvjestaj.Name = "btnIzvjestaj";
            btnIzvjestaj.Size = new Size(181, 23);
            btnIzvjestaj.TabIndex = 1;
            btnIzvjestaj.Text = "Izvještaj";
            btnIzvjestaj.UseVisualStyleBackColor = true;
            btnIzvjestaj.Click += btnIzvjestaj_Click;
            // 
            // btnDrzaveIGradovi
            // 
            btnDrzaveIGradovi.Location = new Point(41, 144);
            btnDrzaveIGradovi.Name = "btnDrzaveIGradovi";
            btnDrzaveIGradovi.Size = new Size(181, 57);
            btnDrzaveIGradovi.TabIndex = 2;
            btnDrzaveIGradovi.Text = "Drzave i gradovi";
            btnDrzaveIGradovi.UseVisualStyleBackColor = true;
            btnDrzaveIGradovi.Click += DrzaveIGradoviBtnClick;
            // 
            // btnPretraga
            // 
            btnPretraga.Location = new Point(228, 144);
            btnPretraga.Name = "btnPretraga";
            btnPretraga.Size = new Size(181, 57);
            btnPretraga.TabIndex = 3;
            btnPretraga.Text = "Pretraga";
            btnPretraga.UseVisualStyleBackColor = true;
            btnPretraga.Click += PretragaBtnClick;
            // 
            // frmPocetna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 213);
            Controls.Add(btnPretraga);
            Controls.Add(btnDrzaveIGradovi);
            Controls.Add(btnIzvjestaj);
            Controls.Add(lblKonekcijaInfo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPocetna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Template 2023/24";
            Load += frmPocetna_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKonekcijaInfo;
        private Button btnIzvjestaj;
        private Button btnDrzaveIGradovi;
        private Button btnPretraga;
    }
}