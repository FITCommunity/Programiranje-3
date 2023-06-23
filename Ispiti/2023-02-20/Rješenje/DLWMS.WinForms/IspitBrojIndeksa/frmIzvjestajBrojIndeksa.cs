using DLWMS.Data;
using DLWMS.Data.BrojIndeksa;
using DLWMS.WinForms.IspitBrojIndeksa;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.BrojIndeksa
{
    public partial class frmIzvjestajBrojIndeksa : Form
    {
        private List<StudentPorukaBrojIndeksa> poruke;
        private Student student;
        public frmIzvjestajBrojIndeksa(List<StudentPorukaBrojIndeksa> porukeStudenti, Student std)
        {
            InitializeComponent();
            poruke = porukeStudenti;
            student = std;
        }

        private void frmIzvjestajBrojIndeksa_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("rpImePrezime", student.Ime + " " + student.Prezime));

            var sum = 0f;
            var tblPoruke = new dsPorukeBrojIndeksa.StudentiPorukeDataTable();

            for (int i = 0; i < poruke.Count(); i++)
            {
                var red = tblPoruke.NewStudentiPorukeRow();
                red.Rb = (i + 1).ToString();
                red.Predmet = poruke[i].Predmet.ToString();
                red.Poruka = poruke[i].Sadrzaj;
                red.BrojZnakova = poruke[i].Sadrzaj.Count().ToString();
                red.Validnost = poruke[i].Validnost.ToString();
                sum += poruke[i].Sadrzaj.Count();
                tblPoruke.AddStudentiPorukeRow(red);
            }

            rpc.Add(new ReportParameter("rpBrojPoruka", poruke.Count().ToString()));
            rpc.Add(new ReportParameter("rpProsjecnoKaraktera", poruke.Count() != 0 ? (sum / poruke.Count()).ToString("0.00") : sum.ToString("0.00")));

            var rds = new ReportDataSource();
            rds.Name = "dsIzvjestaj";
            rds.Value = tblPoruke;
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
