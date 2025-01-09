using FIT.Data;
using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmPorukeBrojIndeksa : Form
    {
        private static readonly DLWMSDbContext _DLWMSDbContext = SharedBrojIndeksa.DLWMSDbContext;
        private readonly Student _student;

        public frmPorukeBrojIndeksa(Student student)
        {
            InitializeComponent();

            _student = student;

            lblPorukeOd.Text = $"Poruke studenta {_student.ImePrezime}";
            SetDgvProperties();
            LoadPorukeIntoDgv();
            LoadPredmetiIntoComboBox();
        }

        private void LoadPredmetiIntoComboBox()
            => cbPredmet.UcitajPodatke(_DLWMSDbContext.Predmeti.ToList());

        private void SetDgvProperties()
        {
            dgvPoruke.ReadOnly = true;
            dgvPoruke.MultiSelect = false;
            dgvPoruke.AutoGenerateColumns = false;
            dgvPoruke.AllowUserToResizeColumns = false;
            dgvPoruke.AllowUserToResizeRows = false;
            dgvPoruke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadPorukeIntoDgv()
        {
            var poruke = _DLWMSDbContext.Poruke
                                        .Include(poruka => poruka.Predmet)
                                        .Include(poruka => poruka.Student)
                                        .Where(poruka =>
                                            poruka.Student == _student
                                         && poruka.Validnost >= DateTime.Now
                                        )
                                        .ToList();

            dgvPoruke.DataSource = null;
            dgvPoruke.DataSource = poruke;

            Text = $"Broj poruka: {poruke.Count}";
            btnDodaj.Enabled = poruke.Count != 0;
        }

        private void NovaPorukaBtnClick(object? sender, EventArgs e)
        {
            using frmNovaPorukaBrojIndeksa frmNovaPorukaBrojIndeksa = new(_student);

            frmNovaPorukaBrojIndeksa.ShowDialog();
            LoadPorukeIntoDgv();
        }

        private void PrintajBtnClick(object? sender, EventArgs e)
        {
            var poruke = (List<StudentiPorukeBrojIndeksa>)dgvPoruke.DataSource;

            using frmPorukaReport frmPorukaReport = new(_student, poruke);
            frmPorukaReport.ShowDialog();
        }

        private void PorukeDgvCellClick(object? sender, DataGridViewCellEventArgs e)
        {
            bool isBrisiClick = e.ColumnIndex == PorukaBrisiBtn.Index;

            if (e.RowIndex < 0 || !isBrisiClick)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Da li ste sigurni da zelite obrisati poruku?",
                "Brisanje poruke",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.No)
            {
                return;
            }

            var poruka = (StudentiPorukeBrojIndeksa)dgvPoruke.Rows[e.RowIndex].DataBoundItem;

            _DLWMSDbContext.Remove(poruka);
            _DLWMSDbContext.SaveChanges();
            LoadPorukeIntoDgv();
        }

        private void DodajPoruku(PredmetiBrojIndeksa predmet, DateTime validnost, string sadrzaj, string hitnost, byte[] slika)
        {
            StudentiPorukeBrojIndeksa poruka = new()
            {
                Student = _student,
                Predmet = predmet,
                Validnost = validnost,
                Sadrzaj = sadrzaj,
                Hitnost = hitnost,
                Slika = slika
            };

            _DLWMSDbContext.Add(poruka);
            _DLWMSDbContext.SaveChanges();
        }

        private void ScrollToEndOfTxtInfo()
        {
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();
        }

        private void GenerisiPoruke(int brojPoruka, PredmetiBrojIndeksa predmet, DateTime validnost, byte[] slika)
        {
            for (int i = 1; i <= brojPoruka; ++i)
            {
                DodajPoruku(predmet, validnost, $"{i}. GENERISANA PORUKA", "Srednja", slika);

                Thread.Sleep(300);

                Invoke(
                    () =>
                    {
                        txtInfo.Text += $"{DateTime.Now:dd/MM/yyyy hh:mm:ss} -> generisana poruka za {_student.ImePrezime} na predmetu {predmet.Naziv}{Environment.NewLine}";
                        ScrollToEndOfTxtInfo();
                    }
                );
            }
        }

        private async void DodajBtnClick(object? sender, EventArgs e)
        {
            int brojPoruka;

            if (!int.TryParse(txtBrojPoruka.Text, out brojPoruka) || brojPoruka <= 0)
            {
                MessageBox.Show("Broj poruka treba biti pozitivan broj", "Broj poruka nije validan");
                return;
            }

            var poruka = (StudentiPorukeBrojIndeksa)dgvPoruke.Rows[0].DataBoundItem;

            var predmet = (PredmetiBrojIndeksa)cbPredmet.SelectedItem;
            DateTime validnost = dtpValidnost.Value;
            byte[] slika = poruka.Slika;

            // Here I'm gonna assume that we're gonna be patient and wait for this to finish 
            // before doing any other action inside the form, otherwise something will probably
            // break
            await Task.Run(() => GenerisiPoruke(brojPoruka, predmet, validnost, slika));

            MessageBox.Show("Poruke su uspjesno generisane", "Uspjeno generisane poruke");
            LoadPorukeIntoDgv();
        }
    }
}
