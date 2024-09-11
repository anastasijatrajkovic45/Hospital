namespace BolnicaLibrary.Entiteti;

internal class Medicinsko : Osoblje
{
    internal protected virtual int Radni_staz { get; set; }
    internal protected virtual string? Tip_lekara { get; set; }
    internal protected virtual int? Broj_ordinacije { get; set; }
    internal protected virtual string? Specijalnost { get; set; }


    //Veza 1:N ZADUZEN_ZA
    internal protected virtual IList<Odeljenje>? Odeljenja { get; set; }
    //Veza 1:N LECI
    internal protected virtual IList<Pacijent>? Pacijenti { get; set; }
    //Veza 1:N PRATI
    internal protected virtual IList<Stacionarni>? Stacionarnis { get; set; }

    //N-arna veza RADI_NA
    internal protected virtual IList<Radi_na> Rade { get; set; }

    ////N-arna veza OBAVLJA
    //public virtual IList<Obavlja> ObavljaIntervenciju { get; set; }
    //public virtual IList<Obavlja> Obavlja_nad_Ambulantnim { get; set; }

    internal Medicinsko()
    {
        Odeljenja = new List<Odeljenje>();
        Pacijenti = new List<Pacijent>();
        Stacionarnis = new List<Stacionarni>();

        Rade = new List<Radi_na>();

        //ObavljaIntervenciju = new List<Obavlja>();
        //Obavlja_nad_Ambulantnim = new List<Obavlja>();
    }
}