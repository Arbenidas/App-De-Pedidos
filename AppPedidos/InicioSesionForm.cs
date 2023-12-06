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
    public partial class InicioSesionForm : Form
    {
        public InicioSesionForm()
        {
            InitializeComponent();
        }

        private void inicioSesion_Load(object sender, EventArgs e)
        {
            Textbox1.Text = "Correo";
            Textbox1.ForeColor = Color.LightGray;

            textBox2.PasswordChar = '\0';
            textBox2.Text = "Contraseña";
            textBox2.ForeColor = Color.LightGray;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        /*Creacion de placeholders para la parte de los inputs de iniciar sesion
         leave: Hace que al quitar el focus del input se pone la palabra usuario siempre y cuando este vacio el campo
        enter: Hace que el texto que coloquemos salga normalmente y no en formato de gris
         */
        private void Textbox1_Leave(object sender, EventArgs e)
        {
            if (Textbox1.Text == "" )
            {
                Textbox1.Text = "Correo";
                Textbox1.ForeColor = Color.LightGray;
            }
        }

        private void Textbox1_Enter(object sender, EventArgs e)
        {
            if (Textbox1.Text == "Correo")
            {
                Textbox1.Text = "";
                Textbox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Contraseña")
            {
                textBox2.PasswordChar = '*';
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
            }
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.PasswordChar = '\0';
                textBox2.Text = "Contraseña";
                textBox2.ForeColor = Color.White;
            }
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            Usuario myUsuario = UsuarioLogica.Obtener(Textbox1.Text, textBox2.Text);
            if (myUsuario != null)
            {
                
                if (myUsuario.EsAdministrador)
                {
                    formularioHome home = new formularioHome(myUsuario.Correo, myUsuario.Contrasena);
                    home.Show();
                    

                }
                else
                {
                    VistaClientes homeCliente = new VistaClientes(myUsuario.Correo, myUsuario.Contrasena);
                    homeCliente.Show();
                    
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas, intente nuevamente");
            }

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            RegistroDeUsuarioAdicionalForm registro = new RegistroDeUsuarioAdicionalForm();
            registro.Show();
            this.Close();
        }
    }
}
