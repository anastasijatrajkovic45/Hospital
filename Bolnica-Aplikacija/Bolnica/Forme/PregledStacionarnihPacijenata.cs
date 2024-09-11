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
    public partial class PregledStacionarnihPacijenata : Form
    {
        public PregledStacionarnihPacijenata()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DodajOdeljenje forma = new DodajOdeljenje();
            forma.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            IzmeniOdeljenje forma = new IzmeniOdeljenje();
            forma.ShowDialog();
        }

        private void buttonDodajOdeljenje_Click(object sender, EventArgs e)
        {
            DodajPacijentStacionarniForma forma = new DodajPacijentStacionarniForma();
            forma.ShowDialog();
        }

        private void buttonIzmeniOdeljenje_Click(object sender, EventArgs e)
        {
            //IzmeniPacijentStacionarniForma forma = new IzmeniPacijentStacionarniForma();
            //forma.ShowDialog();
            if (pacijenti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite paicjenta cije podatke zelite da izmenite!");
                return;
            }

            int idPacijenta = Int32.Parse(pacijenti.SelectedItems[0].SubItems[0].Text);
            StacionarniBasic ob = DTOManager.vratiPacijentStacionarni(idPacijenta);

            IzmeniPacijentStacionarniForma formaUpdate = new IzmeniPacijentStacionarniForma(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        public void popuniPodacima()
        {


            pacijenti.Items.Clear();
            List<StacionarniPregled> podaci = DTOManager.vratiSveStacionarne();



            foreach (StacionarniPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Mat_br.ToString(), p.Ime, p.Prezime, p.Datum_prijema.ToString(), p.Datum_otpusta.ToString()});
                pacijenti.Items.Add(item);

            }



            pacijenti.Refresh();
        }

        private void buttonObrisiOdeljenje_Click(object sender, EventArgs e)
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
                DTOManager.obrisiStacionarni(idPacijenta);
                MessageBox.Show("Brisanje pacijenta je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}
