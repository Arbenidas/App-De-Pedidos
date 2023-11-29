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
    public partial class CategoriaCRUD : Form
    {
        private Categoria categoria = new Categoria();
        public CategoriaCRUD()
        {
            InitializeComponent();
        }

        private void CategoriaCRUD_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        public void Refrescar()
        {
            dataGridView2.DataSource = CategoriaLogica.Listar();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            inputID.Text = "";
            inputNombre.Text = "";
            checkBoxEstado.Checked = false;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            categoria.Activo = checkBoxEstado.Checked;
            categoria.Descripcion = inputNombre.Text.Trim();
            CategoriaLogica.Registrar(categoria);
            MessageBox.Show("Categoria agregada");
            Refrescar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (!inputID.Text.Equals(""))
            {
                string id = dataGridView2.CurrentRow.Cells["IdCategoria"].Value.ToString();

                if (!string.IsNullOrEmpty(id))
                {

                    CategoriaLogica.Eliminar(Convert.ToInt32(id));
                    MessageBox.Show("registro eliminado");
                    Refrescar();

                }

            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (!inputID.Text.Equals(""))
            {
                string id = dataGridView2.CurrentRow.Cells["IdCategoria"].Value.ToString();

                if (!string.IsNullOrEmpty(id))
                {
                    categoria.IdCategoria = Convert.ToInt32(inputID.Text);
                    categoria.Descripcion = inputNombre.Text.Trim();
                    categoria.Activo = checkBoxEstado.Checked;


                    CategoriaLogica.Modificar(categoria);
                    MessageBox.Show(categoria.ToString());
                    Refrescar();
                }

            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var row = dataGridView2.CurrentRow;
                inputID.Text = row.Cells[0].Value.ToString();
                inputNombre.Text = row.Cells["Descripcion"].Value.ToString();
                checkBoxEstado.Checked = Convert.ToBoolean(row.Cells["Activo"].Value);

            }
        }
    }
}
