using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolnica.Forme
{
    public partial class PacijentiForma : Form
    {
        MedicinskoBasic medicinsko;
        public PacijentiForma()
        {
            InitializeComponent();
        }
        public PacijentiForma(MedicinskoBasic p)
        {
            InitializeComponent();
            medicinsko = p;
        }

        private void odeljenja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAmbulantni_Click(object sender, EventArgs e)
        {
            PregledAmbulantnihPacijenata forma = new PregledAmbulantnihPacijenata();
            forma.ShowDialog();
        }

        private void buttonStacionarni_Click(object sender, EventArgs e)
        {
            PregledStacionarnihPacijenata forma = new PregledStacionarnihPacijenata();
            forma.ShowDialog();
        }

        private void buttonDodajPacijenta_Click(object sender, EventArgs e)
        {
        }
    }
}
