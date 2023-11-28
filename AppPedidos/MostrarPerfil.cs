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
    public partial class MostrarPerfil : Form
    {
        public Form inicio;
        
        public MostrarPerfil()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();

            //EditarPerfil MostrarPerfil = new EditarPerfil();
            //MostrarPerfil.dato = this;
            //MostrarPerfil.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio.Enabled = true;
        }
    }
}
