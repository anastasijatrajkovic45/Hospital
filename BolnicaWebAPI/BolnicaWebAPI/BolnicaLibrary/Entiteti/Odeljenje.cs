namespace BolnicaLibrary.Entiteti;

internal class Odeljenje
{
    internal protected virtual int Sifra { get; set; }
    internal protected virtual string? Tip { get; set; }
    internal protected virtual DateTime? Datum_izgradnje { get; set; }

    internal protected virtual Medicinsko? Pripada_Specijalisti { get; set; }

    //Veza N:M LEZI_NA
    internal protected virtual IList<Lezi_na>? Leze_stacionarni { get; set; }

    internal protected virtual IList<Odrzava_higijenu_na>? Odrzavaju_odeljenja { get; set; }

    internal Odeljenje()
    {
        Leze_stacionarni = new List<Lezi_na>();
        Odrzavaju_odeljenja = new List<Odrzava_higijenu_na>();
    }
}



