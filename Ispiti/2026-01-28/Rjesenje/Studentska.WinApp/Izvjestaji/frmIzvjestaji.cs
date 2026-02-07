using Microsoft.Reporting.WinForms;
using Studentska.Servis.Servisi;
using Studentska.Servis.Servisi.IspitIB230XXX;

namespace Studentska.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private int _studentId;

        public frmIzvjestaji(int studentId = 0)
        {
            InitializeComponent();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Studentska.WinApp.Izvjestaji.rptStudentiUplate.rdlc";

            _studentId = studentId;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            using var studentiKnjigeServis = new StudentiKnjigeServisIB230XXX();
            using var studentServis = new StudentServis();

            var student = studentServis.GetById(_studentId)!;
            var iznajmljeneKnjige = studentiKnjigeServis.GetAllIznajmljivanjaForStudent(_studentId);

            int brojDana = iznajmljeneKnjige.Sum(studentKnjiga => studentKnjiga.BrojDanaIzdato);

            ReportParameterCollection reportParameters = new()
            {
                new ReportParameter("Student", student.IndeksImePrezime),
                new ReportParameter("BrojDana", brojDana.ToString()),
            };

            dsIzvjestaji.IznajmljivanjaDataTable iznajmljivanjaDataTable = new();

            for (int i = 0; i < iznajmljeneKnjige.Count; ++i)
            {
                iznajmljivanjaDataTable.AddIznajmljivanjaRow(
                    $"{i + 1}",
                    iznajmljeneKnjige[i].Knjiga.NazivIAutor,
                    iznajmljeneKnjige[i].Vracena? "DA" : "NE",
                    iznajmljeneKnjige[i].BrojDanaIzdato.ToString()
                );
            }

            ReportDataSource reportDataSource = new()
            {
                Name = "Iznajmljivanja",
                Value = iznajmljivanjaDataTable,
            };

            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();
        }
    }
}
