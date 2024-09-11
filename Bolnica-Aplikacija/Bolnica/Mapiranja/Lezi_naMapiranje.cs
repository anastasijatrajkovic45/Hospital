using Bolnica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Mapiranja
{
    class Lezi_naMapiranje : ClassMap<Lezi_na>
    {
        public Lezi_naMapiranje()
        {
            Table("LEZI_NA");

            Id(x => x.Mat_br).Column("MAT_BR").GeneratedBy.SequenceIdentity("S18456.LEZI_NA_MAT_BR_SEQ");

            Map(x => x.Vreme_pocetka).Column("VREME_POCETKA");


            References(x => x.Stacionarnis).Column("MAT_BR_P").LazyLoad();
            References(x => x.Odeljenja).Column("SIFRA").LazyLoad();
        }
    }
}