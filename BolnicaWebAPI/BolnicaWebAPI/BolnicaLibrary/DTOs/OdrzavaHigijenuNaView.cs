namespace BolnicaLibrary.DTOs;

public class OdrzavaHigijenuNaView
{
    public int Matbr { get; set; }
    public NemedicinskoView? HigijenicarOdrzava { get; set; }
    public OdeljenjeView? OdrzavaOdeljenje { get; set; }
    public DateTime? Vreme_odrzavanja { get; set; }

    public OdrzavaHigijenuNaView()
    {

    }
    internal OdrzavaHigijenuNaView(Odrzava_higijenu_na? s)
    {
        if (s != null)
        {
            Matbr = s.Mat_br;
            HigijenicarOdrzava = new NemedicinskoView(s.Higijenicar);
            OdrzavaOdeljenje = new OdeljenjeView(s.Odeljenja);
            Vreme_odrzavanja = s.Vreme_odrzavanja;
        }
    }
}
