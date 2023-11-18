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
    public partial class _7YearsWar : Form
    {
        Loadform loadf = new Loadform();

        int cnt = 1;

        public _7YearsWar()
        {
            InitializeComponent();
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            btn_back.Text = "Back to Maps";
            btn_forward.Text = "Next slide";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (cnt == 1)
            {
                loadf.loadform(new Form_mapa(), Form_start.instance.panelm);
            }
            else
            {
                cnt--;
                panel1.BackgroundImage = Image.FromFile(Application.StartupPath + @"\razboiul de 7 ani\" + cnt + ".jpg");
                if (cnt == 1)
                {
                    btn_forward.Visible = true;
                }
                if (cnt == 1)
                {
                    btn_back.Text = "Back to Maps";
                }
            }
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            cnt++;
            panel1.BackgroundImage = Image.FromFile(Application.StartupPath + @"\razboiul de 7 ani\" + cnt + ".jpg");
            btn_back.Text = "Previous slide";
            if (cnt == 2)
            {
                btn_forward.Visible = false;
                
            }
        }

        private void _7YearsWar_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImage = Image.FromFile(Application.StartupPath + @"\razboiul de 7 ani\" + cnt + ".jpg");
        }
    }
}
