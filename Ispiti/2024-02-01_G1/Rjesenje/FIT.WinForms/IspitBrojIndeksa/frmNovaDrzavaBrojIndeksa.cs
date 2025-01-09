using FIT.Data;
using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmNovaDrzavaBrojIndeksa : Form
    {
        private readonly DLWMSDbContext _DLWMSDbContext = SharedBrojIndeksa.DLWMSDbContext;
        private readonly DrzaveBrojIndeksa _drzava;
        private readonly bool _createNew;


        public frmNovaDrzavaBrojIndeksa(DrzaveBrojIndeksa? drzava = null)
        {
            InitializeComponent();

            if (drzava == null)
            {
                _drzava = new();
                _createNew = true;
            }
            else
            {
                _drzava = drzava;
                _createNew = false;
                FillInputs();
            }
        }

        private void FillInputs()
        {
            pbZastava.Image = _drzava.Zastava.ToImage();
            txtNaziv.Text = _drzava.Naziv;
            chbAktivna.Checked = _drzava.Status;
        }

        private void ZastavaPictureBoxDoubleClick(object? sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private bool AreInputsValid()
            => Validator.ProvjeriUnos(pbZastava, errorProvider, Kljucevi.ReqiredValue)
            && Validator.ProvjeriUnos(txtNaziv, errorProvider, Kljucevi.ReqiredValue)
            && Validator.ProvjeriUnos(chbAktivna, errorProvider, Kljucevi.ReqiredValue);

        private void SacuvajBtnClick(object? sender, EventArgs e)
        {
            if (!AreInputsValid())
            {
                return;
            }

            _drzava.Naziv = txtNaziv.Text.Trim();
            _drzava.Zastava = pbZastava.Image.ToByteArray();
            _drzava.Status = chbAktivna.Checked;

            if (_createNew)
            {
                _DLWMSDbContext.Add(_drzava);
            }
            else
            {
                _DLWMSDbContext.Update(_drzava);
            }

            _DLWMSDbContext.SaveChanges();
            Close();
        }
    }
}
