using Bolnica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Mapiranja
{
    class SmenaMapiranje : ClassMap<Smena>
    {
        public SmenaMapiranje()
        {
            Table("SMENA");

            //mapiranje primarnog kljuca
            Id(x => x.Id).Column("ID").GeneratedBy.SequenceIdentity("S18456.SMENA_ID_SEQ");

            //mapiranje svojstava.
            Map(x => x.Tip_smene, "TIP_SMENE");

            //N-arna veza RADI_NA
            //HasMany(x => x.Rade_na_stolici).KeyColumn("PROIZVODJAC").LazyLoad().Cascade.All().Inverse();
            //HasMany(x => x.Stomatolozi_rade).KeyColumn("MAT_BR").LazyLoad().Cascade.All().Inverse();
        }
    }
}