using DLWMS.Data;
using DLWMS.Data.IspitBrojIndeksa;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using DLWMS.WinApp.Izvjestaji;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitBrojIndeksa
{
    public partial class frmCertifikatiBrojIndeksa : Form
    {
        private readonly DLWMSContext DB = SharedBrojIndeksa.DB;

        public frmCertifikatiBrojIndeksa()
        {
            InitializeComponent();

            dgvCertifikatiGodine.AutoGenerateColumns = false;

            cbGodina.SelectedIndex = 0;
            LoadCertifikatiIntoComboBox();
            LoadCertifikatiGodineIntoDgv();
        }

        private void LoadCertifikatiIntoComboBox()
            => cbCertifikat.DataSource = DB.Certifikati.ToList();

        private void LoadCertifikatiGodineIntoDgv()
        {
            var certifikatiGodine = DB.CertifikatiGodine
                                      .Include(certifikatiGodine => certifikatiGodine.Certifikat)
                                      .ToList();

            dgvCertifikatiGodine.DataSource = certifikatiGodine;
        }

        private bool DoesCertifikatGodinaExist(int godina, CertifikatiBrojIndeksa certifikat)
            => DB.CertifikatiGodine
                 .Include(certifikatiGodine => certifikatiGodine.Certifikat)
                 .Any(certifikatiGodine
                     => certifikatiGodine.Godina == godina
                     && certifikatiGodine.Certifikat == certifikat
                  );

        private bool AreValidInputs()
        {
            int godina = int.Parse(cbGodina.SelectedItem.ToString());
            var certifikat = (CertifikatiBrojIndeksa)cbCertifikat.SelectedItem;
            int mjesecniIznos;

            if (DoesCertifikatGodinaExist(godina, certifikat))
            {
                MessageBox.Show(
                    $"Za odabranu godinu {godina} certifikat {certifikat} vec postoji",
                    "Dupliciranje certifikata za godinu"
                );
                return false;
            }
            else if (!int.TryParse(txtMjesecniIznos.Text, out mjesecniIznos) || mjesecniIznos <= 0)
            {
                MessageBox.Show(
                    "Polje za mjesecni iznos treba biti pozitivan broj",
                    "Nevalidan unos mjesecnog iznosa"
                );
                return false;
            }

            return true;
        }

        private void DodajBtnClick(object? sender, EventArgs e)
        {
            if (!AreValidInputs())
            {
                return;
            }

            int godina = int.Parse(cbGodina.SelectedItem.ToString());
            var certifikat = (CertifikatiBrojIndeksa)cbCertifikat.SelectedItem;
            int mjesecniIznos = int.Parse(txtMjesecniIznos.Text);

            CertifikatiGodineBrojIndeksa certifikatGodina = new()
            {
                Godina = godina,
                Certifikat = certifikat,
                MjesecniIznos = mjesecniIznos,
                Aktivan = true
            };

            DB.Add(certifikatGodina);
            DB.SaveChanges();
            LoadCertifikatiGodineIntoDgv();

            // This is here purely for UX, so when you add something the input is emptied
            txtMjesecniIznos.Text = "";
        }

        private void IzvjestajBtnClick(object? sender, EventArgs e)
        {
            if (dgvCertifikatiGodine.SelectedRows.Count == 0)
            {
                MessageBox.Show("Prije pokretanja radnje odaberite red u data grid view kontroli", "Greska");
                return;
            }

            var certifikatGodina = (CertifikatiGodineBrojIndeksa)dgvCertifikatiGodine.GetOdabraniRed();

            using var frmReportBrojIndeksa = new frmIzvjestaji(certifikatGodina);
            frmReportBrojIndeksa.ShowDialog();
        }

        private bool DoesStudentCertifikatExist(Student student, CertifikatiGodineBrojIndeksa certifikatGodina)
            => DB.StudentiCertifikati
                 .Include(studentiCertifikati => studentiCertifikati.Student)
                 .Include(studentiCertifikati => studentiCertifikati.CertifikatGodina)
                 .ThenInclude(certifikatGodina => certifikatGodina.Certifikat)
                 .Any(studentiCertifikati
                    => studentiCertifikati.CertifikatGodina == certifikatGodina
                    && studentiCertifikati.Student == student
                 );

        private void ScrollToEndOfTxtInfo()
        {
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();
        }

        private void LogToTxtInfo(string message)
        {
            Invoke(
                () =>
                {
                    txtInfo.Text += message;
                    ScrollToEndOfTxtInfo();
                }
            );
        }

        private async Task GenerisiStudentiCertifikati(CertifikatiGodineBrojIndeksa certifikatGodina)
        {
            var studenti = DB.Studenti.ToList();

            for (int i = 0; i < studenti.Count; ++i)
            {
                var student = studenti[i];

                if (DoesStudentCertifikatExist(student, certifikatGodina))
                {
                    LogToTxtInfo($"{i + 1}. {certifikatGodina} vec dodijeljen {student}{Environment.NewLine}");
                    continue;
                }

                StudentiCertifikatiBrojIndeksa studentCertifikat = new()
                {
                    Student = student,
                    CertifikatGodina = certifikatGodina
                };

                DB.Add(studentCertifikat);

                await Task.Delay(300);

                LogToTxtInfo($"{i + 1}. {certifikatGodina} po mjesecnoj cijeni od " +
                $"{certifikatGodina.MjesecniIznos} dodijeljen {student}{Environment.NewLine}");
            }

            DB.SaveChanges();
        }

        private async void GenerisiBtnClick(object? sender, EventArgs e)
        {
            if (dgvCertifikatiGodine.SelectedRows.Count == 0)
            {
                MessageBox.Show("Prije pokretanja radnje odaberite red u data grid view kontroli", "Greska");
                return;
            }

            var certifikatGodina = (CertifikatiGodineBrojIndeksa)dgvCertifikatiGodine.GetOdabraniRed();

            await Task.Run(async () => await GenerisiStudentiCertifikati(certifikatGodina));

            MessageBox.Show("Uspjesno generisani podatci", "Generisanje uspjesno");
            LoadCertifikatiGodineIntoDgv();
        }

        private void CertifikatiGodineDgvCellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var certifikatGodina = (CertifikatiGodineBrojIndeksa)dgvCertifikatiGodine.GetOdabraniRed();

            certifikatGodina.Aktivan = !certifikatGodina.Aktivan;

            DB.Update(certifikatGodina);
            DB.SaveChanges();
            LoadCertifikatiGodineIntoDgv();
        }
    }
}
