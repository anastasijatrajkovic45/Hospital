namespace BolnicaLibrary.Entiteti;

internal class Lezi_na
{
    internal protected virtual int Mat_br { get; set; }
    internal protected virtual DateTime? Vreme_pocetka { get; set; }

    internal protected virtual Stacionarni? Stacionarnis { get; set; }
    internal protected virtual Odeljenje? Odeljenja { get; set; }
    
}