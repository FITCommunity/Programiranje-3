using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmNastavaBrojIndeksa : Form
    {
        private static readonly DLWMSDbContext _DLWMSDbContext = SharedBrojIndeksa.DLWMSDbContext;
        private readonly ProstorijeBrojIndeksa _prostorija;

        public frmNastavaBrojIndeksa(ProstorijeBrojIndeksa prostorija)
        {
            InitializeComponent();

            _prostorija = prostorija;

            SetDgvStyleProperties();
            LoadPredmetiIntoComboBox();
            LoadNastaveIntoDgv();

            cbDan.SelectedIndex = 0;
            cbVrijeme.SelectedIndex = 0;

            lblNazivProstorije.Text = $"{_prostorija.Naziv} - {_prostorija.Oznaka}";
        }

        private void SetDgvStyleProperties()
        {
            dgvNastave.ReadOnly = true;
            dgvNastave.MultiSelect = false;
            dgvNastave.AutoGenerateColumns = false;
            dgvNastave.AllowUserToResizeColumns = false;
            dgvNastave.AllowUserToResizeRows = false;
            dgvNastave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadPredmetiIntoComboBox()
            => cbPredmet.UcitajPodatke(_DLWMSDbContext.Predmeti.ToList());

        private void LoadNastaveIntoDgv()
        {
            dgvNastave.DataSource = null;
            dgvNastave.DataSource = _DLWMSDbContext.Nastave
                                                   .Include(nastava => nastava.Predmet)
                                                   .Include(nastava => nastava.Prostorija)
                                                   .Where(nastava => nastava.Prostorija == _prostorija)
                                                   .ToList();
        }

        private bool DaLiSeIzvodiNastavaUOdabranomTerminu(string dan, string vrijeme)
            => _DLWMSDbContext.Nastave
                              .Include(nastava => nastava.Prostorija)
                              .Any(nastava => nastava.Prostorija == _prostorija 
                                           && nastava.Dan == dan 
                                           && nastava.Vrijeme == vrijeme
                               );

        private void DodajBtnClick(object? sender, EventArgs e)
        {
            var predmet = (PredmetiBrojIndeksa)cbPredmet.SelectedItem;
            string dan = cbDan.SelectedItem.ToString() ?? "";
            string vrijeme = cbVrijeme.SelectedItem.ToString() ?? "";

            if (DaLiSeIzvodiNastavaUOdabranomTerminu(dan, vrijeme))
            {
                MessageBox.Show($"{dan} u {vrijeme} je vec zauzet termin od strane drugog predmeta", "Termin zauzet");
                return;
            }

            NastavaBrojIndeksa nastava = new()
            {
                Predmet = predmet,
                Prostorija = _prostorija,
                Dan = dan,
                Vrijeme = vrijeme,
                Oznaka = $"{predmet.Naziv} :: {dan} :: {vrijeme}"
            };

            _DLWMSDbContext.Add(nastava);
            _DLWMSDbContext.SaveChanges();
            LoadNastaveIntoDgv();
        }
    }
}
