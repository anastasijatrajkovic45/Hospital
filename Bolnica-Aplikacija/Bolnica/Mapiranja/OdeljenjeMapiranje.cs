using Bolnica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Mapiranja
{
    class OdeljenjeMapiranje : ClassMap<Odeljenje>
    {
        public OdeljenjeMapiranje()
        {
            Table("ODELJENJE");

            //mapiranje primarnog kljuca
            Id(x => x.Sifra).Column("SIFRA").GeneratedBy.SequenceIdentity("S18456.ODELJENJE_SIFRA_SEQ");

            //mapiranje svojstava.
            Map(x => x.Tip, "TIP");
            Map(x => x.Datum_izgradnje, "DATUM_IZGRADNJE");

            //Veza 1:N --Odeljenje : Lekaru specijalisti(Medicinsko)
            References(x => x.Pripada_Specijalisti).Column("MAT_BR_LSPEC").LazyLoad();

            //strani kljuc kod veze N:M LEZI_NA
            HasMany(x => x.Leze_stacionarni).KeyColumn("SIFRA").LazyLoad().Cascade.All().Inverse();

            //strani kljuc kod veze N:M ODRZAVA_HIGIJENU_NA
            HasMany(x => x.Odrzavaju_odeljenja).KeyColumn("SIFRA").LazyLoad().Cascade.All().Inverse();
        }
    }
}