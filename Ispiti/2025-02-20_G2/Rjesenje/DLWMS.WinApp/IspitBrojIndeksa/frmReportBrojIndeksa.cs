using DLWMS.Data.IspitBrojIndeksa;
using DLWMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.IspitBrojIndeksa
{
    public partial class frmReportBrojIndeksa : Form
    {
        private readonly DLWMSContext _DLWMSContext = SharedBrojIndeksa.DLWMSContext;
        private readonly List<StudentiCertifikatiBrojIndeksa> _studentiCertifikati;
        private readonly int _godina;
        private readonly CertifikatiBrojIndeksa _certifikat;

        public frmReportBrojIndeksa(int godina, CertifikatiBrojIndeksa certifikat)
        {
            InitializeComponent();

            _godina = godina;
            _certifikat = certifikat;

            var studentiCertifikati = _DLWMSContext.StudentiCertifikati
                                                   .Include(studentiCertifikati => studentiCertifikati.Student)
                                                   .Include(studentiCertifikati => studentiCertifikati.CertifikatGodina)
                                                   .ThenInclude(certifikatGodina => certifikatGodina.Certifikat)
                                                   .Where(studentiCertifikati
                                                        => studentiCertifikati.CertifikatGodina.Godina == _godina
                                                        && studentiCertifikati.CertifikatGodina.Certifikat == _certifikat
                                                   )
                                                   .ToList();

            _studentiCertifikati = studentiCertifikati;
        }

        private void ReportBrojIndeksaFormLoad(object? sender, EventArgs e)
        {
            int ukupnoPlaceno = _studentiCertifikati.Sum(studentCertifikat => studentCertifikat.UkupniIznos);

            ReportParameterCollection reportParameter = new()
            {
                new ReportParameter("Godina", _godina.ToString()),
                new ReportParameter("Certifikat", _certifikat.ToString()),
                new ReportParameter("UkupnoPlaceno", ukupnoPlaceno.ToString()),
            };

            CertifikatiDataSetBrojIndeksa.CertifikatDataTable certifikatiDataTable = new();

            for (int i = 0; i < _studentiCertifikati.Count; ++i)
            {
                certifikatiDataTable.AddCertifikatRow(
                    (i + 1).ToString(),
                    _studentiCertifikati[i].Student.ToString(),
                    _studentiCertifikati[i].MjesecniIznos.ToString(),
                    _studentiCertifikati[i].UkupniIznos.ToString()
                );
            }

            ReportDataSource reportDataSource = new()
            {
                Name = "Certifikati",
                Value = certifikatiDataTable
            };

            reportViewer.LocalReport.ReportPath = ".\\IspitBrojIndeksa\\CertifikatReportBrojIndeksa.rdlc";
            reportViewer.LocalReport.SetParameters(reportParameter);
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.RefreshReport();
        }
    }
}
