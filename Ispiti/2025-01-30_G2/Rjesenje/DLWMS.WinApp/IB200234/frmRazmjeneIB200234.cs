using DLWMS.Data;
using DLWMS.Data.IB200234;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using DLWMS.WinApp.Izvjestaji;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2016.Drawing.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.IB200234
{
    public partial class frmRazmjeneIB200234 : Form
    {
        private Student odabraniStudent;
        DLWMSContext db = new DLWMSContext();
        List<RazmjeneIB200234> razmjene;

        public frmRazmjeneIB200234(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
            dgvRazmjene.AutoGenerateColumns = false;
            cmbDrzava.DataSource = db.Drzave.ToList();
            cmbUniverziteti.DataSource = db.UniverzitetiIB200234.ToList();
        }

        private void frmRazmjeneIB200234_Load(object sender, EventArgs e)
        {
            cmbDrzava.DataSource = db.Drzave.ToList();
            cmbUniverziteti.DataSource = db.UniverzitetiIB200234.ToList();
            cmbGenerisiUniverzitete.DataSource = db.UniverzitetiIB200234.ToList();
            UcitajRazmjene();
        }

        private void UcitajRazmjene()
        {


            razmjene = db.RazmjeneIB200234.Where(x => x.StudentId == odabraniStudent.Id).ToList();

            if (razmjene.Count() == 0)
            {
                MessageBox.Show($" {odabraniStudent} dosada nije imao nikakvih razmjena!");
            }

            if (razmjene != null)
            {
                dgvRazmjene.DataSource = null;
                dgvRazmjene.DataSource = razmjene;
            }


        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var Drzava = cmbDrzava.SelectedItem as Drzava ?? new Drzava();
                var Univerzitet = cmbUniverziteti.SelectedItem as UniverzitetiIB200234 ?? new UniverzitetiIB200234();
                var krediti = int.Parse(txtKrediti.Text);
                var Pocetak = dtpPocetak.Value;
                var Kraj = dtpKraj.Value;
                var okoncana = dtpKraj.Value > DateTime.Now ? false : true;

                if (Pocetak > Kraj)
                {
                    MessageBox.Show("Datum početka ne može biti veći od datum kraja", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (razmjene.Exists(x =>
                    (Pocetak >= x.PocetakRazmjene && Pocetak <= x.KrajRazmjene) || // New start is within an existing range
                    (Kraj >= x.PocetakRazmjene && Kraj <= x.KrajRazmjene) || // New end is within an existing range
                    (Pocetak <= x.KrajRazmjene && Kraj >= x.KrajRazmjene) // New range fully contains an existing range
                 ))
                {
                    MessageBox.Show("Već postoji razmjena u tom vremenskom periodu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var novaRazmjena = new RazmjeneIB200234()
                    {
                        StudentId = odabraniStudent.Id,
                        UniverzitetId = Univerzitet.Id,
                        PocetakRazmjene = Pocetak,
                        KrajRazmjene = Kraj,
                        Kredit = krediti,
                        Okoncana = okoncana
                    };


                    db.RazmjeneIB200234.Add(novaRazmjena);
                    db.SaveChanges();
                }

            }
            UcitajRazmjene();



        }

        private bool Validiraj()
        {
            return Helpers.Validator.ProvjeriUnos(cmbDrzava, err, Kljucevi.RequiredField) &&
                Helpers.Validator.ProvjeriUnos(cmbUniverziteti, err, Kljucevi.RequiredField) &&
                Helpers.Validator.ProvjeriUnos(txtKrediti, err, Kljucevi.RequiredField) &&
                Helpers.Validator.ProvjeriUnos(dtpPocetak, err, Kljucevi.RequiredField) &&
                Helpers.Validator.ProvjeriUnos(dtpKraj, err, Kljucevi.RequiredField);
        }

        private void dgvRazmjene_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaRazmjena = razmjene[e.RowIndex];

            if (e.ColumnIndex == 5)
            {
                db.RazmjeneIB200234.Remove(odabranaRazmjena);
                db.SaveChanges();
            }
            UcitajRazmjene();
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (ValidirajMultithreading())
            {
                var odabraniUniverzitet = cmbGenerisiUniverzitete.SelectedItem as UniverzitetiIB200234;

                Thread thread = new Thread(() => GenerisiRazmjene(odabraniUniverzitet));
                thread.Start();


            }
        }

        private void GenerisiRazmjene(UniverzitetiIB200234? odabraniUniverzitet)
        {
            var broj = int.Parse(txtBrojRazmjena.Text);

            var info = "";

            var ects = int.Parse(txtBrojKredita.Text);

            var datumPocetak = new DateTime(2025, 1, 1, 12, 0, 0);

            for (int i = 0; i < broj; i++)
            {
                Thread.Sleep(300);

                var datumKraj = datumPocetak.AddDays(ects + (i + 1));

                var okoncana = datumKraj > DateTime.Now ? false : true;

                var novaRazmjena = new RazmjeneIB200234()
                {

                    StudentId = odabraniStudent.Id,
                    UniverzitetId = odabraniUniverzitet.Id,
                    PocetakRazmjene = datumPocetak,
                    KrajRazmjene = datumKraj,
                    Okoncana = okoncana,
                    Kredit = ects

                };

                info += $"{i + 1}. razmjena za {odabraniStudent} na {odabraniUniverzitet} ({novaRazmjena.PocetakRazmjene.ToString("dd.MM.yyyy")} - {novaRazmjena.KrajRazmjene.ToString("dd.MM.yyyy")}){Environment.NewLine}";

                db.RazmjeneIB200234.Add(novaRazmjena);
                db.SaveChanges();

            }

            Action action = () =>
            {
                UcitajRazmjene();
                MessageBox.Show($"Uspješno je generisano {broj} razmjena", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInfo.Text = info;
            };
            BeginInvoke(action);

        }

        private bool ValidirajMultithreading()
        {
            return Validator.ProvjeriUnos(txtBrojRazmjena, err, Kljucevi.RequiredField)
                &&
                Validator.ProvjeriUnos(txtBrojKredita, err, Kljucevi.RequiredField);
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            frmIzvjestaji frm = new frmIzvjestaji(odabraniStudent);
            frm.ShowDialog();
        }
    }
}
