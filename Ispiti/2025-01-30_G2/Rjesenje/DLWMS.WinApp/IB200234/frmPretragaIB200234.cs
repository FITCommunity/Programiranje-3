using DLWMS.Data;
using DLWMS.Infrastructure;
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

namespace DLWMS.WinApp.IB200234
{
    public partial class frmPretragaIB200234 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<Student> studenti;
        public frmPretragaIB200234()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmPretragaIB200234_Load(object sender, EventArgs e)
        {
            UcitajStudente();
            cmbDrzave.DataSource = db.Drzave.ToList();
            cmbDrzave.SelectedIndex = -1;
            cmbSpol.DataSource = db.Spolovi.ToList();
            cmbSpol.SelectedIndex = -1;
        }

        private void UcitajStudente()
        {
            var drzava = cmbDrzave.SelectedItem as Drzava ?? new Drzava();
            var Spol = cmbSpol.SelectedItem as Spol ?? new Spol();
            var Aktivan = cbAktivan.Checked;
            studenti = db.Studenti
                .Include(x => x.Grad)
                .Include(x => x.Spol)
                .Where(x => x.Grad.DrzavaId == drzava.Id)
                .Where(x => x.SpolId == Spol.Id)
                .Where(x => x.Aktivan == Aktivan)
                .ToList();




            if (studenti != null)
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studenti;
            }

            var Status = cbAktivan.Checked ? "Aktivan" : "Neaktivan";

            if (studenti.Count() == 0)
            {
                MessageBox.Show($"Ne postoji student u bazi koji dolazi iz {drzava}, koji je spola {Spol} i koji ima status {Status} ");
            }
            this.Text = $"Broj studenata u bazi: {studenti.Count().ToString()}";
        }

        private void cmbDrzave_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void cbAktivan_CheckedChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniStudent = studenti[e.RowIndex];
            if (e.ColumnIndex == 3)
            {
                if (odabraniStudent.Aktivan)
                {
                    odabraniStudent.Aktivan = false;
                }
                else
                {
                    odabraniStudent.Aktivan = true;
                }
                db.Studenti.Update(odabraniStudent);
                db.SaveChanges();
                UcitajStudente();

            }
            else if (e.ColumnIndex==4)
            {
                frmRazmjeneIB200234 frm = new frmRazmjeneIB200234(odabraniStudent);
                frm.ShowDialog();
            }

        }

        private void dgvStudenti_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniStudent = studenti[e.RowIndex];
            if(e.ColumnIndex<3)
            {
                frmStudentEditIB200234 frm = new frmStudentEditIB200234(odabraniStudent);
                frm.ShowDialog();
            }
        }
    }
}
