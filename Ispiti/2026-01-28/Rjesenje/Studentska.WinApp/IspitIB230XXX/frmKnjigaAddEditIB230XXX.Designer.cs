namespace Studentska.WinApp.IspitIB230XXX;

partial class frmKnjigaAddEditIB230XXX
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
        lblNaziv = new Label();
        txtNaziv = new TextBox();
        lblAutori = new Label();
        txtAutori = new TextBox();
        lblBrojPrimjeraka = new Label();
        txtBrojPrimjeraka = new TextBox();
        btnSacuvaj = new Button();
        ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
        SuspendLayout();
        // 
        // pbSlika
        // 
        pbSlika.BorderStyle = BorderStyle.FixedSingle;
        pbSlika.Location = new Point(12, 12);
        pbSlika.Name = "pbSlika";
        pbSlika.Size = new Size(188, 233);
        pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
        pbSlika.TabIndex = 0;
        pbSlika.TabStop = false;
        pbSlika.DoubleClick += pbSlika_DoubleClick;
        // 
        // lblNaziv
        // 
        lblNaziv.AutoSize = true;
        lblNaziv.Location = new Point(217, 12);
        lblNaziv.Name = "lblNaziv";
        lblNaziv.Size = new Size(93, 20);
        lblNaziv.TabIndex = 1;
        lblNaziv.Text = "Naziv knjige:";
        // 
        // txtNaziv
        // 
        txtNaziv.Location = new Point(217, 35);
        txtNaziv.Name = "txtNaziv";
        txtNaziv.Size = new Size(225, 27);
        txtNaziv.TabIndex = 2;
        // 
        // lblAutori
        // 
        lblAutori.AutoSize = true;
        lblAutori.Location = new Point(217, 72);
        lblAutori.Name = "lblAutori";
        lblAutori.Size = new Size(53, 20);
        lblAutori.TabIndex = 1;
        lblAutori.Text = "Autori:";
        // 
        // txtAutori
        // 
        txtAutori.Location = new Point(217, 95);
        txtAutori.Name = "txtAutori";
        txtAutori.Size = new Size(225, 27);
        txtAutori.TabIndex = 2;
        // 
        // lblBrojPrimjeraka
        // 
        lblBrojPrimjeraka.AutoSize = true;
        lblBrojPrimjeraka.Location = new Point(217, 133);
        lblBrojPrimjeraka.Name = "lblBrojPrimjeraka";
        lblBrojPrimjeraka.Size = new Size(114, 20);
        lblBrojPrimjeraka.TabIndex = 1;
        lblBrojPrimjeraka.Text = "Broj primjeraka:";
        // 
        // txtBrojPrimjeraka
        // 
        txtBrojPrimjeraka.Location = new Point(217, 156);
        txtBrojPrimjeraka.Name = "txtBrojPrimjeraka";
        txtBrojPrimjeraka.Size = new Size(225, 27);
        txtBrojPrimjeraka.TabIndex = 2;
        // 
        // btnSacuvaj
        // 
        btnSacuvaj.Location = new Point(348, 216);
        btnSacuvaj.Name = "btnSacuvaj";
        btnSacuvaj.Size = new Size(94, 29);
        btnSacuvaj.TabIndex = 3;
        btnSacuvaj.Text = "Sacuvaj";
        btnSacuvaj.UseVisualStyleBackColor = true;
        btnSacuvaj.Click += btnSacuvaj_Click;
        // 
        // frmKnjigaAddEditIB230XXX
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(474, 266);
        Controls.Add(btnSacuvaj);
        Controls.Add(txtBrojPrimjeraka);
        Controls.Add(lblBrojPrimjeraka);
        Controls.Add(txtAutori);
        Controls.Add(lblAutori);
        Controls.Add(txtNaziv);
        Controls.Add(lblNaziv);
        Controls.Add(pbSlika);
        Name = "frmKnjigaAddEditIB230XXX";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Podaci o knjizi";
        ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pbSlika;
    private Label lblNaziv;
    private TextBox txtNaziv;
    private Label lblAutori;
    private TextBox txtAutori;
    private Label lblBrojPrimjeraka;
    private TextBox txtBrojPrimjeraka;
    private Button btnSacuvaj;
}