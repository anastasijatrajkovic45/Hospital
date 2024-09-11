
namespace BolnicaLibrary.DTOs;

public class NemedicinskoView : OsobljeView
{
    public string? TipOdrzavanja { get; set; }
    public string? Struka { get; set; }
    public virtual IList<Stomatoloska_stolicaView>? Stomatoloske_Stolice { get; set; }
    public virtual IList<OdrzavaHigijenuNaView>? OdrzavaHigijenuNa { get; set; }


    public NemedicinskoView()
    {
        Stomatoloske_Stolice = new List<Stomatoloska_stolicaView>();
        OdrzavaHigijenuNa = new List<OdrzavaHigijenuNaView>();
    }
    internal NemedicinskoView(Nemedicinsko? v) : base(v)
    {
        if (v != null)
        {
            TipOdrzavanja = v.TipOdrzavanja;
            Struka = v.Struka;  
        }
    }
}
