using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public class Osoblje
    {
        public virtual int MatBr { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }

        public Osoblje()
        {

        }
    }
}