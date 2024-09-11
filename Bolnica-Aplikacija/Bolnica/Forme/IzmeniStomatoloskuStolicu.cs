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
    public partial class IzmeniStomatoloskuStolicu : Form
    {
        Stomatoloska_stolicaBasic stolica;
        public IzmeniStomatoloskuStolicu()
        {
            InitializeComponent();
        }
        public IzmeniStomatoloskuStolicu(Stomatoloska_stolicaBasic o)
        {
            InitializeComponent();
            stolica = o;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void IzmeniStomatoloskuStolicu_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            textBox1.Text = stolica.Proizvodjac;
            dateTimePicker1.Value = stolica.Datum_proizvodnje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stolica.Proizvodjac= textBox1.Text;
            stolica.Datum_proizvodnje=dateTimePicker1.Value;
            DTOManager.izmeniStomatoloskuStolicu(stolica);
            MessageBox.Show("Uspesno ste promenili stomatolosku stolicu!");
            this.Close();
        }
    }
}
