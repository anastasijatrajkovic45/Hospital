using Bolnica.Entiteti;
using Remotion.Linq.Parsing.Structure.IntermediateModel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Bolnica.Forme
{
    public partial class IzmeniOsobljeMedicinskoForma : Form
    {
        MedicinskoBasic medicinsko;
        public IzmeniOsobljeMedicinskoForma()
        {
            InitializeComponent();
        }
        public IzmeniOsobljeMedicinskoForma(MedicinskoBasic dl)
        {
            InitializeComponent();
            medicinsko = dl;
            //popuniPodacima();
        }
        private void IzmeniOsobljeMedicinskoForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            txtIme.Text = medicinsko.Ime;
            txtPrezime.Text = medicinsko.Prezime;
            txtTipLekara.Text = medicinsko.TipLekara;
            radniStaz.Value = medicinsko.Radni_staz;
            brojOrdinacije.Value = medicinsko.BrOrdinacije;
            txbSpecijalnost.Text = medicinsko.Specijalnost;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            medicinsko.Ime = txtIme.Text;
            medicinsko.Prezime = txtPrezime.Text;
            medicinsko.TipLekara = txtTipLekara.Text;
            medicinsko.Radni_staz = (int)radniStaz.Value;
            medicinsko.BrOrdinacije = (int)brojOrdinacije.Value;
            medicinsko.Specijalnost = txbSpecijalnost.Text;

            DTOManager.izmeniMedicinsko(medicinsko);
            MessageBox.Show("Uspesno ste izmenili medicinsko osoblje!");
            this.Close();
        }

    }
}
