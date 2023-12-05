using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPedidos
{
    public partial class EditarPerfil : Form
    {
        private Usuario usuario = new Usuario();
        private bool Admin;
        public EditarPerfil(string correoAntiguo, string contrasenaAntigua, bool Admin)
        {
            InitializeComponent();
            this.Admin = Admin;
            usuario = UsuarioLogica.Obtener(correoAntiguo, contrasenaAntigua);
            inputNombres.Text = usuario.Nombres;
            inputApellidos.Text = usuario.Apellidos;
            inputCorreo.Text = usuario.Correo;
            inputContrasena.Text = usuario.Contrasena;

        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            string correo = inputCorreo.Text.Trim();
            string contrasena = inputContrasena.Text.Trim();
            

            usuario.Nombres = inputNombres.Text.Trim();
            usuario.Apellidos = inputApellidos.Text.Trim();
            usuario.Contrasena = contrasena;
            usuario.Correo = correo;
            
            UsuarioLogica.ActualizarUsuario(usuario);

            if (Admin)
            {
                formularioHome padre = Owner as formularioHome;
                padre.RefrescarUsuario(usuario.Correo, usuario.Contrasena);
                this.Close();
            }
            else
            {
                VistaClientes padre = Owner as VistaClientes;
                padre.RefrescarUsuario(usuario.Correo, usuario.Contrasena);
                this.Close();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inputCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
