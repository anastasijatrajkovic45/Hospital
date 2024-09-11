using Bolnica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Mapiranja
{
    class Stomatoloska_stolicaMapiranje : ClassMap<Stomatoloska_stolica>
    {
        public Stomatoloska_stolicaMapiranje()
        {
            Table("STOMATOLOSKA_STOLICA");

            //mapiranje primarnog kljuca
            Id(x => x.Proizvodjac).Column("PROIZVODJAC");

            //mapiranje svojstava.
            Map(x => x.Datum_proizvodnje, "DATUM_PROIZVODNJE");

            //mapiranje veze 1:N, Stomataloska_stolica - Tehnicko_odrzavanje(Nemedicinsko)
            References(x => x.Pripada_tehnickom_osoblju).Column("MAT_BR").LazyLoad();//promeniti u T

            //N-arna veza RADI_NA
            //References(x => x.Radi_stomatolog).Column("MAT_BR").LazyLoad().Cascade.All();
            //HasMany(x => x.Rade_u_smeni).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
        }
    }
}