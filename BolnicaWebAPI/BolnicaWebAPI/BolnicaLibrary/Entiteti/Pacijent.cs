namespace BolnicaLibrary.Entiteti;

internal abstract class Pacijent
{
    internal protected virtual int Mat_br_pac { get; set; }
    internal protected virtual string? Ime_pac { get; set; }
    internal protected virtual string? Prezime_pac { get; set; }
    internal protected virtual string? Tip_pacijenta { get; set; }
    internal protected virtual string? Ulica { get; set; }
    internal protected virtual int Broj { get; set; }
    internal protected virtual DateTime? Datum_prijema { get; set; }
    internal protected virtual DateTime? Datum_otpusta { get; set; }

    //Veza 1:N LECI
    public virtual Medicinsko Pripada_Lekaru_Opste_prakse { get; set; }

    public Pacijent()
    {

    }
}
internal class Ambulantni : Pacijent
{
    //N-arna veza OBAVLJA
    //public virtual Obavlja Stomatolog { get; set; }
    //public virtual IList<Obavlja> Intervencije { get; set;}

    public Ambulantni()
    {
        //Intervencije = new List<Obavlja>();
    }

}
internal class Stacionarni : Pacijent
{
    //Veza 1:N PRATI
    internal protected virtual Medicinsko? Pripada_Lekaru_Specijalisti { get; set; }

    //Veza N:M LEZI_NA
    internal protected virtual IList<Lezi_na>? Leze_na_odeljenju { get; set; }

    public Stacionarni()
    {
        Leze_na_odeljenju = new List<Lezi_na>();
    }
}