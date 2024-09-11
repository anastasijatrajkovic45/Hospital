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
    public partial class DodajPacijentAmbulantniForma : Form
    {
        PacijentBasic pacijent;
        public DodajPacijentAmbulantniForma()
        {
            InitializeComponent();
        }
        /*
        public DodajPacijentAmulantniForma(PacijentBasic p)
        {
            InitializeComponent();
            pacijent = p;
        }*/

        private void DodajPacijentAmbulantniForma_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AmbulantniBasic o = new AmbulantniBasic();
            o.Ime = txtIme.Text;
            o.Prezime = txtPrezime.Text;
            o.Ulica = txtUlica.Text;
            o.Broj = (int)broj.Value;

            //veza 1:n ssa lekarom opste prakse treba ovde
            //o.Pacijent = pacijent;
            DTOManager.sacuvajAmbulantni(o);
            MessageBox.Show("Uspesno ste dodali novog ambulantnog pacijenta!");
            this.Close();
        }

        private void DodajPacijentAmbulantniForma_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
