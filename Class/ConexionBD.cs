using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CLASEDATO
{
    public class ConexionBD
    {
        private SqlConnection conexion;

        private string cadenaConexion =
            @"Server=.\SQLEXPRESS;Database=BD_ABOGADOS_B;User Id=sa;Password=abcdef;TrustServerCertificate=True;";

        public ConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public SqlConnection AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexión: " + ex.Message);
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return conexion;
        }
    }
}
