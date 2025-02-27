using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data.IspitBrojIndeksa
{
    [Table("CertifikatiBrojIndeksa")]
    public class CertifikatiBrojIndeksa
    {
        public int Id { get; set; }
        public string Naziv { get; set; } = "";
        public override string ToString() => Naziv;
    }
}
