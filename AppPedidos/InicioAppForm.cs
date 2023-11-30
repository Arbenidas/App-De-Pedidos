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
        //Atributo para expandir las barras laterales y de la parte superior
        bool sideBarExpand;

        //Atributo que resive un formulario hijo.
        private Form currentChildForm;

        private Usuario usuario;

        public formularioHome(string correo, string contraseña)
        {
            InitializeComponent();
            this.usuario = UsuarioLogica.Obtener(correo, contraseña);
            usuarioToolStripMenuItem.Text = usuario.Nombres;

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
            
        }
        private void sideBarTimer_Tick(object sender, EventArgs e)
        {

            
        }
        private void sideBarTimer_Tick3(object sender, EventArgs e)
        {
            
        }
        private void sideBarTimer_Tick4(object sender, EventArgs e)
        {
            
        }
        private void sideBarTimer_Tick5(object sender, EventArgs e)
        {
            
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
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            


        }





        #region
        //Se abren los formularios correspondientes a cada uno de los botones de la barra superios desplegable
        private void iconButton8_Click(object sender, EventArgs e)
        {
          //  AbrirFormulariosHijo(new MonitoresGamersForm());
        }

        private void iconButton18_Click(object sender, EventArgs e)
        {
          //  AbrirFormulariosHijo(new AuricularesGamersForm());
        }

        private void iconButton25_Click(object sender, EventArgs e)
        {
           // AbrirFormulariosHijo(new LaptopsDev());
        }

        private void iconButton26_Click(object sender, EventArgs e)
        {
           // AbrirFormulariosHijo(new LaptopsGamers());
        }

        private void iconButton28_Click(object sender, EventArgs e)
        {
            //AbrirFormulariosHijo(new LaptopsEconomicas());
        }

        private void iconButton33_Click(object sender, EventArgs e)
        {
          //  AbrirFormulariosHijo(new RatonesStandars());
        }

        private void iconButton34_Click(object sender, EventArgs e)
        {
            //AbrirFormulariosHijo(new RatonesGamers());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            //AbrirFormulariosHijo(new MonitoresStandarsForm());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
           // AbrirFormulariosHijo(new monitoresDeSegundaForm());
        }

        private void iconButton17_Click(object sender, EventArgs e)
        {
          //  AbrirFormulariosHijo(new AuricularesStandarsForm());
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

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new ProductosCRUD());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void timerProduc_Tick(object sender, EventArgs e)
        {
            
        }

        private void iconButton3_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("0002dsadas0000");
            timer5.Start();
        }

        private void iconButton5_Click_1(object sender, EventArgs e)
        {
            
            timerProduc.Start();
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            
        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void misProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new ProductosCRUD());
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioSesionForm formInicio = new InicioSesionForm();
            formInicio.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void editarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarPerfil editarPerfil = new EditarPerfil(usuario.Correo, usuario.Contrasena, usuario.EsAdministrador);
            AddOwnedForm(editarPerfil);
            editarPerfil.Show();
        }

        public void RefrescarUsuario(string correo, string contraseña)
        {
            this.usuario = UsuarioLogica.Obtener(correo, contraseña);
            usuarioToolStripMenuItem.Text = usuario.Nombres;
        }

        private void menuMarcas_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new MarcaCRUD());
        }

        private void iconMenuItem9_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new VistaPedidos(usuario.EsAdministrador, usuario.IdUsuario));
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new ManejoClientes());
        }

        private void InicioButton_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new vista_Inicio());
        }

        private void menuCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new CategoriaCRUD());
        }
    }
}
