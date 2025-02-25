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
    public partial class frmPretragaBrojIndeksa : Form
    {
        DLWMSContext db = new DLWMSContext();
        public frmPretragaBrojIndeksa()
        {
            InitializeComponent();
        }

        private void frmPretragaIB230269_Load(object sender, EventArgs e)
        {
            dgwPretraga.AutoGenerateColumns = false;
            cbStipendija.UcitajPodatke(db.StipendijeBrojIndeksa.ToList());
            cbGodina.SelectedIndex = 0;

            dgwPretraga.DataSource = db.StudentiStipendijeBrojIndeksa.AsNoTracking().Include(s => s.StipendijeGodine).ThenInclude(s => s.Stipendija).Include(s => s.Student).ToList();

            this.Text = $"Broj prikazanih studenata: {dgwPretraga.Rows.Count}";
        }

        private void dgwUcitajPodatke()
        {
            bool pokazi = true;
            var godina = cbGodina.SelectedItem as string;
            var stipendija = cbStipendija.SelectedItem as StipendijeBrojIndeksa;

            if (dgwPretraga.Rows.Count == 0)
                pokazi=false;

            dgwPretraga.DataSource = null;
            dgwPretraga.DataSource = db.StudentiStipendijeBrojIndeksa.AsNoTracking().Include(s => s.StipendijeGodine).ThenInclude(s => s.Stipendija).Include(s => s.Student)
                .Where(s => s.StipendijeGodine.Godina==godina && stipendija.Id == s.StipendijeGodine.StipendijaId).ToList();

            this.Text = $"Broj prikazanih studenata: {dgwPretraga.Rows.Count}";

            if (dgwPretraga.Rows.Count == 0 && !pokazi)
                pokazi=false;
            if (dgwPretraga.Rows.Count==0 && pokazi)
            {
                MessageBox.Show($"U bazi nisu evidentirani studenti kojima je u {godina}. godini dodijeljena {stipendija} stipendija.");
                pokazi = true;
            }
        }

        private void btnDodajStipendiju_Click(object sender, EventArgs e)
        {
            var forma = new frmStipendijaAddEditBrojIndeksa();
            if (forma.ShowDialog()==DialogResult.OK)
                dgwUcitajPodatke();
        }

        private void cbStipendija_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgwUcitajPodatke();
        }

        private void cbGodina_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgwUcitajPodatke();
        }

        private void btnStipendijaPoGodinama_Click(object sender, EventArgs e)
        {
            var forma = new frmStipendijeBrojIndeksa();
            forma.ShowDialog();
            dgwUcitajPodatke();
        }

        private void dgwPretraga_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var odabranaStipendija = dgwPretraga.SelectedRows[0].DataBoundItem as StudentiStipendijeBrojIndeksa;
                if (e.ColumnIndex == 5)
                {
                    if (MessageBox.Show("Jeste li sigurni da želite obrisati ovu stipendiju?",
                                        "Brisanje stipendije!",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        var pracenaStipendija = db.ChangeTracker.Entries<StudentiStipendijeBrojIndeksa>()
                            .FirstOrDefault(e => e.Entity.Id == odabranaStipendija.Id);

                        if (pracenaStipendija != null)
                            pracenaStipendija.State = EntityState.Detached;

                        var stipendijaZaBrisanje = db.StudentiStipendijeBrojIndeksa
                            .AsNoTracking()
                            .FirstOrDefault(s => s.Id == odabranaStipendija.Id);

                        db.StudentiStipendijeBrojIndeksa.Remove(stipendijaZaBrisanje);
                        db.SaveChanges();
                        dgwUcitajPodatke();
                    }
                }
                if (e.ColumnIndex != 5)
                {
                    var forma = new frmStipendijaAddEditBrojIndeksa(odabranaStipendija);
                    if (forma.ShowDialog() == DialogResult.OK)
                        dgwUcitajPodatke();
                }
            }
        }
    }
}
