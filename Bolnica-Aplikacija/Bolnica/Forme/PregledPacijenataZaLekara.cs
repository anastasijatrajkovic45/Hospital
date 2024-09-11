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
    public partial class PregledPacijenataZaLekara : Form
    {
        PacijentBasic odeljenje;
        MedicinskoBasic medicinsko;
        public PregledPacijenataZaLekara()
        {
            InitializeComponent();
        }
        public PregledPacijenataZaLekara(MedicinskoBasic p)
        {
            InitializeComponent();
            medicinsko = p;
        }

        private void PregledPacijenataZaLekara_Load(object sender, EventArgs e)
        {

        }
        public void popuniPodacima()
        {
            pacijenti1.Items.Clear();
            List<PacijentBasic> podaci = DTOManager.GetInfoOdeljenjeSpecijalista(medicinsko.Mat_br);

            foreach (OdeljenjeBasic p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Sifra.ToString(), p.Tip, p.Datum_izgradnje.ToString() });
                odeljenja.Items.Add(item);
            }

            odeljenja.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajPacijentStacionarniForma formaDodaj = new DodajPacijentStacionarniForma();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void buttonDodajOdeljenje_Click(object sender, EventArgs e)
        {
            DodajPacijentAmbulantniForma formaDodaj = new DodajPacijentAmbulantniForma();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
