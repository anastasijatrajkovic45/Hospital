
namespace BolnicaLibrary.DTOs;

public class StacionarniView : PacijentView
{
    public DateTime? Datum_prijema { get; set; }
    public DateTime? Datum_otpusta { get; set; }
    public IList<LeziNaView> Leze_na_odeljenju { get; set; }
    public StacionarniView()
    {
        Leze_na_odeljenju = new List<LeziNaView>();

    }
    internal StacionarniView(Stacionarni? v) : base(v)
    {
        if (v != null)
        {
            Datum_otpusta = v.Datum_otpusta;
            Datum_prijema = v.Datum_prijema;
        }
    }

}
