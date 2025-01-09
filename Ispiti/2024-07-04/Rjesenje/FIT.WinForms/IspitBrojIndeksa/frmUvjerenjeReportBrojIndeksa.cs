using FIT.Data;
using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmUvjerenjeReportBrojIndeksa : Form
    {
        private static readonly DLWMSDbContext _DLWMSDbContext = SharedBrojIndeksa.DLWMSDbContext;
        private readonly Student _student;
        private readonly StudentiUvjerenjaBrojIndeksa _uvjerenje;

        public frmUvjerenjeReportBrojIndeksa(Student student, StudentiUvjerenjaBrojIndeksa uvjerenje)
        {
            InitializeComponent();

            _student = student;
            _uvjerenje = uvjerenje;
        }

        private void UvjerenjeReportBrojIndeksaFormLoad(object? sender, EventArgs e)
        {
            // I need the thing below to load all the predmets so nothing breaks
            // Alternatively mogli bi se svi predmeti samo ucitati
            _ = _DLWMSDbContext.Studenti
                               .Include(student => student.PolozeniPredmeti)
                               .ThenInclude(polozeniPredmet => polozeniPredmet.Predmet)
                               .Where(student => student == _student)
                               .ToList();

            string polozeniIspiti = string.Join(", ", _student.PolozeniPredmeti);

            ReportParameterCollection reportParameters = new()
            {
                new ReportParameter("VrstaUvjerenja", _uvjerenje.Vrsta),
                new ReportParameter("ImePrezimeIndeks", $"{_student.ImePrezime} ({_student.Indeks})"),
                new ReportParameter("SvrhaUvjerenja", _uvjerenje.Svrha),
                new ReportParameter("StatusStudenta", _student.Aktivan? "AKTIVAN" : "NEAKTIVAN"),
                new ReportParameter("BrojPolozenihIspita", _student.PolozeniPredmeti.Count.ToString()),
                new ReportParameter("PolozeniIspiti", polozeniIspiti),
                new ReportParameter("Prosjek", _student.Prosjek.ToString()),
            };

            reportViewer.LocalReport.ReportPath = ".\\IspitBrojIndeksa\\UvjerenjeReportBrojIndeksa.rdlc";
            reportViewer.LocalReport.SetParameters(reportParameters);
            reportViewer.RefreshReport();
        }
    }
}
