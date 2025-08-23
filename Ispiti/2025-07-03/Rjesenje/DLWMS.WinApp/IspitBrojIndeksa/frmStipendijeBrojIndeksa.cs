using DLWMS.Data;
using DLWMS.Data.IspitBrojIndeksa;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using DLWMS.WinApp.Izvjestaji;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitBrojIndeksa
{
    public partial class frmStipendijeBrojIndeksa : Form
    {
        private readonly DLWMSContext DB = SharedBrojIndeksa.DB;

        public frmStipendijeBrojIndeksa()
        {
            InitializeComponent();

            dgvStipendijeGodine.AutoGenerateColumns = false;
            cbGodina.SelectedIndex = 0;
            LoadStipendijeIntoComboBox();
            LoadStipendijeGodineIntoDgv();
        }

        private void LoadStipendijeIntoComboBox()
        {
            var stipendije = DB.Stipendije.ToList();

            cbStipendija.DataSource = stipendije;
        }

        private void LoadStipendijeGodineIntoDgv()
        {
            var stipendijeGodine = DB.StipendijeGodine
                                     .Include(stipendijeGodine => stipendijeGodine.StipendijeBrojIndeksa)
                                     .ToList();

            dgvStipendijeGodine.DataSource = stipendijeGodine;
        }

        private bool DaLiStipendijaGodinaPostoji(StipendijeBrojIndeksa stipendija, string godina)
            => DB.StipendijeGodine
                 .Include(stipendijaGodina => stipendijaGodina.StipendijeBrojIndeksa)
                 .Any(stipendijaGodina =>
                        stipendijaGodina.StipendijeBrojIndeksa == stipendija
                     && stipendijaGodina.Godina.ToString() == godina);

        private void DodajBtnClick(object sender, EventArgs e)
        {
            var stipendija = (StipendijeBrojIndeksa)cbStipendija.SelectedItem;
            var godina = cbGodina.SelectedItem.ToString();
            int mjesecniIznos;

            if (!int.TryParse(txtMjesecniIznos.Text, out mjesecniIznos) || mjesecniIznos <= 0)
            {
                MessageBox.Show("Mjesecni iznos nije validan pozitivni broj", "Greska");
                return;
            }
            else if (DaLiStipendijaGodinaPostoji(stipendija, godina))
            {
                MessageBox.Show("Stipendija postoji za datu godinu", "Greska");
                return;
            }

            var stipendijaGodina = new StipendijeGodineBrojIndeksa()
            {
                StipendijeBrojIndeksa = stipendija,
                Godina = int.Parse(godina),
                MjesecniIznos = mjesecniIznos,
                Aktivna = true
            };

            DB.Add(stipendijaGodina);
            DB.SaveChanges();
            LoadStipendijeGodineIntoDgv();
        }

        private void StipendijeGodineDgvCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var stipendijaGodina = (StipendijeGodineBrojIndeksa)dgvStipendijeGodine.GetOdabraniRed();

            stipendijaGodina.Aktivna = !stipendijaGodina.Aktivna;

            DB.Update(stipendijaGodina);
            DB.SaveChanges();
            LoadStipendijeGodineIntoDgv();
        }

        private bool DaLiStudentStipendijaVecPostoji(
            Student student,
            StipendijeGodineBrojIndeksa stipendijaGodina
            ) => DB.StudentiStipendije
                   .Include(studentStipendija => studentStipendija.Studenti)
                   .Include(studentStipendija => studentStipendija.StipendijeGodineBrojIndeksa)
                   .Any(studentStipendija =>
                      studentStipendija.Studenti == student
                   && studentStipendija.StipendijeGodineBrojIndeksa == stipendijaGodina);

        private void LogToTxtInfo(string text)
        {
            Invoke(() =>
            {
                txtInfo.Text += text;
                txtInfo.SelectionStart = txtInfo.Text.Length;
                txtInfo.ScrollToCaret();
            });
        }

        private async Task DodajStipendijuGodinuSvakomStudentu(StipendijeGodineBrojIndeksa stipendijaGodina)
        {
            var studenti = DB.Studenti.ToList();

            for (int i = 0; i < studenti.Count; ++i)
            {
                var student = studenti[i];

                if (DaLiStudentStipendijaVecPostoji(student, stipendijaGodina))
                {
                    LogToTxtInfo($"{i + 1}. {stipendijaGodina.StipendijeBrojIndeksa} u iznosu od {stipendijaGodina.MjesecniIznos} je vec dodata za studenta {student}{Environment.NewLine}");
                    continue;
                }

                var studentStipendija = new StudentiStipendijeBrojIndeksa()
                {
                    Studenti = student,
                    StipendijeGodineBrojIndeksa = stipendijaGodina
                };

                DB.Add(studentStipendija);

                await Task.Delay(300);

                LogToTxtInfo($"{i + 1}. {stipendijaGodina.StipendijeBrojIndeksa} u iznosu od {stipendijaGodina.MjesecniIznos} je dodata za studenta {student}{Environment.NewLine}");
            }

            DB.SaveChanges();
        }

        private async void GenerisiStipendijeBtnClick(object sender, EventArgs e)
        {
            if (dgvStipendijeGodine.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Da bi se generisale stipendije, prvo trebate odabrati jednu u data grid view kontroli",
                    "Greska"
                );
                return;
            }

            var stipendijaGodina = (StipendijeGodineBrojIndeksa)dgvStipendijeGodine.GetOdabraniRed();

            await Task.Run(async () => await DodajStipendijuGodinuSvakomStudentu(stipendijaGodina));

            MessageBox.Show(
                "Uspjesno generisani studenti stipendije za odabranu stipendija godinu",
                "Generisanje gotovo"
            );
        }

        private void PotvrdaBtnClick(object sender, EventArgs e)
        {
            if (dgvStipendijeGodine.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Da bi se generisale stipendije, prvo trebate odabrati jednu u data grid view kontroli",
                    "Greska"
                );
                return;
            }

            var stipendijaGodina = (StipendijeGodineBrojIndeksa)dgvStipendijeGodine.GetOdabraniRed();

            using var formaZaIzvjestaj = new frmIzvjestaji(stipendijaGodina);
            formaZaIzvjestaj.ShowDialog();
        }
    }
}
