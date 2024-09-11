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

namespace Bolnica.Forme
{
    public partial class IzmeniPacijentAmbulantniForma : Form
    {
        AmbulantniBasic pacijent;
        
        public IzmeniPacijentAmbulantniForma()
        {
            InitializeComponent();
        }

        public IzmeniPacijentAmbulantniForma(AmbulantniBasic o)
        {
            InitializeComponent();
            pacijent = o;
        }
        private void IzmeniPacijentAmbulantniForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            txtIme.Text = pacijent.Ime;
            txtPrezime.Text = pacijent.Prezime;
            txtUlica.Text = pacijent.Ulica;
            broj.Value = pacijent.Broj;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pacijent.Ime = txtIme.Text;
            pacijent.Prezime = txtPrezime.Text;
            pacijent.Ulica = txtUlica.Text;
            pacijent.Broj = (int)broj.Value;

            DTOManager.izmeniAmbulantni(pacijent);
            MessageBox.Show("Uspesno ste izmenili pacijenta!");
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
