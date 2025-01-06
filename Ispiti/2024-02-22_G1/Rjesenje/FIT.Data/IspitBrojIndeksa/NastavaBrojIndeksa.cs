using System.ComponentModel.DataAnnotations.Schema;

namespace FIT.Data.IspitBrojIndeksa
{
    
    [Table("NastavaBrojIndeksa")]
    public class NastavaBrojIndeksa
    {
        public int Id { get; set; }
        public PredmetiBrojIndeksa Predmet { get; set; } = null!;
        public ProstorijeBrojIndeksa Prostorija { get; set; } = null!;
        public string Vrijeme { get; set; } = "";
        public string Dan { get; set; } = "";
        public string Oznaka { get; set; } = "";

        public override string ToString() => $"{Predmet.Naziv} - u {Dan} @ {Vrijeme}";
    }
}
