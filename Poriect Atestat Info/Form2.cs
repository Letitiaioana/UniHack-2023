using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poriect_Atestat_Info
{
    public partial class Principal_Menu : Form
    {
        Loadform loadf = new Loadform();

        public static Principal_Menu instance;

        public Principal_Menu()
        {
            InitializeComponent();
            instance = this;
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            loadf.loadform(new Form_Test(), Form_start.instance.panelm);
        }

        private void button_incepe_Click(object sender, EventArgs e)
        {
            loadf.loadform(new Form_mapa(), Form_start.instance.panelm);
        }

        private void Principal_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
