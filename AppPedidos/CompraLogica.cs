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

        // Método estático para registrar una nueva compra en la base de datos
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

        public static int UltimaCompra()
        {
            int respuesta = 0;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                String id_ultima = "SELECT distinct TOP 1 (IdCompra) FROM COMPRA ORDER BY IdCompra DESC";
                SqlCommand ejecutar = new SqlCommand(id_ultima, oConexion);
                oConexion.Open();
                SqlDataReader leer = ejecutar.ExecuteReader();
                if (leer.Read() == true)
                {
                    respuesta = Convert.ToInt32(leer["IdCompra"].ToString());
                    respuesta++;
                    oConexion.Close();
                }
            }

            return respuesta;
        }

        public static List<DetalleCompra> ObtenerDetallesCompra(int id)
        {
            List <DetalleCompra> listaDetalles = new List<DetalleCompra>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                String id_ultima = "SELECT * FROM DETALLE_COMPRA WHERE IdCompra = " + id;
                SqlCommand ejecutar = new SqlCommand(id_ultima, oConexion);
                oConexion.Open();
                SqlDataReader leer = ejecutar.ExecuteReader();
                
                
                while (leer.Read())
                {
                    listaDetalles.Add(new DetalleCompra()
                    {
                        IdDetalleCompra = Convert.ToInt32(leer["IdDetalleCompra"].ToString()),
                        IdCompra = Convert.ToInt32(leer["IdCompra"].ToString()),
                        IdProducto = Convert.ToInt32(leer["IdProducto"].ToString()),
                        Cantidad = Convert.ToInt32(leer["Cantidad"].ToString()),
                        Total = Convert.ToDecimal(leer["Total"].ToString()),
                        oProducto = ProductoLogica.ProductoID(Convert.ToInt32(leer["IdProducto"].ToString())),
                            
                    });
                }

                leer.Close();
                oConexion.Close();
                
            }

            return listaDetalles;
        }

        public static Compra CompraID(int id)
        {
            Compra compra = null;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                String id_ultima = "SELECT distinct TOP 1 * FROM COMPRA WHERE IdCompra = "+id;
                SqlCommand ejecutar = new SqlCommand(id_ultima, oConexion);
                oConexion.Open();
                SqlDataReader leer = ejecutar.ExecuteReader();
                if (leer.Read() == true)
                {
                    compra = new Compra();
                    compra.IdCompra = Convert.ToInt32(leer["IdCompra"].ToString());
                    compra.IdUsuario = Convert.ToInt32(leer["IdUsuario"].ToString());
                    
                    compra.TotalProducto = leer["TotalProducto"].ToString();
                    compra.Total = Convert.ToDecimal(leer["Total"].ToString());
                    compra.Contacto = leer["Contacto"].ToString();
                    compra.Telefono = leer["Telefono"].ToString();
                    compra.Direccion = leer["Direccion"].ToString();
                    compra.IdDistrito = leer["IdDistrito"].ToString();
                    compra.FechaTexto = leer["FechaCompra"].ToString();

                    compra.oDetalleCompra = ObtenerDetallesCompra(id);
                    oConexion.Close();
                }
            }

            return compra;
        }

        public static DataTable ObtenerCompras(string extra)
        {
            DataTable dt = new DataTable();
            SqlConnection oConexion = new SqlConnection(Conexion.CN);

            string sql = "SELECT * FROM COMPRA " + extra;
            SqlCommand cmd = new SqlCommand(sql, oConexion);

            SqlDataReader dataReader = null;

            try
            {
                oConexion.Open();
                dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
            }
            finally
            {
                cmd.Dispose();
                oConexion.Close();
            }

            return dt;
        }

        public static void CambiarEstadoCompra(int idCompra, bool estado)
        {
            SqlConnection conn = new SqlConnection(Conexion.CN);


            string sql = "UPDATE Compra SET Estado=@Estado WHERE IdCompra=@IdCompra";

            SqlCommand cmd = new SqlCommand(sql, conn);

            
            cmd.Parameters.AddWithValue("@Estado", !estado);

            cmd.Parameters.AddWithValue("@IdCompra", idCompra);

            try
            {
                long respuesta;
                conn.Open();

                respuesta = cmd.ExecuteNonQuery();
                if (respuesta > 0)
                {
                    System.Windows.MessageBox.Show("El estado de la compra se actualizo");
                }
            }
            finally
            {

                cmd.Dispose();
                conn.Close();
            }


        }
    }
}
