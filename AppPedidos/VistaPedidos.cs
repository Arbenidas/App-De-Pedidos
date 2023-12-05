using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace AppPedidos
{
    public partial class VistaPedidos : Form
    {
        private bool esAdmin;
        private bool estadoCompraActual;
        private int Idusuario;
        public VistaPedidos(bool esAdmin, int Idusuario)
        {
            InitializeComponent();
            
            this.esAdmin = esAdmin;
            this.Idusuario = Idusuario;
        }

        private void VistaPedidos_Load(object sender, EventArgs e)
        {
            

            if (!esAdmin)
            {

                label2.Visible=false;
                comboBuscarPor.Visible=false;
                inputBusqueda.Visible=false;
                botonBuscar.Visible=false;
                string condicion = "WHERE IdUsuario = '" + this.Idusuario + "'";
                
                dataGridView1.DataSource = CompraLogica.ObtenerCompras(condicion);
            }
            else
            {
                
                RefrescarGrid();
            }
        }

        public void RefrescarGrid()
        {
            dataGridView1.DataSource = CompraLogica.ObtenerCompras("");
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            string condicion = "WHERE "+comboBuscarPor.Text+ " like '%" + inputBusqueda.Text + "%'";
            //MessageBox.Show(condicion);
            dataGridView1.DataSource = CompraLogica.ObtenerCompras(condicion);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.CurrentRow;
                estadoCompraActual = Convert.ToBoolean(row.Cells["Estado"].Value);
                
                textBoxID.Text = row.Cells[0].Value.ToString();
                
                //MessageBox.Show (row.Cells["IdCategoria"].Value.ToString());


            }
        }

        private void butonCambiarEstado_Click(object sender, EventArgs e)
        {
            if (!textBoxID.Text.Equals(""))
            {
                string id = dataGridView1.CurrentRow.Cells["IdCompra"].Value.ToString();

                if (!string.IsNullOrEmpty(id))
                {
                    CompraLogica.CambiarEstadoCompra(Convert.ToInt32(id), estadoCompraActual);
                    RefrescarGrid();

                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (!textBoxID.Text.Equals(""))
            {
                string id = dataGridView1.CurrentRow.Cells["IdCompra"].Value.ToString();

                if (!string.IsNullOrEmpty(id))
                {
                    VerCompraDetalle verCompraDetalle = new VerCompraDetalle(Convert.ToInt32(id));
                    verCompraDetalle.Show();

                }
            }
            
        }
    }
}
