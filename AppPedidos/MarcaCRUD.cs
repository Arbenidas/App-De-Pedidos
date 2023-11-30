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

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
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
                    marca.IdMarca = Convert.ToInt32(inputID.Text);
                    marca.Descripcion = inputNombre.Text.Trim();
                    marca.Activo = checkBoxEstado.Checked;


                    MarcaLogica.Modificar(marca);
                    MessageBox.Show("Marca actualizada con exito");
                    Refrescar();
                }

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
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
