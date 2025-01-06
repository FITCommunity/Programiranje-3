using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmGradoviReportBrojIndeksa : Form
    {
        private readonly DrzaveBrojIndeksa _drzava;

        public frmGradoviReportBrojIndeksa(DrzaveBrojIndeksa drzava)
        {
            InitializeComponent();

            _drzava = drzava;
        }

        private void GradoviReportBrojIndeksaFormLoad(object? sender, EventArgs e)
        {
            ReportParameterCollection reportParameter = new()
            {
                new ReportParameter("BrojGradova", _drzava.BrojGradova.ToString())
            };

            GradDataSetBrojIndeksa.GradDataTable gradDataTable = new();

            for (int i = 0; i < _drzava.Gradovi.Count; ++i)
            {
                gradDataTable.AddGradRow(
                    (i + 1).ToString(),
                    _drzava.Gradovi[i].Naziv,
                    _drzava.Naziv,
                    _drzava.Gradovi[i].Status? "DA" : "NE"
                );
            }

            ReportDataSource reportDataSource = new()
            {
                Name = "Gradovi",
                Value = gradDataTable
            };

            reportViewer.LocalReport.ReportPath = ".\\IspitBrojIndeksa\\GradReportBrojIndeksa.rdlc";
            reportViewer.LocalReport.SetParameters(reportParameter);
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.RefreshReport();
        }
    }
}
