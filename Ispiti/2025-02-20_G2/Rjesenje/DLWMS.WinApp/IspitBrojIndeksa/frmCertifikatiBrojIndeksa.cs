using DLWMS.Data;
using DLWMS.Data.IspitBrojIndeksa;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitBrojIndeksa
{
    public partial class frmCertifikatiBrojIndeksa : Form
    {
        private readonly DLWMSContext _DLWMSContext = SharedBrojIndeksa.DLWMSContext;

        public frmCertifikatiBrojIndeksa()
        {
            InitializeComponent();

            SetDgvProperties();
            cbGodina.SelectedIndex = 0;
            LoadCertifikatiIntoComboBox();
            LoadCertifikatiGodineIntoDgv();
        }

        private void SetDgvProperties()
        {
            dgvCertifikatiGodine.ReadOnly = true;
            dgvCertifikatiGodine.MultiSelect = false;
            dgvCertifikatiGodine.AllowUserToResizeColumns = false;
            dgvCertifikatiGodine.AllowUserToResizeRows = false;
            dgvCertifikatiGodine.AutoGenerateColumns = false;
            dgvCertifikatiGodine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadCertifikatiIntoComboBox()
            => cbCertifikat.DataSource = _DLWMSContext.Certifikati.ToList();

        private void LoadCertifikatiGodineIntoDgv()
        {
            var certifikatiGodine = _DLWMSContext.CertifikatiGodine
                                                 .Include(certifikatiGodine => certifikatiGodine.Certifikat)
                                                 .ToList();

            dgvCertifikatiGodine.DataSource = certifikatiGodine;
        }

        private bool DoesCertifikatGodinaExist(int godina, CertifikatiBrojIndeksa certifikat)
            => _DLWMSContext.CertifikatiGodine
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

            _DLWMSContext.Add(certifikatGodina);
            _DLWMSContext.SaveChanges();
            LoadCertifikatiGodineIntoDgv();

            txtMjesecniIznos.Text = "";
        }

        private void IzvjestajBtnClick(object? sender, EventArgs e)
        {
            int godina = int.Parse(cbGodina.SelectedItem.ToString());
            var certifikat = (CertifikatiBrojIndeksa)cbCertifikat.SelectedItem;

            using frmReportBrojIndeksa frmReportBrojIndeksa = new(godina, certifikat);
            frmReportBrojIndeksa.ShowDialog();
        }

        private bool DoesStudentCertifikatExist(Student student, CertifikatiGodineBrojIndeksa certifikatGodina)
            => _DLWMSContext.StudentiCertifikati
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

        private void AddStudentCertifikat(Student student, CertifikatiGodineBrojIndeksa certifikatGodina)
        {
            StudentiCertifikatiBrojIndeksa studentCertifikat = new()
            {
                Student = student,
                CertifikatGodina = certifikatGodina 
            };

            _DLWMSContext.Add(studentCertifikat);
            _DLWMSContext.SaveChanges();
        }

        private void GenerisiStudentiCertifikati(List<Student> students, CertifikatiGodineBrojIndeksa certifikatGodina)
        {
            for (int i = 0; i < students.Count; ++i)
            {
                Thread.Sleep(300);

                if (DoesStudentCertifikatExist(students[i], certifikatGodina))
                {
                    LogToTxtInfo($"{i + 1}. {certifikatGodina} vec dodijeljen {students[i]}{Environment.NewLine}");
                }
                else
                {
                    AddStudentCertifikat(students[i], certifikatGodina);
                    LogToTxtInfo($"{i + 1}. {certifikatGodina} po mjesecnoj cijeni od " +
                    $"{certifikatGodina.MjesecniIznos} dodijeljen {students[i]}{Environment.NewLine}");
                }
            }
        }

        private async void GenerisiBtnClick(object? sender, EventArgs e)
        {
            int godina = int.Parse(cbGodina.SelectedItem.ToString());
            var certifikat = (CertifikatiBrojIndeksa)cbCertifikat.SelectedItem;

            List<Student> students = _DLWMSContext.Studenti.ToList();
            CertifikatiGodineBrojIndeksa certifikatGodina;

            try
            {
                certifikatGodina = _DLWMSContext.CertifikatiGodine
                                                 .Include(certifikatiGodine => certifikatiGodine.Certifikat)
                                                 .First(
                                                    certifikatiGodine
                                                       => certifikatiGodine.Godina == godina
                                                       && certifikatiGodine.Certifikat == certifikat
                                                 );
            }
            catch
            {
                MessageBox.Show(
                    $"Za odabranu godinu {godina} nije dodan certifikat {certifikat}",
                    "Nevalidna radnja"
                );
                return;
            }

            await Task.Run(() => GenerisiStudentiCertifikati(students, certifikatGodina));

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

            _DLWMSContext.Update(certifikatGodina);
            _DLWMSContext.SaveChanges();
            LoadCertifikatiGodineIntoDgv();
        }
    }
}
