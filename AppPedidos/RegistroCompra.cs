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
    public partial class RegistroCompra : Form
    {
        private Dictionary<int, int> listaDeCompra = new Dictionary<int, int>();
        private Compra compra = new Compra();
        private int IDusuario;
        private decimal total;
        public RegistroCompra(Dictionary<int, int> listaDeCompra, int IDusuario)
        {
            InitializeComponent();
            this.listaDeCompra = listaDeCompra;
            this.IDusuario = IDusuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            List<DetalleCompra> detallesCompra = new List<DetalleCompra>();
            compra.Direccion = inputDireccion.Text;
            compra.Contacto = inputContacto.Text;
            compra.Telefono = inputTelefono.Text;
            compra.IdUsuario = IDusuario;
            compra.IdDistrito = "1";
            compra.TotalProducto = "0";

            int ultimaCompra = CompraLogica.UltimaCompra();
            List<Producto> listaProductos = ProductoLogica.Listar();
            List<Producto> listaCarrito = new List<Producto>();

            compra.oDetalleCompra = new List<DetalleCompra>();
            foreach (var producto in listaProductos)
            {
                if (listaDeCompra.ContainsKey(producto.IdProducto))
                {
                    DetalleCompra detalleCompra = new DetalleCompra();
                    detalleCompra.IdCompra = ultimaCompra;
                    detalleCompra.IdProducto = producto.IdProducto;
                    detalleCompra.oProducto = producto;
                    detalleCompra.Cantidad = listaDeCompra[producto.IdProducto];
                    detalleCompra.Total = producto.Precio * listaDeCompra[producto.IdProducto];
                    compra.oDetalleCompra.Add(detalleCompra);

                }
            }

            
            foreach (var item in compra.oDetalleCompra)
            {
                MessageBox.Show("detalle "+item.oProducto.Nombre+" cantidad "+item.Cantidad+" idProducto "+item.IdProducto);
            }
            MessageBox.Show("ultima compra "+ultimaCompra.ToString());
            //bool registro = false;
            bool registro = CompraLogica.Registrar(compra);


            CompraLogica.RegistrarDetalle(compra.oDetalleCompra);

            if (registro)
            {
                MessageBox.Show("Se realizo su compra con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al realizar la compra");

            }

        }

        private void RegistroCompra_Load(object sender, EventArgs e)
        {
            total = 0;
            List<Producto> listaProductos = ProductoLogica.Listar();
            List<Producto> listaCarrito = new List<Producto>();

            foreach (var producto in listaProductos)
            {
                if (listaDeCompra.ContainsKey(producto.IdProducto))
                {
                    listaCarrito.Add(producto);
                    total += producto.Precio * listaDeCompra[producto.IdProducto];
                    MessageBox.Show(producto.Precio.ToString() + " X " + listaDeCompra[producto.IdProducto].ToString());
                }
            }

            compra.Total = total;
            textTotal.Text = total.ToString();
            dataGridView1.DataSource = listaCarrito;
        }
    }
}
