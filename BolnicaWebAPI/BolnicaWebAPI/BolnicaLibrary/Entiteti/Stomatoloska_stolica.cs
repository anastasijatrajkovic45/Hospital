namespace BolnicaLibrary.Entiteti;

internal class Stomatoloska_stolica
{
    internal protected virtual string? Proizvodjac { get; set; }
    internal protected virtual DateTime? Datum_proizvodnje { get; set; }

    internal protected virtual Nemedicinsko? Pripada_tehnickom_osoblju { get; set; }

    //N-arna veza RADI_NA
    internal protected virtual IList<Radi_na> Rade { get; set; }

    //public virtual IList<Radi_na> Rade_u_smeni { get; set; }
    //public virtual Radi_na Radi_stomatolog { get; set; }

    public Stomatoloska_stolica()
    {
        Rade = new List<Radi_na>();
        //Rade_u_smeni = new List<Radi_na>();
    }
}