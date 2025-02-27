using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data.IspitBrojIndeksa
{
    [Table("CertifikatiGodineBrojIndeksa")]
    public class CertifikatiGodineBrojIndeksa
    {
        public int Id { get; set; }
        public CertifikatiBrojIndeksa Certifikat { get; set; } = null!;
	    public int Godina { get; set; }
	    public int MjesecniIznos { get; set; }
	    public bool Aktivan { get; set; }

        public int UkupniIznos => (DateTime.Now.Year == Godina ? DateTime.Now.Month : 12) * MjesecniIznos;
        public override string ToString() => Certifikat.Naziv;
    }
}
