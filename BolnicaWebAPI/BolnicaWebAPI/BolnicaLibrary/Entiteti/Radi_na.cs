namespace BolnicaLibrary.Entiteti;

internal class Radi_na
{
    internal protected virtual int Mat_br { get; set; }

    internal protected virtual Medicinsko? Stomatolog { get; set; }
    internal protected virtual Stomatoloska_stolica? StomatoloskaStolica { get; set; }
    internal protected virtual Smena? Smena { get; set; }
    public Radi_na()
    {

    }
}
