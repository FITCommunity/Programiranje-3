namespace Studentska.WinApp.IspitIB230XXX;

partial class frmPretragaIB230XXX
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
        lblPretraga = new Label();
        txtPretraga = new TextBox();
        chkVracena = new CheckBox();
        btnDodajKnjigu = new Button();
        btnIznajmljivanja = new Button();
        dgvStudentiKnjige = new DataGridView();
        IndeksImePrezime = new DataGridViewTextBoxColumn();
        Knjiga = new DataGridViewTextBoxColumn();
        DatumIznajmljivanja = new DataGridViewTextBoxColumn();
        DatumVracanja = new DataGridViewTextBoxColumn();
        Vracena = new DataGridViewCheckBoxColumn();
        Povrat = new DataGridViewButtonColumn();
        ((System.ComponentModel.ISupportInitialize)dgvStudentiKnjige).BeginInit();
        SuspendLayout();
        // 
        // lblPretraga
        // 
        lblPretraga.AutoSize = true;
        lblPretraga.Location = new Point(12, 9);
        lblPretraga.Name = "lblPretraga";
        lblPretraga.Size = new Size(201, 20);
        lblPretraga.TabIndex = 0;
        lblPretraga.Text = "Ime i prezime ili naziv knjige:";
        // 
        // txtPretraga
        // 
        txtPretraga.Location = new Point(12, 32);
        txtPretraga.Name = "txtPretraga";
        txtPretraga.Size = new Size(358, 27);
        txtPretraga.TabIndex = 1;
        txtPretraga.TextChanged += txtPretraga_TextChanged;
        // 
        // chkVracena
        // 
        chkVracena.AutoSize = true;
        chkVracena.Location = new Point(376, 35);
        chkVracena.Name = "chkVracena";
        chkVracena.Size = new Size(83, 24);
        chkVracena.TabIndex = 2;
        chkVracena.Text = "Vracena";
        chkVracena.UseVisualStyleBackColor = true;
        chkVracena.CheckedChanged += chkVracena_CheckedChanged;
        // 
        // btnDodajKnjigu
        // 
        btnDodajKnjigu.Location = new Point(717, 30);
        btnDodajKnjigu.Name = "btnDodajKnjigu";
        btnDodajKnjigu.Size = new Size(141, 29);
        btnDodajKnjigu.TabIndex = 3;
        btnDodajKnjigu.Text = "Dodaj knjigu";
        btnDodajKnjigu.UseVisualStyleBackColor = true;
        btnDodajKnjigu.Click += btnDodajKnjigu_Click;
        // 
        // btnIznajmljivanja
        // 
        btnIznajmljivanja.Location = new Point(864, 30);
        btnIznajmljivanja.Name = "btnIznajmljivanja";
        btnIznajmljivanja.Size = new Size(136, 29);
        btnIznajmljivanja.TabIndex = 3;
        btnIznajmljivanja.Text = "Iznajmljivanja";
        btnIznajmljivanja.UseVisualStyleBackColor = true;
        btnIznajmljivanja.Click += btnIznajmljivanja_Click;
        // 
        // dgvStudentiKnjige
        // 
        dgvStudentiKnjige.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvStudentiKnjige.Columns.AddRange(new DataGridViewColumn[] { IndeksImePrezime, Knjiga, DatumIznajmljivanja, DatumVracanja, Vracena, Povrat });
        dgvStudentiKnjige.Location = new Point(12, 65);
        dgvStudentiKnjige.Name = "dgvStudentiKnjige";
        dgvStudentiKnjige.RowHeadersWidth = 51;
        dgvStudentiKnjige.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvStudentiKnjige.Size = new Size(988, 373);
        dgvStudentiKnjige.TabIndex = 4;
        dgvStudentiKnjige.CellClick += dgvStudentiKnjige_CellClick;
        dgvStudentiKnjige.CellDoubleClick += dgvStudentiKnjige_CellDoubleClick;
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
        DatumIznajmljivanja.DataPropertyName = "DatumIznajmljivanja";
        DatumIznajmljivanja.HeaderText = "Datum iznajmljivanja";
        DatumIznajmljivanja.MinimumWidth = 6;
        DatumIznajmljivanja.Name = "DatumIznajmljivanja";
        DatumIznajmljivanja.ReadOnly = true;
        DatumIznajmljivanja.Width = 171;
        // 
        // DatumVracanja
        // 
        DatumVracanja.DataPropertyName = "DatumVracanja";
        DatumVracanja.HeaderText = "Datum vracanja";
        DatumVracanja.MinimumWidth = 6;
        DatumVracanja.Name = "DatumVracanja";
        DatumVracanja.ReadOnly = true;
        DatumVracanja.Width = 171;
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
        // Povrat
        // 
        Povrat.HeaderText = "";
        Povrat.MinimumWidth = 6;
        Povrat.Name = "Povrat";
        Povrat.ReadOnly = true;
        Povrat.Text = "Povrat";
        Povrat.UseColumnTextForButtonValue = true;
        Povrat.Width = 125;
        // 
        // frmPretragaIB230XXX
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1012, 450);
        Controls.Add(dgvStudentiKnjige);
        Controls.Add(btnIznajmljivanja);
        Controls.Add(btnDodajKnjigu);
        Controls.Add(chkVracena);
        Controls.Add(txtPretraga);
        Controls.Add(lblPretraga);
        Name = "frmPretragaIB230XXX";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "frmPretragaIB230XXX";
        ((System.ComponentModel.ISupportInitialize)dgvStudentiKnjige).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblPretraga;
    private TextBox txtPretraga;
    private CheckBox chkVracena;
    private Button btnDodajKnjigu;
    private Button btnIznajmljivanja;
    private DataGridView dgvStudentiKnjige;
    private DataGridViewTextBoxColumn IndeksImePrezime;
    private DataGridViewTextBoxColumn Knjiga;
    private DataGridViewTextBoxColumn DatumIznajmljivanja;
    private DataGridViewTextBoxColumn DatumVracanja;
    private DataGridViewCheckBoxColumn Vracena;
    private DataGridViewButtonColumn Povrat;
}