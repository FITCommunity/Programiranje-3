using DLWMS.Data;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private readonly Student _student;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(Student student)
        {
            InitializeComponent();

            _student = student;
        }

        private void RazmjenaReportBrojIndeksaFormLoad(object? sender, EventArgs e)
        {
            int ectsTotal = _student.Razmjene
                                    .Where(razmjena => razmjena.Okoncano)
                                    .Sum(razmjena => razmjena.ECTS);

            ReportParameterCollection reportParameters = new()
            {
                new ReportParameter("IndeksImePrezime", _student.IndeksImePrezime),
                new ReportParameter("ECTSTotal", ectsTotal.ToString())
            };

            dsDLWMS.RazmjenaDataTable dataTable = new();

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

            reportViewer.LocalReport.SetParameters(reportParameters);
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.RefreshReport();
        }
    }
}
