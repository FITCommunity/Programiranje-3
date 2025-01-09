using FIT.Data;
using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmPrisustvoBrojIndeksa : Form
    {
        private static readonly DLWMSDbContext _DLWMSDbContext = SharedBrojIndeksa.DLWMSDbContext;
        private readonly ProstorijeBrojIndeksa _prostorija;

        public frmPrisustvoBrojIndeksa(ProstorijeBrojIndeksa prostorija)
        {
            InitializeComponent();

            _prostorija = prostorija;

            SetDgvStyleProperties();
            LoadStudentiIntoComboBox();
            LoadNastaveIntoComboBox();
            LoadPrisustvaIntoDgv();

            lblNazivProstorije.Text = $"{_prostorija.Naziv} - {_prostorija.Oznaka}";
        }

        private void SetDgvStyleProperties()
        {
            dgvPrisustva.ReadOnly = true;
            dgvPrisustva.MultiSelect = false;
            dgvPrisustva.AutoGenerateColumns = false;
            dgvPrisustva.AllowUserToResizeColumns = false;
            dgvPrisustva.AllowUserToResizeRows = false;
            dgvPrisustva.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadStudentiIntoComboBox()
        {
            cbStudent.DataSource = null;
            cbStudent.DataSource = _DLWMSDbContext.Studenti
                                                  .ToList();
        }

        private void LoadNastaveIntoComboBox()
        {
            var nastave = _DLWMSDbContext.Nastave
                                         .Include(nastava => nastava.Prostorija)
                                         .Where(nastava => nastava.Prostorija == _prostorija)
                                         .ToList();

            cbNastava.UcitajPodatke(nastave, "Oznaka");
        }

        private void LoadPrisustvaIntoDgv()
        {
            var nastava = (NastavaBrojIndeksa)cbNastava.SelectedItem;
            var prisustva = _DLWMSDbContext.Prisustvo
                                           .Include(prisustvo => prisustvo.Nastava)
                                           .ThenInclude(nastava => nastava.Predmet)
                                           .Where(prisustvo => prisustvo.Nastava == nastava)
                                           .ToList();

            dgvPrisustva.DataSource = null;
            dgvPrisustva.DataSource = prisustva;

            lblKapacitet.Text = $"{prisustva.Count}/{_prostorija.Kapacitet}";
        }

        private bool DaLiJeStudentEvidentiranNaNastavi(Student student, NastavaBrojIndeksa nastava)
            => _DLWMSDbContext.Prisustvo
                              .Include(prisustvo => prisustvo.Nastava)
                              .Include(prisustvo => prisustvo.Student)
                              .Any(prisustvo => prisustvo.Student == student && prisustvo.Nastava == nastava);

        private bool DaLiJeKapacitetPrekoracen(int count)
            => dgvPrisustva.Rows.Count + count > _prostorija.Kapacitet;

        private void AddPrisustvo(Student student, NastavaBrojIndeksa nastava)
        {
            PrisustvoBrojIndeksa prisustvo = new()
            {
                Nastava = nastava,
                Student = student
            };

            _DLWMSDbContext.Add(prisustvo);
            _DLWMSDbContext.SaveChanges();
        }

        private void DodajBtnClick(object? sender, EventArgs e)
        {
            var nastava = (NastavaBrojIndeksa)cbNastava.SelectedItem;
            var student = (Student)cbStudent.SelectedItem;

            if (DaLiJeStudentEvidentiranNaNastavi(student, nastava))
            {
                MessageBox.Show("Student je vec evidentiran na nastavi", "Ponavljanje evidencije");
                return;
            }
            else if (DaLiJeKapacitetPrekoracen(1))
            {
                MessageBox.Show($"{nastava} ima pun kapacitet", "Kapacitet pun");
                return;
            }

            AddPrisustvo(student, nastava);
            LoadPrisustvaIntoDgv();
        }

        private void ScrollToEndOfTxtInfo()
        {
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();
        }

        private void GenerisiPrisustva(int brojZapisa, Student student, NastavaBrojIndeksa nastava)
        {
            for (int i = 0; i < brojZapisa; ++i)
            {
                AddPrisustvo(student, nastava);

                Thread.Sleep(300);

                Invoke(
                    () =>
                    {
                        txtInfo.Text += $"{DateTime.Now:dd.MM HH:mm:ss} -> {student} za {nastava}{Environment.NewLine}";
                        ScrollToEndOfTxtInfo();
                    }
                );
            }
        }

        private async void GenerisiBtnClick(object? sender, EventArgs e)
        {
            int brojZapisa;

            if (!int.TryParse(txtBrojZapisa.Text, out brojZapisa) || brojZapisa <= 0)
            {
                MessageBox.Show("Kapacitet treba biti pozitivan broj", "Nevalidan kapacitet");
                return;
            }
            
            var nastava = (NastavaBrojIndeksa)cbNastava.SelectedItem;
            
            if (DaLiJeKapacitetPrekoracen(brojZapisa))
            {
                MessageBox.Show(
                    $"Za {nastava} se ne moze dodati {brojZapisa} prisustava, jer ce prekoraciti kapacitet", 
                    "Kapacitet pun"
                );
                return;
            }

            var student = (Student)cbStudent.SelectedItem;

            await Task.Run(() => GenerisiPrisustva(brojZapisa, student, nastava));

            MessageBox.Show("Uspjesno generisana prisustva", "Generisanje zavrseno");
            LoadPrisustvaIntoDgv();
        }

        private void NastavaComboBoxSelectedIndexChanged(object? sender, EventArgs e)
            => LoadPrisustvaIntoDgv();
    }
}
