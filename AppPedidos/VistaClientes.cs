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
   
    public partial class VistaClientes : Form
    {
        
        private Form currentChildForm;
        private Usuario usuario;
        private Dictionary<int, int> listaID_Cantidad = new Dictionary<int, int>();

        public VistaClientes(string correo, string contraseña)
        {
            InitializeComponent();
            this.usuario = UsuarioLogica.Obtener(correo, contraseña);
            usuarioToolStripMenuItem.Text = usuario.Nombres;

        }

        

        private void AbrirFormulariosHijo(Form childForm)
        {
            //Validamos si el formulario esta vacio, si no hay un formulario se cierra y se deja en blanco.
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            //se Asigna al atributo el formulario que se pasa como parametro
            currentChildForm = childForm;
            AddOwnedForm(childForm);

            //Se estiliza y se pone en un lugar correspondiente.
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            //Se agregan al panelHome el formulario hijo y se muestra
            PanelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

        }

        private void monitoresEstandarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AbrirFormulariosHijo(new MonitoresStandarsForm());

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

        private void PanelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VistaClientes_Load(object sender, EventArgs e)
        {
            List<Categoria> categorias = CategoriaLogica.Listar();
            List<string> idcategorias = new List<string>();
            for (int i = 0; i < categorias.Count; i++)
            {
                //idcategorias.Add(categorias[i].Descripcion);
                ToolStripMenuItem itemCategoria = new ToolStripMenuItem();
                itemCategoria.Text = categorias[i].Descripcion;
                itemCategoria.Name = categorias[i].IdCategoria.ToString();
                itemCategoria.Click += itemsCategorias_Click;

                nuevoToolStripMenuItem.DropDownItems.Add(itemCategoria);
            }


            
        }

        private void itemsCategorias_Click(object sender, EventArgs e)
        {
            string categoria = sender.ToString();
            
            AbrirFormulariosHijo(new MonitoresStandarsForm(categoria));

        }

        public void DefinirCompras(int idproducto, int cantidad)
        {
            this.listaID_Cantidad.Add(idproducto, cantidad);
            //MessageBox.Show(String.Join(", ", listaID_Cantidad));
        }
        public void QuitarProducto(int idproducto)
        {
            this.listaID_Cantidad.Remove(idproducto);
            //MessageBox.Show(String.Join(", ", listaID_Cantidad));
            AbrirFormulariosHijo(new VistaCarrito(listaID_Cantidad, usuario.IdUsuario));

        }


        private void carritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new VistaCarrito(listaID_Cantidad, usuario.IdUsuario));
        }

        private void misComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new VistaPedidos(usuario.EsAdministrador, usuario.IdUsuario));
        }

        private void menuInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijo(new vista_Inicio());
        }
    }
}
