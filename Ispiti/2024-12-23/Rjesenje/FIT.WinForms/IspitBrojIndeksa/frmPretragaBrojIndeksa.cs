using FIT.Data;
using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmPretragaBrojIndeksa : Form
    {
        private static readonly DLWMSDbContext _DLWMSDbContext = SharedBrojIndeksa.DLWMSDbContext;

        public frmPretragaBrojIndeksa()
        {
            InitializeComponent();

            SetDgvProperties();
            LoadSemestriIntoComboBox();
            LoadUlogeIntoComboBox();
            SetDateTimePickersFormat("dd.MM.yyyy hh:mm");
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

        private void LoadSemestriIntoComboBox()
            => cbSemestar.UcitajPodatke(_DLWMSDbContext.Semestri.ToList(), "Oznaka");

        private void LoadUlogeIntoComboBox()
            => cbUloga.UcitajPodatke(_DLWMSDbContext.Uloge.ToList());


        private void SetDateTimePickersFormat(string format)
        {
            dtpOd.Format = DateTimePickerFormat.Custom;
            dtpOd.CustomFormat = format;

            dtpDo.Format = DateTimePickerFormat.Custom;
            dtpDo.CustomFormat = format;
        }

        private void LoadStudentiIntoDgv()
        {
            var semestar = (SemestriBrojIndeksa)cbSemestar.SelectedItem;
            var uloga = (UlogeBrojIndeksa)cbUloga.SelectedItem;
            DateTime rodenOd = dtpOd.Value;
            DateTime rodenDo = dtpDo.Value;

            var studenti = _DLWMSDbContext.Studenti
                                          .Include(student => student.Semestar)
                                          .Include(student => student.Uloga)
                                          .Include(student => student.PolozeniPredmeti)
                                          .Where(student =>
                                             student.Semestar == semestar
                                          && student.Uloga == uloga
                                          && student.DatumRodjenja >= rodenOd
                                          && student.DatumRodjenja <= rodenDo
                                          )
                                          .ToList();

            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti;

            if (studenti.Count == 0)
            {
                MessageBox.Show("Za odabrani semestar, ulogu i period rodenja nema studenata", "Nema studenata");
            }
        }

        private void ComboBoxSelectionChangeCommitted(object? sender, EventArgs e)
            => LoadStudentiIntoDgv();

        private void DateTimePickersValueChanged(object? sender, EventArgs e)
            => LoadStudentiIntoDgv();

        private void StudentiDgvCellClick(object? sender, DataGridViewCellEventArgs e)
        {
            bool isPorukeClick = e.ColumnIndex == StudentPorukeBtn.Index;

            if (e.RowIndex < 0 || !isPorukeClick)
            {
                return;
            }

            var student = (Student)dgvStudenti.Rows[e.RowIndex].DataBoundItem;

            using frmPorukeBrojIndeksa frmPorukeBrojIndeksa = new(student);

            frmPorukeBrojIndeksa.ShowDialog();
        }
    }
}
