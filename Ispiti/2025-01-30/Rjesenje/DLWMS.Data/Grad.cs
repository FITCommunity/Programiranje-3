namespace DLWMS.Data
{
    public class Grad
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oznaka{ get; set; }
        public int DrzavaId { get; set; }
        public bool Aktivan { get; set; }

        // Methods I added below

        public Drzava Drzava { get; set; } = null!;

        public override string ToString() => Naziv;
    }
}
