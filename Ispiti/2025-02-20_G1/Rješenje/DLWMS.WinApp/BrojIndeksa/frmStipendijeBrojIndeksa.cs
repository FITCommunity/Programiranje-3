using DLWMS.Data;
using DLWMS.Data.IB230269;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using DLWMS.WinApp.Izvjestaji;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.IB230269
{
    public partial class frmStipendijeBrojIndeksa : Form
    {
        DLWMSContext db = new DLWMSContext();
        int iznosStipendije;
        public frmStipendijeBrojIndeksa()
        {
            InitializeComponent();
            dgwStipendije.AutoGenerateColumns = false;
        }

        private void ucitajDgw(int scrollAt = 0)
        {
            dgwStipendije.DataSource = null;
            dgwStipendije.DataSource = db.StipendijeGodineBrojIndeksa.Include(s => s.Stipendija).ToList();

            if (dgwStipendije.FirstDisplayedScrollingRowIndex != -1 && scrollAt + 1 < dgwStipendije.Rows.Count)
                dgwStipendije.FirstDisplayedScrollingRowIndex = scrollAt + 1;
        }

        private void frmStipendijeIB230269_Load(object sender, EventArgs e)
        {
            ucitajFormu();
        }

        private void ucitajFormu()
        {
            cbGodina.SelectedIndex = 0;
            cbStipendija.UcitajPodatke(db.StipendijeBrojIndeksa.ToList());
            cbStipendija.SelectedIndex = 0;
            ucitajDgw();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var stipendija = cbStipendija.SelectedItem as StipendijeBrojIndeksa;

            if (!validitajTextBoxIznosaStipendije())
                return;

            if (!provjeraPostojanjaStipendije(stipendija))
                return;


            var novaStipendijaGodina = new StipendijeGodineBrojIndeksa()
            {
                Godina = cbGodina.Text,
                StipendijaId = stipendija.Id,
                Stipendija = stipendija,
                Aktivna = true,
                Iznos = iznosStipendije,
            };

            db.StipendijeGodineBrojIndeksa.Add(novaStipendijaGodina);
            db.SaveChanges();
            ucitajDgw();
        }

        private bool provjeraPostojanjaStipendije(StipendijeBrojIndeksa? stipendija)
        {
            foreach (var s in db.StipendijeGodineBrojIndeksa)
            {
                if (s.Godina == cbGodina.Text && s.StipendijaId == stipendija.Id)
                {
                    MessageBox.Show("Vec postoji stipendija za datu godinu!");
                    return false;
                }
            }
            return true;
        }

        private bool validitajTextBoxIznosaStipendije()
        {
            if (string.IsNullOrWhiteSpace(tbMjesecniIznos.Text))
            {
                MessageBox.Show("Unesite vrijednost u TextBox");
                return false;
            }
            else if (!int.TryParse(tbMjesecniIznos.Text, out iznosStipendije) || iznosStipendije < 1)
            {
                MessageBox.Show("Unesite broj u TextBox!");
                return false;
            }
            return true;
        }

        private void DgwStipendije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgwStipendije.SelectedRows.Count > 0)
            {
                var selectedItem = dgwStipendije.SelectedRows[0].DataBoundItem as StipendijeGodineBrojIndeksa;
                selectedItem.Aktivna = !selectedItem.Aktivna;

                db.StipendijeGodineBrojIndeksa.Update(selectedItem);
                ucitajDgw(dgwStipendije.FirstDisplayedScrollingRowIndex - 1);
            }
        }

        private void btnPotvrda_click(object sender, EventArgs e)
        {
            if (dgwStipendije.SelectedRows.Count != 0)
            {
                var odabranaStipendija = dgwStipendije.SelectedRows[0].DataBoundItem as StipendijeGodineBrojIndeksa;

                var listaStudenata = db.StudentiStipendijeBrojIndeksa.Include(s => s.StipendijeGodine).ThenInclude(s => s.Stipendija).Include(s => s.Student)
                .Where(s => s.StipendijeGodineID==odabranaStipendija.Id).ToList();

                var godina = odabranaStipendija.Godina;

                var kategorijaStipendije = odabranaStipendija.Stipendija.Naziv;

                var novaForma = new frmIzvjestaji(listaStudenata, godina, kategorijaStipendije);
                novaForma.ShowDialog();
            }
        }

        private void btnGenerisi_click(object sender, EventArgs e)
        {
            if (dgwStipendije.SelectedRows.Count > 0)
            {
                var stipendija = dgwStipendije.SelectedRows[0].DataBoundItem as StipendijeGodineBrojIndeksa;

                var tred = new Thread(t => { generisi(stipendija, iznosStipendije); });
                tred.Start();
            }
        }

        private async void  generisi(StipendijeGodineBrojIndeksa? stipendija, int iznosStipendije)
        {
            int brojac = 0;

            BeginInvoke(() => { btnGenerisiStipendije.Enabled = false; });

            foreach (var student in db.Studenti.ToList())
            {
                if (validirajStipendijuZaStudenta(student, stipendija))
                {
                    brojac++;
                    var novaStipendija = new StudentiStipendijeBrojIndeksa()
                    {
                        StipendijeGodineID = stipendija.Id,
                        StipendijeGodine = stipendija,
                        StudentID = student.Id,
                        Student = student,
                    };

                    BeginInvoke(() =>
                    {
                        db.StudentiStipendijeBrojIndeksa.Add(novaStipendija);
                        db.SaveChanges();
                        tbGenerisiInfo.Text += $"{brojac}. {stipendija.Naziv} stipendija u iznosu od {stipendija.Iznos} KM dodata {student.IndeksImePrezime}." + Environment.NewLine;
                        tbGenerisiInfo.SelectionStart = tbGenerisiInfo.Text.Length;
                        tbGenerisiInfo.ScrollToCaret();
                    });
                    Thread.Sleep(300);
                }
            }
            BeginInvoke(() => { btnGenerisiStipendije.Enabled = true; });
            MessageBox.Show($"Uspješno ste dodali {brojac} stipendija!");
        }

        private bool validirajStipendijuZaStudenta(Student student, StipendijeGodineBrojIndeksa? stipendija)
        {
            return db.StudentiStipendijeBrojIndeksa.Include(s => s.Student).Include(s => s.StipendijeGodine).ThenInclude(s => s.Stipendija).
                Where(s => s.StudentID == student.Id && s.StipendijeGodineID == stipendija.Id)
                .Any() ? false : true;
        }

    }
}
