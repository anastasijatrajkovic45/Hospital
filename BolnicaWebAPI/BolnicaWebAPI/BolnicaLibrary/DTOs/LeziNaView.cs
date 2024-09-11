namespace BolnicaLibrary.DTOs;

public class LeziNaView
{
    public int Matbr { get; set; }
    public StacionarniView? StacionarniLezi { get; set; }
    public OdeljenjeView? LeziNaOdeljenju { get; set; }
    public virtual DateTime? Vreme_pocetka { get; set; }

    public LeziNaView()
    {
    }

    internal LeziNaView(Lezi_na? s)
    {
        if (s != null)
        {
            Matbr = s.Mat_br;
            StacionarniLezi = new StacionarniView(s.Stacionarnis);
            LeziNaOdeljenju = new OdeljenjeView(s.Odeljenja);
            Vreme_pocetka = s.Vreme_pocetka;
        }
    }
}
