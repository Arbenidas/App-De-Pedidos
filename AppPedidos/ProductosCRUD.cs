using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AppPedidos
{
    public partial class ProductosCRUD : Form
    {
        private Producto produco = new Producto();
        private Marca marca = new Marca();
        private Categoria categoria = new Categoria();
        public ProductosCRUD()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void RefrescarGrid()
        {
            //MessageBox.Show("refresco");
            dataGridView1.DataSource = ProductoLogica.Listar();
        }
        private void ProductosCRUD_Load(object sender, EventArgs e)
        {
            RefrescarGrid();
            List<Marca> marcas = MarcaLogica.Listar();
            List<string> idmarcas = new List<string>();
            for (int i = 0; i < marcas.Count; i++)
            {
                idmarcas.Add(marcas[i].Descripcion);
            }

            List<Categoria> categorias = CategoriaLogica.Listar();
            List<string> idcategorias = new List<string>();
            for (int i = 0; i < categorias.Count; i++)
            {
                idcategorias.Add(categorias[i].Descripcion);
            }
            
            comboMarcas.DataSource = idmarcas;
            comboCategorias.DataSource = idcategorias;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            List<Marca> marcas = MarcaLogica.Listar();

            Dictionary<string, int> idmarcas = new Dictionary<string, int>();
            for (int i = 0; i < marcas.Count; i++)
            {
                idmarcas.Add(marcas[i].Descripcion, marcas[i].IdMarca);
            }

            List<Categoria> categorias = CategoriaLogica.Listar();

            Dictionary<string, int> idcategorias = new Dictionary<string, int>();
            for (int i = 0; i < categorias.Count; i++)
            {
                idcategorias.Add(categorias[i].Descripcion, categorias[i].IdCategoria);
            }

            produco.Nombre = inputNombre.Text.Trim();
            produco.Descripcion = inputDescripcion.Text.Trim();
            produco.IdMarca = idmarcas[comboMarcas.Text];
            produco.IdCategoria = idcategorias[comboCategorias.Text];
            produco.Precio = Convert.ToDecimal(inputPrecio.Text.Trim());
            produco.Stock = Convert.ToInt32(inputStock.Text.Trim());
            produco.Activo = checkBoxEstado.Checked;
            produco.RutaImagen = inputImagen.Text.Trim();
            produco.FechaRegistro = Convert.ToString(inputFecha.Value);

            ProductoLogica.Registrar(produco);
            MessageBox.Show("Producto Agregado");
            RefrescarGrid();



        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && comboMarcas.SelectedIndex != -1 && comboCategorias.SelectedIndex != -1)
            {
                var row = dataGridView1.CurrentRow;
                inputID.Text = row.Cells[0].Value.ToString();
                inputNombre.Text = row.Cells["Nombre"].Value.ToString();
                inputDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                //MessageBox.Show (row.Cells["IdCategoria"].Value.ToString());
                comboCategorias.SelectedIndex = Convert.ToInt32(row.Cells["IdCategoria"].Value.ToString())-1;
                comboMarcas.SelectedIndex = Convert.ToInt32(row.Cells["IdMarca"].Value.ToString())-1;
                inputPrecio.Text = row.Cells["Precio"].Value.ToString();
                inputStock.Text = row.Cells["Stock"].Value.ToString();
                inputImagen.Text = row.Cells["RutaImagen"].Value.ToString();
                checkBoxEstado.Checked = Convert.ToBoolean(row.Cells["Activo"].Value);
                inputFecha.Text = row.Cells["FechaRegistro"].Value.ToString();
            }
           


            
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (!inputID.Text.Equals(""))
            {
                string id = dataGridView1.CurrentRow.Cells["IdProducto"].Value.ToString();

                if (!string.IsNullOrEmpty(id))
                {

                    List<Marca> marcas = MarcaLogica.Listar();

                    Dictionary<string, int> idmarcas = new Dictionary<string, int>();
                    for (int i = 0; i < marcas.Count; i++)
                    {
                        idmarcas.Add(marcas[i].Descripcion, marcas[i].IdMarca);
                    }

                    List<Categoria> categorias = CategoriaLogica.Listar();

                    Dictionary<string, int> idcategorias = new Dictionary<string, int>();
                    for (int i = 0; i < categorias.Count; i++)
                    {
                        idcategorias.Add(categorias[i].Descripcion, categorias[i].IdCategoria);
                    }

                    produco.IdProducto = Convert.ToInt32(id);
                    produco.Nombre = inputNombre.Text.Trim();
                    produco.Descripcion = inputDescripcion.Text.Trim();
                    produco.IdMarca = idmarcas[comboMarcas.Text];
                    produco.IdCategoria = idcategorias[comboCategorias.Text];
                    produco.Precio = Convert.ToDecimal(inputPrecio.Text.Trim());
                    produco.Stock = Convert.ToInt32(inputStock.Text.Trim());
                    produco.Activo = checkBoxEstado.Checked;
                    produco.RutaImagen = inputImagen.Text.Trim();
                    produco.FechaRegistro = Convert.ToString(inputFecha.Value);
                    ProductoLogica.Modificar(produco);
                    MessageBox.Show("registro actualizado");
                    RefrescarGrid();
                }

            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (!inputID.Text.Equals(""))
            {
                string id = dataGridView1.CurrentRow.Cells["IdProducto"].Value.ToString();

                if (!string.IsNullOrEmpty(id))
                {
                    
                    ProductoLogica.Eliminar(Convert.ToInt32(id));
                    MessageBox.Show("registro eliminado");
                    RefrescarGrid();

                }

            }
        }
    }
}
