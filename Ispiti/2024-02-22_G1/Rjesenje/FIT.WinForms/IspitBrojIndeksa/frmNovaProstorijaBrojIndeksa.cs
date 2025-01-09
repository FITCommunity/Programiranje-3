using FIT.Data;
using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmNovaProstorijaBrojIndeksa : Form
    {
        private static readonly DLWMSDbContext _DLWMSDbContext = SharedBrojIndeksa.DLWMSDbContext;
        private readonly ProstorijeBrojIndeksa _prostorija;
        private readonly bool _createNew;

        public frmNovaProstorijaBrojIndeksa(ProstorijeBrojIndeksa? prostorija = null)
        {
            InitializeComponent();

            if (prostorija == null)
            {
                _createNew = true;
                _prostorija = new();
            }
            else
            {
                _createNew = false;
                _prostorija = prostorija;
                FillInputs();
            }
        }

        private void FillInputs()
        {
            pbLogo.Image = _prostorija.Logo.ToImage();
            txtNaziv.Text = _prostorija.Naziv;
            txtOznaka.Text = _prostorija.Oznaka;
            txtKapacitet.Text = _prostorija.Kapacitet.ToString();
        }

        private void LogoPictureBoxDoubleClick(object? sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private bool AreInputsValid()
            => Validator.ProvjeriUnos(pbLogo, errorProvider, Kljucevi.ReqiredValue)
            && Validator.ProvjeriUnos(txtNaziv, errorProvider, Kljucevi.ReqiredValue)
            && Validator.ProvjeriUnos(txtOznaka, errorProvider, Kljucevi.ReqiredValue)
            && Validator.ProvjeriUnos(txtKapacitet, errorProvider, Kljucevi.ReqiredValue);

        private void SacuvajBtnClick(object sender, EventArgs e)
        {
            int kapacitet;

            if (!AreInputsValid())
            {
                return;
            }
            else if (!int.TryParse(txtKapacitet.Text, out kapacitet) || kapacitet <= 0)
            {
                errorProvider.SetError(txtKapacitet, "Kapacitet treba biti pozitivan broj");
                return;
            }
            else
            {
                errorProvider.Clear();
            }

            _prostorija.Logo = pbLogo.Image.ToByteArray();
            _prostorija.Naziv = txtNaziv.Text.Trim();
            _prostorija.Oznaka = txtOznaka.Text.Trim();
            _prostorija.Kapacitet = kapacitet;

            if (_createNew)
            {
                _DLWMSDbContext.Add(_prostorija);
            }
            else
            {
                _DLWMSDbContext.Update(_prostorija);
            }

            _DLWMSDbContext.SaveChanges();
            Close();
        }
    }
}
