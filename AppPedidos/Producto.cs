using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppPedidos
{
    internal class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string RutaImagen { get; set; }
        public bool Activo { get; set; }
        public string FechaRegistro{ get; set; }
        

        public List<Producto> Listar()
        {
            List < Producto > lista  = new List < Producto > ();
            lista = ProductoLogica.Listar();
            return lista;
        }
    }
}
