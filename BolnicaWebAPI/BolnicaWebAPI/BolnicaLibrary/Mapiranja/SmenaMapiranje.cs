using FluentNHibernate.Mapping;

namespace BolnicaLibrary.Mapiranja;

internal class SmenaMapiranje : ClassMap<Smena>
{
    public SmenaMapiranje()
    {
        Table("SMENA");

        //mapiranje primarnog kljuca
        Id(x => x.Id).Column("ID").GeneratedBy.SequenceIdentity("S18456.SMENA_ID_SEQ");

        //mapiranje svojstava.
        Map(x => x.Tip_smene, "TIP_SMENE");

        //N-arna veza RADI_NA
        HasMany(x => x.Rade).KeyColumn("MAT_BR_S").LazyLoad().Cascade.All();
        //HasMany(x => x.Rade_na_stolici).KeyColumn("PROIZVODJAC").LazyLoad().Cascade.All().Inverse();
        //HasMany(x => x.Stomatolozi_rade).KeyColumn("MAT_BR").LazyLoad().Cascade.All().Inverse();
    }
}