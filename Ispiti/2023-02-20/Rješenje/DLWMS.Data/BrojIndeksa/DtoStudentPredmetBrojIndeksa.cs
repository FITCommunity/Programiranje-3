using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.BrojIndeksa
{
    public class DtoStudentPredmetBrojIndeksa
    {
        public StudentPredmetBrojIndeksa stdPredm { get; set; }
        public string Indeks => stdPredm.Student.BrojIndeksa;
        public string ImePrezime => stdPredm.Student.Ime + ' ' + stdPredm.Student.Prezime;
        public string Predmet => stdPredm.Predmet.Naziv;
        public int Ocjena => stdPredm.Ocjena;
        public DateTime DatumPolaganja => stdPredm.Datum;    
    }
}
