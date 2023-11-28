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
    public partial class EditarPerfil : Form
    {

        public Form dato;
        public EditarPerfil()
        {
            InitializeComponent();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            MostrarPerfil modPerfil = new MostrarPerfil();
            modPerfil.label7.Text = textBox1.Text;
            modPerfil.label8.Text = textBox10.Text;
            modPerfil.label9.Text = textBox9.Text;
            modPerfil.label10.Text = textBox8.Text;
            modPerfil.label11.Text = textBox7.Text;
            modPerfil.label12.Text = textBox6.Text;


            dato.Enabled = true;
            this.Hide();
            modPerfil.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            dato.Enabled = true;
            this.Hide();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // EditarPerfil
            // 
            this.ClientSize = new System.Drawing.Size(503, 259);
            this.Name = "EditarPerfil";
            this.ResumeLayout(false);

        }
    }
}
