using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bolnica.Forme
{
    public partial class DodajSmenu : Form
    {
        SmenaBasic smena;
        public DodajSmenu()
        {
            InitializeComponent();
        }
        public DodajSmenu(SmenaBasic smena)
        {
            InitializeComponent();
            this.smena = smena;
        }

        private void DodajSmenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonDodajSmenu_Click(object sender, EventArgs e)
        {
            SmenaBasic o = new SmenaBasic();
            o.Tip_smene = textBoxSmena.Text;
            DTOManager.sacuvajSmenu(o);
            MessageBox.Show("Uspesno ste dodali novu smenu!");
            this.Close();
        }
    }
}
