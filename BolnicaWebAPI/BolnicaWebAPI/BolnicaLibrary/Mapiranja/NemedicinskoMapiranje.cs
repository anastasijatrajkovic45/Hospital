using FluentNHibernate.Mapping;

namespace BolnicaLibrary.Mapiranja;

internal class NemedicinskoMapiranje : SubclassMap<Nemedicinsko>
{
   public NemedicinskoMapiranje()
   {
        Table("NEMEDICINSKO");

        KeyColumn("MAT_BR");

        Map(x => x.TipOdrzavanja).Column("TIP_ODRZAVANJA");
        Map(x => x.Struka).Column("STRUKA");

        //veza 1:N sa stomatoloske stolice
        HasMany(x => x.Stomatoloske_Stolice).KeyColumn("MAT_BR").LazyLoad().Cascade.All().Inverse();

        //strani kljuc N:M kod veze ODRZAVA_HIGIJENU_NA
        HasMany(x => x.Odrzavaju_higijenu).KeyColumn("MAT_BR_H").LazyLoad().Cascade.All().Inverse();
    }
}



