using FIT.Data;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmPretragaBrojIndeksa : Form
    {
        private static readonly DLWMSDbContext _DLWMSDbContext = SharedBrojIndeksa.DLWMSDbContext;

        public frmPretragaBrojIndeksa()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new("bs-Latn-BA");

            SetDgvProperties();
            SetDateTimePickersFormat("dddd, d. MMMM yyyy.");
            LoadSpoloviIntoComboBox();
            LoadStudentsIntoDgv();
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

        private void SetDateTimePickersFormat(string format)
        {
            dtpOd.Format = DateTimePickerFormat.Custom;
            dtpOd.CustomFormat = format;

            dtpDo.Format = DateTimePickerFormat.Custom;
            dtpDo.CustomFormat = format;
        }

        private void LoadSpoloviIntoComboBox()
        {
            var spolovi = new[]
            {
                new { Name = "Svi spolovi", Value = 0 },
                new { Name = "Muski", Value = 1 },
                new { Name = "Zenski", Value = 2 },
                new { Name = "Ostali", Value = 3 }
            };

            cbSpol.DisplayMember = "Name";
            cbSpol.ValueMember = "Value";
            cbSpol.DataSource = spolovi;
            cbSpol.SelectedIndex = 0;
        }

        private void LoadStudentsIntoDgv()
        {
            int spol = (int)cbSpol.SelectedValue;
            DateTime rodenOd = dtpOd.Value;
            DateTime rodenDo = dtpDo.Value;

            var studenti = _DLWMSDbContext.Studenti
                                          .Include(student => student.PolozeniPredmeti)
                                          .Where(
                                            student => (spol == 0 || student.Spol == spol)
                                                && student.DatumRodjenja >= rodenOd
                                                && student.DatumRodjenja <= rodenDo
                                          )
                                          .ToList();

            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti;

            if (studenti.Count == 0)
            {
                MessageBox.Show("Za dati spol, datume od i do, nema studenata u bazi", "Nema studenata");
            }
        }

        private void SpolComboBoxSelectedIndexChanged(object? sender, EventArgs e)
            => LoadStudentsIntoDgv();

        private void OdDoDateTimePickersValueChanged(object? sender, EventArgs e)
            => LoadStudentsIntoDgv();

        private void StudentiDgvCellClick(object? sender, DataGridViewCellEventArgs e)
        {
            bool isUvjerenjeClick = e.ColumnIndex == StudentUvjerenjeBtn.Index;

            if (e.RowIndex < 0)
            {
                return;
            }

            var student = (Student)dgvStudenti.Rows[e.RowIndex].DataBoundItem;

            if (isUvjerenjeClick)
            {
                using frmUvjerenjaBrojIndeksa frmUvjerenjaBrojIndeksa = new(student);
                frmUvjerenjaBrojIndeksa.ShowDialog();
                return;
            }

            using frmStudentInfoBrojIndeksa frmStudentInfoBrojIndeksa = new(student);
            frmStudentInfoBrojIndeksa.ShowDialog();
        }
    }
}
