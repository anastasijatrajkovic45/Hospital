using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public class Smena
    {
        public virtual int Id { get; set; }
        public virtual string Tip_smene { get; set; }
        //N-arna veza RADI_NA
        //public virtual IList<Radi_na> Rade_na_stolici { get; set; }
        //public virtual IList<Radi_na> Stomatolozi_rade { get; set; }

        public Smena()
        {
            //Rade_na_stolici = new List<Radi_na>();
            //Stomatolozi_rade = new List<Radi_na>();
        }
    }
}