using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmGradoviBrojIndeksa : Form
    {
        private readonly DLWMSDbContext _DLWMSDbContext = SharedBrojIndeksa.DLWMSDbContext;
        private readonly DrzaveBrojIndeksa _drzava;

        public frmGradoviBrojIndeksa(DrzaveBrojIndeksa drzava)
        {
            InitializeComponent();

            _drzava = drzava;

            SetCurrentDrzavaControls();
            SetDgvProperties();
            LoadGradoviIntoDgv();
        }

        private void SetCurrentDrzavaControls()
        {
            lblNazivDrzave.Text = _drzava.Naziv;
            pbZastava.Image = _drzava.Zastava.ToImage();
        }

        private void SetDgvProperties()
        {
            dgvGradovi.ReadOnly = true;
            dgvGradovi.MultiSelect = false;
            dgvGradovi.AutoGenerateColumns = false;
            dgvGradovi.AllowUserToResizeColumns = false;
            dgvGradovi.AllowUserToResizeRows = false;
            dgvGradovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadGradoviIntoDgv()
        {
            dgvGradovi.DataSource = null;
            dgvGradovi.DataSource = _DLWMSDbContext.Gradovi
                                                   .Include(grad => grad.Drzava)
                                                   .Where(grad => grad.Drzava == _drzava)
                                                   .ToList();
        }

        private void AddGrad(string naziv, bool status)
        {
            GradoviBrojIndeksa grad = new()
            {
                Naziv = naziv,
                Status = status,
                Drzava = _drzava
            };

            _DLWMSDbContext.Add(grad);
            _DLWMSDbContext.SaveChanges();
        }

        private bool DaLiJeNazivGradaValidan(string nazivGrada)
            => nazivGrada.Postavljen()
            && !_DLWMSDbContext.Gradovi.Include(grad => grad.Drzava).Any(grad => grad.Drzava == _drzava && grad.Naziv == nazivGrada);

        private void DodajBtnClick(object? sender, EventArgs e)
        {
            string naziv = txtNazivGrada.Text.Trim();

            if (!DaLiJeNazivGradaValidan(naziv))
            {
                MessageBox.Show("Naziv grada ne smije biti prazan tekst ili postojece ime", "Greska pri dodavanju grada");
                return;
            }

            AddGrad(naziv, true);
            LoadGradoviIntoDgv();
            
            txtNazivGrada.Text = ""; 
        }

        private void ScrollToEndOfTxtInfo()
        {
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();
        }

        private void GenerisiGradove(int brojGradova, bool status)
        {
            for (int i = 1; i <= brojGradova; ++i)
            {
                string naziv = $"Grad {i}.";
                AddGrad(naziv, status);

                Thread.Sleep(300);

                Invoke(
                    () =>
                    {
                        txtInfo.Text += $"{DateTime.Now:dd.MM HH:mm:ss} -> dodat grad {naziv} za drzavu {_drzava.Naziv}{Environment.NewLine}";
                        ScrollToEndOfTxtInfo();
                    }
                );
            }
        }

        private async void GenerisiBtnClick(object? sender, EventArgs e)
        {
            int brojGradova;

            if (!int.TryParse(txtBrojGradova.Text, out brojGradova) || brojGradova <= 0)
            {
                MessageBox.Show("Uneseni broj gradova mora biti pozitivan broj", "Greska pri generisanju");
                return;
            }

            bool status = chbAktivan.Checked;

            // Here I'm gonna assume that we're gonna be patient and wait for this to finish 
            // before doing any other action inside the form, otherwise something will probably
            // break
            await Task.Run(() => GenerisiGradove(brojGradova, status));

            MessageBox.Show("Uspjesno generisani gradovi", "Generisanje gotovo");
            LoadGradoviIntoDgv();
        }

        private void GradoviDgvCellClick(object? sender, DataGridViewCellEventArgs e)
        {
            bool isPromjeniStatusClick = e.ColumnIndex == GradPromjeniStatusBtn.Index; 

            if (e.RowIndex < 0 || !isPromjeniStatusClick)
            {
                return;
            }

            var grad = (GradoviBrojIndeksa)dgvGradovi.Rows[e.RowIndex].DataBoundItem;

            grad.Status = !grad.Status;

            _DLWMSDbContext.Update(grad);
            _DLWMSDbContext.SaveChanges();
            LoadGradoviIntoDgv();
        }
    }
}
