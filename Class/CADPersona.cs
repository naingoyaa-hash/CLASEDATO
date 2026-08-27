using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CLASEDATO
{
    public class CADPersona : CRUD
    {

        public ResultadoCRUD Insertar(
            string cedula,
            string apellidos,
            string nombres,
            bool sexo,
            DateTime fechaNacimiento,
            string email,
            string telefono)
        {
            return EjecutarOperacion(
                "PERSONAI",
                Parametro("@CEDULA", cedula),
                Parametro("@APELLIDOS", apellidos),
                Parametro("@NOMBRES", nombres),
                Parametro("@SEXO", sexo),
                Parametro("@FECHA_NAC", fechaNacimiento),
                Parametro("@EMAIL", email),
                Parametro("@TELEFONO", telefono)
            );
        }

        public DataTable Seleccionar()
        {
            return Consultar("PERSONAS");
        }

        public DataTable Buscar(string cedula)
        {
            return Consultar(
                "PERSONAS",
                Parametro("@CEDULA", cedula)
            );
        }

        public ResultadoCRUD Actualizar(
            string cedulaActual,
            string cedulaNueva,
            string apellidos,
            string nombres,
            bool sexo,
            DateTime fechaNacimiento,
            string email,
            string telefono)
        {
            return EjecutarOperacion(
                "PERSONAU",
                Parametro("@CED_ACTUAL", cedulaActual),
                Parametro("@CEDULA_NUEVA", cedulaNueva),
                Parametro("@APELLIDOS", apellidos),
                Parametro("@NOMBRES", nombres),
                Parametro("@SEXO", sexo),
                Parametro("@FECHA_NAC", fechaNacimiento),
                Parametro("@EMAIL", email),
                Parametro("@TELEFONO", telefono)
            );
        }

        public ResultadoCRUD Eliminar(string cedula)
        {
            return EjecutarOperacion(
                "PERSONAD",
                Parametro("@CEDULA", cedula)
            );
        }
    }
}
