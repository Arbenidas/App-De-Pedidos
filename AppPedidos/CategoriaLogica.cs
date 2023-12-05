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



        public static bool Registrar(Categoria oCategoria)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCategoria", oConexion);
                    cmd.Parameters.AddWithValue("Descripcion", oCategoria.Descripcion);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);

                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public static bool Modificar(Categoria oCategoria)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ModificarCategoria", oConexion);
                    cmd.Parameters.AddWithValue("IdCategoria", oCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Descripcion", oCategoria.Descripcion);
                    cmd.Parameters.AddWithValue("Activo", oCategoria.Activo);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);

                }
                catch (Exception ex)
                {
                    respuesta = false;
                }

            }

            return respuesta;

        }

        public static bool Eliminar(int id)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("delete from CATEGORIA where idcategoria = @id", oConexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = true;

                }
                catch (Exception ex)
                {
                    respuesta = false;
                }

            }

            return respuesta;

        }
    }
}
