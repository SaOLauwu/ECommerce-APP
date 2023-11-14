using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ProyectoFinal
{
    internal static class API_Choferes
    {
        public static string CargarTransportesDisponibles()
        {
            EntidadesJSON.sentenciaSQL sentencia = new EntidadesJSON.sentenciaSQL
            {
                sql = "SELECT Matricula, Tipo, Estado FROM Transportes WHERE Estado = 'Disponible'"
            };

            string sentenciaSerializada = JsonSerializer.Serialize(sentencia);
            return CapaNegocios.ObtenerTransportesDisponibles(sentenciaSerializada);
        }
    }
}
