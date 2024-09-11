using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entiteti
{
    public class Nemedicinsko : Osoblje
    {
        public virtual string TipOdrzavanja { get; set; }
        public virtual string Struka { get; set; }

        //Veza 1:N Odrzava
        public virtual IList<Stomatoloska_stolica> Stomatoloske_Stolice { get; set; }

        //Veza N:M Odrzava_Higijenu_Na
        public virtual IList<Odrzava_higijenu_na> Odrzavaju_higijenu { get; set; }

        public Nemedicinsko()
        {
            Stomatoloske_Stolice = new List<Stomatoloska_stolica>();
            Odrzavaju_higijenu = new List<Odrzava_higijenu_na>();
        }
    }
}