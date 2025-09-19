using DLWMS.Data.IspitBrojIndeksa;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitBrojIndeksa
{
    public partial class frmPretragaBrojIndeksa : Form
    {
        private readonly DLWMSContext DB = SharedBrojIndeksa.DB;

        public frmPretragaBrojIndeksa()
        {
            InitializeComponent();

            dgvStudentiStipendije.AutoGenerateColumns = false;
            cbGodina.SelectedIndex = 0;

            LoadStipendijeGodineIntoComboBox();
            LoadStudentiStipendijeIntoDgv();
        }

        private void LoadStipendijeGodineIntoComboBox()
        {
            var godina = cbGodina.SelectedItem.ToString();
            bool toggleState = chbToggle.Checked;

            cbStipendijaGodina.DataSource = DB.StipendijeGodine
                              .Include(stipendijaGodina => stipendijaGodina.StipendijeBrojIndeksa)
                              .Where(stipendijaGodina => 
                                 stipendijaGodina.Godina.ToString() == godina 
                              && stipendijaGodina.Aktivna == toggleState)
                              .ToList();
        }

        private void LoadStudentiStipendijeIntoDgv()
        {
            var godina = cbGodina.SelectedItem.ToString();
            var stipendijaGodina = (StipendijeGodineBrojIndeksa)cbStipendijaGodina.SelectedItem;

            var studentiStipendije = DB.StudentiStipendije
                                 .Include(studentiStipendije => studentiStipendije.Studenti)
                                 .Include(studentiStipendije => studentiStipendije.StipendijeGodineBrojIndeksa)
                                 .ThenInclude(stipendijaGodina => stipendijaGodina.StipendijeBrojIndeksa)
                                 .Where(studentiStipendije => studentiStipendije.StipendijeGodineBrojIndeksa == stipendijaGodina)
                                 .ToList();

            dgvStudentiStipendije.DataSource = studentiStipendije;
            Text = $"Broj prikazanih studenata: {studentiStipendije.Count}";

            if (studentiStipendije.Count == 0)
            {
                string nazivStipendije = (stipendijaGodina == null) ?
                    "Nema naziva za stipendiju" : stipendijaGodina.StipendijeBrojIndeksa.Naziv;

                MessageBox.Show($"U bazi nisu evidentirani studenti kojima je u {godina}.godini dodijeljena {nazivStipendije}.");
            }
        }

        private void ComboBoxGodinaSelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadStipendijeGodineIntoComboBox();
            LoadStudentiStipendijeIntoDgv();
        }

        private void ComboBoxStipendijaGodinaSelectionChangeCommitted(object sender, EventArgs e)
            => LoadStudentiStipendijeIntoDgv();

        private void DgvStudentiStipendijeCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != BtnUkloni.Index)
            {
                return;
            }

            var studentStipendija = (StudentiStipendijeBrojIndeksa)dgvStudentiStipendije.GetOdabraniRed();
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite obrisati stipendiju za odabranog studenta?", "Brisanje stipendije za studenta", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DB.Remove(studentStipendija);
                DB.SaveChanges();
                LoadStudentiStipendijeIntoDgv();
            }
        }

        private void StudentiStipendijeDgvCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var studentStipendija = (StudentiStipendijeBrojIndeksa)dgvStudentiStipendije.GetOdabraniRed();

            using var formaAddEdit = new frmStipendijaAddEditBrojIndeksa(studentStipendija);
            formaAddEdit.ShowDialog();
            LoadStudentiStipendijeIntoDgv();
        }

        private void DodajStipendijuBtnClick(object sender, EventArgs e)
        {
            using var formaAddEdit = new frmStipendijaAddEditBrojIndeksa();
            formaAddEdit.ShowDialog();
            LoadStudentiStipendijeIntoDgv();
        }

        private void StipendijePoGodinamaBtnClick(object sender, EventArgs e)
        {
            using var formaStipendijePoGodinama = new frmStipendijeBrojIndeksa();
            formaStipendijePoGodinama.ShowDialog();
            LoadStipendijeGodineIntoComboBox();
        }

        private void ToggleCheckBoxClick(object sender, EventArgs e)
        {
            LoadStipendijeGodineIntoComboBox();
            LoadStudentiStipendijeIntoDgv();
        }
    }
}
