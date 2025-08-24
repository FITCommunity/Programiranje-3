using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data.IspitBrojIndeksa
{
    [Table("StudentiStipendijeBrojIndeksa")]
    public class StudentiStipendijeBrojIndeksa
    {
        public int Id { get; set; }
	    public Student Studenti { get; set; }
	    public StipendijeGodineBrojIndeksa StipendijeGodineBrojIndeksa { get; set; }

        public string IndeksImePrezime => Studenti.IndeksImePrezime;

        public int Godina => StipendijeGodineBrojIndeksa.Godina;
        public string Stipendija => StipendijeGodineBrojIndeksa.StipendijeBrojIndeksa.ToString();

        public int MjesecniIznos => StipendijeGodineBrojIndeksa.MjesecniIznos;

        public int Ukupno => MjesecniIznos * (DateTime.Now.Year == Godina ? DateTime.Now.Month : 12);
    }
}
