using DLWMS.Data.IspitBrojIndeksa;
using DLWMS.Infrastructure;
using DLWMS.WinApp.IspitBrojIndeksa;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private readonly DLWMSContext DB = SharedBrojIndeksa.DB;
        private readonly CertifikatiGodineBrojIndeksa _certifikatGodina;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(CertifikatiGodineBrojIndeksa certifikatGodina)
        {
            InitializeComponent();

            _certifikatGodina = certifikatGodina;
        }

        private void ReportBrojIndeksaFormLoad(object? sender, EventArgs e)
        {
            var studenti = DB.StudentiCertifikati
                             .Include(studentCertifikat => studentCertifikat.Student)
                             .Include(studentCertifikat => studentCertifikat.CertifikatGodina)
                             .Where(studentCertifikat
                                => studentCertifikat.CertifikatGodina == _certifikatGodina
                             )
                             .Select(studentCertifikat => studentCertifikat.Student)
                             .ToList();

            int ukupnoPlaceno = studenti.Count * _certifikatGodina.UkupniIznos;

            ReportParameterCollection reportParameter = new()
            {
                new ReportParameter("Godina", _certifikatGodina.Godina.ToString()),
                new ReportParameter("Certifikat", _certifikatGodina.ToString()),
                new ReportParameter("UkupnoPlaceno", ukupnoPlaceno.ToString()),
            };

            dsDLWMS.CertifikatDataTable certifikatiDataTable = new();

            for (int i = 0; i < studenti.Count; ++i)
            {
                certifikatiDataTable.AddCertifikatRow(
                    (i + 1).ToString(),
                    studenti[i].ToString(),
                    _certifikatGodina.MjesecniIznos.ToString(),
                    _certifikatGodina.UkupniIznos.ToString()
                );
            }

            ReportDataSource reportDataSource = new()
            {
                Name = "Certifikati",
                Value = certifikatiDataTable
            };

            reportViewer.LocalReport.SetParameters(reportParameter);
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.RefreshReport();
        }
    }
}
