﻿using System;
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
        //Atributo para expandir las barras laterales y de la parte superior
        bool sideBarExpand;

        //Atributo que resive un formulario hijo.
        private Form currentChildForm;



        public formularioHome()
        {
            InitializeComponent();

           
        }

        /// <summary>
        /// Se envia un formulario Hijo que se asigna al panel principal del inicio y que se muestra al frente para poder mostrar los productos que corresponden.
        /// </summary>
        /// <param name="childForm"></param>
        private void AbrirFormulariosHijo(Form childForm)
        {
            //Validamos si el formulario esta vacio, si no hay un formulario se cierra y se deja en blanco.
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            //se Asigna al atributo el formulario que se pasa como parametro
            currentChildForm = childForm;

            //Se estiliza y se pone en un lugar correspondiente.
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            
            //Se agregan al panelHome el formulario hijo y se muestra
            PanelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            
        }

        #region
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
        #endregion


        //Estos son los timers que regulan el tamaño de cada una de las barras que se van a desplegar tomando como referencia los valores minimos y maximos de cada una de las barras desplegables
        #region
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
        #endregion





        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formularioHome_Load(object sender, EventArgs e)
        {

        }

        

        //Al darle Click al logo se cierran los formularios que esten en el panelDesktop
        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();

        }





        #region
        //Se abren los formularios correspondientes a cada uno de los botones de la barra superios desplegable
        private void iconButton8_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new MonitoresGamersForm());
        }

        private void iconButton18_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new AuricularesGamersForm());
        }

        private void iconButton25_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new LaptopsDev());
        }

        private void iconButton26_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new LaptopsGamers());
        }

        private void iconButton28_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new LaptopsEconomicas());
        }

        private void iconButton33_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new RatonesStandars());
        }

        private void iconButton34_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new RatonesGamers());
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
        #endregion

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
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        private void PanelDesktop_Resize(object sender, EventArgs e)
        {

        }
        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
