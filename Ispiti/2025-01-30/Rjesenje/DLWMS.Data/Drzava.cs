using DLWMS.Data.IspitBrojIndeksa;

namespace DLWMS.Data
{
    public class Drzava
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }        
        public bool Aktivan { get; set; }

        // Stuff I added below

        public List<Grad> Gradovi = new();

        public List<UniverzitetBrojIndeksa> Univerziteti = new();
        public override string ToString() => Naziv;
    }
}
