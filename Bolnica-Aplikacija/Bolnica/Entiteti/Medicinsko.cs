using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public class Medicinsko : Osoblje
    {
        public virtual int Radni_staz { get; set; }
        public virtual string Tip_lekara { get; set; }
        public virtual int Broj_ordinacije { get; set; }
        public virtual string Specijalnost { get; set; }


        //Veza 1:N ZADUZEN_ZA
        public virtual IList<Odeljenje> Odeljenja { get; set; }
        //Veza 1:N LECI
        public virtual IList<Pacijent> Pacijenti { get; set; }
        //Veza 1:N PRATI
        public virtual IList<Stacionarni> Stacionarnis { get; set; }

        //N-arna veza RADI_NA
        //public virtual Radi_na Rade_na_stolici { get; set; }
        //public virtual IList<Radi_na> Rade_u_smeni { get; set; }

        ////N-arna veza OBAVLJA
        //public virtual IList<Obavlja> ObavljaIntervenciju { get; set; }
        //public virtual IList<Obavlja> Obavlja_nad_Ambulantnim { get; set; }

        public Medicinsko()
        {
            Odeljenja = new List<Odeljenje>();
            Pacijenti = new List<Pacijent>();
            Stacionarnis = new List<Stacionarni>();

            //Rade_u_smeni = new List<Radi_na>();

            //ObavljaIntervenciju = new List<Obavlja>();
            //Obavlja_nad_Ambulantnim = new List<Obavlja>();
        }
    }
}