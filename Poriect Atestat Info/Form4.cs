using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poriect_Atestat_Info
{
    public partial class Form_mapa : Form
    {

        Loadform loadf = new Loadform();

        bool oke;
        Point formStartLocation = new Point();

        int originalFormWidth, originalFormHeight,
            originalImageWidth, originalImageHeight, originalImageLeft, originalImageTop;

        

        float widthRatio, heightRatio;

        public Form_mapa()
        {
            InitializeComponent();

            

            gettingData();
            Form_start.instance.WindowState = FormWindowState.Maximized;
            settingForm();
            


           

            formStartLocation = Form_start.instance.Location;
            mapa_europa.Image = Image.FromFile(Application.StartupPath + @"\mape\7yearswar.jpg");
        }
        
        private void gettingData()
        {
            originalFormHeight = Form_start.instance.Size.Height;
            originalFormWidth = Form_start.instance.Size.Width;

            originalImageHeight = mapa_europa.Size.Height;
            originalImageWidth = mapa_europa.Size.Width;
            originalImageLeft = mapa_europa.Left;
            originalImageTop = mapa_europa.Top;

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_start.instance.WindowState = FormWindowState.Normal;
            Form_start.instance.Size = Form_start.instance.size;
            loadf.loadform(new ColdWar(), Form_start.instance.panelm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_start.instance.WindowState = FormWindowState.Normal;
            Form_start.instance.Size = Form_start.instance.size;
            loadf.loadform(new UnificareaGermaniei(), Form_start.instance.panelm);
        }

        private void btn_napoleon_Click(object sender, EventArgs e)
        {
            Form_start.instance.WindowState = FormWindowState.Normal;
            Form_start.instance.Size = Form_start.instance.size;
            loadf.loadform(new Napoleon(), Form_start.instance.panelm);
        }

        private void btn_7years_Click(object sender, EventArgs e)
        {
            Form_start.instance.WindowState = FormWindowState.Normal;
            Form_start.instance.Size = Form_start.instance.size;
            loadf.loadform(new _7YearsWar(), Form_start.instance.panelm);
        }

        private void btn_coldwar_MouseHover(object sender, EventArgs e)
        {
            mapa_europa.Image = Image.FromFile( Application.StartupPath + @"\mape\razboiul-rece.jpg");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            mapa_europa.Image = Image.FromFile(Application.StartupPath + @"\mape\1848true.jpg");
        }

        private void btn_napoleon_MouseHover(object sender, EventArgs e)
        {
            mapa_europa.Image = Image.FromFile(Application.StartupPath + @"\mape\napoleon.jpg");
        }

        private void btn_7years_MouseHover(object sender, EventArgs e)
        {
            mapa_europa.Image = Image.FromFile(Application.StartupPath + @"\mape\7yearswar.jpg");
        }

        private void settingForm()
        {
            
            widthRatio = (float)Form_start.instance.Size.Width / originalFormWidth;
            heightRatio = (float)Form_start.instance.Size.Height / originalFormHeight;

            mapa_europa.Width = (int)(originalImageWidth * widthRatio);
            mapa_europa.Height = (int)(originalImageHeight * heightRatio);
            mapa_europa.Left = (int)(originalImageLeft * widthRatio);
            mapa_europa.Top = (int)(originalImageTop * heightRatio);

        }

        private void CheckMousePosition()
        {
            oke = Form_start.ok;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            


            CheckMousePosition();

            if ( MousePosition.X > Form_start.instance.Right - 100  && oke == true ) 
                mapa_europa.Left -= 5;
            if ( MousePosition.X < Form_start.instance.Left + 100   && oke == true )
                mapa_europa.Left += 5;
            if ( MousePosition.Y > Form_start.instance.Bottom - 100 && oke == true )
                mapa_europa.Top -= 5;
            if ( MousePosition.Y < Form_start.instance.Top + 100    && oke == true )
                mapa_europa.Top += 5;

            if (  0 < mapa_europa.Left  )
            {
                mapa_europa.Location = new Point ( Form_start.instance.Left - formStartLocation.X , mapa_europa.Top );
            }

            if ( Form_start.instance.Right > mapa_europa.Right)
            {
                mapa_europa.Location = new Point ( Form_start.instance.Right - mapa_europa.Width, mapa_europa.Top );
            }
            if ( 0 < mapa_europa.Top )
            {
                mapa_europa.Location = new Point ( mapa_europa.Left , Form_start.instance.Top - formStartLocation.Y );
            }
            if ( Form_start.instance.Bottom > mapa_europa.Bottom )
            {
                mapa_europa.Location = new Point ( mapa_europa.Left, Form_start.instance.Bottom - mapa_europa.Height );
            }


            
        }

        

        private void Form_mapa_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Form_mapa_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_start.instance.WindowState = FormWindowState.Normal;
            Form_start.instance.Size = new System.Drawing.Size(1047, 656);
            loadf.loadform(new Principal_Menu(), Form_start.instance.panelm);
            this.Close();
        }
    }

}
