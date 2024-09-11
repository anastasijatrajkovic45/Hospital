using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public class Radi_na
    {
        public virtual int Mat_br { get; set; }

        public virtual Medicinsko Stomatolog { get; set; }
        public virtual Stomatoloska_stolica StomatoloskaStolica { get; set; }
        public virtual Smena Smena { get; set; }
        public Radi_na()
        {

        }
    }
}
