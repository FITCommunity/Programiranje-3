using DLWMS.Data.IspitBrojIndeksa;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitBrojIndeksa
{
    public partial class frmPretragaBrojIndeksa : Form
    {
        private readonly DLWMSContext DB = SharedBrojIndeksa.DB;

        public frmPretragaBrojIndeksa()
        {
            InitializeComponent();

            dgvStudentiCertifikati.AutoGenerateColumns = false;

            cbGodina.SelectedIndex = 0;
            LoadCertifikatiGodineIntoComboBox();
            LoadStudentiCertifikatiIntoDgv();
        }

        private void LoadCertifikatiGodineIntoComboBox()
        {
            int godina = int.Parse(cbGodina.SelectedItem.ToString());

            cbCertifikatGodina.DataSource = DB.CertifikatiGodine
                                              .Include(certifikatGodina => certifikatGodina.Certifikat)
                                              .Where(certifikatGodina => certifikatGodina.Godina == godina)
                                              .ToList();
        }

        private void LoadStudentiCertifikatiIntoDgv()
        {
            var certifikatGodina = (CertifikatiGodineBrojIndeksa)cbCertifikatGodina.SelectedItem;

            var studentiCertifikati = DB.StudentiCertifikati
                                        .Include(studentiCertifikati => studentiCertifikati.Student)
                                        .Include(studentiCertifikati => studentiCertifikati.CertifikatGodina)
                                        .ThenInclude(certifikatGodina => certifikatGodina.Certifikat)
                                        .Where(studentiCertifikati => 
                                                studentiCertifikati.CertifikatGodina == certifikatGodina
                                         )
                                        .ToList();

            dgvStudentiCertifikati.DataSource = studentiCertifikati;
            Text = $"Broj prikazanih zapisa: {studentiCertifikati.Count}";

            if (studentiCertifikati.Count == 0)
            {
                string godina = cbGodina.SelectedItem.ToString();
                string certifikatGodinaNaziv = certifikatGodina?.ToString() ?? "'Nema certifikata'";

                MessageBox.Show(
                    $"Za godinu {godina} certifikat {certifikatGodinaNaziv} nema studenata", 
                    "Nema studenata"
                );
            }
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
            using var formaCertifikat = new frmCertifikatiBrojIndeksa();
            formaCertifikat.ShowDialog();
            LoadCertifikatiGodineIntoComboBox();
        }

        private void StudentiCertifikatiDgvCellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != UkloniBtn.Index)
            {
                return;
            }

            var studentCertifikat = (StudentiCertifikatiBrojIndeksa)dgvStudentiCertifikati.GetOdabraniRed(); ;

            DialogResult dialogResult = MessageBox.Show(
                $"Da li ste sigurni da zelite obrisati za studenta {studentCertifikat.Student} certifikat {studentCertifikat.CertifikatGodina}?",
                "Brisanje certifikata za studenta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Yes)
            {
                DB.Remove(studentCertifikat);
                DB.SaveChanges();
                LoadStudentiCertifikatiIntoDgv();
            }
        }

        private void AddCertifikatBtnClick(object? sender, EventArgs e)
        {
            using var formaAdd = new frmCertifikatiAddEditBrojIndeksa();
            formaAdd.ShowDialog();
            LoadStudentiCertifikatiIntoDgv();
        }

        private void StudentiCertifikatiDgvCellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var studentCertifikat = (StudentiCertifikatiBrojIndeksa)dgvStudentiCertifikati.GetOdabraniRed(); ;

            using var formaEdit = new frmCertifikatiAddEditBrojIndeksa(studentCertifikat);
            formaEdit.ShowDialog();
            LoadStudentiCertifikatiIntoDgv();
        }
    }
}
