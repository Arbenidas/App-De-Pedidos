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
    public partial class ComponenteDeImagenesDeProductosForm : Form
    {
        public ComponenteDeImagenesDeProductosForm(String rutaImg)
        {
            InitializeComponent();
            // Configura el PictureBox con la imagen seleccionada

            pictureBoxImage.Image = Image.FromFile(rutaImg);
            
        }

        private void ComponenteDeImagenesDeProductosForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
