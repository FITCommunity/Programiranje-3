using FIT.Data;
using FIT.Data.IspitBrojIndeksa;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmPorukaReport : Form
    {
        private readonly Student _student;
        private readonly List<StudentiPorukeBrojIndeksa> _poruke;

        public frmPorukaReport(Student student, List<StudentiPorukeBrojIndeksa> poruke)
        {
            InitializeComponent();

            _student = student;
            _poruke = poruke;
        }

        private void PorukaReportFormLoad(object? sender, EventArgs e)
        {
            double averageCharsPerPoruka = _poruke.Count == 0 ? 0 : _poruke.Average(poruka => poruka.Sadrzaj.Length);

            ReportParameterCollection reportParameters = new()
            {
                new ReportParameter("ImePrezimeStudenta", _student.ImePrezime),
                new ReportParameter("BrojPoruka", _poruke.Count.ToString()),
                new ReportParameter("ProsjecnoKaraktera", averageCharsPerPoruka.ToString())
            };

            PorukeDataSetBrojIndeksa.PorukeDataTable porukeDataTable = new();
            for (int i = 0; i < _poruke.Count; ++i)
            {
                porukeDataTable.AddPorukeRow(
                    (i + 1).ToString(),
                    _poruke[i].Predmet.Naziv,
                    _poruke[i].Sadrzaj,
                    _poruke[i].Sadrzaj.Length.ToString(),
                    _poruke[i].Validnost.ToString()
                );
            }

            ReportDataSource reportDataSource = new()
            {
                Name = "Poruke",
                Value = porukeDataTable
            };

            reportViewer.LocalReport.ReportPath = ".\\IspitBrojIndeksa\\PorukeReportBrojIndeksa.rdlc";
            reportViewer.LocalReport.SetParameters(reportParameters);
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.RefreshReport();
        }
    }
}
