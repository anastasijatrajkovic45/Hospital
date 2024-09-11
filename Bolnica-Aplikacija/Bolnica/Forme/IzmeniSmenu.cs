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
    public partial class IzmeniSmenu : Form
    {
        SmenaBasic smena;
        public IzmeniSmenu()
        {

        }
        public IzmeniSmenu(SmenaBasic o)
        {
            InitializeComponent();
            smena = o;
        }

        private void IzmeniSmenu_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            textBox1.Text = smena.Tip_smene;
        }

        private void buttonIzmeniSmenu_Click(object sender, EventArgs e)
        {
            smena.Tip_smene = textBox1.Text;
            DTOManager.izmeniSmenu(smena);
            MessageBox.Show("Uspesno ste promenili smenu!");
            this.Close();
        }
    }
}
