﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPedidos
{
    internal class DetalleCompraVista
    {
        
        public int IdCompra { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal Precio { get; set; }

        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
    }
}
