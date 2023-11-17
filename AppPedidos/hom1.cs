using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPedidos
{
    public partial class Usuario : Form
    {
        bool sideBarExpand;
        public Usuario()
        {
            InitializeComponent();
        }

        private void btnMenubar_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {

            //Coloquemos el maximo y el minimo de la animacion de la barra
            if (sideBarExpand)
            {
                //si la sidebar esta expandida, se minimiza.
                sidebartop1.Height -= 10;
                if (sidebartop1.Height == sidebartop1.MinimumSize.Height)
                {
                    sideBarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebartop1.Height += 10;
                if (sidebartop1.Height == sidebartop1.MaximumSize.Height)
                {
                    sideBarExpand = true;
                    sidebarTimer.Stop();

                }
            }
        }

        private void sidebarLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sideBarTimer_Tick2(object sender, EventArgs e)
        {
            //Coloquemos el maximo y el minimo de la animacion de la barra
            if (sideBarExpand)
            {
                //si la sidebar esta expandida, se minimiza.
                sidebarLateral.Width -= 10;
                if (sidebarLateral.Width == sidebarLateral.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    timer1.Stop();
                }
            }
            else
            {
                sidebarLateral.Width += 10;
                if (sidebarLateral.Width == sidebarLateral.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    timer1.Stop();

                }
            }
        }


        private void iconButton44_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sideBarTimer_Tick3(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                //si la sidebar esta expandida, se minimiza.
                sidebartop2.Height -= 10;
                if (sidebartop2.Height == sidebartop2.MinimumSize.Height)
                {
                    sideBarExpand = false;
                    timer2.Stop();
                }
            }
            else
            {
                sidebartop2.Height += 10;
                if (sidebartop2.Height == sidebartop2.MaximumSize.Height)
                {
                    sideBarExpand = true;
                    timer2.Stop();

                }
            }
        }

        private void sideBarTimer_Tick4(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                //si la sidebar esta expandida, se minimiza.
                sidebartop3.Height -= 10;
                if (sidebartop3.Height == sidebartop3.MinimumSize.Height)
                {
                    sideBarExpand = false;
                    timer3.Stop();
                }
            }
            else
            {
                sidebartop3.Height += 10;
                if (sidebartop3.Height == sidebartop3.MaximumSize.Height)
                {
                    sideBarExpand = true;
                    timer3.Stop();

                }
            }
        }

        private void sideBarTimer_Tick5(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                //si la sidebar esta expandida, se minimiza.
                sidebartop4.Height -= 10;
                if (sidebartop4.Height == sidebartop4.MinimumSize.Height)
                {
                    sideBarExpand = false;
                    timer4.Stop();
                }
            }
            else
            {
                sidebartop4.Height += 10;
                if (sidebartop4.Height == sidebartop4.MaximumSize.Height)
                {
                    sideBarExpand = true;
                    timer4.Stop();

                }
            }
        }

        private void iconButton24_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void panel35_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenubar_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
