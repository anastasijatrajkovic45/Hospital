
namespace BolnicaLibrary.DTOs;

public class AmbulantniView : PacijentView
{
    public string Ulica { get; set; }
    public int Broj { get; set; }
    public AmbulantniView()
    {

    }
    internal AmbulantniView(Ambulantni? v) : base(v)
    {
        if (v != null)
        {
            Ulica= v.Ulica;
            Broj= v.Broj;
        }
    }

}
