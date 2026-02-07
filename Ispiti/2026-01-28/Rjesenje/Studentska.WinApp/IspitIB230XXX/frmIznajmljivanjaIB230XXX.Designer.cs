namespace Studentska.WinApp.IspitIB230XXX;

partial class frmIznajmljivanjaIB230XXX
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
        lblStudent = new Label();
        cbStudent = new ComboBox();
        lblKnjiga = new Label();
        cbKnjiga = new ComboBox();
        btnIznajmi = new Button();
        dgvStudentiKnjige = new DataGridView();
        IndeksImePrezime = new DataGridViewTextBoxColumn();
        Knjiga = new DataGridViewTextBoxColumn();
        DatumIznajmljivanja = new DataGridViewTextBoxColumn();
        Vracena = new DataGridViewCheckBoxColumn();
        btnThread = new Button();
        btnPotvrda = new Button();
        gbThread = new GroupBox();
        txtInfo = new TextBox();
        ((System.ComponentModel.ISupportInitialize)dgvStudentiKnjige).BeginInit();
        gbThread.SuspendLayout();
        SuspendLayout();
        // 
        // lblStudent
        // 
        lblStudent.AutoSize = true;
        lblStudent.Location = new Point(12, 9);
        lblStudent.Name = "lblStudent";
        lblStudent.Size = new Size(63, 20);
        lblStudent.TabIndex = 0;
        lblStudent.Text = "Student:";
        // 
        // cbStudent
        // 
        cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
        cbStudent.FormattingEnabled = true;
        cbStudent.Location = new Point(12, 32);
        cbStudent.Name = "cbStudent";
        cbStudent.Size = new Size(296, 28);
        cbStudent.TabIndex = 1;
        // 
        // lblKnjiga
        // 
        lblKnjiga.AutoSize = true;
        lblKnjiga.Location = new Point(314, 9);
        lblKnjiga.Name = "lblKnjiga";
        lblKnjiga.Size = new Size(54, 20);
        lblKnjiga.TabIndex = 0;
        lblKnjiga.Text = "Knjiga:";
        // 
        // cbKnjiga
        // 
        cbKnjiga.DropDownStyle = ComboBoxStyle.DropDownList;
        cbKnjiga.FormattingEnabled = true;
        cbKnjiga.Location = new Point(314, 32);
        cbKnjiga.Name = "cbKnjiga";
        cbKnjiga.Size = new Size(374, 28);
        cbKnjiga.TabIndex = 1;
        // 
        // btnIznajmi
        // 
        btnIznajmi.Location = new Point(694, 32);
        btnIznajmi.Name = "btnIznajmi";
        btnIznajmi.Size = new Size(94, 29);
        btnIznajmi.TabIndex = 2;
        btnIznajmi.Text = "Iznajmi";
        btnIznajmi.UseVisualStyleBackColor = true;
        btnIznajmi.Click += btnIznajmi_Click;
        // 
        // dgvStudentiKnjige
        // 
        dgvStudentiKnjige.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvStudentiKnjige.Columns.AddRange(new DataGridViewColumn[] { IndeksImePrezime, Knjiga, DatumIznajmljivanja, Vracena });
        dgvStudentiKnjige.Location = new Point(12, 66);
        dgvStudentiKnjige.Name = "dgvStudentiKnjige";
        dgvStudentiKnjige.RowHeadersWidth = 51;
        dgvStudentiKnjige.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvStudentiKnjige.Size = new Size(776, 245);
        dgvStudentiKnjige.TabIndex = 3;
        // 
        // IndeksImePrezime
        // 
        IndeksImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        IndeksImePrezime.DataPropertyName = "StudentIndeksImePrezime";
        IndeksImePrezime.HeaderText = "(Indeks) Ime i prezime";
        IndeksImePrezime.MinimumWidth = 6;
        IndeksImePrezime.Name = "IndeksImePrezime";
        IndeksImePrezime.ReadOnly = true;
        // 
        // Knjiga
        // 
        Knjiga.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Knjiga.DataPropertyName = "NazivKnjige";
        Knjiga.HeaderText = "Knjiga";
        Knjiga.MinimumWidth = 6;
        Knjiga.Name = "Knjiga";
        Knjiga.ReadOnly = true;
        // 
        // DatumIznajmljivanja
        // 
        DatumIznajmljivanja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        DatumIznajmljivanja.DataPropertyName = "DatumIznajmljivanja";
        DatumIznajmljivanja.HeaderText = "Datum iznajmljivanja";
        DatumIznajmljivanja.MinimumWidth = 6;
        DatumIznajmljivanja.Name = "DatumIznajmljivanja";
        DatumIznajmljivanja.ReadOnly = true;
        // 
        // Vracena
        // 
        Vracena.DataPropertyName = "Vracena";
        Vracena.HeaderText = "Vracena";
        Vracena.MinimumWidth = 6;
        Vracena.Name = "Vracena";
        Vracena.ReadOnly = true;
        Vracena.Width = 125;
        // 
        // btnThread
        // 
        btnThread.Location = new Point(12, 317);
        btnThread.Name = "btnThread";
        btnThread.Size = new Size(201, 29);
        btnThread.TabIndex = 2;
        btnThread.Text = "Generisi iznajmljivanja";
        btnThread.UseVisualStyleBackColor = true;
        btnThread.Click += btnThread_Click;
        // 
        // btnPotvrda
        // 
        btnPotvrda.Location = new Point(694, 317);
        btnPotvrda.Name = "btnPotvrda";
        btnPotvrda.Size = new Size(94, 29);
        btnPotvrda.TabIndex = 2;
        btnPotvrda.Text = "Potvrda";
        btnPotvrda.UseVisualStyleBackColor = true;
        btnPotvrda.Click += btnPotvrda_Click;
        // 
        // gbThread
        // 
        gbThread.Controls.Add(txtInfo);
        gbThread.Location = new Point(12, 352);
        gbThread.Name = "gbThread";
        gbThread.Size = new Size(776, 224);
        gbThread.TabIndex = 4;
        gbThread.TabStop = false;
        gbThread.Text = "Generator info";
        // 
        // txtInfo
        // 
        txtInfo.BackColor = Color.White;
        txtInfo.Location = new Point(6, 26);
        txtInfo.Multiline = true;
        txtInfo.Name = "txtInfo";
        txtInfo.ReadOnly = true;
        txtInfo.ScrollBars = ScrollBars.Both;
        txtInfo.Size = new Size(764, 192);
        txtInfo.TabIndex = 0;
        // 
        // frmIznajmljivanjaIB230XXX
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 588);
        Controls.Add(gbThread);
        Controls.Add(dgvStudentiKnjige);
        Controls.Add(btnPotvrda);
        Controls.Add(btnThread);
        Controls.Add(btnIznajmi);
        Controls.Add(cbKnjiga);
        Controls.Add(lblKnjiga);
        Controls.Add(cbStudent);
        Controls.Add(lblStudent);
        Name = "frmIznajmljivanjaIB230XXX";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Iznajmljivanja knjiga";
        ((System.ComponentModel.ISupportInitialize)dgvStudentiKnjige).EndInit();
        gbThread.ResumeLayout(false);
        gbThread.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblStudent;
    private ComboBox cbStudent;
    private Label lblKnjiga;
    private ComboBox cbKnjiga;
    private Button btnIznajmi;
    private DataGridView dgvStudentiKnjige;
    private DataGridViewTextBoxColumn IndeksImePrezime;
    private DataGridViewTextBoxColumn Knjiga;
    private DataGridViewTextBoxColumn DatumIznajmljivanja;
    private DataGridViewCheckBoxColumn Vracena;
    private Button btnThread;
    private Button btnPotvrda;
    private GroupBox gbThread;
    private TextBox txtInfo;
}