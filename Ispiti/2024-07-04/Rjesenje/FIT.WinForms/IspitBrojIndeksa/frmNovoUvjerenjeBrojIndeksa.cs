using FIT.Data;
using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmNovoUvjerenjeBrojIndeksa : Form
    {
        private static readonly DLWMSDbContext _DLWMSDbContext = SharedBrojIndeksa.DLWMSDbContext;
        private readonly Student _student;

        public frmNovoUvjerenjeBrojIndeksa(Student student)
        {
            InitializeComponent();

            _student = student;
        }

        private void UplatnicaPictureBoxDoubleClick(object? sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private bool AreInputsValid()
            => Validator.ProvjeriUnos(cbVrstaUvjerenja, errorProvider, Kljucevi.ReqiredValue)
            && Validator.ProvjeriUnos(txtSvrhaIzdavanja, errorProvider, Kljucevi.ReqiredValue)
            && Validator.ProvjeriUnos(pbUplatnica, errorProvider, Kljucevi.ReqiredValue);

        private void SacuvajBtnClick(object? sender, EventArgs e)
        {
            if (!AreInputsValid())
            {
                return;
            }

            StudentiUvjerenjaBrojIndeksa uvjerenje = new()
            {
                Student = _student,
                VrijemeKreiranja = DateTime.Now,
                Vrsta = cbVrstaUvjerenja.SelectedItem.ToString() ?? "",
                Svrha = txtSvrhaIzdavanja.Text.Trim(),
                Uplatnica = pbUplatnica.Image.ToByteArray(),
                Printano = false
            };

            _DLWMSDbContext.Add(uvjerenje);
            _DLWMSDbContext.SaveChanges();
            Close();
        }
    }
}
