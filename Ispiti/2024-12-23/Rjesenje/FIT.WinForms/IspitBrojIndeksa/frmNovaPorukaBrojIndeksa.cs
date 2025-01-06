using FIT.Data;
using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmNovaPorukaBrojIndeksa : Form
    {
        private static readonly DLWMSDbContext _DLWMSDbContext = SharedBrojIndeksa.DLWMSDbContext;
        private readonly Student _student;

        public frmNovaPorukaBrojIndeksa(Student student)
        {
            InitializeComponent();

            _student = student;

            LoadPredmetiIntoComboBox();
        }

        private void LoadPredmetiIntoComboBox()
            => cbPredmet.UcitajPodatke(_DLWMSDbContext.Predmeti.ToList());

        private bool AreInputsValid()
            => Validator.ProvjeriUnos(cbPredmet, errorProvider, Kljucevi.ReqiredValue)
            && Validator.ProvjeriUnos(cbHitnost, errorProvider, Kljucevi.ReqiredValue)
            && Validator.ProvjeriUnos(txtSadrzaj, errorProvider, Kljucevi.ReqiredValue)
            && Validator.ProvjeriUnos(pbSlika, errorProvider, Kljucevi.ReqiredValue);

        private void SacuvajBtnClick(object? sender, EventArgs e)
        {
            if (!AreInputsValid())
            {
                return;
            }

            var predmet = (PredmetiBrojIndeksa)cbPredmet.SelectedItem;

            StudentiPorukeBrojIndeksa poruka = new()
            {
                Student = _student,
                Predmet = predmet,
                Validnost = dtpValidnost.Value,
                Sadrzaj = txtSadrzaj.Text.Trim(),
                Hitnost = cbHitnost.SelectedItem.ToString() ?? "",
                Slika = pbSlika.Image.ToByteArray()
            };

            _DLWMSDbContext.Add(poruka);
            _DLWMSDbContext.SaveChanges();
            Close();
        }

        private void OdustaniBtnClick(object? sender, EventArgs e)
            => Close();

        private void SlikaPictureBoxDoubleClick(object? sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
