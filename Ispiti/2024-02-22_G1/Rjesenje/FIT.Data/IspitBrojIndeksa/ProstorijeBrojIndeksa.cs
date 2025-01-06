using System.ComponentModel.DataAnnotations.Schema;

namespace FIT.Data.IspitBrojIndeksa
{
    [Table("ProstorijeBrojIndeksa")]
    public class ProstorijeBrojIndeksa
    {
	    public int Id { get; set; }
        public string Naziv { get; set; } = "";
	    public string Oznaka { get; set; } = "";
        public byte[] Logo { get; set; } = null!;
	    public int Kapacitet { get; set; }

        [NotMapped]
        public int BrojPredmeta => Predmeti.Count;

        public List<PredmetiBrojIndeksa> Predmeti = new();
    }
}
