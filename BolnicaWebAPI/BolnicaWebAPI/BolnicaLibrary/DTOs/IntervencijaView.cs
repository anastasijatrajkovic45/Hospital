
namespace BolnicaLibrary.DTOs;

public class IntervencijaView
{
    public virtual string Vrsta { get; set; }
    public virtual DateTime Datum { get; set; }
    public IntervencijaView()
    {

    }
    internal IntervencijaView(Intervencija? p)
    {
        if (p != null)
        {
            Vrsta = p.Vrsta;
            Datum = p.Datum;
        }
    }
}
