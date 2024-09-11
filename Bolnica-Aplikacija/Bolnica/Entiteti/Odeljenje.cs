using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public class Odeljenje
    {
        public virtual int Sifra { get; set; }
        public virtual string Tip { get; set; }
        public virtual DateTime Datum_izgradnje { get; set; }


        public virtual Medicinsko Pripada_Specijalisti { get; set; }

        //Veza N:M LEZI_NA
        public virtual IList<Lezi_na> Leze_stacionarni { get; set; }

        public virtual IList<Odrzava_higijenu_na> Odrzavaju_odeljenja { get; set; }

        public Odeljenje()
        {
            Leze_stacionarni = new List<Lezi_na>();
            Odrzavaju_odeljenja = new List<Odrzava_higijenu_na>();
        }
    }
}



