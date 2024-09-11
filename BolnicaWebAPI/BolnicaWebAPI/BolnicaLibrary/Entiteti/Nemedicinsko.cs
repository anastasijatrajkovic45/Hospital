
namespace BolnicaLibrary.Entiteti;

internal class Nemedicinsko : Osoblje
{
    internal protected virtual string? TipOdrzavanja { get; set; }
    internal protected virtual string? Struka { get; set; }

    //Veza 1:N Odrzava
    internal protected virtual IList<Stomatoloska_stolica>? Stomatoloske_Stolice { get; set; }

    //Veza N:M Odrzava_Higijenu_Na
    internal protected virtual IList<Odrzava_higijenu_na>? Odrzavaju_higijenu { get; set; }

    public Nemedicinsko()
    {
        Stomatoloske_Stolice = new List<Stomatoloska_stolica>();
        Odrzavaju_higijenu = new List<Odrzava_higijenu_na>();
    }
}