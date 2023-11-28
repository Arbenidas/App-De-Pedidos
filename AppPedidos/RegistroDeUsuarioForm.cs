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
    public partial class RegistroDeUsuarioForm : Form
    {
        public RegistroDeUsuarioForm()
        {

            InitializeComponent();
            textBoxCorreo.GotFocus += new EventHandler(this.RemoveText);
            textBoxCorreo.LostFocus += new EventHandler(this.AddText);
            textBoxContrasena.GotFocus += new EventHandler(this.RemoveText);
            textBoxContrasena.LostFocus += new EventHandler(this.AddText);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void RemoveText(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.ToString());
            if (textBoxCorreo.Text == "Ingrese su correo")
            {
                textBoxCorreo.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCorreo.Text))
                textBoxCorreo.Text = "Ingrese su correo";
        }

        public void RemoveText2(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.ToString());
            if (textBoxCorreo.Text == "Ingrese su contraseña")
            {
                textBoxCorreo.Text = "";
            }
        }

        public void AddText2(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCorreo.Text))
                textBoxCorreo.Text = "Ingrese su contraseña";
        }
    }
}
