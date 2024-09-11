namespace BolnicaLibrary.DTOs;

public class OdeljenjeView
{
    public int? Sifra { get; set; }
    public string? Tip { get; set; }
    public DateTime? Datum_izgradnje { get; set; }
       
    public virtual MedicinskoView? Medicinsko { get; set; }
    public virtual IList<LeziNaView>? LezeNaOdeljenju { get; set; }
    public virtual IList<OdrzavaHigijenuNaView>? OdrzavaHigijenuNa { get; set; }


    public OdeljenjeView()
        {
            LezeNaOdeljenju = new List<LeziNaView>();
            OdrzavaHigijenuNa = new List<OdrzavaHigijenuNaView>();
        }

        internal OdeljenjeView(Odeljenje? o)
        {
            if (o != null)
            {
                Sifra = o.Sifra;
                Tip = o.Tip;
                Datum_izgradnje = o.Datum_izgradnje;
            }
        }

        internal OdeljenjeView(Odeljenje? o, Medicinsko? p)
        {
            Medicinsko = new MedicinskoView(p);
        }
}

