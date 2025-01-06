namespace FIT.Data.IspitBrojIndeksa
{
    public class PredmetiBrojIndeksa
    {
        public int Id { get; set; }
        public string Naziv { get; set; } = "";

        public List<ProstorijeBrojIndeksa> Prostorije = new();

        public override string ToString() => Naziv;
    }
}
