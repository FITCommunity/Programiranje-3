using Studentska.Servis.Servisi;
using Studentska.Servis.Servisi.IspitIB230XXX;
using Studentska.WinApp.Helpers;
using Studentska.WinApp.Izvjestaji;

namespace Studentska.WinApp.IspitIB230XXX;

public partial class frmIznajmljivanjaIB230XXX : Form
{
    public frmIznajmljivanjaIB230XXX()
    {
        InitializeComponent();

        dgvStudentiKnjige.AutoGenerateColumns = false;

        LoadStudentiIntoComboBox();
        LoadKnjigeIntoComboBox();
        LoadStudentiKnjigeIntoDgv();
    }

    private void LoadKnjigeIntoComboBox()
    {
        using var studentServis = new StudentServis();
        var studenti = studentServis.GetAll();

        cbStudent.UcitajPodatke(studenti, "Id", "IndeksImePrezime");
    }

    private void LoadStudentiIntoComboBox()
    {
        using var knjigeServis = new KnjigeServisIB230XXX();
        var knjige = knjigeServis.GetAll();

        cbKnjiga.UcitajPodatke(knjige);
    }

    private void LoadStudentiKnjigeIntoDgv()
    {
        using var studentiKnjigeServis = new StudentiKnjigeServisIB230XXX();

        var iznajmljivanja = studentiKnjigeServis.GetAllIznajmljivanja();

        dgvStudentiKnjige.DataSource = iznajmljivanja;
    }

    private int GetSelectedStudentId()
    {
        var studentId = (int)cbStudent.SelectedValue!;

        return studentId;
    }

    private int GetSelectedKnjigaId()
    {
        var knjigaId = (int)cbKnjiga.SelectedValue!;

        return knjigaId;
    }


    private bool ValidateFields()
    {
        int studentId = GetSelectedStudentId();
        int knjigaId = GetSelectedKnjigaId();
        using var studentiKnjigeServis = new StudentiKnjigeServisIB230XXX();

        if (studentiKnjigeServis.DaLiJeStudentIznajmioKnjigu(knjigaId, studentId))
        {
            MessageBox.Show(
                "Student je vec iznajmio tu knjigu",
                "Nevalidan unos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return false;
        }
        else if (!studentiKnjigeServis.DaLiJeBrojPrimjerakaNaStanu(knjigaId))
        {
            MessageBox.Show(
                "Trenutno nema dovoljno knjiga na stanju",
                "Nevalidan unos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return false;
        }


        return true;
    }

    private void btnIznajmi_Click(object sender, EventArgs e)
    {
        if (!ValidateFields())
        {
            return;
        }

        using var studentiKnjigeServis = new StudentiKnjigeServisIB230XXX();

        int studentId = GetSelectedStudentId();
        int knjigaId = GetSelectedKnjigaId();

        studentiKnjigeServis.IznajmiKnjiguZaStudenta(knjigaId, studentId);

        LoadStudentiKnjigeIntoDgv();
    }

    private void btnPotvrda_Click(object sender, EventArgs e)
    {
        int studentId = GetSelectedStudentId();

        using var frmReport = new frmIzvjestaji(studentId);
        frmReport.ShowDialog();
    }

    private async void btnThread_Click(object sender, EventArgs e)
    {
        txtInfo.Text = "";

        int studentId = GetSelectedStudentId();

        await Task.Run(async () => await GenerateIznajmljivanjaForStudent(studentId));

        MessageBox.Show(
            "Uspjesno generisana iznajmljivanja za studenta",
            "Generisanje gotovo",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
        LoadStudentiKnjigeIntoDgv();
    }

    private async Task GenerateIznajmljivanjaForStudent(int studentId)
    {
        using var studentiKnjigeServis = new StudentiKnjigeServisIB230XXX();
        using var studentServis = new StudentServis();
        using var knjigeServis = new KnjigeServisIB230XXX();

        var student = studentServis.GetById(studentId)!;
        var knjigeZaIznajmitIds = studentiKnjigeServis.GetKnjigeIdForStudentWhichIznajmljenje(studentId);

        for (int i = 0; i < knjigeZaIznajmitIds.Count; ++i)
        {
            var knjigaId = knjigeZaIznajmitIds[i];
            var knjiga = knjigeServis.GetById(knjigaId)!;

            studentiKnjigeServis.IznajmiKnjiguZaStudenta(knjigaId, studentId);

            await Task.Delay(300);

            string txtInfoMessage = $"{i + 1}. {student.IndeksImePrezime} dodato zaduzenje {knjiga.NazivIAutor}{Environment.NewLine}";

            LogToTxtInfo(txtInfoMessage);
        }
    }

    private void LogToTxtInfo(string txtInfoMessage)
    {
        Invoke(() =>
        {
            txtInfo.Text += txtInfoMessage;
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();
        });
    }
}
