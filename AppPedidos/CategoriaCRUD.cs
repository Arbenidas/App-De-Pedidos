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

<<<<<<< HEAD
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

=======
        /// <summary>
        /// boton para limpiar los inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
>>>>>>> Cambios_finales
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            inputID.Text = "";
            inputNombre.Text = "";
            checkBoxEstado.Checked = false;
        }

<<<<<<< HEAD
        private void buttonAgregar_Click(object sender, EventArgs e)
        {

=======
        private void CategoriaCRUD_Load(object sender, EventArgs e)
        {
            //refrescar la grilla con los datos
            Refrescar();
        }

        public void Refrescar()
        {
            //carga la lista de categorias
            dataGridView1.DataSource = CategoriaLogica.Listar();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            //Se obtienen los valores de los inputs y se mandan a registrar
>>>>>>> Cambios_finales
            categoria.Activo = checkBoxEstado.Checked;
            categoria.Descripcion = inputNombre.Text.Trim();
            CategoriaLogica.Registrar(categoria);
            MessageBox.Show("Categoria agregada");
            Refrescar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (!inputID.Text.Equals(""))
            {
                string id = dataGridView2.CurrentRow.Cells["IdCategoria"].Value.ToString();

                if (!string.IsNullOrEmpty(id))
                {

=======
            // se verifica que no este vacio el id
            if (!inputID.Text.Equals(""))
            {
                string id = dataGridView1.CurrentRow.Cells["IdCategoria"].Value.ToString();

                if (!string.IsNullOrEmpty(id))
                {
                    //se manda a llamar el metodo para eliminar la categoria y se notifica
>>>>>>> Cambios_finales
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
<<<<<<< HEAD
                string id = dataGridView2.CurrentRow.Cells["IdCategoria"].Value.ToString();
=======
                string id = dataGridView1.CurrentRow.Cells["IdCategoria"].Value.ToString();
>>>>>>> Cambios_finales

                if (!string.IsNullOrEmpty(id))
                {
                    categoria.IdCategoria = Convert.ToInt32(inputID.Text);
                    categoria.Descripcion = inputNombre.Text.Trim();
                    categoria.Activo = checkBoxEstado.Checked;


                    CategoriaLogica.Modificar(categoria);
<<<<<<< HEAD
                    MessageBox.Show(categoria.ToString());
=======
                    MessageBox.Show("Categoria Actualizada");
>>>>>>> Cambios_finales
                    Refrescar();
                }

            }
        }

<<<<<<< HEAD
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var row = dataGridView2.CurrentRow;
=======
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.CurrentRow;
>>>>>>> Cambios_finales
                inputID.Text = row.Cells[0].Value.ToString();
                inputNombre.Text = row.Cells["Descripcion"].Value.ToString();
                checkBoxEstado.Checked = Convert.ToBoolean(row.Cells["Activo"].Value);

            }
        }
<<<<<<< HEAD
=======

        private void checkBoxEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputID_TextChanged(object sender, EventArgs e)
        {

        }
>>>>>>> Cambios_finales
    }
}
