using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public class Intervencija
    {
        public virtual string Vrsta { get; set; }
        public virtual DateTime Datum { get; set; }

        //N-arna veza OBAVLJA
        //public virtual Obavlja Stomatolog { get; set; }
        //public virtual IList<Obavlja> Nad_ambulatnim { get; set; }
        //public Intervencija()
        //{
        //    //Nad_ambulatnim = new List<Obavlja>();
        //}
    }
}
