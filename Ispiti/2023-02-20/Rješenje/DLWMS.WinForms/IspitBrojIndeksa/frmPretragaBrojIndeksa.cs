using DLWMS.Data;
using DLWMS.Data.BrojIndeksa;
using DLWMS.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmPretragaBrojIndeksa : Form
    {
        private Student student;
        DLWMSDbContext db = KonekcijaBrojIndeksa.db;
        List<DtoStudentPredmetBrojIndeksa> studentiPredmeti = new List<DtoStudentPredmetBrojIndeksa>();
        public frmPretragaBrojIndeksa()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            dtpDatumOd.Value = new DateTime(2022,12,1); //ovo smo dodali radi jednostavnijeg ucitavanja (datumi unesenih ocjena su poslije ovog)

            //Kod za dodavanje novih ocjena studentima
            //----------------------------------------------
            //var std = db.Studenti.Include(x => x.Spol).ToList();
            //var predmeti=db.Predmeti.ToList();
            //var rand = new Random();
            //db.StudentiPredmeti.Add(new StudentPredmetBrojIndeksa() { 
            //    Student = std[0], Datum=DateTime.Now, Ocjena=rand.Next(6, 10),Predmet = predmeti[2]});
            // db.StudentiPredmeti.Add(new StudentPredmetBrojIndeksa() { 
            //    Student = std[1], Datum=DateTime.Now, Ocjena=rand.Next(6, 10),Predmet = predmeti[0]});
            // db.StudentiPredmeti.Add(new StudentPredmetBrojIndeksa() { 
            //    Student = std[1], Datum=DateTime.Now, Ocjena=rand.Next(6, 10),Predmet = predmeti[1]});
            //db.SaveChanges();

        }

        private void UcitajPodakte()
        {
            if (validniPodaci())
            {
                studentiPredmeti.Clear();
                var ocjenaOd = int.Parse(cmbOcjenaOd.SelectedItem.ToString());
                var ocjenaDo = int.Parse(cmbOcjenaDo.SelectedItem.ToString());
                var dtmOd = dtpDatumOd.Value;
                var dtmDo = dtpDatumDo.Value; 
                var lista = db.StudentiPredmeti.Include(x => x.Student).Include(x => x.Predmet).Where(x => x.Ocjena >= ocjenaOd &&
                x.Ocjena <= ocjenaDo && x.Datum >= dtmOd && x.Datum <= dtmDo).ToList();

                foreach (var stdPredm in lista)
                    studentiPredmeti.Add(new DtoStudentPredmetBrojIndeksa() { stdPredm = stdPredm });

                dgvStudenti.DataSource = null;

                if (lista.Count == 0)
                    MessageBox.Show($"U periodu od {dtmOd.ToString("dd.MM.yyyy")} - {dtmDo.ToString("dd.MM.yyyy")} godine ne postoje evidentirane" +
                        $" ocjene u opsegu od {ocjenaOd} do {ocjenaDo} za bilo kojeg studenta.");
                else
                    dgvStudenti.DataSource = studentiPredmeti;
            }
        }

        private void cmbOcjenaOd_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodakte();
        }

        private void cmbOcjenaDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodakte();
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
           UcitajPodakte();
        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
           UcitajPodakte();
        }

        private bool validniPodaci()
        {
            return Helpers.Validator.ValidirajKontrolu(cmbOcjenaOd, err, Kljucevi.ObaveznaVrijednost)
                && Helpers.Validator.ValidirajKontrolu(cmbOcjenaDo, err, Kljucevi.ObaveznaVrijednost)
                && Helpers.Validator.ValidirajKontrolu(dtpDatumOd, err, Kljucevi.ObaveznaVrijednost)
                && Helpers.Validator.ValidirajKontrolu(dtpDatumDo, err, Kljucevi.ObaveznaVrijednost);
        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==5)
            {
                var std = dgvStudenti.SelectedRows[0].DataBoundItem as DtoStudentPredmetBrojIndeksa;
                var frm=new frmPorukeBrojIndeksa(std.stdPredm.Student);
                frm.ShowDialog();
            }
        }
    }
}
