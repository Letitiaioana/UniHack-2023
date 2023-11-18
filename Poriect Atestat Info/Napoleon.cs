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
    public partial class Napoleon : Form
    {

        Loadform loadf = new Loadform();

        int cnt = 1;


        public Napoleon()
        {
            InitializeComponent();
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            btn_back.Text = "Back to Maps";
            btn_forward.Text = "Next slide";
        }

        private void Napoleon_Load(object sender, EventArgs e)
        {
            panel2.BackgroundImage = Image.FromFile(Application.StartupPath + @"\razboaiele napoleoniene\" + cnt + ".jpg");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if ( cnt == 1 )
            {
                loadf.loadform(new Form_mapa(), Form_start.instance.panelm);
            }
            else
            {
                cnt--;
                panel2.BackgroundImage = Image.FromFile(Application.StartupPath + @"\razboaiele napoleoniene\" + cnt + ".jpg");
                if ( cnt == 5 )
                {
                    btn_forward.Visible = true;
                }
                if ( cnt == 1 )
                {
                    btn_back.Text = "Back to Maps";
                }
            }
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            cnt++;
            panel2.BackgroundImage = Image.FromFile(Application.StartupPath + @"\razboaiele napoleoniene\" + cnt + ".jpg");
            btn_back.Text = "Previous slide";
            if ( cnt == 6 )
            {
                btn_forward.Visible = false;
                
            }
        }
    }
}
