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
    public partial class DodajOdeljenje : Form
    {
        OdeljenjeBasic odeljenje;
        public DodajOdeljenje()
        {
            InitializeComponent();
        }
        public DodajOdeljenje(OdeljenjeBasic p)
        {
            InitializeComponent();
            odeljenje = p;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OdeljenjeBasic o = new OdeljenjeBasic();
            o.Tip = textBox1.Text;
            o.Datum_izgradnje = dateTimePicker1.Value;
            DTOManager.sacuvajOdeljenje(o);
            MessageBox.Show("Uspesno ste dodali novo odeljenje!");
            this.Close();
        }
    }
}
