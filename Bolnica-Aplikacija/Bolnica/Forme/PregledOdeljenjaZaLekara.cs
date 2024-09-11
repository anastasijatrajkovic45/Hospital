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
    public partial class PregledOdeljenjaZaLekara : Form
    {
        OdeljenjeBasic odeljenje;
        MedicinskoBasic medicinsko;
        public PregledOdeljenjaZaLekara()
        {
            InitializeComponent();
        }

        private void PregledOdeljenjaZaLekara_Load(object sender, EventArgs e)
        {

        }
        public PregledOdeljenjaZaLekara(OdeljenjeBasic p)
        {
            InitializeComponent();
            odeljenje = p;
        }
        public PregledOdeljenjaZaLekara(MedicinskoBasic p)
        {
            InitializeComponent();
            medicinsko = p;
        }
        public void popuniPodacima()
        {
            odeljenja.Items.Clear();
            List<OdeljenjeBasic> podaci = DTOManager.GetInfoOdeljenjeSpecijalista(medicinsko.Mat_br);

            foreach (OdeljenjeBasic p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Sifra.ToString(), p.Tip, p.Datum_izgradnje.ToString() });
                odeljenja.Items.Add(item);
            }

            odeljenja.Refresh();
        }


        private void buttonDodajOdeljenje_Click(object sender, EventArgs e)
        {
            DodajOdeljenje formaDodaj = new DodajOdeljenje();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void buttonIzmeniOdeljenje_Click(object sender, EventArgs e)
        {
            //if (odeljenja.SelectedItems.Count == 0)
            //{
            //    MessageBox.Show("Izaberite odeljenje cije podatke zelite da izmenite!");
            //    return;
            //}

            //int id = Int32.Parse(odeljenja.SelectedItems[0].SubItems[0].Text);
            //OdeljenjeBasic ob = DTOManager.vratiOdeljenje(id);

            //IzmeniOdeljenje formaUpdate = new IzmeniOdeljenje(ob);
            //formaUpdate.ShowDialog();

            //this.popuniPodacima();
        }

        private void buttonObrisiOdeljenje_Click(object sender, EventArgs e)
        {
            if (odeljenja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite odeljenje koju zelite da obrisete!");
                return;
            }

            int id = Int32.Parse(odeljenja.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrano odeljenje?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiOdeljenje(id);
                MessageBox.Show("Brisanje prodavnice je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}
