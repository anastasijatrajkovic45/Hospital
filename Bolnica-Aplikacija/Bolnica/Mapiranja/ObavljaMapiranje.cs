using Bolnica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Mapiranja
{
    class ObavljaMapiranje : ClassMap<Obavlja>
    {
        public ObavljaMapiranje()
        {
            Table("OBAVLJA");

            Id(x => x.Mat_br).Column("MAT_BR").GeneratedBy.SequenceIdentity("S18456.OBAVLJA_MAT_BR_SEQ");

            Map(x => x.Vreme_intervencije).Column("VREME_INTERVENCIJE");

            //References(x => x.Stomatolog).Column("MAT_BR_S").LazyLoad();
            //References(x => x.AmbulantniPacijent).Column("MAT_BR_P").LazyLoad();
            //References(x => x.Intervencija).Column("VRSTA").LazyLoad();
        }
    }
}
