using DLWMS.Data;
using DLWMS.Data.IspitBrojIndeksa;
using DLWMS.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitBrojIndeksa
{
    public partial class frmStipendijaAddEditBrojIndeksa : Form
    {
        private readonly DLWMSContext DB = SharedBrojIndeksa.DB;
        private readonly StudentiStipendijeBrojIndeksa _studentStipendija;
        private readonly bool _isUpdate;

        public frmStipendijaAddEditBrojIndeksa()
        {
            InitializeComponent();
            InitializeFormData();

            _studentStipendija = new StudentiStipendijeBrojIndeksa();
            _isUpdate = false;
        }

        public frmStipendijaAddEditBrojIndeksa(StudentiStipendijeBrojIndeksa studentStipendija)
        {
            InitializeComponent();
            InitializeFormData();

            _studentStipendija = studentStipendija;
            cbStudent.SelectedItem = studentStipendija.Studenti;
            cbStudent.Enabled = false;

            cbGodina.SelectedItem = studentStipendija.Godina.ToString();
            LoadStipendijeGodineIntoComboBox();
            cbStipendijaGodina.SelectedItem = studentStipendija.StipendijeGodineBrojIndeksa;

            _isUpdate = true;
        }

        private void InitializeFormData()
        {
            LoadStudentiIntoComboBox();
            cbGodina.SelectedIndex = 0;
            LoadStipendijeGodineIntoComboBox();
        }

        private void LoadStudentiIntoComboBox()
        {
            var studenti = DB.Studenti.ToList();

            cbStudent.DataSource = studenti;
        }

        private void LoadStipendijeGodineIntoComboBox()
        {
            var godina = cbGodina.SelectedItem.ToString();

            cbStipendijaGodina.DataSource = DB.StipendijeGodine
                              .Include(stipendijaGodina => stipendijaGodina.StipendijeBrojIndeksa)
                              .Where(stipendijaGodina => stipendijaGodina.Godina.ToString() == godina)
                              .ToList();
        }

        private void GodinaComboBoxSelectionChangeCommitted(object sender, EventArgs e)
            => LoadStipendijeGodineIntoComboBox();

        private bool DaLiStudentStipendijaVecPostoji(
            Student student,
            StipendijeGodineBrojIndeksa stipendijaGodina
            ) => DB.StudentiStipendije
                   .Include(studentStipendija => studentStipendija.Studenti)
                   .Include(studentStipendija => studentStipendija.StipendijeGodineBrojIndeksa)
                   .Any(studentStipendija => 
                      studentStipendija != _studentStipendija 
                   && studentStipendija.Studenti == student 
                   && studentStipendija.StipendijeGodineBrojIndeksa == stipendijaGodina);

        private void SacuvajBtnClick(object sender, EventArgs e)
        {
            var student = (Student)cbStudent.SelectedItem;
            var stipendijaGodina = (StipendijeGodineBrojIndeksa)cbStipendijaGodina.SelectedItem;

            if (stipendijaGodina == null)
            {
                MessageBox.Show("Niste odabrali validnu stipendiju", "Greska");
                return;
            }
            else if (DaLiStudentStipendijaVecPostoji(student, stipendijaGodina))
            {
                MessageBox.Show("Student ima vec odabranu stipendiju", "Greska");
                return;
            }

            _studentStipendija.Studenti = student;
            _studentStipendija.StipendijeGodineBrojIndeksa = stipendijaGodina;

            if (_isUpdate) 
            {
                DB.Update(_studentStipendija);
            }
            else 
            {
                DB.Add(_studentStipendija);
            }

            DB.SaveChanges();
            Close();
        }
    }
}
