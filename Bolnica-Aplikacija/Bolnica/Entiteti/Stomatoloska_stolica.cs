using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public class Stomatoloska_stolica
    {
        public virtual string Proizvodjac { get; set; }
        public virtual DateTime Datum_proizvodnje { get; set; }

        public virtual Nemedicinsko Pripada_tehnickom_osoblju { get; set; }

        //N-arna veza RADI_NA
        //public virtual IList<Radi_na> Rade_u_smeni { get; set; }
        //public virtual Radi_na Radi_stomatolog { get; set; }

        public Stomatoloska_stolica()
        {
            //Rade_u_smeni = new List<Radi_na>();
        }
    }
}