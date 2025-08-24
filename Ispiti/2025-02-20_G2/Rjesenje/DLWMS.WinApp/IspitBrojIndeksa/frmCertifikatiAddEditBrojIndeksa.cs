using DLWMS.Data;
using DLWMS.Data.IspitBrojIndeksa;
using DLWMS.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitBrojIndeksa
{
    public partial class frmCertifikatiAddEditBrojIndeksa : Form
    {
        private readonly DLWMSContext DB = SharedBrojIndeksa.DB;
        private readonly StudentiCertifikatiBrojIndeksa _studentiCertifikati;
        private readonly bool _isAdd;

        public frmCertifikatiAddEditBrojIndeksa()
        {
            InitializeComponent();
            LoadDataIntoFormControls();

            _studentiCertifikati = new();
            _isAdd = true;
        }

        public frmCertifikatiAddEditBrojIndeksa(StudentiCertifikatiBrojIndeksa studentiCertifikati)
        {
            InitializeComponent();
            LoadDataIntoFormControls();

            _studentiCertifikati = studentiCertifikati;
            _isAdd = false;

            cbStudent.Enabled = false;
            cbStudent.SelectedItem = _studentiCertifikati.Student;
            cbGodina.SelectedItem = _studentiCertifikati.Godina.ToString();
            LoadCertifikatiGodineIntoComboBox();
            cbCertifikatGodina.SelectedItem = _studentiCertifikati.CertifikatGodina;
        }

        private void LoadDataIntoFormControls()
        {
            LoadStudentiIntoComboBox();
            cbGodina.SelectedIndex = 0;
            LoadCertifikatiGodineIntoComboBox();
        }

        private void LoadStudentiIntoComboBox()
            => cbStudent.DataSource = DB.Studenti.ToList();

        private void LoadCertifikatiGodineIntoComboBox()
        {
            int godina = int.Parse(cbGodina.SelectedItem.ToString());

            cbCertifikatGodina.DataSource = DB.CertifikatiGodine
                                              .Include(certifikatGodina => certifikatGodina.Certifikat)
                                              .Where(certifikatGodina => certifikatGodina.Godina == godina)
                                              .ToList();
        }

        private void GodinaComboBoxSelectionChangeCommitted(object? sender, EventArgs e)
            => LoadCertifikatiGodineIntoComboBox();

        private bool DoesStudentCertifikatExist(Student student, CertifikatiGodineBrojIndeksa certifikatGodina)
            => DB.StudentiCertifikati
                 .Include(studentiCertifikati => studentiCertifikati.Student)
                 .Include(studentiCertifikati => studentiCertifikati.CertifikatGodina)
                 .ThenInclude(certifikatGodina => certifikatGodina.Certifikat)
                 .Any(studentiCertifikati
                    => studentiCertifikati != _studentiCertifikati
                    && studentiCertifikati.CertifikatGodina == certifikatGodina
                    && studentiCertifikati.Student == student
                 );

        private bool AreValidInputs()
        {
            var student = (Student)cbStudent.SelectedItem;
            int godina = int.Parse(cbGodina.SelectedItem.ToString());
            var certifikatGodina = (CertifikatiGodineBrojIndeksa)cbCertifikatGodina.SelectedItem;

            if (certifikatGodina == null)
            {
                MessageBox.Show($"Za odabranu godinu {godina} nema certifikata", "Nema certifikata");
                return false;
            }
            else if (DoesStudentCertifikatExist(student, certifikatGodina))
            {
                MessageBox.Show(
                    $"Za odabranu godinu {godina} student {student} vec ima odabrani certifikat",
                    "Dupliciranje podataka"
                );
                return false;
            }

            return true;
        }

        private void SacuvajBtnClick(object? sender, EventArgs e)
        {
            if (!AreValidInputs())
            {
                return;
            }

            var student = (Student)cbStudent.SelectedItem;
            var certifikatGodina = (CertifikatiGodineBrojIndeksa)cbCertifikatGodina.SelectedItem;

            _studentiCertifikati.Student = student;
            _studentiCertifikati.CertifikatGodina = certifikatGodina;

            if (_isAdd)
            {
                DB.Add(_studentiCertifikati);
            }
            else
            {
                DB.Update(_studentiCertifikati);
            }

            DB.SaveChanges();
            Close();
        }
    }
}
