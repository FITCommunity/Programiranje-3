using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitBrojIndeksa
{
    /*
     * A warning to future readers
     * 
     * frmStudentEditBrojIndeksa u okviru koje će biti omogućena promjena slike i grada iz kojeg student dolazi
     * 
     * Iznad je isjecak jedne recenice iz postavke, kolega mi je rekao da ovo moze znaciti da se ocekuje
     * da se promjeni samo grad za studenta, a ne drzava iz koje dolazi
     * 
     * Medutim u istom zadatku na slici se vidi se da je combo box za drzavu disabled, jos pored toga ako se ne
     * treba mijenjati vise bi mozda imalo logike da nije uopste tu ili se koristi neka druga kontrola za prikaz
     * te informacije (tipa label), ALI profesor je u proslosti stavljao stvari na slike forme koje nisu bitne
     * bile za implementaciju (npr. minimize and maximize buttons) 
     * 
     * Ja mogu vidjeti da su oba tumacenja zadatka ispravna, ja se vise slazem sa svojim pa u implementaciji ispod
     * dozvoljavam promjenu drzave i grada, u slucaju da bude slicna situacija na buducemo roku najsigurnije je 
     * pitati profesora za dodatno pojasnjenje
     */
    public partial class frmStudentEditBrojIndeksa : Form
    {
        private readonly DLWMSContext DB = SharedBrojIndeksa.DB;
        private readonly Student _student;

        public frmStudentEditBrojIndeksa(Student student)
        {
            InitializeComponent();

            _student = student;

            LoadDrzavaIntoComboBox();
            FillStudentData();
        }

        private void LoadDrzavaIntoComboBox()
            => cbDrzava.UcitajPodatke(DB.Drzave.Include(drzava => drzava.Gradovi).ToList());

        private void LoadGradIntoComboBox()
        {
            var drzava = (Drzava)cbDrzava.SelectedItem;

            cbGrad.UcitajPodatke(
                DB.Gradovi
                  .Include(grad => grad.Drzava)
                  .Where(grad => grad.Drzava == drzava)
                  .ToList()
            );
        }

        private void FillStudentData()
        {
            lblImePrezime.Text = _student.ImePrezime;
            lblIndeks.Text = _student.BrojIndeksa;
            pbSlika.Image = _student.Slika.ToImage();
            cbDrzava.SelectedItem = _student.Drzava;
            LoadGradIntoComboBox();
            cbGrad.SelectedItem = _student.Grad;
        }

        private void UcitajSlikuBtnClick(object? sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void SacuvajBtnClick(object? sender, EventArgs e)
        {
            var grad = (Grad)cbGrad.SelectedItem;

            _student.Slika = pbSlika.Image.ToByteArray();
            _student.Grad = grad;

            DB.Update(_student);
            DB.SaveChanges();
            Close();
        }

        private void DrzavaComboBoxSelectionChangeCommitted(object? sender, EventArgs e)
            => LoadGradIntoComboBox();
    }
}
