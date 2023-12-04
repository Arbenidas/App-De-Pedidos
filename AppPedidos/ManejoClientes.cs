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
    public partial class ManejoClientes : Form
    {
        Usuario cliente;
        public ManejoClientes()
        {
            InitializeComponent();
            cliente = new Usuario();
            RefrescarGrid();
        }

        public void RefrescarGrid()
        {
            dataGridView1.DataSource = UsuarioLogica.ObtenerClientes("");
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            cliente.Nombres = inputNombres.Text.Trim();
            cliente.Apellidos = inputApellidos.Text.Trim();
            cliente.Contrasena = inputContrasena.Text.Trim();
            cliente.Correo = inputCorreo.Text.Trim();
            cliente.EsAdministrador = checkBoxAdministrador.Checked;
            cliente.Activo = checkBoxActivo.Checked;
            int registro = UsuarioLogica.Registrar(cliente);
            if (registro != 0)
            {
                MessageBox.Show("cliente registrado con exito");
                
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 )
            {
                var row = dataGridView1.CurrentRow;
                textBoxID.Text = row.Cells[0].Value.ToString();
                inputNombres.Text = row.Cells["Nombres"].Value.ToString();
                inputApellidos.Text = row.Cells["Apellidos"].Value.ToString();
                inputCorreo.Text = row.Cells["Correo"].Value.ToString();
                inputContrasena.Text = row.Cells["Contrasena"].Value.ToString();
                checkBoxAdministrador.Checked = Convert.ToBoolean(row.Cells["EsAdministrador"].Value);
                checkBoxActivo.Checked = Convert.ToBoolean(row.Cells["Activo"].Value);
                //MessageBox.Show (row.Cells["IdCategoria"].Value.ToString());
               

            }
        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            if (!textBoxID.Text.Equals(""))
            {
                string id = dataGridView1.CurrentRow.Cells["IdUsuario"].Value.ToString();

                if (!string.IsNullOrEmpty(id))
                {
                    cliente.IdUsuario = Convert.ToInt32(id);
                    cliente.Nombres = inputNombres.Text.Trim();
                    cliente.Apellidos = inputApellidos.Text.Trim();
                    cliente.Contrasena = inputContrasena.Text.Trim();
                    cliente.Correo = inputCorreo.Text.Trim();
                    cliente.EsAdministrador = checkBoxAdministrador.Checked;
                    cliente.Activo = checkBoxActivo.Checked;
                    UsuarioLogica.ActualizarUsuario(cliente);
                    RefrescarGrid();

                }
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (!textBoxID.Text.Equals(""))
            {
                string id = dataGridView1.CurrentRow.Cells["IdUsuario"].Value.ToString();

                if (!string.IsNullOrEmpty(id))
                {

                    UsuarioLogica.Eliminar(Convert.ToInt32(id));
                    MessageBox.Show("registro eliminado"+id.ToString());
                    RefrescarGrid();

                }

            }
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            string condicion = "WHERE " + comboBuscarPor.Text + " like '%" + inputBusqueda.Text + "%'";
            
            dataGridView1.DataSource = UsuarioLogica.ObtenerClientes(condicion);
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            inputNombres.Text = "";
            inputApellidos.Text = "";
            inputCorreo.Text = "";
            inputContrasena.Text = "";
            checkBoxAdministrador.Checked = false;
            checkBoxActivo.Checked = false;

            RefrescarGrid();
        }

        private void comboBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inputBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inputApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inputCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxActivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
