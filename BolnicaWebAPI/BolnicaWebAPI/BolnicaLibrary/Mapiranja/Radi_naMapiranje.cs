using FluentNHibernate.Mapping;

namespace BolnicaLibrary.Mapiranja;

internal class Radi_naMapiranje : ClassMap<Radi_na>
{
    public Radi_naMapiranje()
    {
        Table("RADI_NA");

        Id(x => x.Mat_br).Column("MAT_BR").GeneratedBy.SequenceIdentity("S18456.RADI_NA_MAT_BR_SEQ");

        References(x => x.Stomatolog).Column("MAT_BR_S").LazyLoad();
        References(x => x.StomatoloskaStolica).Column("PROIZVODJAC").LazyLoad();
        References(x => x.Smena).Column("ID").LazyLoad();
    }
}
