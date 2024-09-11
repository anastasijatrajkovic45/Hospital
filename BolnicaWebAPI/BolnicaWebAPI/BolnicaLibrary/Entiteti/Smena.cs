namespace BolnicaLibrary.Entiteti;

internal class Smena
{
    public virtual int Id { get; set; }
    public virtual string Tip_smene { get; set; }

    //N-arna veza RADI_NA
    internal protected virtual IList<Radi_na> Rade { get; set; }
    //public virtual IList<Radi_na> Rade_na_stolici { get; set; }
    //public virtual IList<Radi_na> Stomatolozi_rade { get; set; }

    public Smena()
    {
        Rade = new List<Radi_na>();
    }
}