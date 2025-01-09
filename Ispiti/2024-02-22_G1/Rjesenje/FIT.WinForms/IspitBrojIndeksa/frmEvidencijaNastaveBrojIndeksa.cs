using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmEvidencijaNastaveBrojIndeksa : Form
    {
        private static readonly DLWMSDbContext _DLWMSDbContext = SharedBrojIndeksa.DLWMSDbContext;
        private readonly ProstorijeBrojIndeksa _prostorija;
        public frmEvidencijaNastaveBrojIndeksa(ProstorijeBrojIndeksa prostorija)
        {
            InitializeComponent();

            _prostorija = prostorija;
        }

        private void frmEvidencijaNastaveBrojIndeksa_Load(object sender, EventArgs e)
        {
            var prisustva = _DLWMSDbContext.Prisustvo
                                           .Include(prisustvo => prisustvo.Nastava)
                                           .ThenInclude(nastava => nastava.Prostorija)
                                           .Include(prisustvo => prisustvo.Nastava)
                                           .ThenInclude(nastava => nastava.Predmet)
                                           .Include(prisustvo => prisustvo.Student)
                                           .Where(prisustvo => prisustvo.Nastava.Prostorija == _prostorija)
                                           .ToList();

            ReportParameterCollection reportParameter = new()
            {
                new ReportParameter("NazivProstorije", _prostorija.Naziv),
                new ReportParameter("BrojStudenata", prisustva.Count.ToString())
            };

            EvidencijaNastaveDataSetBrojIndeksa.EvidencijaNastaveDataTable evidencijaNastaveDataTable = new();

            for (int i = 0; i < prisustva.Count; ++i)
            {
                evidencijaNastaveDataTable.AddEvidencijaNastaveRow(
                    (i + 1).ToString(),
                    prisustva[i].Nastava.Predmet.Naziv,
                    prisustva[i].Nastava.Vrijeme,
                    prisustva[i].Student.Indeks,
                    prisustva[i].Student.ImePrezime
                );
            }

            ReportDataSource reportDataSource = new()
            {
                Name = "EvidencijaNastave",
                Value = evidencijaNastaveDataTable
            };

            reportViewer.LocalReport.ReportPath = ".\\IspitBrojIndeksa\\EvidencijaNastaveReportBrojIndeksa.rdlc";
            reportViewer.LocalReport.SetParameters(reportParameter);
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.RefreshReport();
        }
    }
}
