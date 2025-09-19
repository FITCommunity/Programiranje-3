using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data.IspitBrojIndeksa
{
    [Table("StipendijeGodineBrojIndeksa")]
    public class StipendijeGodineBrojIndeksa
    {
        public int Id { get; set; }
	    public StipendijeBrojIndeksa StipendijeBrojIndeksa { get; set; }
	    public int Godina { get; set; }
	    public int MjesecniIznos { get; set; }
	    public bool Aktivna { get; set; }
        public int Ukupno => MjesecniIznos * (DateTime.Now.Year == Godina ? DateTime.Now.Month : 12);

        public override string ToString() => StipendijeBrojIndeksa.ToString();
    }
}
