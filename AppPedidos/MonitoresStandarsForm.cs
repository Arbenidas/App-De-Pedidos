using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppPedidos
{
    public partial class MonitoresStandarsForm : Form
    {
        //private List<Producto> listaComprar = new List<Producto>();
        private Dictionary<int , int>  listaID_Cantidad = new Dictionary<int , int>();
        public MonitoresStandarsForm(string categoria)
        {
            InitializeComponent();
            CargarProductos(categoria);
        }

        private void CargarProductos(string categoria)
        {
            // Obtiene la lista de productos desde la base de datos
            List<Producto> listaProductos = ObtenerListaDeProductosDesdeBD();

            List<Categoria> categorias = CategoriaLogica.Listar();
            int categoriaID=0;
            for (int i = 0; i < categorias.Count; i++)
            {
                if (categoria == categorias[i].Descripcion)
                {
                    categoriaID = categorias[i].IdCategoria;
                }
            }

               
            // Verifica que el FlowLayoutPanel existente no sea nulo
            if (PanelDeProdcutos != null)
            {
                // Recorre la lista de productos y agrega un Panel para cada producto
                foreach (Producto producto in listaProductos)
                {
                    if (producto.IdCategoria == categoriaID) { 
                    Panel panel = new Panel();
                    panel.Padding = new Padding(3, 30, 3, 10);
                    panel.Width = 180;
                    panel.Height = 197;
                    panel.BorderStyle = BorderStyle.FixedSingle;

                    // Creamos un picture box dentro del panel
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Dock = DockStyle.Top;
                    pictureBox.Height = 120;
                    string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "Productos", producto.RutaImagen);
                    // Asumiendo que la propiedad RutaImagen de Producto contiene la ruta de la imagen
                    pictureBox.Image = Image.FromFile(rutaCompleta);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    // Crea un Label con el nombre del producto
                    Label labelNombreProducto = new Label();
                    labelNombreProducto.Text = producto.Nombre;
                    labelNombreProducto.Dock = DockStyle.Bottom;

                    // Agrega la PictureBox y el Label al Panel
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(labelNombreProducto);

                    // Agrega el Panel al FlowLayoutPanel existente
                    PanelDeProdcutos.Controls.Add(panel);

                    // Asigna el evento Click para mostrar el formulario de la imagen (puedes ajustar esto según tus necesidades)
                    pictureBox.Click += (sender, e) => MostrarFormularioImagen(rutaCompleta, producto.Nombre, producto.Precio, producto.IdProducto, producto.Descripcion);
                }
                }
            }
        }

        private List<Producto> ObtenerListaDeProductosDesdeBD()
        {
            // Llama a la función Listar de ProductoLogica para obtener la lista de productos desde la base de datos
            return ProductoLogica.Listar();
        }

        private void MostrarFormularioImagen(string rutaImagen, string nombre, decimal precio, int IdProducto, string descripcion)
        {
            // Crea un nuevo formulario hijo para mostrar la imagen y el botón
            ComponenteDeImagenesDeProductosForm formularioImagen = new ComponenteDeImagenesDeProductosForm(rutaImagen, nombre, precio , IdProducto, descripcion);
            AddOwnedForm(formularioImagen);
            // Abre el formulario hijo
            formularioImagen.Show();
        }

        // Resto del código...

        private void iconButton7_Click(object sender, EventArgs e)
        {
            // Tu lógica aquí...
        }

        private void MonitoresStandars_Load(object sender, EventArgs e)
        {
            // Tu lógica aquí...
        }

        private void PanelDeProdcutos_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ponerDatos(int idproducto, int cantidad)
        {
            //List<Producto> listaProductos = ObtenerListaDeProductosDesdeBD();
            listaID_Cantidad.Add(idproducto, cantidad);

            VistaClientes padre = Owner as VistaClientes;
            padre.DefinirCompras(idproducto, cantidad);


            //MessageBox.Show(String.Join(", ", listaID_Cantidad));

            
        }
        
        private void mandarCarrito_Click(object sender, EventArgs e)
        {
            VistaClientes padre = Owner as VistaClientes;
            
        }
    }
}
