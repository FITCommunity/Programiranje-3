using DLWMS.Data;
using DLWMS.Data.BrojIndeksa;
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

namespace DLWMS.WinForms.BrojIndeksa
{
    public partial class frmPorukeBrojIndeksa : Form
    {
        private Student student;
        DLWMSDbContext db = KonekcijaBrojIndeksa.db;
        List<StudentPorukaBrojIndeksa> poruke = new List<StudentPorukaBrojIndeksa>();
        public frmPorukeBrojIndeksa(Student std)
        {
            InitializeComponent();
            dgvPoruke.AutoGenerateColumns = false;
            student = std;
            lblStudent.Text = "Poruke studenta " + student.Ime + " " + student.Prezime + ":";
            cmbPredmet.DataSource=db.Predmeti.ToList();
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            var frm = new frmNovaPorukaBrojIndeksa(student);
            frm.ShowDialog();
            UcitajPoruke();
        }

        private void frmPorukeBrojIndeksa_Load(object sender, EventArgs e)
        {
            UcitajPoruke();
        }

        private void UcitajPoruke()
        {
            dgvPoruke.DataSource = null;
            poruke = db.StudentiPoruke.Include(x => x.Student).Include(x => x.Predmet).
                Where(x => x.Student.Id == student.Id && x.Validnost > DateTime.Now).ToList();
            dgvPoruke.DataSource = poruke;
            Text = "Broj poruka: " + poruke.Count.ToString();
            if (poruke.Count == 0)
                btnDodaj.Enabled = false;
            else
                btnDodaj.Enabled = true;
        }

        private void dgvPoruke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var poruka = dgvPoruke.SelectedRows[0].DataBoundItem as StudentPorukaBrojIndeksa;
                var mb = MessageBox.Show("Da li želite izbrisati odabranu poruku?", "Upozorenje", MessageBoxButtons.YesNo);
                if (mb == DialogResult.Yes)
                {
                    db.StudentiPoruke.Remove(poruka);
                    db.SaveChanges();
                    UcitajPoruke();
                }
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var frm = new frmIzvjestajBrojIndeksa(poruke, student);
            frm.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int brojPoruka;
            bool isNumerical = int.TryParse(txtBrojPoruka.Text, out brojPoruka);
            if(isNumerical)
            {
                var predmet = cmbPredmet.SelectedItem as PredmetBrojIndeksa;
                var dtm = dtpValidan.Value;

                var thread = new Thread(() => dodajPoruku(brojPoruka, predmet, dtm, student));
                thread.Start();
            }
        }

        private void dodajPoruku(int brojPoruka, PredmetBrojIndeksa predmet, DateTime dtm, Student student)
        {
            var img = poruke[0].Slika;
            for(int i=1;i<=brojPoruka;i++)
            {
                var poruka = new StudentPorukaBrojIndeksa()
                {
                    Predmet = predmet,
                    Student = student,
                    Slika = img,
                    Sadrzaj = i.ToString() + ". GENERISANA PORUKA",
                    Validnost = dtm
                };
                db.StudentiPoruke.Add(poruka);
                db.SaveChanges();
                Action ac = () =>
                {
                    txtInfo.Text += $"{DateTime.Now.ToString()} -> generisana poruka za {student.Ime} {student.Prezime} " +
                    $"na predmetu {predmet.ToString()}" + Environment.NewLine;
                    SetCursor(); //ova metoda stavlja kursor na kraj teksta te ako je puno poruka prikazuju nam se najnovije poruke
                };
                BeginInvoke(ac);
                Thread.Sleep(300);
            }
            MessageBox.Show($"Studentu {student.Ime} {student.Prezime} je dodano {brojPoruka} novih poruka na predmetu " +
                $"{predmet.Naziv} koje su validne do {dtm.ToString()}");
            BeginInvoke(UcitajPoruke);
        }

        private void SetCursor()
        {
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();
        }
    }
}
