using FIT.Data;
using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmUvjerenjaBrojIndeksa : Form
    {
        private static readonly DLWMSDbContext _DLWMSDbContext = SharedBrojIndeksa.DLWMSDbContext;
        private readonly Student _student;

        public frmUvjerenjaBrojIndeksa(Student student)
        {
            InitializeComponent();

            _student = student;

            SetDgvProperties();
            LoadUvjerenjaIntoDgv();
        }

        private void SetDgvProperties()
        {
            dgvUvjerenja.ReadOnly = true;
            dgvUvjerenja.MultiSelect = false;
            dgvUvjerenja.AutoGenerateColumns = false;
            dgvUvjerenja.AllowUserToResizeColumns = false;
            dgvUvjerenja.AllowUserToResizeRows = false;
            dgvUvjerenja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadUvjerenjaIntoDgv()
        {
            var uvjerenja = _DLWMSDbContext.Uvjerenja
                                           .Include(uvjerenje => uvjerenje.Student)
                                           .Where(uvjerenje => uvjerenje.Student == _student)
                                           .ToList();

            dgvUvjerenja.DataSource = null;
            dgvUvjerenja.DataSource = uvjerenja;

            Text = $"Broj uvjerenja -> {uvjerenja.Count}";
            btnDodaj.Enabled = uvjerenja.Count != 0;
        }

        private void NoviZahtjevBtnClick(object? sender, EventArgs e)
        {
            using frmNovoUvjerenjeBrojIndeksa frmNovoUvjerenjeBrojIndeksa = new(_student);
            frmNovoUvjerenjeBrojIndeksa.ShowDialog();
            LoadUvjerenjaIntoDgv();
        }

        private bool AreInputsValid()
             => Validator.ProvjeriUnos(cbVrstaUvjerenja, errorProvider, Kljucevi.ReqiredValue)
             && Validator.ProvjeriUnos(txtSvrhaIzdavanja, errorProvider, Kljucevi.ReqiredValue)
             && Validator.ProvjeriUnos(txtBrojZahtjeva, errorProvider, Kljucevi.ReqiredValue);

        private void AddUvjerenje(string vrsta, string svrha, byte[] uplatnica)
        {
            StudentiUvjerenjaBrojIndeksa uvjerenje = new()
            {
                Student = _student,
                VrijemeKreiranja = DateTime.Now,
                Vrsta = vrsta,
                Svrha = svrha,
                Uplatnica = uplatnica,
                Printano = false
            };

            _DLWMSDbContext.Add(uvjerenje);
            _DLWMSDbContext.SaveChanges();
        }

        private void ScrollToEndOfTxtInfo()
        {
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();
        }

        private void GenerisiUvjerenja(int brojZahtjeva, string vrsta, string svrha, byte[] uplatnica)
        {
            for (int i = 0; i < brojZahtjeva; ++i)
            {
                AddUvjerenje(vrsta, svrha, uplatnica);

                Thread.Sleep(300);

                Invoke(
                    () => 
                    {
                        txtInfo.Text += $"{DateTime.Now:HH:mm:ss} -> {vrsta} studentu ({_student.Indeks}) - {_student.ImePrezime} u svrhu {svrha}{Environment.NewLine}";
                        ScrollToEndOfTxtInfo();
                    }   
                );
            }
        }

        private async void DodajBtnClick(object? sender, EventArgs e)
        {
            int brojZahtjeva;

            // The validations below are optional
            if (!AreInputsValid())
            {
                return;
            }
            else if (!int.TryParse(txtBrojZahtjeva.Text, out brojZahtjeva) || brojZahtjeva <= 0)
            {
                errorProvider.SetError(txtBrojZahtjeva, "Broj zahtjeva treba biti pozitivan broj");
                return;
            }
            else
            {
                errorProvider.Clear();
            }

            var uvjerenje = (StudentiUvjerenjaBrojIndeksa)dgvUvjerenja.Rows[0].DataBoundItem;
            string vrsta = cbVrstaUvjerenja.SelectedItem.ToString() ?? "";
            string svrha = txtSvrhaIzdavanja.Text.Trim();
            byte[] uplatnica = uvjerenje.Uplatnica;

            await Task.Run(() => GenerisiUvjerenja(brojZahtjeva, vrsta, svrha, uplatnica));

            MessageBox.Show("Uspjesno generisana uvjerenja", "Generisanje uspjesno");
            LoadUvjerenjaIntoDgv();
        }

        private void UvjerenjaDgvCellClick(object? sender, DataGridViewCellEventArgs e)
        {
            bool isBrisiClick = e.ColumnIndex == UvjerenjeBrisiBtn.Index;
            bool isPrintajClick = e.ColumnIndex == UvjerenjePrintajBtn.Index;

            if (e.RowIndex < 0 || (!isBrisiClick && !isPrintajClick))
            {
                return;
            }

            var uvjerenje = (StudentiUvjerenjaBrojIndeksa)dgvUvjerenja.Rows[e.RowIndex].DataBoundItem;

            if (isBrisiClick)
            {
                DialogResult result = MessageBox.Show(
                    "Da li ste sigurni da zelite izbrisati odabrano uvjerenje?",
                    "Brisanje uvjerenja",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    _DLWMSDbContext.Remove(uvjerenje);
                }
            }
            else
            {
                using frmUvjerenjeReportBrojIndeksa frmUvjerenjeReportBrojIndeksa = new(_student, uvjerenje);
                frmUvjerenjeReportBrojIndeksa.ShowDialog();
                uvjerenje.Printano = true;
            }

            _DLWMSDbContext.SaveChanges();
            LoadUvjerenjaIntoDgv();
        }
    }
}
