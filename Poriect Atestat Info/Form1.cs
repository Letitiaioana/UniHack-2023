using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poriect_Atestat_Info
{
    public partial class Form_start : Form
    {
        Loadform loadf = new Loadform();

        public static Form_start instance;
        public Panel panelm;
        public Size size;
        public static bool ok;

        public Form_start()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            instance = this;
            panelm = main_panel;
            size = this.Size;
            
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Form_start_Load(object sender, EventArgs e)
        {
            loadf.loadform(new Principal_Menu(), main_panel); // Principal_Menu
        }

   

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Timer_Tick ( object sender, EventArgs e )
        {
            Point cursorpoint = this.PointToClient(Cursor.Position);
            ok = this.ClientRectangle.Contains(cursorpoint);
        }











        private void Form_start_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void Form_start_MouseLeave(object sender, EventArgs e)
        {
      
        }

        private void Form_start_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void upperpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
