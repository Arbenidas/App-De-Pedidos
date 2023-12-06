using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace AppPedidos
{
    internal class CarritoLogica
    {
        private static CarritoLogica _instancia = null;

        public CarritoLogica()
        {

        }
        /// <summary>
        /// Propiedad estática que proporciona acceso a la instancia única de la clase
        /// </summary>
        public static CarritoLogica Instancia
        {
            get
            {
                // Si la instancia no ha sido creada, crea una nueva
                if (_instancia == null)
                {
                    _instancia = new CarritoLogica();
                }

                // Devuelve la instancia (puede ser la nueva o la existente)
                return _instancia;
            }
        }

        /// <summary>
        /// Método para registrar un carrito en la base de datos
        /// </summary>
        /// <param name="oCarrito"></param>
        /// <returns></returns>
        public int Registrar(Carrito oCarrito)
        {
            // Variable para almacenar la respuesta (éxito o fallo)
            int respuesta = 0;

            // Uso de una conexión a la base de datos utilizando la cadena de conexión de la clase Conexion
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    // Creación de un comando SQL para llamar al procedimiento almacenado sp_InsertarCarrito
                    SqlCommand cmd = new SqlCommand("sp_InsertarCarrito", oConexion);

                    // Configuración de los parámetros del procedimiento almacenado
                    cmd.Parameters.AddWithValue("IdUsuario", oCarrito.IdUsuario);
                    cmd.Parameters.AddWithValue("IdProducto", oCarrito.IdProducto);

                    // Agregando un parámetro de salida para almacenar el resultado de la ejecución del procedimiento almacenado
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;

                    // Especificación del tipo de comando como un procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Apertura de la conexión a la base de datos
                    oConexion.Open();

                    // Ejecución del procedimiento almacenado
                    cmd.ExecuteNonQuery();

                    // Obtención del resultado almacenado en el parámetro de salida "Resultado"
                    respuesta = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception ex)
                {
                    // En caso de una excepción, la respuesta se establece en 0
                    respuesta = 0;
                    // También se podría registrar la excepción para fines de depuración
                    // Console.WriteLine("Excepción: " + ex.Message);
                }
            }

            // Devolución de la respuesta al llamar al método
            return respuesta;
        }



        /// <summary>
        /// Método para obtener la cantidad de elementos en el carrito de un usuario
        /// </summary>
        /// <param name="idusuario"></param>
        /// <returns></returns>
        public int Cantidad(int idusuario)
        {
            // Variable para almacenar la respuesta (número de elementos en el carrito)
            int respuesta = 0;

            // Uso de una conexión a la base de datos utilizando la cadena de conexión de la clase Conexion
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    // Creación de un comando SQL para ejecutar una consulta que cuenta los elementos en el carrito del usuario
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM carrito WHERE idusuario = @idusuario", oConexion);

                    // Especificación de un parámetro para el valor del idusuario en la consulta
                    cmd.Parameters.AddWithValue("@idusuario", idusuario);

                    // Especificación del tipo de comando como un comando de texto (consulta SQL directa)
                    cmd.CommandType = CommandType.Text;

                    // Apertura de la conexión a la base de datos
                    oConexion.Open();

                    // Ejecución de la consulta y obtención del resultado mediante ExecuteScalar
                    // La consulta cuenta el número de elementos en el carrito del usuario
                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                }
                catch (Exception ex)
                {
                    // En caso de una excepción, la respuesta se establece en 0
                    respuesta = 0;
                    // También se podría registrar la excepción para fines de depuración
                    // Console.WriteLine("Excepción: " + ex.Message);
                }
            }

            // Devolución de la respuesta al llamar al método
            return respuesta;
        }


        /// <summary>
        /// Método para obtener una lista de elementos en el carrito de un usuario
        /// </summary>
        /// <param name="_idusuario"></param>
        /// <returns></returns>
        public List<Carrito> Obtener(int _idusuario)
        {
            // Lista para almacenar los elementos en el carrito
            List<Carrito> lst = new List<Carrito>();

            // Uso de una conexión a la base de datos utilizando la cadena de conexión de la clase Conexion
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    // Creación de un comando SQL para llamar al procedimiento almacenado sp_ObtenerCarrito
                    SqlCommand cmd = new SqlCommand("sp_ObtenerCarrito", oConexion);

                    // Especificación de parámetros para el procedimiento almacenado (en este caso, el IdUsuario)
                    cmd.Parameters.AddWithValue("IdUsuario", _idusuario);

                    // Especificación del tipo de comando como un procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Apertura de la conexión a la base de datos
                    oConexion.Open();

                    // Utilización de un SqlDataReader para leer los resultados del procedimiento almacenado
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // Iteración a través de las filas devueltas por el procedimiento almacenado
                        while (dr.Read())
                        {
                            // Creación de objetos Carrito y agregándolos a la lista
                            lst.Add(new Carrito()
                            {
                                IdCarrito = Convert.ToInt32(dr["IdCarrito"].ToString()),
                                IdProducto = Convert.ToInt32(dr["Idproducto"].ToString()),
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"].ToString())
                            });
                        }
                    }
                }
                // Captura de excepciones, si ocurre alguna durante la ejecución
                catch (Exception ex)
                {
                    // En caso de excepción, se asigna una nueva lista vacía
                    // Esto puede ser útil para manejar el escenario donde la obtención de datos falla
                    lst = new List<Carrito>();
                }
            }

            // Devolución de la lista al llamar al método
            return lst;
        }

        /// <summary>
        /// Método para eliminar un elemento del carrito y actualizar el stock del producto
        /// </summary>
        /// <param name="IdCarrito"></param>
        /// <param name="IdProducto"></param>
        /// <returns></returns>
        public bool Eliminar(string IdCarrito, string IdProducto)
        {
            // Variable para almacenar la respuesta (éxito o fallo)
            bool respuesta = true;

            // Uso de una conexión a la base de datos utilizando la cadena de conexión de la clase Conexion
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    // Construcción de una consulta SQL utilizando un StringBuilder
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("DELETE FROM carrito WHERE idcarrito = @idcarrito");
                    query.AppendLine("UPDATE PRODUCTO SET Stock = Stock + 1 WHERE IdProducto = @idproducto");

                    // Creación de un comando SQL para ejecutar la consulta
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);

                    // Especificación de parámetros para la consulta (IdCarrito e IdProducto)
                    cmd.Parameters.AddWithValue("@idcarrito", IdCarrito);
                    cmd.Parameters.AddWithValue("@idproducto", IdProducto);

                    // Especificación del tipo de comando como una consulta SQL directa
                    cmd.CommandType = CommandType.Text;

                    // Apertura de la conexión a la base de datos
                    oConexion.Open();

                    // Ejecución de la consulta
                    cmd.ExecuteNonQuery();
                }
                // Captura de excepciones, si ocurre alguna durante la ejecución
                catch (Exception ex)
                {
                    // En caso de excepción, la respuesta se establece en false
                    respuesta = false;
                }
            }

            // Devolución de la respuesta al llamar al método
            return respuesta;
        }


        /// <summary>
        /// Método para obtener detalles de compras de un usuario
        /// </summary>
        /// <param name="IdUsuario"></param>
        /// <returns></returns>
        public List<Compra> ObtenerCompra(int IdUsuario)
        {
            // Lista para almacenar los detalles de la compra
            List<Compra> rptDetalleCompra = new List<Compra>();

            // Uso de una conexión a la base de datos utilizando la cadena de conexión de la clase Conexion
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                // Creación de un comando SQL para llamar al procedimiento almacenado sp_ObtenerCompra
                SqlCommand cmd = new SqlCommand("sp_ObtenerCompra", oConexion);
                cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    // Apertura de la conexión a la base de datos
                    oConexion.Open();

                    // Utilización de un XmlReader para leer los resultados del procedimiento almacenado en formato XML
                    using (XmlReader dr = cmd.ExecuteXmlReader())
                    {
                        while (dr.Read())
                        {
                            // Carga del XML en un objeto XDocument
                            XDocument doc = XDocument.Load(dr);

                            // Verificación si el XML contiene la estructura esperada
                            if (doc.Element("DATA") != null)
                            {
                                // Mapeo de los elementos XML a objetos Compra y DetalleCompra
                                rptDetalleCompra = (from c in doc.Element("DATA").Elements("COMPRA")
                                                    select new Compra()
                                                    {
                                                        Total = Convert.ToDecimal(c.Element("Total").Value, new CultureInfo("es-PE")),
                                                        FechaTexto = c.Element("Fecha").Value,
                                                        oDetalleCompra = (from d in c.Element("DETALLE_PRODUCTO").Elements("PRODUCTO")
                                                                          select new DetalleCompra()
                                                                          {
                                                                              oProducto = new Producto()
                                                                              {
                                                                                  Nombre = d.Element("Nombre").Value,
                                                                                  RutaImagen = d.Element("RutaImagen").Value
                                                                              },
                                                                              Total = Convert.ToDecimal(d.Element("Total").Value, new CultureInfo("es-PE")),
                                                                              Cantidad = Convert.ToInt32(d.Element("Cantidad").Value)
                                                                          }).ToList()
                                                    }).ToList();
                            }
                            else
                            {
                                // En caso de que la estructura del XML no sea la esperada, se asigna una nueva lista vacía
                                rptDetalleCompra = new List<Compra>();
                            }
                        }

                        // Cierre del XmlReader
                        dr.Close();
                    }

                    // Devolución de la lista al llamar al método
                    return rptDetalleCompra;
                }
                // Captura de excepciones, si ocurre alguna durante la ejecución
                catch (Exception ex)
                {
                    // En caso de excepción, la lista se establece en null y se devuelve
                    rptDetalleCompra = null;
                    return rptDetalleCompra;
                }
            }
        }
    }
}