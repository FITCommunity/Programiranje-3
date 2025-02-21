using DLWMS.Data;
using DLWMS.Data.IB230269;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
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

namespace DLWMS.WinApp.IB230269
{
    public partial class frmStipendijaAddEditBrojIndeksa : Form
    {
        DLWMSContext db = new DLWMSContext();
        StudentiStipendijeBrojIndeksa studentStipendijaGlobal;
        public frmStipendijaAddEditBrojIndeksa(StudentiStipendijeBrojIndeksa? odabranaStipendija = null)
        {
            InitializeComponent();
            studentStipendijaGlobal = odabranaStipendija;
        }

        private void frmStipendijaAddEditIB230269_Load(object sender, EventArgs e)
        {
            cbGodina.SelectedIndex = 0;
            cbStudent.UcitajPodatke(db.Studenti.ToList());
            cbStudent.SelectedIndex=0;
            ucitajStipendije();

            if (studentStipendijaGlobal != null)
            {
                ucitajEditStipendiju();
            }
        }

        private void ucitajEditStipendiju()
        {
            cbStudent.Enabled = false;
            cbGodina.SelectedItem = studentStipendijaGlobal.Godina;
            ucitajStipendije();
            cbStipendija.SelectedValue = studentStipendijaGlobal.StipendijeGodine.Id;
            cbStudent.SelectedValue = studentStipendijaGlobal.StudentID;
        }

        private void ucitajStipendije()
        {
            var godina = cbGodina.SelectedItem.ToString();
            var listaStipendijeGodine = db.StipendijeGodineBrojIndeksa.Include(s => s.Stipendija).Where(s => s.Godina==godina).ToList();
            cbStipendija.UcitajPodatke(listaStipendijeGodine);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!validirajComboBoxove())
                return;

            var stipendijaGodina = cbStipendija.SelectedItem as StipendijeGodineBrojIndeksa;
            var student = cbStudent.SelectedItem as Student;

            var listaStipendijaZaStudenta = db.StudentiStipendijeBrojIndeksa
                .Where(s => s.StudentID == student.Id)
                .ToList();

            foreach (var s in listaStipendijaZaStudenta)
            {
                if (s.StipendijeGodineID == stipendijaGodina.Id)
                {
                    if (cbStudent.Enabled)
                        MessageBox.Show($"Odabrani student već prima {stipendijaGodina.Stipendija} stipendiju za {stipendijaGodina.Godina} godinu!");
                    else
                        this.Close();
                    return;
                }
            }

            if (studentStipendijaGlobal == null)
            {
                var novi = new StudentiStipendijeBrojIndeksa()
                {
                    StipendijeGodineID = stipendijaGodina.Id,
                    StipendijeGodine = stipendijaGodina,
                    StudentID = student.Id,
                    Student = student
                };

                db.StudentiStipendijeBrojIndeksa.Add(novi);
            }
            else
            {
                var trackingStudentiStipendije = db.ChangeTracker.Entries<StudentiStipendijeBrojIndeksa>()
                    .FirstOrDefault(e => e.Entity.Id == studentStipendijaGlobal.Id);
                if (trackingStudentiStipendije != null)
                    trackingStudentiStipendije.State = EntityState.Detached;

                studentStipendijaGlobal.StudentID = student.Id;
                studentStipendijaGlobal.Student = student;
                studentStipendijaGlobal.StipendijeGodineID = stipendijaGodina.Id;
                studentStipendijaGlobal.StipendijeGodine = stipendijaGodina;

                db.Update(studentStipendijaGlobal);
            }

            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private bool validirajComboBoxove()
        {
            return Helpers.Validator.ProvjeriUnos(cbStipendija, errorProvider1, "RequiredValue");
        }


        private void cbGodina_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            ucitajStipendije();
        }
    }
}
