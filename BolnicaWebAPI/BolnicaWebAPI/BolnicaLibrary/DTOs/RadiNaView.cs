namespace BolnicaLibrary.DTOs;

public class RadiNaView
{
    public int Matbr { get; set; }
    public MedicinskoView? Stomatolog { get; set; }
    public Stomatoloska_stolicaView? Stomatoloska_Stolica { get; set; }
    public SmenaView? Smena { get; set; }

    public RadiNaView()
    {
    }

    internal RadiNaView(Lezi_na? s)
    {
        if (s != null)
        {
            Matbr = s.Mat_br;
            //Stomatolog = new MedicinskoView(s.Stomatolog);
            //Stomatoloska_Stolica = new Stomatoloska_stolicaView(s.StomatoloskaStolica);
            //Smena = new SmenaView(s.Smena);
        }
    }
}
