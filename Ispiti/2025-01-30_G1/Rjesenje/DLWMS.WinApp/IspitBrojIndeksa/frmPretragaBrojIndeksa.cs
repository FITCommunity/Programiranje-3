using DLWMS.Data;
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

            dgvStudenti.AutoGenerateColumns = false;

            LoadDrzaveIntoDgv();
            LoadSpoloviIntoDgv();
            LoadStudentiIntoDgv();
        }

        private void LoadDrzaveIntoDgv()
            => cbDrzava.UcitajPodatke(DB.Drzave.Include(drzava => drzava.Gradovi).ToList());

        private void LoadSpoloviIntoDgv()
            => cbSpol.UcitajPodatke(DB.Spolovi.Include(spol => spol.Studenti).ToList());


        private void LoadStudentiIntoDgv()
        {
            string imeIliPrezime = txtImeIliPrezime.Text.Trim().ToLower();
            var spol = (Spol)cbSpol.SelectedItem;
            var drzava = (Drzava)cbDrzava.SelectedItem;

            var daLiImeIliPrezimePaseUnosu = (string ime, string prezime) => imeIliPrezime == ""
                                                                       || ime.StartsWith(imeIliPrezime)
                                                                       || prezime.StartsWith(imeIliPrezime);

            var studenti = DB.Studenti
                             .Include(student => student.Spol)
                             .Include(student => student.Grad)
                             .ThenInclude(grad => grad.Drzava)
                             .ToList()
                             /* ^
                              * This is needed here to make the evaluation client side / in memory, otherwise 
                              * an exception will be thrown because the function daLiImeIliPrezimePaseUnosu
                              * cannot be evaluated as SQL code
                              */
                             .Where(
                                 student =>
                                 daLiImeIliPrezimePaseUnosu(student.Ime.ToLower(), student.Prezime.ToLower())
                                 && student.Grad.Drzava == drzava
                                 && student.Spol == spol
                             )
                             .ToList();

            dgvStudenti.DataSource = studenti;
            Text = $"Broj prikazanih studenta: {studenti.Count}";

            if (studenti.Count == 0)
            {
                MessageBox.Show("Za dato ime ili prezime, drzavu i spol nema studenata", "Prazna pretraga");
            }
        }

        private void FilterStudents(object sender, EventArgs e)
            => LoadStudentiIntoDgv();

        private void StudentiDgvCellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var student = (Student)dgvStudenti.GetOdabraniRed();

            using var formaEdit = new frmStudentEditBrojIndeksa(student);
            formaEdit.ShowDialog();

            LoadStudentiIntoDgv();
        }

        private void StudentiDgvCellClick(object? sender, DataGridViewCellEventArgs e)
        {
            bool isRazmjeneClick = e.ColumnIndex == RazmjeneBtn.Index;
            bool isAktivanClick = e.ColumnIndex == Aktivan.Index;

            if (e.RowIndex < 0 || (!isRazmjeneClick && !isAktivanClick))
            {
                return;
            }

            var student = (Student)dgvStudenti.GetOdabraniRed();

            if (isAktivanClick)
            {
                student.Aktivan = !student.Aktivan;
                DB.Update(student);
                DB.SaveChanges();
                LoadStudentiIntoDgv();
            }
            else if (isRazmjeneClick)
            {
                using var formaRazmjene = new frmRazmjeneBrojIndeksa(student);
                formaRazmjene.ShowDialog();
            }
        }
    }
}
