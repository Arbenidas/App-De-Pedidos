﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppPedidos
{
    internal class UsuarioLogica
    {
        private static UsuarioLogica _instancia = null;

        public UsuarioLogica()
        {

        }

        public static UsuarioLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new UsuarioLogica();
                }

                return _instancia;
            }
        }

        public static Usuario Obtener(string _correo, string _contrasena)
        {
            Usuario objeto = null;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_obtenerUsuario", oConexion);
                    cmd.Parameters.AddWithValue("Correo", _correo);
                    cmd.Parameters.AddWithValue("Contrasena", _contrasena);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objeto = new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"].ToString()),
                                Nombres = dr["Nombres"].ToString(),
                                Apellidos = dr["Apellidos"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Contrasena = dr["Contrasena"].ToString(),
                                EsAdministrador = Convert.ToBoolean(dr["EsAdministrador"].ToString())
                            };

                        }
                    }

                }
                catch (Exception ex)
                {
                    objeto = null;
                }
            }
            return objeto;
        }

        public static int Registrar(Usuario oUsuario)
        {
            int respuesta = 0;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_registrarUsuario", oConexion);
                    cmd.Parameters.AddWithValue("Nombres", oUsuario.Nombres);
                    cmd.Parameters.AddWithValue("Apellidos", oUsuario.Apellidos);
                    cmd.Parameters.AddWithValue("Correo", oUsuario.Correo);
                    cmd.Parameters.AddWithValue("Contrasena", oUsuario.Contrasena);
                    cmd.Parameters.AddWithValue("EsAdministrador", oUsuario.EsAdministrador);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToInt32(cmd.Parameters["Resultado"].Value);

                }
                catch (Exception ex)
                {
                    respuesta = 0;
                }
            }
            return respuesta;
        }

        public static DataTable ObtenerClientes(string extra)
        {
            DataTable dt = new DataTable();
            SqlConnection oConexion = new SqlConnection(Conexion.CN);

            string sql = "SELECT * FROM USUARIO " + extra;
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

        public static void ActualizarUsuario(Usuario usuario)
        {
            SqlConnection conn = new SqlConnection(Conexion.CN);


            string sql = "UPDATE USUARIO SET Nombres=@Nombres, Apellidos=@Apellidos, Correo=@Correo, Contrasena=@Contrasena, EsAdministrador=@EsAdministrador, Activo=@Activo WHERE IdUsuario=@IdUsuario";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Nombres", usuario.Nombres);
            cmd.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
            cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
            cmd.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
            cmd.Parameters.AddWithValue("@EsAdministrador", usuario.EsAdministrador);
            cmd.Parameters.AddWithValue("@Activo", usuario.Activo);
            
            cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);

            try
            {
                long respuesta;
                conn.Open();

                respuesta = cmd.ExecuteNonQuery();
                if (respuesta > 0)
                {
                    MessageBox.Show("Usuario actualizado correctamente");
                }
            }
            finally
            {

                cmd.Dispose();
                conn.Close();
            }


        }
        public static bool Eliminar(int id)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("delete from USUARIO where IdUsuario = @id", oConexion);
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
        //
    }
}

