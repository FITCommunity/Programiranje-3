using DLWMS.Data.IspitBrojIndeksa;
using DLWMS.Infrastructure;
using DLWMS.WinApp.IspitBrojIndeksa;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using static DLWMS.WinApp.Izvjestaji.dsDLWMS;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private readonly DLWMSContext DB = SharedBrojIndeksa.DB;
        private readonly StipendijeGodineBrojIndeksa _stipendijaGodina;

        public frmIzvjestaji()
        {
            InitializeComponent();            
        }

        public frmIzvjestaji(StipendijeGodineBrojIndeksa stipendijaGodina)
        {
            InitializeComponent();

            _stipendijaGodina = stipendijaGodina;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var studenti = DB.StudentiStipendije
                             .Include(studentiStipendije => studentiStipendije.Studenti)
                             .Include(studentiStipendije => studentiStipendije.StipendijeGodineBrojIndeksa)
                             .Where(studentiStipendije => studentiStipendije.StipendijeGodineBrojIndeksa == _stipendijaGodina)
                             .Select(studentiStipendije => studentiStipendije.Studenti)
                             .ToList();

            ReportParameterCollection reportParameters = new()
            {
                new ReportParameter("Godina", _stipendijaGodina.Godina.ToString()),
                new ReportParameter("Stipendija", _stipendijaGodina.ToString()),
                new ReportParameter("Total", (_stipendijaGodina.Ukupno * studenti.Count).ToString())
            };

            StudentiStipendijeDataTable dataTable = new();

            for (int i = 0; i < studenti.Count; ++i)
            {
                dataTable.AddStudentiStipendijeRow(
                    $"{i + 1}",
                    studenti[i].IndeksImePrezime,
                    _stipendijaGodina.MjesecniIznos.ToString(),
                    _stipendijaGodina.Ukupno.ToString()
                );
            }

            ReportDataSource reportData = new()
            {
                Name = "StudentiStipendije",
                Value = dataTable
            };

            reportViewer1.LocalReport.DataSources.Add(reportData);
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport(); 
        }
    }
}
