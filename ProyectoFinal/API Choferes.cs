using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Data;

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


        public static DataTable ObtenerLotesPorAlmacenDestino(int idAlmacenDestino)
        {
            // Primero, obtenemos la ruta del almacén destino.
            string sqlRuta = $@"SELECT Ruta.ID_Ruta FROM Almacenes
                        INNER JOIN Ruta ON Almacenes.IDRuta = Ruta.ID_Ruta
                        WHERE Almacenes.ID_Almacen = {idAlmacenDestino}";
            DataTable rutaTable = CapaNegocios.ObtenerDatos(sqlRuta);

            // Si no encontramos ruta, regresamos un DataTable vacío.
            if (rutaTable.Rows.Count == 0)
            {
                return new DataTable();
            }

            // Si hay ruta, obtenemos los lotes.
            int idRuta = Convert.ToInt32(rutaTable.Rows[0]["ID_Ruta"]);
            string sqlLotes = $@"SELECT * FROM Lotes
                         INNER JOIN Almacenes ON Lotes.AlmacenDestino = Almacenes.ID_Almacen
                         WHERE Almacenes.IDRuta = {idRuta} AND Lotes.Estado = 'En almacén'";
            return CapaNegocios.ObtenerDatos(sqlLotes);
        }

        public static DataTable CargarLotesConUbicacion()
        {
            string sql = @"
        SELECT 
            Lotes.ID_Lote, 
            Lotes.Fecha_Creacion, 
            Lotes.ID_Almacen, 
            AlmOrigen.Ubicacion AS UbicacionAlmacen, 
            Lotes.Estado, 
            Lotes.AlmacenDestino, 
            AlmDestino.Ubicacion AS UbicacionDestino
        FROM Lotes
        INNER JOIN Almacenes AS AlmOrigen ON Lotes.ID_Almacen = AlmOrigen.ID_Almacen
        INNER JOIN Almacenes AS AlmDestino ON Lotes.AlmacenDestino = AlmDestino.ID_Almacen
        WHERE Lotes.Estado = 'En almacén'";
            return CapaNegocios.ObtenerDatos(sql);
        }

        public static void ActualizarEstadoYAlmacenLotes(List<int> idsLotes, string estado)
        {
            string ids = String.Join(",", idsLotes.Select(id => id.ToString()).ToArray());
            CapaNegocios.ActualizarEstadoYAlmacenLotes(ids, estado);
        }

        public static EntidadesJSON.Ruta ObtenerInformacionDeRuta(int idRuta)
        {
            string sql = $@"SELECT Destino, Duracion_Estimada FROM Ruta WHERE ID_Ruta = {idRuta}";
            DataTable rutaTable = CapaNegocios.ObtenerDatos(sql);

            if (rutaTable.Rows.Count == 0)
            {
                throw new Exception("No se encontró la ruta especificada.");
            }

            DataRow row = rutaTable.Rows[0];
            return new EntidadesJSON.Ruta
            {
                Destino = row["Destino"].ToString(),
                DuracionEstimada = Convert.ToDecimal(row["Duracion_Estimada"])
            };
        }

        public static List<int> ObtenerPaquetesDeLotes(List<int> idsLotes)
        {
            string ids = String.Join(",", idsLotes);
            string sql = $"SELECT ID_Paquete FROM Paquete_Lote WHERE ID_Lote IN ({ids})";
            DataTable dt = CapaNegocios.ObtenerDatos(sql);
            return dt.AsEnumerable().Select(row => row.Field<int>("ID_Paquete")).ToList();
        }

        public static DataTable CargarPaquetesEnAlmacenOrdenadosPorAlmacen()
        {
            string sql = @"
            SELECT 
                ID_Paquete, 
                Descripcion, 
                Peso, 
                Estado, 
                Ci, 
                ID_Almacen 
            FROM Paquetes 
            WHERE Estado = 'En almacén' AND ID_Lote IS NULL
            ORDER BY ID_Almacen";
            return CapaNegocios.ObtenerDatos(sql);
        }

        public static void ActualizarEstadoPaquetes(List<int> idsPaquetes, string estado, string matricula)
        {
            string ids = String.Join(",", idsPaquetes.Select(id => id.ToString()).ToArray());
            CapaNegocios.ActualizarEstadoPaquetes(ids, estado);

            // Registrar cada cambio de estado en la tabla Eventos
            foreach (var idPaquete in idsPaquetes)
            {
                CapaNegocios.RegistrarEventoPaquete(idPaquete, "Último tramo del recorrido", matricula);
            }
        }

    }
}
