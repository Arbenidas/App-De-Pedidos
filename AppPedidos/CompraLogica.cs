using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Security.Policy;
using System.Collections;
using System.Runtime.CompilerServices;

namespace AppPedidos
{
    internal class CompraLogica
    {
        private static CompraLogica _instancia = null;

        public CompraLogica()
        {

        }

        public static CompraLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new CompraLogica();
                }

                return _instancia;
            }
        }

        /// <summary>
        /// Método estático para registrar una nueva compra en la base de datos
        /// </summary>
        /// <param name="oCompra"></param>
        /// <returns></returns>
        public static bool Registrar(Compra oCompra)
        {
            // Variable para almacenar la respuesta (éxito o fallo)
            bool respuesta = false;

            // Uso de una conexión a la base de datos utilizando la cadena de conexión de la clase Conexion
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    // Creación de un comando SQL para llamar al procedimiento almacenado sp_registrarCompra
                    SqlCommand cmd = new SqlCommand("sp_registrarCompra", oConexion);

                    // Especificación de parámetros para el procedimiento almacenado
                    cmd.Parameters.AddWithValue("IdUsuario", oCompra.IdUsuario);
                    cmd.Parameters.AddWithValue("TotalProducto", oCompra.TotalProducto);
                    cmd.Parameters.AddWithValue("Total", oCompra.Total);
                    cmd.Parameters.AddWithValue("Contacto", oCompra.Contacto);
                    cmd.Parameters.AddWithValue("Telefono", oCompra.Telefono);
                    cmd.Parameters.AddWithValue("Direccion", oCompra.Direccion);
                    cmd.Parameters.AddWithValue("IdDistrito", oCompra.IdDistrito);

                    // Especificación de un parámetro de salida para el resultado del procedimiento almacenado
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    // Especificación del tipo de comando como un procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Apertura de la conexión a la base de datos
                    oConexion.Open();

                    // Ejecución del procedimiento almacenado
                    cmd.ExecuteNonQuery();

                    // Obtención del resultado del procedimiento almacenado (valor del parámetro de salida)
                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);

                    // Cierre de la conexión a la base de datos
                    oConexion.Close();
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
        /// Registra un detalle en la base de datos *DETALLE_COMPRA*
        /// </summary>
        /// <param name="detallesDeCompra"></param>
        /// <returns></returns>
        public static int RegistrarDetalle(List<DetalleCompra> detallesDeCompra)
        {
            int resultado = 0;
            SqlConnection conexion = new SqlConnection(Conexion.CN);

            foreach (DetalleCompra dc in detallesDeCompra)
            {
                try
                {
                    // Potencial problema de seguridad: Construcción de consulta mediante concatenación de cadenas
                    string totalSinComa = dc.Total.ToString().Replace(',', '.');

                    // Potencial problema de seguridad e inyección SQL: Construcción de consulta sin parámetros
                    string insertarDetalle = "INSERT INTO DETALLE_COMPRA (IdCompra, IdProducto, Cantidad, Total) VALUES ("
                        + dc.IdCompra + "," + dc.IdProducto + "," + dc.Cantidad + "," + totalSinComa + ");";

                    SqlCommand comando = new SqlCommand(insertarDetalle, conexion);

                    // Problema de eficiencia: Apertura y cierre de la conexión en cada iteración del bucle
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();

                    // Resultado se sobrescribe en cada iteración, solo refleja la última operación
                    resultado = 1;
                }
                catch (Exception ex)
                {
                    // Si hay una excepción, se establece el resultado en -1 y se muestra un mensaje de error
                    resultado = -1;
                    System.Windows.MessageBox.Show(ex.ToString());
                }
            }

            return resultado;
        }
        /// <summary>
        /// Selecciona la ultima compra de la tabla COMPRA.
        /// </summary>
        /// <returns></returns>
        public static int UltimaCompra()
        {
            int respuesta = 0;

            // Uso de 'using' para asegurar la liberación de recursos
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                // Consulta SQL para obtener el identificador de la última compra
                String id_ultima = "SELECT TOP 1 IdCompra FROM COMPRA ORDER BY IdCompra DESC";

                // Uso de SqlCommand para ejecutar la consulta
                SqlCommand ejecutar = new SqlCommand(id_ultima, oConexion);

                // Apertura de la conexión a la base de datos
                oConexion.Open();

                // Uso de SqlDataReader para leer el resultado de la consulta
                SqlDataReader leer = ejecutar.ExecuteReader();

                // Verificación si hay resultados en la consulta
                if (leer.Read())
                {
                    // Obtención del valor del identificador de la última compra
                    respuesta = Convert.ToInt32(leer["IdCompra"].ToString());

                    // Incremento del identificador para utilizarlo en una nueva compra
                    respuesta++;
                }

            }

            // Devolución del identificador de la última compra
            return respuesta;
        }


        public static List<DetalleCompra> ObtenerDetallesCompra(int id)
        {
            List<DetalleCompra> listaDetalles = new List<DetalleCompra>();

            // Uso de 'using' para asegurar la liberación de recursos
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                // Consulta SQL para obtener detalles de compra específicos
                String id_ultima = "SELECT * FROM DETALLE_COMPRA WHERE IdCompra = " + id;

                // Uso de SqlCommand para ejecutar la consulta
                SqlCommand ejecutar = new SqlCommand(id_ultima, oConexion);

                // Apertura de la conexión a la base de datos
                oConexion.Open();

                // Uso de SqlDataReader para leer el resultado de la consulta
                SqlDataReader leer = ejecutar.ExecuteReader();

                // Iteración a través de los resultados y construcción de la lista de detalles de compra
                while (leer.Read())
                {
                    listaDetalles.Add(new DetalleCompra()
                    {
                        IdDetalleCompra = Convert.ToInt32(leer["IdDetalleCompra"].ToString()),
                        IdCompra = Convert.ToInt32(leer["IdCompra"].ToString()),
                        IdProducto = Convert.ToInt32(leer["IdProducto"].ToString()),
                        Cantidad = Convert.ToInt32(leer["Cantidad"].ToString()),
                        Total = Convert.ToDecimal(leer["Total"].ToString()),

                        // Invocación de ProductoLogica.ProductoID para obtener información adicional del producto
                        oProducto = ProductoLogica.ProductoID(Convert.ToInt32(leer["IdProducto"].ToString())),
                    });
                }

                // Cierre del SqlDataReader y de la conexión a la base de datos
                leer.Close();
                oConexion.Close();
            }

            // Devolución de la lista de detalles de compra
            return listaDetalles;
        }


        public static Compra CompraID(int id)
        {
            Compra compra = null;

            // Uso de 'using' para asegurar la liberación de recursos
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                // Consulta SQL para obtener información de una compra específica
                String id_ultima = "SELECT TOP 1 * FROM COMPRA WHERE IdCompra = " + id;

                // Uso de SqlCommand para ejecutar la consulta
                SqlCommand ejecutar = new SqlCommand(id_ultima, oConexion);

                // Apertura de la conexión a la base de datos
                oConexion.Open();

                // Uso de SqlDataReader para leer el resultado de la consulta
                SqlDataReader leer = ejecutar.ExecuteReader();

                // Verificación si hay resultados en la consulta
                if (leer.Read())
                {
                    // Inicialización de la instancia de Compra
                    compra = new Compra();

                    // Asignación de valores desde el resultado de la consulta a la instancia de Compra
                    compra.IdCompra = Convert.ToInt32(leer["IdCompra"].ToString());
                    compra.IdUsuario = Convert.ToInt32(leer["IdUsuario"].ToString());
                    compra.TotalProducto = leer["TotalProducto"].ToString();
                    compra.Total = Convert.ToDecimal(leer["Total"].ToString());
                    compra.Contacto = leer["Contacto"].ToString();
                    compra.Telefono = leer["Telefono"].ToString();
                    compra.Direccion = leer["Direccion"].ToString();
                    compra.IdDistrito = leer["IdDistrito"].ToString();
                    compra.FechaTexto = leer["FechaCompra"].ToString();

                    // Obtención de los detalles de compra asociados utilizando el método ObtenerDetallesCompra
                    compra.oDetalleCompra = ObtenerDetallesCompra(id);

                    // Cierre de la conexión a la base de datos
                    oConexion.Close();
                }
            }

            // Devolución de la instancia de Compra (puede ser null si no se encontraron resultados)
            return compra;
        }

        /// <summary>
        /// Optione todos los detalles de las compras de la tabla
        /// </summary>
        /// <param name="extra"></param>
        /// <returns></returns>
        public static DataTable ObtenerCompras(string extra)
        {
            DataTable dt = new DataTable();

            // Uso de 'using' para asegurar la liberación de recursos
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                // Construcción de la consulta SQL utilizando el parámetro 'extra'
                string sql = "SELECT * FROM COMPRA " + extra;

                // Uso de SqlCommand para ejecutar la consulta
                SqlCommand cmd = new SqlCommand(sql, oConexion);
                SqlDataReader dataReader = null;

                try
                {
                    // Apertura de la conexión a la base de datos
                    oConexion.Open();

                    // Uso de SqlDataReader para leer el resultado de la consulta
                    dataReader = cmd.ExecuteReader();

                    // Carga de datos en el DataTable
                    dt.Load(dataReader);
                }
                finally
                {
                    // Liberación de recursos y cierre de la conexión a la base de datos
                    cmd.Dispose();
                    oConexion.Close();
                }
            }

            // Devolución del DataTable que contiene los resultados de la consulta
            return dt;
        }


        public static void CambiarEstadoCompra(int idCompra, bool estado)
        {
            // Uso de 'using' para asegurar la liberación de recursos
            using (SqlConnection conn = new SqlConnection(Conexion.CN))
            {
                // Consulta SQL para actualizar el estado de una compra
                string sql = "UPDATE Compra SET Estado=@Estado WHERE IdCompra=@IdCompra";

                // Uso de SqlCommand para ejecutar la consulta
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Asignación de valores a los parámetros utilizando AddWithValue
                cmd.Parameters.AddWithValue("@Estado", !estado); // Inversión del estado actual
                cmd.Parameters.AddWithValue("@IdCompra", idCompra);

                try
                {
                    long respuesta;

                    // Apertura de la conexión a la base de datos
                    conn.Open();

                    // Ejecución de la consulta y obtención del número de filas afectadas
                    respuesta = cmd.ExecuteNonQuery();

                    // Verificación si la actualización fue exitosa
                    if (respuesta > 0)
                    {
                        System.Windows.MessageBox.Show("El estado de la compra se actualizó");
                    }
                }
                finally
                {
                    // Liberación de recursos y cierre de la conexión a la base de datos
                    cmd.Dispose();
                    conn.Close();
                }
            }
        }

    }
}
