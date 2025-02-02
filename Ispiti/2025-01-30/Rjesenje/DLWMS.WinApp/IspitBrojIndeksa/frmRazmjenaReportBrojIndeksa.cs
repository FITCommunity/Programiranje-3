using DLWMS.Data;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.IspitBrojIndeksa
{
    public partial class frmRazmjenaReportBrojIndeksa : Form
    {
        private readonly Student _student;

        public frmRazmjenaReportBrojIndeksa(Student student)
        {
            InitializeComponent();

            _student = student;
        }

        private void RazmjenaReportBrojIndeksaFormLoad(object? sender, EventArgs e)
        {
            int ectsTotal = _student.Razmjene.Sum(razmjena => razmjena.ECTS);

            ReportParameterCollection reportParameters = new()
            {
                new ReportParameter("IndeksImePrezime", _student.IndeksImePrezime),
                new ReportParameter("ECTSTotal", ectsTotal.ToString())
            };

            DataSetBrojIndeksa.RazmjenaDataTable dataTable = new();

            for (int i = 0; i < _student.Razmjene.Count; ++i)
            {
                dataTable.AddRazmjenaRow(
                    (i + 1).ToString(),
                    _student.Razmjene[i].Univerzitet.ToString(),
                    _student.Razmjene[i].Pocetak.ToString(),
                    _student.Razmjene[i].Kraj.ToString(),
                    _student.Razmjene[i].ECTS.ToString(),
                    _student.Razmjene[i].Okoncano? "DA" : "NE"
                );
            }

            ReportDataSource reportDataSource = new()
            {
                Name = "Razmjene",
                Value = dataTable
            };

            reportViewer.LocalReport.ReportPath = ".\\IspitBrojIndeksa\\ReportRazmjenaBrojIndeksa.rdlc";
            reportViewer.LocalReport.SetParameters(reportParameters);
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.RefreshReport();
        }
    }
}
