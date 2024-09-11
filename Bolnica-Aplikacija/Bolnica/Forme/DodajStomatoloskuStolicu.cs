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
    public partial class DodajStomatoloskuStolicu : Form
    {
        Stomatoloska_stolicaBasic stolica;
        public DodajStomatoloskuStolicu()
        {
            InitializeComponent();
        }
        public DodajStomatoloskuStolicu(Stomatoloska_stolicaBasic stolica)
        {
            InitializeComponent();
            this.stolica = stolica;
        }

        private void DodajStomatoloskuStolicu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stomatoloska_stolicaBasic o = new Stomatoloska_stolicaBasic();
            o.Proizvodjac = textBox1.Text;
            o.Datum_proizvodnje = dateTimePicker1.Value;
            DTOManager.sacuvajStomatoloskeStolice(o);
            MessageBox.Show("Uspesno ste dodali novu stomatolosku stolicu!");
            this.Close();
        }
    }
}
