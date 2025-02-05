using DLWMS.Data;
using DLWMS.Infrastructure;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private Student odabraniStudent;

        DLWMSContext db = new DLWMSContext();

        public frmIzvjestaji(Student odabraniStudent)
        {
            InitializeComponent();   
            this.odabraniStudent = odabraniStudent;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            IsprintajReport();
            reportViewer1.RefreshReport(); 
        }

        private void IsprintajReport()
        {
            var razmjene = db.RazmjeneIB200234.Include(x => x.Univerzitet.Drzava)
                .Where(x => x.StudentId == odabraniStudent.Id).ToList();

            var tblRazmjene = new dsDLWMS.tblRazmjeneDataTable();
            if(razmjene.Count()==0)
            {
                MessageBox.Show($"{odabraniStudent} nije imao nikakve razmjene sa drugim univerzitetima!");
            }
            for (int i = 0; i < razmjene.Count(); i++)
            {
                var red = tblRazmjene.NewtblRazmjeneRow();

                red.Rb = (i + 1).ToString();
                red.Univerzitet = razmjene[i].Univerzitet.ToString();
                red.Pocetak = razmjene[i].PocetakRazmjene.ToString("dd.MM.yyyy");
                red.Kraj = razmjene[i].KrajRazmjene.ToString("dd.MM.yyyy");
                red.ECTS = razmjene[i].Kredit.ToString();
                red.Okoncano = razmjene[i].Okoncana ? "DA" : "NE";

                tblRazmjene.Rows.Add(red);
            }

            var rds = new ReportDataSource();

            rds.Value = tblRazmjene;
            rds.Name = "dsRazmjene";

            reportViewer1.LocalReport.DataSources.Add(rds);

            var rpc = new ReportParameterCollection();

            var ects = razmjene.Sum(x => x.Kredit);

            rpc.Add(new ReportParameter("student", odabraniStudent.StudentInfo.
                ToString()));
            rpc.Add(new ReportParameter("ects", ects.ToString()));

            reportViewer1.LocalReport.SetParameters(rpc);
        }
    }
}
