using FIT.Data;
using FIT.WinForms.Helpers;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmStudentInfoBrojIndeksa : Form
    {
        public frmStudentInfoBrojIndeksa(Student student)
        {
            InitializeComponent();

            Text = student.Indeks;
            pbSlikaStudenta.Image = student.Slika.ToImage();
            lblImePrezime.Text = student.ImePrezime;
            lblProsjek.Text = $"Prosjek: {student.Prosjek}";
        }
    }
}
