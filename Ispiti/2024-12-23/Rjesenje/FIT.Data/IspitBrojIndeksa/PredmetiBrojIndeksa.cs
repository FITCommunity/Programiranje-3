namespace FIT.Data.IspitBrojIndeksa
{
    public class PredmetiBrojIndeksa
    {
        public int Id { get; set; }
        public string Naziv { get; set; } = "";
        public override string ToString() => Naziv;
    }
}
