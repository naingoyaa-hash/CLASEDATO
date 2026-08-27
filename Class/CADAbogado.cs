using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CLASEDATO
{
    public class CADAbogado : CRUD
    {
        public ResultadoCRUD Insertar(
            string numLicencia,
            string cedula,
            DateTime vigenteDesde,
            bool activo)
        {
            return EjecutarOperacion(
                "ABOGADOI",
                Parametro("@NUM_LICENCIA", numLicencia),
                Parametro("@CEDULA", cedula),
                Parametro("@VIGENTE_DESDE", vigenteDesde),
                Parametro("@ACTIVO", activo)
            );
        }

        public DataTable Seleccionar()
        {
            return Consultar("ABOGADOS");
        }

        public DataTable Buscar(string numLicencia)
        {
            return Consultar(
                "ABOGADOS",
                Parametro("@NUM_LICENCIA", numLicencia)
            );
        }

        public ResultadoCRUD Actualizar(
            string numLicenciaActual,
            string numLicenciaNueva,
            string cedula,
            DateTime vigenteDesde,
            bool activo)
        {
            return EjecutarOperacion(
                "ABOGADOU",
                Parametro("@NUM_LICENCIA_ACTUAL", numLicenciaActual),
                Parametro("@NUM_LICENCIA_NUEVA", numLicenciaNueva),
                Parametro("@CEDULA", cedula),
                Parametro("@VIGENTE_DESDE", vigenteDesde),
                Parametro("@ACTIVO", activo)
            );
        }

        public ResultadoCRUD Eliminar(string numLicencia)
        {
            return EjecutarOperacion(
                "ABOGADOD",
                Parametro("@NUM_LICENCIA", numLicencia)
            );
        }
    }
}
