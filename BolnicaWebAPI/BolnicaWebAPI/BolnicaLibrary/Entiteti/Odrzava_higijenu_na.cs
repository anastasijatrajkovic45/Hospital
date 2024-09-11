namespace BolnicaLibrary.Entiteti;

internal class Odrzava_higijenu_na
{
    public virtual int Mat_br { get; set; }
    public virtual DateTime Vreme_odrzavanja { get; set; }

    public virtual Nemedicinsko Higijenicar { get; set; }
    public virtual Odeljenje Odeljenja { get; set; }
    public Odrzava_higijenu_na()
    {

    }
}
