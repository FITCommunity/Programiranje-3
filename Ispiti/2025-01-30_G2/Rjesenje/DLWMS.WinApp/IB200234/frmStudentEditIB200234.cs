using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
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
    public partial class frmStudentEditIB200234 : Form
    {
        private Student odabraniStudent;
        DLWMSContext db = new DLWMSContext();

        public frmStudentEditIB200234(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }


        private void frmStudentEditIB200234_Load(object sender, EventArgs e)
        {
            UcitajStudenta();
            cmbDrzave.DataSource = db.Drzave.ToList();
            cmbDrzave.SelectedIndex = odabraniStudent.Grad.DrzavaId - 1;

        }

        private void UcitajStudenta()
        {
            lblImePrezime.Text = odabraniStudent.Ime + " " + odabraniStudent.Prezime;
            lblIndeks.Text = odabraniStudent.BrojIndeksa;
            pbImage.Image = Helpers.Ekstenzije.ToImage(odabraniStudent.Slika);


        }

     

        private void cmbDrzave_SelectedIndexChanged(object sender, EventArgs e)
        {
            var odabranaDrzava = cmbDrzave.SelectedItem as Drzava;

            cmbGradovi.DataSource = db.Gradovi.Where(x => x.DrzavaId == odabranaDrzava.Id).ToList();
        }
        
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var odabraniGrad = cmbGradovi.SelectedItem as Grad;
            var slika = pbImage.Image.ToByteArray();

            odabraniStudent.Slika = slika;
            odabraniStudent.GradId = odabraniStudent.Id;
            odabraniStudent.Grad = odabraniGrad!;

            db.Studenti.Update(odabraniStudent);
            db.SaveChanges();
            UcitajStudenta();

            DialogResult = DialogResult.OK;
        }
    }
}
