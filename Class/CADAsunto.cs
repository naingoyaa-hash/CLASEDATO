using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CLASEDATO
{
    public class CADAsunto : CRUD
    {

        public ResultadoCRUD Insertar(
            long numExpediente,
            string cedula,
            DateTime inicio,
            string resumen)
        {
            return EjecutarOperacion(
                "ASUNTOI",
                Parametro("@NEXPEDIENTE", numExpediente),
                Parametro("@CEDULA", cedula),
                Parametro("@INICIO", inicio),
                Parametro("@RESUMEN", resumen)
            );
        }

        public DataTable Seleccionar()
        {
            return Consultar("ASUNTOS");
        }

        public DataTable Buscar(long numExpediente)
        {
            return Consultar(
                "ASUNTOS",
                Parametro("@NEXPEDIENTE", numExpediente)
            );
        }

        public ResultadoCRUD Actualizar(
            long numExpedienteActual,
            long numExpedienteNuevo,
            string cedula,
            DateTime inicio,
            string resumen)
        {
            return EjecutarOperacion(
                "ASUNTOU",
                Parametro("@NEXPEDIENTE_ACTUAL", numExpedienteActual),
                Parametro("@NEXPEDIENTE_NUEVO", numExpedienteNuevo),
                Parametro("@CEDULA", cedula),
                Parametro("@INICIO", inicio),
                Parametro("@RESUMEN", resumen)
            );
        }

        public ResultadoCRUD Eliminar(long numExpediente)
        {
            return EjecutarOperacion(
                "ASUNTOD",
                Parametro("@NEXPEDIENTE", numExpediente)
            );
        }
    }
}
