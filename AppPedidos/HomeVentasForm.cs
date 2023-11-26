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
    public partial class HomeVentasForm : Form
    {

        bool sideBarExpand;
        public HomeVentasForm()
        {
            InitializeComponent();
        }

        private void PanelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExpandBarLaptops_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //Coloquemos el maximo y el minimo de la animacion de la barra
            if (sideBarExpand)
            {
                //si la sidebar esta expandida, se minimiza.
                sidebartop1.Width -= 10;
                if (sidebartop1.Width == sidebartop1.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    timer1.Stop();
                }
            }
            else
            {
                sidebartop1.Width += 10;
                if (sidebartop1.Width == sidebartop1.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    timer1.Stop();

                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
