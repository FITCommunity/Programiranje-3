using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data.IspitBrojIndeksa
{
    [Table("UniverzitetBrojIndeksa")]
    public class UniverzitetBrojIndeksa
    {
        public int Id { get; set; }
        public Drzava Drzava { get; set; } = null!;
        public string Naziv { get; set; } = "";

        public override string ToString() => Naziv;
    }
}
