using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitBrojIndeksa
{
    public partial class frmStudentEditBrojIndeksa : Form
    {
        private readonly DLWMSContext _DLWMSContext = SharedBrojIndeksa.DLWMSContext;
        private readonly Student _student;

        public frmStudentEditBrojIndeksa(Student student)
        {
            InitializeComponent();

            _student = student;

            LoadDrzavaIntoComboBox();
            FillStudentData();
        }

        private void LoadDrzavaIntoComboBox()
            => cbDrzava.UcitajPodatke(_DLWMSContext.Drzave.Include(drzava => drzava.Gradovi).ToList());

        private void LoadGradIntoComboBox()
        {
            var drzava = (Drzava)cbDrzava.SelectedItem;

            cbGrad.UcitajPodatke(
                _DLWMSContext.Gradovi
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

            _DLWMSContext.Update(_student);
            _DLWMSContext.SaveChanges();
            Close();
        }

        private void cbDrzava_SelectionChangeCommitted(object? sender, EventArgs e)
            => LoadGradIntoComboBox();
    }
}
