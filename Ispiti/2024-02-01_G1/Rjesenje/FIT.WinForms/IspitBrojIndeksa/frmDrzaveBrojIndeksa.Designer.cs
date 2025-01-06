namespace FIT.WinForms.IspitBrojIndeksa
{
    partial class frmDrzaveBrojIndeksa
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
            btnNovaDrzava = new Button();
            btnPrintaj = new Button();
            dgvDrzave = new DataGridView();
            statusStrip = new StatusStrip();
            lblCurrentTime = new ToolStripStatusLabel();
            tmrCurrentTime = new System.Windows.Forms.Timer(components);
            DrzavaZastava = new DataGridViewImageColumn();
            DrzavaNaziv = new DataGridViewTextBoxColumn();
            DrzavaBrojGradova = new DataGridViewTextBoxColumn();
            DrzavaStatus = new DataGridViewCheckBoxColumn();
            DrzavaGradoviBtn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnNovaDrzava
            // 
            btnNovaDrzava.Location = new Point(690, 33);
            btnNovaDrzava.Name = "btnNovaDrzava";
            btnNovaDrzava.Size = new Size(98, 23);
            btnNovaDrzava.TabIndex = 0;
            btnNovaDrzava.Text = "Nova drzava";
            btnNovaDrzava.UseVisualStyleBackColor = true;
            btnNovaDrzava.Click += NovaDrzavaBtnClick;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(690, 281);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(98, 23);
            btnPrintaj.TabIndex = 1;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += PrintajBtnClick;
            // 
            // dgvDrzave
            // 
            dgvDrzave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrzave.Columns.AddRange(new DataGridViewColumn[] { DrzavaZastava, DrzavaNaziv, DrzavaBrojGradova, DrzavaStatus, DrzavaGradoviBtn });
            dgvDrzave.Location = new Point(12, 62);
            dgvDrzave.Name = "dgvDrzave";
            dgvDrzave.RowTemplate.Height = 25;
            dgvDrzave.Size = new Size(776, 213);
            dgvDrzave.TabIndex = 2;
            dgvDrzave.CellClick += DrzaveDgvCellClick;
            dgvDrzave.CellDoubleClick += DrzaveDgvCellDoubleClick;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { lblCurrentTime });
            statusStrip.Location = new Point(0, 320);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(118, 17);
            lblCurrentTime.Text = "toolStripStatusLabel1";
            // 
            // tmrCurrentTime
            // 
            tmrCurrentTime.Enabled = true;
            tmrCurrentTime.Interval = 1000;
            tmrCurrentTime.Tick += CurrentTimeTmrTick;
            // 
            // DrzavaZastava
            // 
            DrzavaZastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DrzavaZastava.DataPropertyName = "Zastava";
            DrzavaZastava.HeaderText = "Zastava";
            DrzavaZastava.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DrzavaZastava.Name = "DrzavaZastava";
            DrzavaZastava.Width = 53;
            // 
            // DrzavaNaziv
            // 
            DrzavaNaziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DrzavaNaziv.DataPropertyName = "Naziv";
            DrzavaNaziv.HeaderText = "Drzava";
            DrzavaNaziv.Name = "DrzavaNaziv";
            // 
            // DrzavaBrojGradova
            // 
            DrzavaBrojGradova.DataPropertyName = "BrojGradova";
            DrzavaBrojGradova.HeaderText = "Broj gradova";
            DrzavaBrojGradova.Name = "DrzavaBrojGradova";
            // 
            // DrzavaStatus
            // 
            DrzavaStatus.DataPropertyName = "Status";
            DrzavaStatus.HeaderText = "Aktivna";
            DrzavaStatus.Name = "DrzavaStatus";
            // 
            // DrzavaGradoviBtn
            // 
            DrzavaGradoviBtn.HeaderText = "";
            DrzavaGradoviBtn.Name = "DrzavaGradoviBtn";
            DrzavaGradoviBtn.Text = "Gradovi";
            DrzavaGradoviBtn.UseColumnTextForButtonValue = true;
            // 
            // frmDrzaveBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 342);
            Controls.Add(statusStrip);
            Controls.Add(dgvDrzave);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaDrzava);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDrzaveBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drzave";
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovaDrzava;
        private Button btnPrintaj;
        private DataGridView dgvDrzave;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblCurrentTime;
        private System.Windows.Forms.Timer tmrCurrentTime;
        private DataGridViewImageColumn DrzavaZastava;
        private DataGridViewTextBoxColumn DrzavaNaziv;
        private DataGridViewTextBoxColumn DrzavaBrojGradova;
        private DataGridViewCheckBoxColumn DrzavaStatus;
        private DataGridViewButtonColumn DrzavaGradoviBtn;
    }
}