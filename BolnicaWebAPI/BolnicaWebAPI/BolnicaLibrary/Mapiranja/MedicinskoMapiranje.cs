using FluentNHibernate.Mapping;


namespace BolnicaLibrary.Mapiranja;

internal class MedicinskoMapiranje : SubclassMap<Medicinsko>

{
    public MedicinskoMapiranje()
    {
        Table("MEDICINSKO");

        KeyColumn("MAT_BR");

        Map(x => x.Radni_staz).Column("RADNI_STAZ");
        Map(x => x.Tip_lekara).Column("TIP_LEKARA");
        Map(x => x.Broj_ordinacije).Column("BROJ_ORDINACIJE");
        Map(x => x.Specijalnost).Column("SPECIJALNOST");

        //Veza 1:N --Odeljenje:Lekar specijalista(Medicinsko)
        HasMany(x => x.Odeljenja).KeyColumn("MAT_BR_LSPEC").LazyLoad().Cascade.All().Inverse();
        //Veza 1:N --Pacijent : Lekar opste prakse (Medicinsko)
        HasMany(x => x.Pacijenti).KeyColumn("MAT_BR_LOP").LazyLoad().Cascade.All().Inverse();
        //Veza 1:N --Stacionarni : Lekar specijalista (Medicinsko)
        HasMany(x => x.Stacionarnis).KeyColumn("MAT_BR_LSPEC").LazyLoad().Cascade.All().Inverse();

        //N-arna veza RADI_NA
        HasMany(x => x.Rade).KeyColumn("PROIZVODJAC").LazyLoad().Cascade.All();
       // References(x => x.Rade_na_stolici).Column("PROIZVODJAC").LazyLoad().Cascade.All();
        //HasMany(x => x.Rade_u_smeni).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();

        //N-arna veza OBAVLJA
       // HasMany(x => x.ObavljaIntervenciju).KeyColumn("VRSTA").LazyLoad().Cascade.All().Inverse();
        //HasMany(x => x.Obavlja_nad_Ambulantnim).KeyColumn("MAT_BR_P").LazyLoad().Cascade.All();

    }
}



