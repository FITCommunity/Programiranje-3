using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data.IspitBrojIndeksa
{
    [Table("StipendijeBrojIndeksa")]
    public class StipendijeBrojIndeksa
    {
        public int Id { get; set; }
	    public string Naziv { get; set; }

        public override string ToString() => Naziv;
    }
}
