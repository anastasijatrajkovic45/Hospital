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
    public partial class DodajIntervenciju : Form
    {
        IntervencijaBasic intervencija;
        public DodajIntervenciju()
        {
            InitializeComponent();
        }
        public DodajIntervenciju(IntervencijaBasic intervencija)
        {
            InitializeComponent();
            this.intervencija = intervencija;
        }

        private void DodajIntervenciju_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntervencijaBasic o = new IntervencijaBasic();
            o.Vrsta = textBox1.Text;
            o.Datum = dateTimePicker1.Value;
            DTOManager.sacuvajIntervencijuu(o);
            MessageBox.Show("Uspesno ste dodali novu intervenciju!");
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
