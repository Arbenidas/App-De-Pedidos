﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPedidos
{
    internal class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string ConfirmarContrasena { get; set; }
        public bool EsAdministrador { get; set; }
        public bool Activo { get; set; }
    }
}
