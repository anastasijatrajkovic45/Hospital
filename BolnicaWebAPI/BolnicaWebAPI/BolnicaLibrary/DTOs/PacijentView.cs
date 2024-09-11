namespace BolnicaLibrary.DTOs;

public class PacijentView
{
    public int? Mat_br { get; set; }
    public string? Ime { get; set; }
    public string? Prezime { get; set; }
    public MedicinskoView? Medicinsko { get; set; }

    public PacijentView()
    {

    }
    internal PacijentView(Pacijent? p)
    {
        if (p != null)
        {
            Mat_br = p.Mat_br_pac;
            Ime = p.Ime_pac;
            Prezime=p.Prezime_pac;
        }
    }
    internal PacijentView(Pacijent? o, Medicinsko? p) : this(o)

    {
        Medicinsko = new MedicinskoView(p);
    }

}
