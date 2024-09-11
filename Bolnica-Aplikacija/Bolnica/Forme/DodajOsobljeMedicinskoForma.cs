using Bolnica.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolnica.Forme
{
    public partial class DodajOsobljeMedicinskoForma : Form
    {
        MedicinskoBasic medicinsko;
        public DodajOsobljeMedicinskoForma()
        {
            InitializeComponent();
        }
        /*public DodajOsobljeMedicinskoForma(Basic o)
        {
            InitializeComponent();
            odeljenje = o;
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            MedicinskoBasic v = new MedicinskoBasic();

            v.Ime = txtIme.Text;
            v.Prezime = txtPrezime.Text;
            v.TipLekara = txtTipLekara.Text;
            v.Radni_staz = (int)radniStaz.Value;
            v.BrOrdinacije = (int)brojOrdinacije.Value;
            v.Specijalnost = txbSpecijalnost.Text;

            //proveriti jel radi ovo
            if (txtTipLekara.Text == "Lekar opste prakse")
            {
                brojOrdinacije.Visible = true;
                txbSpecijalnost.Visible = false;
            }
            else if (txtTipLekara.Text == "Lekar specijalista")
            {
                brojOrdinacije.Visible = false;
                txbSpecijalnost.Visible = true;
            }
            else
            {
                brojOrdinacije.Visible = false;
                txbSpecijalnost.Visible = false;
            }


            DTOManager.sacuvajMedicinsko(v);
            //ProdajeSeBasic prodaja = new ProdajeSeBasic();
            //prodaja.ProdajeOdeljenje = odeljenje;
            //prodaja.ProdajeProzivod = DTOManager.vratiSveProizvodeBasic().OrderByDescending(item => item.BarKod).First();
            DTOManager.sacuvajMedicinsko(medicinsko);
            MessageBox.Show("Uspesno ste dodali medicinsko osoblje!");
            this.Close();
        }

    }
}
