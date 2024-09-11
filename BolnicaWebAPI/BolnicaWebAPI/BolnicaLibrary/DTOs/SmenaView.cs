
namespace BolnicaLibrary.DTOs;

public class SmenaView
{
    public virtual int Id { get; set; }
    public virtual string Tip_smene { get; set; }
    public SmenaView()
    {

    }
    internal SmenaView(Smena? p)
    {
        if (p != null)
        {
            Id = p.Id;
            Tip_smene = p.Tip_smene;
        }
    }
}