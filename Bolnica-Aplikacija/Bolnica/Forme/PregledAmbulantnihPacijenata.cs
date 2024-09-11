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
    public partial class PregledAmbulantnihPacijenata : Form
    {
        public PregledAmbulantnihPacijenata()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajPacijentAmbulantniForma forma = new DodajPacijentAmbulantniForma();
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //IzmeniPacijentAmbulantniForma forma = new IzmeniPacijentAmbulantniForma();
            //forma.ShowDialog();
            if (pacijenti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite paicjenta cije podatke zelite da izmenite!");
                return;
            }

            int idPacijenta = Int32.Parse(pacijenti.SelectedItems[0].SubItems[0].Text);
            AmbulantniBasic ob = DTOManager.vratiPacijentAmbulantni(idPacijenta);

            IzmeniPacijentAmbulantniForma formaUpdate = new IzmeniPacijentAmbulantniForma(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }
        public void popuniPodacima()
        {


            pacijenti.Items.Clear();
            List<AmbulantniPregled> podaci = DTOManager.vratiSveAmbulantne();



            foreach (AmbulantniPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Mat_br.ToString(), p.Ime, p.Prezime, p.Ulica, p.Broj.ToString()});
                pacijenti.Items.Add(item);

            }



            pacijenti.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)//brisanje ambulantnog
        {
            if (pacijenti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite pacijenta koga zelite da obrisete!");
                return;
            }

            int idPacijenta = Int32.Parse(pacijenti.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog pacijenta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiAmbulantni(idPacijenta);
                MessageBox.Show("Brisanje pacijenta je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DodajIntervenciju forma = new DodajIntervenciju();
            forma.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IzmeniIntervenciju forma = new IzmeniIntervenciju();
            forma.ShowDialog();
        }
    }
}
