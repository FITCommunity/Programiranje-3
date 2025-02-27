using DLWMS.Data;
using DLWMS.Data.IspitBrojIndeksa;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitBrojIndeksa
{
    public partial class frmPretragaBrojIndeksa : Form
    {
        private readonly DLWMSContext _DLWMSContext = SharedBrojIndeksa.DLWMSContext;

        public frmPretragaBrojIndeksa()
        {
            InitializeComponent();

            SetDgvProperties();
            cbGodina.SelectedIndex = 0;
            LoadCertifikatiGodineIntoComboBox();
            LoadStudentiCertifikatiIntoDgv();
        }

        private void SetDgvProperties()
        {
            dgvStudentiCertifikati.ReadOnly = true;
            dgvStudentiCertifikati.MultiSelect = false;
            dgvStudentiCertifikati.AllowUserToResizeColumns = false;
            dgvStudentiCertifikati.AllowUserToResizeRows = false;
            dgvStudentiCertifikati.AutoGenerateColumns = false;
            dgvStudentiCertifikati.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadCertifikatiGodineIntoComboBox()
        {
            int godina = int.Parse(cbGodina.SelectedItem.ToString());

            cbCertifikatGodina.DataSource = _DLWMSContext.CertifikatiGodine
                                                         .Include(certifikatGodina => certifikatGodina.Certifikat)
                                                         .Where(certifikatGodina => certifikatGodina.Godina == godina)
                                                         .ToList();
        }

        private void LoadStudentiCertifikatiIntoDgv()
        {
            int godina = int.Parse(cbGodina.SelectedItem.ToString());
            var certifikatGodina = (CertifikatiGodineBrojIndeksa)cbCertifikatGodina.SelectedItem;

            // Optional if statement if you ensure the table CertifikatiGodineBrojIndeksa
            // has all the years your defined in the combo box appear from the start
            // I'm adding this condition because I did not do that
            // Since the professor said we can add as much test data as we want it should be legal
            if (certifikatGodina == null)
            {
                MessageBox.Show($"Za odabranu godinu {godina} nema certifikata", "Nema certifikata");
                dgvStudentiCertifikati.DataSource = new List<Student>();
                return;
            }

            var studentiCertifikati = _DLWMSContext.StudentiCertifikati
                                                   .Include(studentiCertifikati => studentiCertifikati.Student)
                                                   .Include(studentiCertifikati => studentiCertifikati.CertifikatGodina)
                                                   .ThenInclude(certifikatGodina => certifikatGodina.Certifikat)
                                                   .Where(studentiCertifikati => studentiCertifikati.CertifikatGodina == certifikatGodina)
                                                   .ToList();

            dgvStudentiCertifikati.DataSource = studentiCertifikati;

            if (studentiCertifikati.Count == 0)
            {
                MessageBox.Show($"Za godinu {godina} certifikat {certifikatGodina} nema studenata", "Nema studenata");
            }
            Text = $"Broj prikazanih studenata: {studentiCertifikati.Count}";
        }

        private void GodineComboBoxSelectionChangeCommitted(object? sender, EventArgs e)
        {
            LoadCertifikatiGodineIntoComboBox();
            LoadStudentiCertifikatiIntoDgv();
        }

        private void CertifikatGodinaSelectionChangeCommitted(object? sender, EventArgs e)
            => LoadStudentiCertifikatiIntoDgv();

        private void CertifikatiPoGodinamaBtnClick(object? sender, EventArgs e)
        {
            using frmCertifikatiBrojIndeksa frmCertifikatiBrojIndeksa = new();
            frmCertifikatiBrojIndeksa.ShowDialog();
            LoadCertifikatiGodineIntoComboBox();
        }

        private void StudentiCertifikatiDgvCellClick(object? sender, DataGridViewCellEventArgs e)
        {
            bool isUkloniClicked = e.ColumnIndex == StudentCertifikatUkloniBtn.Index;

            if (e.RowIndex < 0 || !isUkloniClicked)
            {
                return;
            }

            var studentCertifikat = (StudentiCertifikatiBrojIndeksa)dgvStudentiCertifikati.GetOdabraniRed(); ;

            DialogResult result = MessageBox.Show(
                $"Da li ste sigurni da zelite obrisati za studenta {studentCertifikat.Student} certifikat {studentCertifikat.CertifikatGodina}?",
                "Brisanje certifikata za studenta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return;
            }

            _DLWMSContext.Remove(studentCertifikat);
            _DLWMSContext.SaveChanges();
            LoadStudentiCertifikatiIntoDgv();
        }

        private void OpenFrmAddEditCertifikati(StudentiCertifikatiBrojIndeksa? studentiCertifikati = null)
        {
            using frmCertifikatiAddEditBrojIndeksa frmCertifikatiAddEditBrojIndeksa = new(studentiCertifikati);
            frmCertifikatiAddEditBrojIndeksa.ShowDialog();
            LoadStudentiCertifikatiIntoDgv();
        }

        private void AddCertifikatBtnClick(object? sender, EventArgs e)
            => OpenFrmAddEditCertifikati();


        private void StudentiCertifikatiDgvCellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var studentCertifikat = (StudentiCertifikatiBrojIndeksa)dgvStudentiCertifikati.GetOdabraniRed(); ;

            OpenFrmAddEditCertifikati(studentCertifikat);
        }
    }
}
