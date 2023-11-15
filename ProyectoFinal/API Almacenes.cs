using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ProyectoFinal
{
    internal class API_Almacenes
    {

        public static string CargarAlmacenes()
        {
            EntidadesJSON.sentenciaSQL sentencia = new EntidadesJSON.sentenciaSQL
            {
                sql = "SELECT * FROM Almacenes"
            };

            string sentenciaSerializada = JsonSerializer.Serialize(sentencia);
            return CapaNegocios.ObtenerAlmacenes(sentenciaSerializada);
        }

        public static string CrearPaquete(EntidadesJSON.Paquete paquete)
        {
            string paqueteJSON = JsonSerializer.Serialize(paquete);
            return CapaNegocios.InsertarPaquete(paqueteJSON);
        }

        public static string CambiarEstadoPaquetes(List<EntidadesJSON.Paquete> paquetes)
        {
            string paquetesJSON = JsonSerializer.Serialize(paquetes);
            return CapaNegocios.ActualizarEstadoPaquetes(paquetesJSON);
        }

        public static string AsignarPaquetesLote(int idAlmacen, List<int> idsPaquetes)
        {
            string paquetesLoteJSON = JsonSerializer.Serialize(new
            {
                ID_Almacen = idAlmacen,
                IDsPaquetes = idsPaquetes
            });
            return CapaNegocios.AsignarPaquetesANuevoLote(paquetesLoteJSON);
        }
        public static string CargarPaquetesPorAlmacen(int idAlmacen)
        {
            EntidadesJSON.sentenciaSQL sentencia = new EntidadesJSON.sentenciaSQL
            {
                sql = $"SELECT * FROM Paquetes WHERE ID_Almacen = {idAlmacen} AND ID_Lote IS NULL"
            };

            string sentenciaSerializada = JsonSerializer.Serialize(sentencia);
            return CapaNegocios.EjecutarConsulta(sentenciaSerializada);
        }

    }
}
