
namespace BolnicaLibrary.DTOs;

public class Stomatoloska_stolicaView
{
    public string? Proizvodjac { get; set; }
    public DateTime? Datum_proizvodnje { get; set; }

    internal protected virtual NemedicinskoView? Nemedicinsko { get; set; }
    public Stomatoloska_stolicaView()
    {

    }
    internal Stomatoloska_stolicaView(Stomatoloska_stolica? p)
    {
        if (p != null)
        {
            Proizvodjac = p.Proizvodjac;
            Datum_proizvodnje = p.Datum_proizvodnje;
        }
    }

    internal Stomatoloska_stolicaView(Stomatoloska_stolica? o, Nemedicinsko? p)
    {
        Nemedicinsko = new NemedicinskoView(p);
    }
}