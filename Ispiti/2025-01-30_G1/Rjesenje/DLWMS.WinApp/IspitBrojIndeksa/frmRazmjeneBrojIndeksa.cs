using DLWMS.Data;
using DLWMS.Data.IspitBrojIndeksa;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using DLWMS.WinApp.Izvjestaji;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitBrojIndeksa
{
    public partial class frmRazmjeneBrojIndeksa : Form
    {
        private readonly DLWMSContext DB = SharedBrojIndeksa.DB;
        private readonly Student _student;

        public frmRazmjeneBrojIndeksa(Student student)
        {
            InitializeComponent();

            _student = student;

            Text = $"Razmjena studenta {_student.IndeksImePrezime}";

            dgvRazmjene.AutoGenerateColumns = false;

            LoadDrzaveIntoComboBox();
            LoadUniverzitetiIntoComboBox();
            LoadRazmjeneIntoDgv();

            gcbUniverzitet.DataSource = DB.Univerziteti.ToList();
        }

        private void LoadDrzaveIntoComboBox()
            => cbDrzava.UcitajPodatke(
                   DB.Drzave
                     .Include(drzava => drzava.Gradovi)
                     .Include(drzava => drzava.Univerziteti)
                     .ToList()
               );

        private void LoadUniverzitetiIntoComboBox()
        {
            var drzava = (Drzava)cbDrzava.SelectedItem;

            cbUniverzitet.UcitajPodatke(
                DB.Univerziteti
                  .Include(univerzitet => univerzitet.Drzava)
                  .Where(univerzitet => univerzitet.Drzava == drzava)
                  .ToList()
            );
        }

        private void LoadRazmjeneIntoDgv()
        {
            var razmjene = DB.Razmjene
                             .Include(razmjena => razmjena.Student)
                             .Include(razmjena => razmjena.Univerzitet)
                             .Where(razmjena => razmjena.Student == _student)
                             .ToList();

            dgvRazmjene.DataSource = razmjene;
        }

        private static bool DoDatesOverlap(DateTime start1, DateTime end1, DateTime start2, DateTime end2)
            => start1 <= end2 && start2 <= end1;

        private bool DoesRazmjenaPeriodOverlap(DateTime pocetak, DateTime kraj)
        {
            var razmjene = (List<RazmjeneBrojIndeksa>)dgvRazmjene.DataSource;

            return razmjene.Any(razmjena => DoDatesOverlap(pocetak, kraj, razmjena.Pocetak, razmjena.Kraj));
        }

        private bool AreInputsValid()
        {
            var univerzitet = (UniverzitetBrojIndeksa)cbUniverzitet.SelectedItem;
            DateTime pocetak = dtpPocetak.Value;
            DateTime kraj = dtpKraj.Value;

            if (univerzitet == null)
            {
                MessageBox.Show(
                    "Odabrana drzava nema univerziteta za ponudu, probajte odabrati drugaciju drzavu",
                    "Greska pri odaberu univerziteta"
                );
                return false;
            }
            else if (!int.TryParse(txtECTS.Text, out int ects) || ects <= 0)
            {
                MessageBox.Show("Broj kredita treba biti pozitivan broj", "Greska pri unosu broja kredita");
                return false;
            }
            else if (kraj < pocetak)
            {
                MessageBox.Show("Datum kraja ne smije biti prija datuma pocetka", "Greska pri unosu datuma kraja");
                return false;
            }
            else if (DoesRazmjenaPeriodOverlap(pocetak, kraj))
            {
                MessageBox.Show("Periodi razmjene se preklapaju", "Greska pri unosu perioda nastave");
                return false;
            }

            return true;
        }

        private void SacuvajBtnClick(object? sender, EventArgs e)
        {
            if (!AreInputsValid())
            {
                return;
            }

            var univerzitet = (UniverzitetBrojIndeksa)cbUniverzitet.SelectedItem;
            int ects = int.Parse(txtECTS.Text);
            DateTime pocetak = dtpPocetak.Value;
            DateTime kraj = dtpKraj.Value;

            DodajRazmjenu(univerzitet, ects, pocetak, kraj);
            LoadRazmjeneIntoDgv();
        }

        private void DrzavaComboBoxSelectionChangeCommitted(object? sender, EventArgs e)
            => LoadUniverzitetiIntoComboBox();

        private void PotvrdaBtnClick(object? sender, EventArgs e)
        {
            using var formaIzvjestaj = new frmIzvjestaji(_student);
            formaIzvjestaj.ShowDialog();
        }

        private void DodajRazmjenu(UniverzitetBrojIndeksa univerzitet, int ects, DateTime pocetak, DateTime kraj)
        {
            RazmjeneBrojIndeksa razmjena = new()
            {
                Student = _student,
                Univerzitet = univerzitet,
                Pocetak = pocetak,
                Kraj = kraj,
                ECTS = ects,
                Okoncano = kraj < DateTime.Now
            };

            DB.Add(razmjena);
            DB.SaveChanges();
        }

        private void ScrollToEndOfTxtInfo()
        {
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();
        }

        private void LogToTxtInfo(string text)
        {
            Invoke(
                () =>
                {
                    txtInfo.Text += text;
                    ScrollToEndOfTxtInfo();
                }
            );
        }

        private async Task GenerisiRazmjene(
            int brojRazmjena,
            UniverzitetBrojIndeksa univerzitet,
            int ects,
            DateTime pocetak,
            DateTime kraj
        )
        {
            for (int i = 1; i <= brojRazmjena; ++i)
            {
                kraj = kraj.AddDays(1);

                DodajRazmjenu(univerzitet, ects, pocetak, kraj);

                await Task.Delay(300);

                LogToTxtInfo($"{i}. razmjena za {_student.IndeksImePrezime} na {univerzitet} " +
                    $"({pocetak:dd.MM.yyyy} - {kraj:dd.MM.yyyy}){Environment.NewLine}");

                Invoke(LoadRazmjeneIntoDgv);
            }
        }

        private async void GenerisiBtnClick(object? sender, EventArgs e)
        {
            int brojRazmjena;
            int ects;

            if (!int.TryParse(txtBrojRazmjena.Text, out brojRazmjena) || brojRazmjena <= 0)
            {
                MessageBox.Show("Broj razmjena treba biti pozitivan broj", "Greska pri unosu broja razmjena");
                return;
            }
            else if (!int.TryParse(gtxtECTS.Text, out ects) || ects <= 0)
            {
                MessageBox.Show("Broj kredita treba biti pozitivan broj", "Greska pri unosu broja kredita");
                return;
            }

            var univerzitet = (UniverzitetBrojIndeksa)gcbUniverzitet.SelectedItem;
            DateTime pocetak = new(2025, 1, 1);
            DateTime kraj = pocetak.AddDays(ects);

            await Task.Run(() => GenerisiRazmjene(brojRazmjena, univerzitet, ects, pocetak, kraj));

            MessageBox.Show("Uspjesno generisane razmjene", "Generisanje gotovo");
        }

        private void RazmjeneDgvCellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != ObrisiBtn.Index)
            {
                return;
            }

            var razmjena = (RazmjeneBrojIndeksa)dgvRazmjene.GetOdabraniRed();

            DialogResult dialogResult = MessageBox.Show(
                $"Da li ste sigurni da zelite obrisati podatke o razmjeni {_student.IndeksImePrezime} na"
                + $"{razmjena.Univerzitet.Naziv} ({razmjena.Univerzitet.Drzava})",
                "Upit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Yes)
            {
                DB.Remove(razmjena);
                DB.SaveChanges();
                LoadRazmjeneIntoDgv();
            }
        }
    }
}
