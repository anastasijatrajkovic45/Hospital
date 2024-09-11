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
    public partial class IzmeniOdeljenje : Form
    {
        OdeljenjeBasic odeljenje;
        public IzmeniOdeljenje()
        {
            InitializeComponent();
        }
        public IzmeniOdeljenje(OdeljenjeBasic o)
        {
            InitializeComponent();
            odeljenje = o;  
        }

        private void IzmeniOdeljenje_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            textBox1.Text= odeljenje.Tip;
            dateTimePicker1.Value = odeljenje.Datum_izgradnje;
        }
        private void buttonIzmeniOdeljenje_Click(object sender, EventArgs e)
        {
            odeljenje.Tip = textBox1.Text;
            odeljenje.Datum_izgradnje = dateTimePicker1.Value;
            DTOManager.izmeniOdeljenje(odeljenje);
            MessageBox.Show("Uspesno ste izmenili odeljenje!");
            this.Close();

        }
    }
}
