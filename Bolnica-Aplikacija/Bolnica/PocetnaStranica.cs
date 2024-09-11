using Bolnica.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolnica
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }

       
        private void btnOsoblje_Click(object sender, EventArgs e)
        {
            OsobljeForma forma = new OsobljeForma();
            forma.ShowDialog();
        }

        private void btnPacijenti_Click(object sender, EventArgs e)
        {
            PacijentiForma forma=new PacijentiForma();
            forma.ShowDialog();
        }

        private void btnOdeljenja_Click(object sender, EventArgs e)
        {
            OdeljenjaForma forma= new OdeljenjaForma();
            forma.ShowDialog();
        }
    }
}
