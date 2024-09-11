using Bolnica.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bolnica.Forme
{
    public partial class IzmeniIntervenciju : Form
    {
        IntervencijaBasic intervencija;
        public IzmeniIntervenciju()
        {
            InitializeComponent();
        }
        public IzmeniIntervenciju(IntervencijaBasic o)
        {
            InitializeComponent();
            intervencija = o;
        }

        private void IzmeniIntervenciju_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            textBox1.Text = intervencija.Vrsta;
            dateTimePicker1.Value = intervencija.Datum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            intervencija.Vrsta = textBox1.Text;
            intervencija.Datum= dateTimePicker1.Value;
            DTOManager.izmeniIntervenciju(intervencija);
            MessageBox.Show("Uspesno ste promenili intervenciju!");
            this.Close();
        }
    }
}
