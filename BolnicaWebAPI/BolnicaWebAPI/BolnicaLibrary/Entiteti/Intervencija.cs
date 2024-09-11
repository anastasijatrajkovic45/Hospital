namespace BolnicaLibrary.Entiteti;

internal class Intervencija
{
    public virtual string Vrsta { get; set; }
    public virtual DateTime Datum { get; set; }

    //N-arna veza OBAVLJA
    //public virtual Obavlja Stomatolog { get; set; }
    //public virtual IList<Obavlja> Nad_ambulatnim { get; set; }
    //public Intervencija()
    //{
    //    //Nad_ambulatnim = new List<Obavlja>();
    //}
}
