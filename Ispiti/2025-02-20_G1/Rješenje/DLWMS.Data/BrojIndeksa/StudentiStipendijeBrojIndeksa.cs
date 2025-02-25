using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230269
{
    public class StudentiStipendijeBrojIndeksa
    {
        public int Id { get; set; }
        public int StipendijeGodineID { get; set; }
        public StipendijeGodineBrojIndeksa StipendijeGodine { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
        [NotMapped] public string IndeksImePrezime => Student.IndeksImePrezime;
        [NotMapped] public string Godina => StipendijeGodine.Godina;
        [NotMapped] public int Iznos => StipendijeGodine.Iznos;
        [NotMapped] public int Ukupno => (Godina == DateTime.Now.Year.ToString() ? DateTime.Now.Month : 12) * Iznos;
        [NotMapped] public string Stipendija => StipendijeGodine.Stipendija.Naziv;
    }
}
