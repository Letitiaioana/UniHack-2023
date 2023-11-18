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
    public partial class UnificareaGermaniei : Form
    {

        Loadform loadf = new Loadform();

        int cnt = 1;

        public UnificareaGermaniei()
        {
            InitializeComponent();
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            btn_back.Text = "Back to Maps";
            btn_forward.Text = "Next slide";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            panel2.BackgroundImage = Image.FromFile(Application.StartupPath + @"\unirea germaniei\" + cnt + ".jpg");
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            cnt++;
            panel2.BackgroundImage = Image.FromFile(Application.StartupPath + @"\unirea germaniei\" + cnt + ".jpg");
            btn_back.Text = "Previous slide";
            if (cnt == 5)
            {
                btn_forward.Visible = false;
                
            }
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
                panel2.BackgroundImage = Image.FromFile(Application.StartupPath + @"\unirea germaniei\" + cnt + ".jpg");
                if (cnt == 4)
                {
                    btn_forward.Visible = true;
                }
                if (cnt == 1)
                {
                    btn_back.Text = "Back to Maps";
                }
            }
        }
    }
}
