using Bolnica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Mapiranja
{
    class PacijentMapiranje : ClassMap<Pacijent>
    {
        public PacijentMapiranje()
        {
            Table("PACIJENT");

            Id(x => x.Mat_br_pac).Column("MAT_BR").GeneratedBy.SequenceIdentity("S18456.PACIJENT_MAT_BR_SEQ");

            DiscriminateSubClassesOnColumn("TIP_PACIJENTA");

            Map(x => x.Ime_pac).Column("IME");
            Map(x => x.Prezime_pac).Column("PREZIME");
            Map(x => x.Ulica).Column("ULICA");
            Map(x => x.Broj).Column("BROJ");
            Map(x => x.Datum_prijema).Column("DATUM_PRIJEMA");
            Map(x => x.Datum_otpusta).Column("DATUM_OTPUSTA");

            //Veza 1:N -- Pacijent : Lekar opste prakse (Medicinsko)
            References(x => x.Pripada_Lekaru_Opste_prakse).Column("MAT_BR_LOP").LazyLoad();
        }
    }
    public class AmbulantniMapiranje : SubclassMap<Ambulantni>
    {
        public AmbulantniMapiranje()
        {
            DiscriminatorValue("AMBULANTNI");

            //N-arna veza RADI_NA
            //References(x => x.Stomatolog).Column("MAT_BR_S").LazyLoad().Cascade.All();
            //HasMany(x => x.Intervencije).KeyColumn("VRSTA").LazyLoad().Cascade.All();
        }
    }
    public class StacionarniMapiranje : SubclassMap<Stacionarni>
    {
        public StacionarniMapiranje()
        {
            DiscriminatorValue("STACIONARNI");

            //Veza 1:N --Stacionarni (Pacijent) : Lekar specijalista (Medicinsko)
            References(x => x.Pripada_Lekaru_Specijalisti).Column("MAT_BR_LSPEC").LazyLoad();

            //strani kljuc kod veze N:M LEZI_NA
            HasMany(x => x.Leze_na_odeljenju).KeyColumn("MAT_BR_P").LazyLoad().Cascade.All().Inverse();
        }
    }
}