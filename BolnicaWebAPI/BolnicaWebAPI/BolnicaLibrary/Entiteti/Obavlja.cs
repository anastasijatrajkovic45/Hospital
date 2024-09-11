namespace BolnicaLibrary.Entiteti;

internal class Obavlja
{
    public virtual int Mat_br { get; set; }
    public virtual DateTime Vreme_intervencije { get; set; }

    public virtual Medicinsko Stomatolog { get; set; }
    public virtual Ambulantni AmbulantniPacijent { get; set; }
    public virtual Intervencija Intervencija { get; set; }
    public Obavlja()
    {

    }
}
