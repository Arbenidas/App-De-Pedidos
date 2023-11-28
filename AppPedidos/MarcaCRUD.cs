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
    public partial class MarcaCRUD : Form
    {
        private Marca marca = new Marca();
        public MarcaCRUD()
        {
            InitializeComponent();
        }

        private void MarcaCRUD_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        public void Refrescar()
        {
            dataGridView1.DataSource = MarcaLogica.Listar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void inputFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            List<Marca> marcas = MarcaLogica.Listar();

            Dictionary<string, int> idmarcas = new Dictionary<string, int>();

            for (int i = 0; i < marcas.Count; i++)
            {
                idmarcas.Add(marcas[i].Descripcion, marcas[i].IdMarca);
            }

            marca.Activo = checkBoxEstado.Checked;
            marca.Descripcion = inputNombre.Text.Trim();

            MarcaLogica.Registrar(marca);
            MessageBox.Show("Marca agregada");
            Refrescar();
           

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (!inputID.Text.Equals(""))
            {
                string id = dataGridView1.CurrentRow.Cells["IdMarca"].Value.ToString();

                if (!string.IsNullOrEmpty(id))
                {

                    List<Marca> marcas = MarcaLogica.Listar();

                    Dictionary<string, int> idmarcas = new Dictionary<string, int>();
                    for (int i = 0; i < marcas.Count; i++)
                    {
                        idmarcas.Add(marcas[i].Descripcion, marcas[i].IdMarca);
                    }

                    
                    marca.Descripcion = inputNombre.Text.Trim();
                    marca.Activo = checkBoxEstado.Checked;
 
                    MarcaLogica.Modificar(marca);
                    MessageBox.Show("registro actualizado");
                    Refrescar();
                }

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 )
            {
                var row = dataGridView1.CurrentRow;
                inputID.Text = row.Cells[0].Value.ToString();
                inputNombre.Text = row.Cells["Descripcion"].Value.ToString();
                checkBoxEstado.Checked = Convert.ToBoolean(row.Cells["Activo"].Value);
               
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            inputID.Text = "";
            inputNombre.Text = "";
            checkBoxEstado.Checked = false;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (!inputID.Text.Equals(""))
            {
                string id = dataGridView1.CurrentRow.Cells["IdMarca"].Value.ToString();

                if (!string.IsNullOrEmpty(id))
                {

                    MarcaLogica.Eliminar(Convert.ToInt32(id));
                    MessageBox.Show("registro eliminado");
                    Refrescar();

                }

            }
        }
    }
    }

