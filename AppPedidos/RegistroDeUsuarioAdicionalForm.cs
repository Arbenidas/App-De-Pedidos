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
    public partial class RegistroDeUsuarioAdicionalForm : Form
    {
        private Usuario usuario = new Usuario();
        public RegistroDeUsuarioAdicionalForm()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario.Nombres = inputNombres.Text.Trim();
            usuario.Apellidos = inputApellidos.Text.Trim();
            usuario.Contrasena = inputContrasena.Text.Trim();
            usuario.Correo = inputCorreo.Text.Trim();
            usuario.EsAdministrador = checkBoxAdministrador.Checked;
            usuario.Activo = checkBoxActivo.Checked;
            int registro = UsuarioLogica.Registrar(usuario);
            if(registro != 0)
            {
                MessageBox.Show("usuario registrado con exito");
                InicioSesionForm inicioSesionForm = new InicioSesionForm();
                inicioSesionForm.Show();
                this.Close();
            }

        }
    }
}
