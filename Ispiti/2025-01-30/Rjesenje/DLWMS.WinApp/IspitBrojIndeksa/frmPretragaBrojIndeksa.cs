using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitBrojIndeksa
{
    public partial class frmPretragaBrojIndeksa : Form
    {
        private readonly DLWMSContext _DLWMSContext = SharedBrojIndeksa.DLWMSContext;

        public frmPretragaBrojIndeksa()
        {
            InitializeComponent();

            SetDgvProperties();
            LoadDrzaveIntoDgv();
            LoadSpoloviIntoDgv();
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

        private void LoadDrzaveIntoDgv()
            => cbDrzava.UcitajPodatke(_DLWMSContext.Drzave.Include(drzava => drzava.Gradovi).ToList());

        private void LoadSpoloviIntoDgv()
            => cbSpol.UcitajPodatke(_DLWMSContext.Spolovi.Include(spol => spol.Studenti).ToList());


        private void LoadStudentiIntoDgv()
        {
            string imeIliPrezime = txtImeIliPrezime.Text.Trim();
            var spol = (Spol)cbSpol.SelectedItem;
            var drzava = (Drzava)cbDrzava.SelectedItem;

            var studenti = _DLWMSContext.Studenti
                                        .Include(student => student.Spol)
                                        .Include(student => student.Grad)
                                        .ThenInclude(grad => grad.Drzava)
                                        .Where(
                                            student => (imeIliPrezime == "" || student.Ime.StartsWith(imeIliPrezime) || student.Ime.StartsWith(imeIliPrezime))
                                                    && student.Grad.Drzava == drzava
                                                    && student.Spol == spol
                                        )
                                        .ToList();

            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti;

            if (studenti.Count == 0) 
            {
                MessageBox.Show("Za dato ime ili prezime, drzavu i spol nema studenata", "Prazna pretraga");
            }

            Text = $"Broj prikazanih studenta: {studenti.Count}";
        }

        private void FilterStudents(object sender, EventArgs e)
            => LoadStudentiIntoDgv();

        private void StudentiDgvCellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var student = (Student)dgvStudenti.Rows[e.RowIndex].DataBoundItem;

            using frmStudentEditBrojIndeksa frmStudentEditBrojIndeksa = new(student);
            frmStudentEditBrojIndeksa.ShowDialog();

            LoadStudentiIntoDgv();
        }

        private void StudentiDgvCellClick(object? sender, DataGridViewCellEventArgs e)
        {
            bool isRazmjeneClick = e.ColumnIndex == StudentRazmjeneBtn.Index;
            bool isAktivanClick = e.ColumnIndex == StudentAktivan.Index;

            if (e.RowIndex < 0 || (!isRazmjeneClick && !isAktivanClick)) 
            {
                return;
            }

            var student = (Student)dgvStudenti.Rows[e.RowIndex].DataBoundItem;

            if (isAktivanClick) 
            {
                student.Aktivan = !student.Aktivan;
                _DLWMSContext.Update(student);
                _DLWMSContext.SaveChanges();
                LoadStudentiIntoDgv();
                return;
            }

            using frmRazmjeneBrojIndeksa frmRazmjeneBrojIndeksa = new(student);
            frmRazmjeneBrojIndeksa.ShowDialog();
        }
    }
}
