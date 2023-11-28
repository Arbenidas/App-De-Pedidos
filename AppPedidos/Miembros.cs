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
    public partial class Miembros : Form
    {
        public Form inicio;
        public Miembros()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio.Enabled = true;
        }
    }
}
