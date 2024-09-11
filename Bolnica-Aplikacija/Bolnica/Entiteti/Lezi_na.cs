using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public class Lezi_na
    {
        public virtual int Mat_br { get; set; }
        public virtual DateTime Vreme_pocetka { get; set; }

        public virtual Stacionarni Stacionarnis { get; set; }
        public virtual Odeljenje Odeljenja { get; set; }
        public Lezi_na()
        {

        }
    }
}