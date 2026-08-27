using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CLASEDATO
{
    public class CRUD
    {
        private ConexionBD conexion = new ConexionBD();

        protected DataTable Consultar(string procedimiento,
                                      params SqlParameter[] parametros)
        {
            DataTable tabla = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = procedimiento;
                comando.CommandType = CommandType.StoredProcedure;

                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros);
                }

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al consultar la base de datos: " + ex.Message
                );
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        protected ResultadoCRUD EjecutarOperacion(
            string procedimiento,
            params SqlParameter[] parametros)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = procedimiento;
                comando.CommandType = CommandType.StoredProcedure;

                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros);
                }

                SqlDataReader lector = comando.ExecuteReader();

                ResultadoCRUD resultado = new ResultadoCRUD();

                if (lector.Read())
                {
                    if (ExisteColumna(lector, "CODIGO"))
                    {
                        resultado.Codigo =
                            Convert.ToInt32(lector["CODIGO"]);
                    }

                    if (ExisteColumna(lector, "MSG"))
                    {
                        resultado.Mensaje =
                            lector["MSG"].ToString();
                    }

                    if (ExisteColumna(lector, "NUM_ERROR_SQL"))
                    {
                        resultado.Codigo =
                            Convert.ToInt32(lector["NUM_ERROR_SQL"]);
                    }

                    if (ExisteColumna(lector, "MSG_SQL"))
                    {
                        resultado.Mensaje =
                            lector["MSG_SQL"].ToString();
                    }
                }

                lector.Close();

                return resultado;
            }
            catch (Exception ex)
            {
                return new ResultadoCRUD
                {
                    Codigo = -999,
                    Mensaje = ex.Message
                };
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        private bool ExisteColumna(SqlDataReader lector, string columna)
        {
            for (int i = 0; i < lector.FieldCount; i++)
            {
                if (lector.GetName(i).Equals(
                    columna,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        protected SqlParameter Parametro(
            string nombre,
            object valor)
        {
            return new SqlParameter(
                nombre,
                valor ?? DBNull.Value
            );
        }
    }

    public class ResultadoCRUD
    {
        public int Codigo { get; set; }

        public string Mensaje { get; set; }

        public ResultadoCRUD()
        {
            Codigo = 0;
            Mensaje = "";
        }
    }
}
