using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPedidos
{
    public partial class VistaPedidos : Form
    {
        private bool esAdmin;
        public VistaPedidos(bool esAdmin)
        {
            InitializeComponent();
            this.esAdmin = esAdmin;
        }

        private void VistaPedidos_Load(object sender, EventArgs e)
        {
            RefrescarGrid();
            if (esAdmin)
            {
                label2.Visible=false;
                comboBuscarPor.Visible=false;
                inputBusqueda.Visible=false;
                botonBuscar.Visible=false;
            }
        }

        public void RefrescarGrid()
        {
            dataGridView1.DataSource = CompraLogica.ObtenerCompras("");
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            string condicion = "WHERE "+comboBuscarPor.Text+ " like '%" + inputBusqueda.Text + "%'";
            MessageBox.Show(condicion);
            dataGridView1.DataSource = CompraLogica.ObtenerCompras(condicion);
        }
    }
}
