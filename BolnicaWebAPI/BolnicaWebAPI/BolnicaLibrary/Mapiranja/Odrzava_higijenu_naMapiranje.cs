using FluentNHibernate.Mapping;

namespace BolnicaLibrary.Mapiranja;

internal class Odrzava_higijenu_naMapiranje : ClassMap<Odrzava_higijenu_na>
{
    public Odrzava_higijenu_naMapiranje()
    {
        Table("ODRZAVA_HIGIJENU_NA");

        Id(x => x.Mat_br).Column("MAT_BR").GeneratedBy.SequenceIdentity("S18456.ODRZAVA_HIGIJENU_NA_MAT_BR_SEQ");

        Map(x => x.Vreme_odrzavanja).Column("VREME_ODRZAVANJA");


        References(x => x.Higijenicar).Column("MAT_BR_H").LazyLoad();
        References(x => x.Odeljenja).Column("SIFRA").LazyLoad();
    }
}
