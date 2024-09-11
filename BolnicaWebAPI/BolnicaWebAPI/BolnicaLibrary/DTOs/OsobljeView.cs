
namespace BolnicaLibrary.DTOs;

public class OsobljeView
{
    public int Mat_br { get; set; }
    public string Ime { get; set; }
    public string Prezime { get; set; }

    public OsobljeView()
    {
        
    }
    internal OsobljeView(Osoblje? p)
    {
        if (p != null)
        {
            Mat_br = p.MatBr;
            Ime = p.Ime;
            Prezime = p.Prezime;
        }
    }
}
