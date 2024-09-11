using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public class Pacijent
    {
        public virtual int Mat_br_pac { get; set; }
        public virtual string Ime_pac { get; set; }
        public virtual string Prezime_pac { get; set; }
        public virtual string Tip_pacijenta { get; set; }
        public virtual string Ulica { get; set; }
        public virtual int Broj { get; set; }
        public virtual DateTime Datum_prijema { get; set; }
        public virtual DateTime Datum_otpusta { get; set; }

        //Veza 1:N LECI
        public virtual Medicinsko Pripada_Lekaru_Opste_prakse { get; set; }

        public Pacijent()
        {

        }
    }
    public class Ambulantni : Pacijent
    {
        //N-arna veza OBAVLJA
        //public virtual Obavlja Stomatolog { get; set; }
        //public virtual IList<Obavlja> Intervencije { get; set;}

        public Ambulantni()
        {
            //Intervencije = new List<Obavlja>();
        }

    }
    public class Stacionarni : Pacijent
    {
        //Veza 1:N PRATI
        public virtual Medicinsko Pripada_Lekaru_Specijalisti { get; set; }

        //Veza N:M LEZI_NA
        public virtual IList<Lezi_na> Leze_na_odeljenju { get; set; }

        public Stacionarni()
        {
            Leze_na_odeljenju = new List<Lezi_na>();
        }
    }
}