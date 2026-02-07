using Studentska.Data.Modeli.IspitIB230XXX;
using Studentska.Servis.Servisi.IspitIB230XXX;

namespace Studentska.WinApp.IspitIB230XXX;

public partial class frmPretragaIB230XXX : Form
{
    public frmPretragaIB230XXX()
    {
        InitializeComponent();

        dgvStudentiKnjige.AutoGenerateColumns = false;

        LoadStudentiKnjigeIntoDgv();
    }

    private void LoadStudentiKnjigeIntoDgv()
    {
        string imePrezimeIliNazivKnjige = txtPretraga.Text.Trim().ToLower();
        bool vracena = chkVracena.Checked;

        using var studentiKnjigeServis = new StudentiKnjigeServisIB230XXX();

        var iznajmljivanja = studentiKnjigeServis.GetIznajmljivanjaForFilter(imePrezimeIliNazivKnjige, vracena);

        dgvStudentiKnjige.DataSource = iznajmljivanja;

        Text = $"Broj prikazanih podatak: {iznajmljivanja.Count}";
    }

    private void txtPretraga_TextChanged(object sender, EventArgs e)
    {
        LoadStudentiKnjigeIntoDgv();
    }

    private void chkVracena_CheckedChanged(object sender, EventArgs e)
    {
        LoadStudentiKnjigeIntoDgv();
    }

    private void dgvStudentiKnjige_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        int selectedStudentKnjigaId = GetSelectedStudentKnjigaId();

        if (e.ColumnIndex == Povrat.Index)
        {
            PovratiKnjigu(selectedStudentKnjigaId);
        }
    }

    private int GetSelectedStudentKnjigaId()
    {
        var studentKnjiga = (StudentiKnjigeIB230XXX)dgvStudentiKnjige.SelectedRows[0].DataBoundItem;

        return studentKnjiga.Id;
    }

    private int GetSelectedKnjigaId()
    {
        var studentKnjiga = (StudentiKnjigeIB230XXX)dgvStudentiKnjige.SelectedRows[0].DataBoundItem;

        return studentKnjiga.KnjigaId;
    }

    private void PovratiKnjigu(int studentKnjigaId)
    {
        using var studentiKnjigeServis = new StudentiKnjigeServisIB230XXX();

        studentiKnjigeServis.PovratiKnjigu(studentKnjigaId);

        LoadStudentiKnjigeIntoDgv();
    }

    private void btnDodajKnjigu_Click(object sender, EventArgs e)
    {
        using var frmKnjigaAddEdit = new frmKnjigaAddEditIB230XXX();
        frmKnjigaAddEdit.ShowDialog();
    }

    private void dgvStudentiKnjige_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        int knjigaId = GetSelectedKnjigaId();

        if (e.ColumnIndex != Povrat.Index)
        {
            using var frmKnjigaAddEdit = new frmKnjigaAddEditIB230XXX(knjigaId);
            frmKnjigaAddEdit.ShowDialog();

            LoadStudentiKnjigeIntoDgv();
        }
    }

    private void btnIznajmljivanja_Click(object sender, EventArgs e)
    {
        using var frmIznajmljivanja = new frmIznajmljivanjaIB230XXX();
        frmIznajmljivanja.ShowDialog();

        LoadStudentiKnjigeIntoDgv();
    }
}
