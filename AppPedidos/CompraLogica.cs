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

        public static bool Registrar(Compra oCompra)
        {

            bool respuesta = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    SqlCommand cmd = new SqlCommand("sp_registrarCompra", oConexion);
                    cmd.Parameters.AddWithValue("IdUsuario", oCompra.IdUsuario);
                    cmd.Parameters.AddWithValue("TotalProducto", oCompra.TotalProducto);
                    cmd.Parameters.AddWithValue("Total", oCompra.Total);
                    cmd.Parameters.AddWithValue("Contacto", oCompra.Contacto);
                    cmd.Parameters.AddWithValue("Telefono", oCompra.Telefono);
                    cmd.Parameters.AddWithValue("Direccion", oCompra.Direccion);
                    cmd.Parameters.AddWithValue("IdDistrito", oCompra.IdDistrito);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    
                    oConexion.Close();

                }
                catch (Exception ex)
                {     
                    respuesta = false;
                }
            }

            

            return respuesta;
        }
        public static int RegistrarDetalle(List<DetalleCompra> detallesDeCompra)
        {
            int resultado =0;
            System.Windows.MessageBox.Show("Entro al metodo");
            SqlConnection conexion = new SqlConnection(Conexion.CN);
            foreach (DetalleCompra dc in detallesDeCompra)
            {
                System.Windows.MessageBox.Show("Se insertara producto"+dc.IdProducto.ToString());

                try
                {
                    string totalSinComa = dc.Total.ToString().Replace(',', '.');
                    
                    string insetarDetalle = "INSERT INTO DETALLE_COMPRA (IdCompra,IdProducto,Cantidad,Total) values (" + dc.IdCompra + "," + dc.IdProducto + "," + dc.Cantidad + "," + totalSinComa + ");";

                    SqlCommand comando = new SqlCommand(insetarDetalle, conexion);
                    conexion.Open();
                    System.Windows.MessageBox.Show(insetarDetalle.ToString());
                    comando.ExecuteNonQuery();
                    conexion.Close();

                    resultado = 1;
                }
                catch (Exception ex)
                {
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
                    //MessageBox.Show(respuesta.ToString());
                    oConexion.Close();
                }
            }

            return respuesta;
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
    }
}
