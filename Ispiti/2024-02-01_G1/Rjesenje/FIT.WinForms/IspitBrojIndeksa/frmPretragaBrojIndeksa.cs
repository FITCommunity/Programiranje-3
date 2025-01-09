using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmPretragaBrojIndeksa : Form
    {
        private readonly DLWMSDbContext _DLWMSDbContext = SharedBrojIndeksa.DLWMSDbContext;

        public frmPretragaBrojIndeksa()
        {
            InitializeComponent();

            SetDgvProperties();
            LoadDrzaveIntoComboBox();
            LoadGradoviIntoComboBox();
            LoadStudentiIntoDgv();
        }

        private void SetDgvProperties()
        {
            dgvStudenti.ReadOnly = true;
            dgvStudenti.MultiSelect = false;
            dgvStudenti.AutoGenerateColumns = false;
            dgvStudenti.AllowUserToResizeColumns = false;
            dgvStudenti.AllowUserToResizeRows = false;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadDrzaveIntoComboBox()
            => cbDrzava.UcitajPodatke(_DLWMSDbContext.Drzave.ToList());

        private void LoadGradoviIntoComboBox()
        {
            var drzava = (DrzaveBrojIndeksa)cbDrzava.SelectedItem;

            var gradovi = _DLWMSDbContext.Gradovi
                                         .Include(grad => grad.Drzava)
                                         .Where(grad => grad.Drzava == drzava)
                                         .ToList();

            cbGrad.UcitajPodatke(gradovi);
        }

        private void LoadStudentiIntoDgv()
        {
            var grad = (GradoviBrojIndeksa)cbGrad.SelectedItem;

            var studenti = _DLWMSDbContext.Studenti
                                          .Include(student => student.Grad)
                                          .ThenInclude(grad => grad.Drzava)
                                          .Include(student => student.PolozeniPredmeti)
                                          .Where(student => student.Grad == grad)
                                          .ToList();

            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti;

            if (studenti.Count == 0)
            {
                MessageBox.Show($"Za grad {grad.Naziv} nema studenata", "Nema studenata");
            }
        }

        private void DrzavaComboBoxSelectedIndexChanged(object? sender, EventArgs e)
            => LoadGradoviIntoComboBox();

        private void GradComboBoxSelectedIndexChanged(object? sender, EventArgs e)
            => LoadStudentiIntoDgv();
    }
}
