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
        //Se crea la instancia de un usuario y un clase global que comprueba si es administrador o no para poder editar perfiles.
        private Usuario usuario = new Usuario();
        private bool Admin;
        public EditarPerfil(string correoAntiguo, string contrasenaAntigua, bool Admin)
        {
            // Inicialización del formulario
            InitializeComponent();

            // Asignación del valor del parámetro Admin al miembro de la clase Admin
            this.Admin = Admin;

            // Obtención de información de usuario utilizando UsuarioLogica.Obtener
            usuario = UsuarioLogica.Obtener(correoAntiguo, contrasenaAntigua);

            // Asignación de valores de usuario a los controles del formulario
            inputNombres.Text = usuario.Nombres;
            inputApellidos.Text = usuario.Apellidos;
            inputCorreo.Text = usuario.Correo;
            inputContrasena.Text = usuario.Contrasena;
        }


        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            // Obtención de valores de los controles del formulario
            string correo = inputCorreo.Text.Trim();
            string contrasena = inputContrasena.Text.Trim();

            // Actualización de propiedades del objeto usuario con los valores de los controles
            usuario.Nombres = inputNombres.Text.Trim();
            usuario.Apellidos = inputApellidos.Text.Trim();
            usuario.Contrasena = contrasena;
            usuario.Correo = correo;

            // Llamada al método de UsuarioLogica para actualizar la información del usuario
            UsuarioLogica.ActualizarUsuario(usuario);

            // Verificación si el formulario es de administrador (Admin) o cliente
            if (Admin)
            {
                // Si es administrador, se refresca la información en el formularioHome
                formularioHome padre = Owner as formularioHome;
                padre.RefrescarUsuario(usuario.Correo, usuario.Contrasena);
                this.Close();
            }
            else
            {
                // Si no es administrador, se refresca la información en la VistaClientes
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

        private void EditarPerfil_Load(object sender, EventArgs e)
        {

        }
    }
}
