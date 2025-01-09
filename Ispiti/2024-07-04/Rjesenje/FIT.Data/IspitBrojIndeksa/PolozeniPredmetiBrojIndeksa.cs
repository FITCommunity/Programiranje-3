namespace FIT.Data.IspitBrojIndeksa
{
    public class PolozeniPredmetiBrojIndeksa
    {
        public int Id { get; set; }
        public Student Student { get; set; } = null!;
        public PredmetiBrojIndeksa Predmet { get; set; } = null!;
	    public int Ocjena { get; set; }
	    public DateTime DatumPolaganja { get; set; }
        public string Napomena { get; set; } = "";

        public override string ToString() => $"{Predmet.Naziv} ({Ocjena})";
    }
}
