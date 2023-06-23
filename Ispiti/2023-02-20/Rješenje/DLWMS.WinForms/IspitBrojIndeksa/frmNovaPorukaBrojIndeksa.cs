using DLWMS.Data;
using DLWMS.Data.BrojIndeksa;
using DLWMS.WinForms.Helpers;
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
    public partial class frmNovaPorukaBrojIndeksa : Form
    {
        private Student student;
        DLWMSDbContext db = KonekcijaBrojIndeksa.db;
        public frmNovaPorukaBrojIndeksa(Student std)
        {
            InitializeComponent();
            student = std;
        }

        private void frmNovaPorukaBrojIndeksa_Load(object sender, EventArgs e)
        {
            cmbPredmet.DataSource = db.Predmeti.ToList();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (podaciValidni())
            {
                var poruka = new StudentPorukaBrojIndeksa()
                {
                    Student = student,
                    Predmet = cmbPredmet.SelectedItem as PredmetBrojIndeksa,
                    Sadrzaj = txtSadrzaj.Text,
                    Validnost = dtpValidan.Value,
                    Slika = Helpers.ImageHelper.FromImageToByte(pbSlika.Image)
                };
                db.StudentiPoruke.Add(poruka);
                db.SaveChanges();

                MessageBox.Show("Uspjesno ste dodali poruku u bazu");
            }
        }

        private bool podaciValidni()
        {
            return Helpers.Validator.ValidirajKontrolu(cmbPredmet, err, Kljucevi.ObaveznaVrijednost) &&
                Helpers.Validator.ValidirajKontrolu(dtpValidan, err, Kljucevi.ObaveznaVrijednost) &&
                Helpers.Validator.ValidirajKontrolu(txtSadrzaj, err, Kljucevi.ObaveznaVrijednost) &&
                Helpers.Validator.ValidirajKontrolu(pbSlika, err, Kljucevi.ObaveznaVrijednost);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            var rd = new OpenFileDialog();
            if (rd.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(rd.FileName);
            }
        }
    }
}
