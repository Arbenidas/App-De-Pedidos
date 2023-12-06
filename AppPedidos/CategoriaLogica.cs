using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPedidos
{
    internal class CategoriaLogica
    {
        private static CategoriaLogica _instancia = null;

        public CategoriaLogica()
        {

        }

        public static CategoriaLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new CategoriaLogica();
                }

                return _instancia;
            }
        }

        // Método estático para listar todas las categorías desde la base de datos
        public static List<Categoria> Listar()
        {
            // Lista para almacenar las categorías
            List<Categoria> rptListaCategoria = new List<Categoria>();

            // Uso de una conexión a la base de datos utilizando la cadena de conexión de la clase Conexion
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                // Creación de un comando SQL para llamar al procedimiento almacenado sp_obtenerCategoria
                SqlCommand cmd = new SqlCommand("sp_obtenerCategoria", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    // Apertura de la conexión a la base de datos
                    oConexion.Open();

                    // Utilización de un SqlDataReader para leer los resultados del procedimiento almacenado
                    SqlDataReader dr = cmd.ExecuteReader();

                    // Iteración a través de las filas devueltas por el procedimiento almacenado
                    while (dr.Read())
                    {
                        // Creación de objetos Categoria y agregándolos a la lista
                        rptListaCategoria.Add(new Categoria()
                        {
                            IdCategoria = Convert.ToInt32(dr["IdCategoria"].ToString()),
                            Descripcion = dr["Descripcion"].ToString(),
                            Activo = Convert.ToBoolean(dr["Activo"].ToString())
                        });
                    }

                    // Cierre del SqlDataReader
                    dr.Close();

                    // Devolución de la lista al llamar al método
                    return rptListaCategoria;
                }
                // Captura de excepciones, si ocurre alguna durante la ejecución
                catch (Exception ex)
                {
                    // En caso de excepción, la lista se establece en null y se devuelve
                    rptListaCategoria = null;
                    return rptListaCategoria;
                }
            }
        }



        /// <summary>
        /// Método estático para registrar una nueva categoría en la base de datos
        /// </summary>
        /// <param name="oCategoria"></param>
        /// <returns></returns>
        public static bool Registrar(Categoria oCategoria)
        {
            // Variable para almacenar la respuesta (éxito o fallo)
            bool respuesta = true;

            // Uso de una conexión a la base de datos utilizando la cadena de conexión de la clase Conexion
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    // Creación de un comando SQL para llamar al procedimiento almacenado sp_RegistrarCategoria
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCategoria", oConexion);

                    // Especificación de parámetros para el procedimiento almacenado (en este caso, Descripcion)
                    cmd.Parameters.AddWithValue("Descripcion", oCategoria.Descripcion);

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
        /// Método estático para modificar una categoría en la base de datos
        /// </summary>
        /// <param name="oCategoria"></param>
        /// <returns></returns>
        public static bool Modificar(Categoria oCategoria)
        {
            // Variable para almacenar la respuesta (éxito o fallo)
            bool respuesta = true;

            // Uso de una conexión a la base de datos utilizando la cadena de conexión de la clase Conexion
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    // Creación de un comando SQL para llamar al procedimiento almacenado sp_ModificarCategoria
                    SqlCommand cmd = new SqlCommand("sp_ModificarCategoria", oConexion);

                    // Especificación de parámetros para el procedimiento almacenado (IdCategoria, Descripcion, Activo)
                    cmd.Parameters.AddWithValue("IdCategoria", oCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Descripcion", oCategoria.Descripcion);
                    cmd.Parameters.AddWithValue("Activo", oCategoria.Activo);

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


        // Método estático para eliminar una categoría de la base de datos
        public static bool Eliminar(int id)
        {
            // Variable para almacenar la respuesta (éxito o fallo)
            bool respuesta = true;

            // Uso de una conexión a la base de datos utilizando la cadena de conexión de la clase Conexion
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    // Creación de un comando SQL para realizar la eliminación de la categoría
                    SqlCommand cmd = new SqlCommand("DELETE FROM CATEGORIA WHERE IdCategoria = @id", oConexion);

                    // Especificación de parámetros para la consulta (en este caso, el parámetro @id)
                    cmd.Parameters.AddWithValue("@id", id);

                    // Especificación del tipo de comando como una consulta SQL directa
                    cmd.CommandType = CommandType.Text;

                    // Apertura de la conexión a la base de datos
                    oConexion.Open();

                    // Ejecución de la consulta SQL para eliminar la categoría
                    cmd.ExecuteNonQuery();

                    // Establecimiento de la respuesta en true (éxito)
                    respuesta = true;
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

    }
}
