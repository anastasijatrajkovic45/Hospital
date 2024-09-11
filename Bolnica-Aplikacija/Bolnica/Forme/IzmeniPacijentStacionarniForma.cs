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
    public partial class IzmeniPacijentStacionarniForma : Form
    {
        StacionarniBasic pacijent;
        public IzmeniPacijentStacionarniForma()
        {
            InitializeComponent();
        }

        public IzmeniPacijentStacionarniForma(StacionarniBasic o)
        {
            InitializeComponent();
            pacijent = o;
        }
        private void IzmeniPacijentStacionarniForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            txtIme.Text = pacijent.Ime;
            txtPrezime.Text = pacijent.Prezime;
            datumPrijema.Value = pacijent.Datum_prijema;
            datumOtpusta.Value = pacijent.Datum_otpusta;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pacijent.Ime = txtIme.Text;
            pacijent.Prezime = txtPrezime.Text;
            pacijent.Datum_prijema = datumPrijema.Value;
            pacijent.Datum_otpusta = datumOtpusta.Value;

            DTOManager.izmeniStacionarni(pacijent);
            MessageBox.Show("Uspesno ste izmenili pacijenta!");
            this.Close();
        }
    }
}
