using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libreria para poder acceder a directorios
using System.IO;

namespace AppPedidos
{
    public partial class formularioHome : Form
    {
        bool sideBarExpand;
        private Form currentChildForm;





        public formularioHome()
        {
            InitializeComponent();

           
        }
        private void AbrirFormulariosHijo(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(childForm);
            PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        //Al dar click en cada uno de los botones de la barra superior empezara un contador que abrira una barra desplegable
        private void btnMenubar_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        private void iconButton44_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void iconButton24_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }
        
        //Estos son los timers que regulan el tamaño de cada una de las barras que se van a desplegar tomando como referencia los valores minimos y maximos de cada una de las barras desplegables
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
        
        private void sidebarLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        

        private void panel35_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenubar_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new MonitoresGamersForm());
        }
       

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formularioHome_Load(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new MonitoresStandarsForm());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new monitoresDeSegundaForm());
        }

        private void iconButton17_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new AuricularesStandarsForm());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();

        }

        

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelDesktop_Resize(object sender, EventArgs e)
        {
            // Ajusta el tamaño de los formularios hijos cuando el formulario principal se redimensiona
            if (currentChildForm != null)
            {
                currentChildForm.Size = PanelDesktop.Size;
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton18_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new AuricularesGamersForm());
        }
    }
}
