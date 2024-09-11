namespace BolnicaLibrary.DTOs;

public class MedicinskoView : OsobljeView
{
    public int Radni_staz { get; set; }
    public string? TipLekara { get; set; }
    public int? BrOrdinacije { get; set; }
    public string? Specijalnost { get; set; }

    public virtual IList<OdeljenjeView>? Odeljenja { get; set; }
    public IList<PacijentView>? Pacijenti { get; set; }
    public IList<StacionarniView>? Stacionarni { get; set; }

    public MedicinskoView()
    {
        Odeljenja = new List<OdeljenjeView>();
        Pacijenti = new List<PacijentView>();
        Stacionarni = new List<StacionarniView>();
    }
    internal MedicinskoView(Medicinsko? p) : base(p)
    {
        if (p != null)
        {
            Radni_staz = p.Radni_staz;
            TipLekara = p.Tip_lekara;
            BrOrdinacije = p.Broj_ordinacije;
            Specijalnost = p.Specijalnost;
        }
    }
}
