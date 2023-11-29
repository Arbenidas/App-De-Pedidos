using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPedidos
{
    public partial class VistaCarrito : Form
    {
        Dictionary<int, int> listaCompra = new Dictionary<int, int>();
        int IDusuario;
        public VistaCarrito(Dictionary<int, int> listaDeCompra, int IDusuario)
        {
            InitializeComponent();
            this.listaCompra = listaDeCompra;
            CargarProductos(listaDeCompra);
            this.IDusuario = IDusuario;
        }

        private void CargarProductos(Dictionary<int, int> listaDeCompra)
        {
            // Obtiene la lista de productos desde la base de datos
            List<Producto> listaProductos = ObtenerListaDeProductosDesdeBD();


            //MessageBox.Show(String.Join(", ", listaDeCompra));


            // Verifica que el FlowLayoutPanel existente no sea nulo
            if (PanelDeProdcutos != null)
            {
                // Recorre la lista de productos y agrega un Panel para cada producto
                foreach (Producto producto in listaProductos)
                {
                    if (listaDeCompra.ContainsKey( producto.IdProducto))
                    {
                        Panel panel = new Panel();
                        panel.Padding = new Padding(3, 30, 3, 10);
                        panel.Width = 180;
                        panel.Height = 300;
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
                        
                            
                        
                        
                        string detalle = "Unidades/ " + listaDeCompra[producto.IdProducto].ToString();
                        detalle += " Precio: " + producto.Precio.ToString();
                        Label labelDetalle = new Label();
                        labelDetalle.Text = detalle;
                        labelDetalle.Dock = DockStyle.Bottom;

                        Label labelSubtotal = new Label();
                        labelSubtotal.Text = "Sub Total: $"+(producto.Precio * listaDeCompra[producto.IdProducto]).ToString();
                        labelSubtotal.Dock = DockStyle.Bottom;

                        // Crea un Label con el nombre del producto
                        Button botonCancelar = new Button();
                        botonCancelar.Text = "Quitar del carrito";
                        botonCancelar.Dock = DockStyle.Bottom;

                        Panel panelDetalle = new Panel();
                        panel.Width = 170;
                        panel.Width = 270;
                        
                        panelDetalle.Dock= DockStyle.Bottom;

                        
                        panelDetalle.Controls.Add(labelNombreProducto);
                        panelDetalle.Controls.Add(labelDetalle);
                        panelDetalle.Controls.Add(labelSubtotal);
                        panelDetalle.Controls.Add(botonCancelar);

                        

                        // Agrega la PictureBox y el Label al Panel
                        panel.Controls.Add(pictureBox);
                        panel.Controls.Add(panelDetalle);

                        // Agrega el Panel al FlowLayoutPanel existente
                        PanelDeProdcutos.Controls.Add(panel);

                        botonCancelar.Click += (sender, e) => QuitarDelCarrito(producto.IdProducto);
                        // Asigna el evento Click para mostrar el formulario de la imagen (puedes ajustar esto según tus necesidades)
                        //pictureBox.Click += (sender, e) => MostrarFormularioImagen(rutaCompleta, producto.Nombre, producto.Precio, producto.IdProducto);
                    }
                }
            }
        }
        private void QuitarDelCarrito(int IdProducto)
        {
            VistaClientes padre = Owner as VistaClientes;
            padre.QuitarProducto(IdProducto);
        }
        private List<Producto> ObtenerListaDeProductosDesdeBD()
        {
            // Llama a la función Listar de ProductoLogica para obtener la lista de productos desde la base de datos
            return ProductoLogica.Listar();
        }

        private void botonDeComprar_Click(object sender, EventArgs e)
        {
            RegistroCompra registroCompra = new RegistroCompra(listaCompra, IDusuario);
            registroCompra.Show();
        }
    }
}
