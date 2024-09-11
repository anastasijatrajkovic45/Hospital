using Bolnica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Mapiranja
{
    class IntervencijaMapiranje : ClassMap<Intervencija>
    {
        public IntervencijaMapiranje()
        {
            Table("INTERVENCIJA");

            //mapiranje primarnog kljuca
            Id(x => x.Vrsta).Column("VRSTA");

            //mapiranje svojstava.
            Map(x => x.Datum, "DATUM");

            //N-arna veza OBAVLJA
            //References(x => x.Stomatolog).Column("MAT_BR_S").LazyLoad().Cascade.All();
            //HasMany(x => x.Nad_ambulatnim).KeyColumn("MAR_BR_P").LazyLoad().Cascade.All().Inverse();
        }
    }
}