namespace FIT.WinForms.IspitBrojIndeksa
{
    partial class frmPretragaBrojIndeksa
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
            lblDrzava = new Label();
            cbDrzava = new ComboBox();
            cbGrad = new ComboBox();
            lblGrad = new Label();
            dgvStudenti = new DataGridView();
            StudentIme = new DataGridViewTextBoxColumn();
            StudentPrezime = new DataGridViewTextBoxColumn();
            StudentGrad = new DataGridViewTextBoxColumn();
            StudentDrzava = new DataGridViewTextBoxColumn();
            StudentProsjek = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Location = new Point(12, 9);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(42, 15);
            lblDrzava.TabIndex = 0;
            lblDrzava.Text = "Drzava";
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(12, 27);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(197, 23);
            cbDrzava.TabIndex = 1;
            cbDrzava.SelectedIndexChanged += DrzavaComboBoxSelectedIndexChanged;
            // 
            // cbGrad
            // 
            cbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrad.FormattingEnabled = true;
            cbGrad.Location = new Point(226, 27);
            cbGrad.Name = "cbGrad";
            cbGrad.Size = new Size(197, 23);
            cbGrad.TabIndex = 3;
            cbGrad.SelectedIndexChanged += GradComboBoxSelectedIndexChanged;
            // 
            // lblGrad
            // 
            lblGrad.AutoSize = true;
            lblGrad.Location = new Point(226, 9);
            lblGrad.Name = "lblGrad";
            lblGrad.Size = new Size(32, 15);
            lblGrad.TabIndex = 2;
            lblGrad.Text = "Grad";
            // 
            // dgvStudenti
            // 
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { StudentIme, StudentPrezime, StudentGrad, StudentDrzava, StudentProsjek });
            dgvStudenti.Location = new Point(12, 56);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.RowTemplate.Height = 25;
            dgvStudenti.Size = new Size(776, 150);
            dgvStudenti.TabIndex = 4;
            // 
            // StudentIme
            // 
            StudentIme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentIme.DataPropertyName = "Ime";
            StudentIme.HeaderText = "Ime";
            StudentIme.Name = "StudentIme";
            // 
            // StudentPrezime
            // 
            StudentPrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentPrezime.DataPropertyName = "Prezime";
            StudentPrezime.HeaderText = "Prezime";
            StudentPrezime.Name = "StudentPrezime";
            // 
            // StudentGrad
            // 
            StudentGrad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentGrad.DataPropertyName = "Grad";
            StudentGrad.HeaderText = "Grad";
            StudentGrad.Name = "StudentGrad";
            // 
            // StudentDrzava
            // 
            StudentDrzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentDrzava.DataPropertyName = "Drzava";
            StudentDrzava.HeaderText = "Drzava";
            StudentDrzava.Name = "StudentDrzava";
            // 
            // StudentProsjek
            // 
            StudentProsjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentProsjek.DataPropertyName = "Prosjek";
            StudentProsjek.HeaderText = "Prosjek";
            StudentProsjek.Name = "StudentProsjek";
            // 
            // frmPretragaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 216);
            Controls.Add(dgvStudenti);
            Controls.Add(cbGrad);
            Controls.Add(lblGrad);
            Controls.Add(cbDrzava);
            Controls.Add(lblDrzava);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPretragaBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o studentima";
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDrzava;
        private ComboBox cbDrzava;
        private ComboBox cbGrad;
        private Label lblGrad;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn StudentIme;
        private DataGridViewTextBoxColumn StudentPrezime;
        private DataGridViewTextBoxColumn StudentGrad;
        private DataGridViewTextBoxColumn StudentDrzava;
        private DataGridViewTextBoxColumn StudentProsjek;
    }
}