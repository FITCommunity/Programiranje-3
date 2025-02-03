using DLWMS.Data;
using DLWMS.Data.IspitBrojIndeksa;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitBrojIndeksa
{
    public partial class frmRazmjeneBrojIndeksa : Form
    {
        private readonly DLWMSContext _DLWMSContext = SharedBrojIndeksa.DLWMSContext;
        private readonly Student _student;

        public frmRazmjeneBrojIndeksa(Student student)
        {
            InitializeComponent();

            _student = student;

            Text = $"Razmjena studenta {_student.IndeksImePrezime}";

            SetDgvProperties();
            LoadDrzaveIntoDgv();
            LoadUniverzitetiIntoDgv(cbUniverzitet);
            LoadUniverzitetiIntoDgv(gcbUniverzitet);
            LoadRazmjeneIntoDgv();
        }

        private void SetDgvProperties()
        {
            dgvRazmjene.ReadOnly = true;
            dgvRazmjene.MultiSelect = false;
            dgvRazmjene.AutoGenerateColumns = false;
            dgvRazmjene.AllowUserToResizeColumns = false;
            dgvRazmjene.AllowUserToResizeRows = false;
            dgvRazmjene.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadDrzaveIntoDgv()
        {
            cbDrzava.UcitajPodatke(
                   _DLWMSContext.Drzave
                                .Include(drzava => drzava.Gradovi)
                                .Include(drzava => drzava.Univerziteti)
                                .ToList()
            );
        }

        private void LoadUniverzitetiIntoDgv(ComboBox comboBox) 
        {
            var drzava = (Drzava)cbDrzava.SelectedItem;

            comboBox.UcitajPodatke(
                _DLWMSContext.Univerziteti
                             .Include(univerzitet => univerzitet.Drzava)
                             .Where(univerzitet => univerzitet.Drzava == drzava)
                             .ToList()
            );
        }

        private void LoadRazmjeneIntoDgv() 
        {
            var razmjene = _DLWMSContext.Razmjene
                                        .Include(razmjena => razmjena.Student)
                                        .Include(razmjena => razmjena.Univerzitet)
                                        .Where(razmjena => razmjena.Student == _student)
                                        .ToList();

            dgvRazmjene.DataSource = null;
            dgvRazmjene.DataSource = razmjene;
        }

        private bool DoDatesOverlap(DateTime start1, DateTime end1, DateTime start2, DateTime end2)
        {
            return start1 <= end2 && start2 <= end1;
        }

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
        {
            LoadUniverzitetiIntoDgv(cbUniverzitet);
            LoadUniverzitetiIntoDgv(gcbUniverzitet);
        }

        private void PotvrdaBtnClick(object? sender, EventArgs e)
        {
            using frmRazmjenaReportBrojIndeksa frmRazmjenaReportBrojIndeksa = new(_student);
            frmRazmjenaReportBrojIndeksa.ShowDialog();
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

            _DLWMSContext.Add(razmjena);
            _DLWMSContext.SaveChanges();
        }

        private void ScrollToEndOfTxtInfo()
        {
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();
        }

        private void GenerisiRazmjene(
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

                Thread.Sleep(300);

                Invoke(
                    () => 
                    {
                        txtInfo.Text += $"{i}. razmjena za {_student.IndeksImePrezime} na {univerzitet} " +
                        $"({pocetak:dd.MM.yyyy} - {kraj:dd.MM.yyyy}){Environment.NewLine}";
                        ScrollToEndOfTxtInfo();
                    }
                );
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

            LoadRazmjeneIntoDgv();
        }

        private void RazmjeneDgvCellClick(object? sender, DataGridViewCellEventArgs e)
        {
            bool isObrisiClick = e.ColumnIndex == RazmjenaObrisiBtn.Index;

            if (e.RowIndex < 0)
            {
                return;
            }

            var razmjena = (RazmjeneBrojIndeksa)dgvRazmjene.Rows[e.RowIndex].DataBoundItem;

            DialogResult result = MessageBox.Show(
                $"Da li ste sigurni da zelite obrisati podatke o razmjeni {_student.IndeksImePrezime} na"
                + $"{razmjena.Univerzitet.Naziv} ({razmjena.Univerzitet.Drzava})",
                "Upit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return;
            }

            _DLWMSContext.Remove(razmjena);
            _DLWMSContext.SaveChanges();
            LoadRazmjeneIntoDgv();
        }
    }
}
