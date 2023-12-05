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
    public partial class VerCompraDetalle : Form
    {
        private Compra compra;
        public VerCompraDetalle(int idCompra)
        {
            InitializeComponent();
            compra = CompraLogica.CompraID(idCompra);
            

        }

        private void VerCompraDetalle_Load(object sender, EventArgs e)
        {
            inputDireccion.Text = compra.Direccion;
            inputContacto.Text = compra.Contacto;
            inputTelefono.Text = compra.Telefono;
            textTotal.Text = compra.Total.ToString();

            List<DetalleCompra> detalleCompras = new List<DetalleCompra>();
            detalleCompras = CompraLogica.ObtenerDetallesCompra(compra.IdCompra);

            List<DetalleCompraVista> detalleCompraVistas = new List<DetalleCompraVista>();
            foreach (var item in detalleCompras)
            {
                DetalleCompraVista detalle = new DetalleCompraVista();
                detalle.IdCompra = item.IdCompra;
                detalle.NombreProducto = item.oProducto.Nombre;
                detalle.DescripcionProducto = item.oProducto.Descripcion;
                detalle.Precio = item.oProducto.Precio;
                
                detalle.Cantidad = item.Cantidad;
                detalle.SubTotal = item.Total;

                detalleCompraVistas.Add(detalle);
            }

            dataGridView1.DataSource = detalleCompraVistas;
        }
    }
}
