using DLWMS.Data.IB230269;
using DLWMS.Infrastructure;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<Data.IB230269.StudentiStipendijeBrojIndeksa> listaStudenataGlobal;
        string godinaStipendije;
        string kategorijaStipendije;
        public frmIzvjestaji(List<Data.IB230269.StudentiStipendijeBrojIndeksa> listaStudenata, string godina, string kategorija)
        {
            InitializeComponent();
            listaStudenataGlobal = listaStudenata;
            godinaStipendije = godina;
            kategorijaStipendije = kategorija;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var tabela = new dsDLWMS.dsIzvjestajDataTable();
            for (int i = 0; i < listaStudenataGlobal.Count; i++)
            {
                var studentTemp = listaStudenataGlobal[i];
                var row = tabela.NewdsIzvjestajRow();

                row.Rb = (i + 1).ToString();
                row.IndeksImePrezime = studentTemp.IndeksImePrezime;
                row.Iznos = studentTemp.Iznos.ToString();
                row.Ukupno = studentTemp.Ukupno.ToString();
                
                tabela.Rows.Add(row);
            }
            var dsIzvjestaj = new ReportDataSource()
            {
                Name = "dsIzvjestaj",
                Value = tabela
            };
            reportViewer1.LocalReport.DataSources.Add(dsIzvjestaj);

            var parametri = new ReportParameterCollection();
            var ukupno = listaStudenataGlobal.Sum(s=>s.Ukupno);

            parametri.Add(new ReportParameter("pGodina", godinaStipendije));
            parametri.Add(new ReportParameter("pKategorija", kategorijaStipendije));
            parametri.Add(new ReportParameter("pUkupno", ukupno.ToString()));

            reportViewer1.LocalReport.SetParameters(parametri);

            reportViewer1.RefreshReport(); 
        }
    }
}
