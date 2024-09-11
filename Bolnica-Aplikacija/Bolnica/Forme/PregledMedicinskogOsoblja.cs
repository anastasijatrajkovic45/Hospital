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
    public partial class PregledMedicinskogOsoblja : Form
    {
        OdeljenjeBasic od;
        public PregledMedicinskogOsoblja()
        {
            InitializeComponent();
        }
        public PregledMedicinskogOsoblja(OdeljenjeBasic p)
        {
            InitializeComponent();
            od = p;
        }

        private void PregledMedicinskogOsoblja_Load(object sender, EventArgs e)
        {
             popuniPodacima();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajOsobljeMedicinskoForma formaDodaj = new DodajOsobljeMedicinskoForma();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }
        public void popuniPodacima()
        {


            medicinsko.Items.Clear();
            List<MedicinskoPregled> podaci = DTOManager.vratiMedicinsko();



            foreach (MedicinskoPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {p.Mar_br.ToString(), p.Ime,p.Prezime,p.Radni_staz.ToString(), p.TipLekara,p.BrOrdinacije.ToString(), p.Specijalnost});
                medicinsko.Items.Add(item);

            }
            medicinsko.Refresh();
        }

        private void medicinsko_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (medicinsko.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite osobu cije podatke zelite da izmenite!");
                return;
            }

            int id = Int32.Parse(medicinsko.SelectedItems[0].SubItems[0].Text);
            MedicinskoBasic ob = DTOManager.vratiMedicinsko(id);

            IzmeniOsobljeMedicinskoForma formaUpdate = new IzmeniOsobljeMedicinskoForma(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (medicinsko.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite oosobu koju zelite da obrisete!");
                return;
            }

            int id = Int32.Parse(medicinsko.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu osobu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiOsobljeIzSistema(id);
                MessageBox.Show("Brisanjeosobe je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (medicinsko.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite LEKARA kojem zelite da dodate odeljenje!");
                return;
            }

            int id = Int32.Parse(medicinsko.SelectedItems[0].SubItems[0].Text);
            MedicinskoBasic p = DTOManager.vratiMedicinsko(id);
            PregledOdeljenjaZaLekara forma = new PregledOdeljenjaZaLekara(p);
            forma.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (medicinsko.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite LEKARA kojem zelite da dodelite pacijenta!");
                return;
            }

            int id = Int32.Parse(medicinsko.SelectedItems[0].SubItems[0].Text);
            MedicinskoBasic p = DTOManager.vratiMedicinsko(id);
            PacijentiForma forma = new PacijentiForma(p);
            forma.ShowDialog();

        }
    }
}
