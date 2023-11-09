using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static ProyectoFinal.EntidadesJSON;

namespace ProyectoFinal
{
    internal class CapaNegocios
    {
        public static string Login(string user)
        {
            EntidadesJSON.empleado empleadoo = JsonSerializer.Deserialize<EntidadesJSON.empleado>(user);
            if (Program.cn.State != 1)
            {
                try
                {
                    Program.cn.Open("database", empleadoo.nombre, empleadoo.clave);
                }
                catch
                {
                    empleadoo.resultado = "false";
                    return JsonSerializer.Serialize(empleadoo);
                }
                Program.cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
                empleadoo.resultado = "true";
                return JsonSerializer.Serialize(empleadoo);
            }
            else
            {
                Program.cn.Close();
                try
                {
                    Program.cn.Open("database", empleadoo.nombre, empleadoo.clave);
                }
                catch
                {
                    empleadoo.resultado = "false";
                    return JsonSerializer.Serialize(empleadoo);
                }
                Program.cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
                
                return identificacion(JsonSerializer.Serialize(empleadoo));
            }
        }

        public static String identificacion(string emp)
        {
            EntidadesJSON.empleado a = JsonSerializer.Deserialize<EntidadesJSON.empleado>(emp);

            ADODB.Recordset rs = new ADODB.Recordset();
            String sql;
            sql = "SELECT Cargo FROM empleados WHERE CI =" + a.ci;
            Object filasAfectadas;
            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                a.resultado = "false";
                return JsonSerializer.Serialize(a);
            }

            if (rs.RecordCount > 0)
            {
                String rol = Convert.ToString(rs.Fields[0].Value);
                a.rol = rol;
                return JsonSerializer.Serialize(a);

            }
            else 
            {
                a.resultado = "false";
                return JsonSerializer.Serialize(a);
            }
        }
        public static string AsignarLoteACamion(string asignacionJson)
        {
            var asignacion = JsonSerializer.Deserialize<EntidadesJSON.AsignacionLote>(asignacionJson);

            // Suponiendo que se elige el camión basado en la información del destino y disponibilidad.
            var camion = SeleccionarCamionParaDestino(asignacion.Destino);

            string sql = $"UPDATE Lotes SET ID_Camion = {camion.Id} WHERE ID_Lote = {asignacion.IdLote}";

            try
            {
                Program.cn.Execute(sql, out _);
                asignacion.resultado = "true";
            }
            catch (Exception ex)
            {
                asignacion.resultado = "false";
                asignacion.mensajeError = ex.Message;
            }

            return JsonSerializer.Serialize(asignacion);
        }

        public static string AsignarRutaACamion(string rutaACamionJson)
        {
            // Deserializar la información recibida para obtener los detalles de la asignación
            var rutaACamion = JsonSerializer.Deserialize<EntidadesJSON.RutaACamion>(rutaACamionJson);

            // SQL para actualizar la asignación de una ruta a un camión
            string sql = $"UPDATE Transportes SET IDRuta = {rutaACamion.IdRuta} WHERE Matricula = {rutaACamion.Matricula}";

            try
            {
                Program.cn.Execute(sql, out _);
                rutaACamion.resultado = "true";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                rutaACamion.resultado = "false";
            }

            // Serializar la respuesta y devolverla
            return JsonSerializer.Serialize(rutaACamion);
        }
        public static string ConsultarEstadoLote(string loteJson)
        {
            var lote = JsonSerializer.Deserialize<EntidadesJSON.Lote>(loteJson);

            string sql = $"SELECT Estado FROM Lotes WHERE ID_Lote = {lote.Id}";

            ADODB.Recordset rs;
            try
            {
                rs = Program.cn.Execute(sql, out _);
                if (rs.RecordCount > 0)
                {
                    lote.Estado = Convert.ToString(rs.Fields["Estado"].Value);
                    lote.resultado = "true";
                }
                else
                {
                    lote.resultado = "false";
                    lote.mensajeError = "Lote no encontrado.";
                }
            }
            catch (Exception ex)
            {
                lote.resultado = "false";
                lote.mensajeError = ex.Message;
            }

            return JsonSerializer.Serialize(lote);
        }
        public static string CrearPaquete(string paqueteJson)
        {
            var paquete = JsonSerializer.Deserialize<EntidadesJSON.Paquete>(paqueteJson);

            string sql = $"INSERT INTO Paquetes (Descripcion, Peso) VALUES ('{paquete.Descripcion}', {paquete.Peso})";

            try
            {
                Program.cn.Execute(sql, out _);
                paquete.resultado = "true";
            }
            catch (Exception ex)
            {
                paquete.resultado = "false";
                paquete.mensajeError = ex.Message;
            }

            return JsonSerializer.Serialize(paquete);
        }
        public static string AgruparPaqueteEnLote(string paqueteJson, int idLote)
        {
            EntidadesJSON.Paquete paquete = JsonSerializer.Deserialize<EntidadesJSON.Paquete>(paqueteJson);
            ADODB.Command command = new ADODB.Command();
            ADODB.Recordset recordset = new ADODB.Recordset();
            string sql = $"INSERT INTO PaquetesLotes (IdPaquete, IdLote) VALUES ({paquete.Id}, {idLote});";

            try
            {
                command.ActiveConnection = Program.cn;
                command.CommandText = sql;
                Program.cn.BeginTrans();
                recordset = command.Execute();
                Program.cn.CommitTrans();
                return JsonSerializer.Serialize(new { resultado = "true" });
            }
            catch (Exception ex)
            {
                Program.cn.RollbackTrans();
                return JsonSerializer.Serialize(new { resultado = "false", mensaje = ex.Message });
            }
        }

        public static string DesagruparPaqueteDelLote(int idPaquete)
        {
            ADODB.Command command = new ADODB.Command();
            string sql = $"DELETE FROM PaquetesLotes WHERE IdPaquete = {idPaquete};";

            try
            {
                command.ActiveConnection = Program.cn;
                command.CommandText = sql;
                Program.cn.BeginTrans();
                command.Execute();
                Program.cn.CommitTrans();
                return JsonSerializer.Serialize(new { resultado = "true" });
            }
            catch (Exception ex)
            {
                Program.cn.RollbackTrans();
                return JsonSerializer.Serialize(new { resultado = "false", mensaje = ex.Message });
            }
        }
        public static string ObtenerEstadoLote(int idLote)
        {
            ADODB.Recordset recordset = new ADODB.Recordset();
            string sql = $"SELECT Estado FROM Lotes WHERE IdLote = {idLote};";

            try
            {
                recordset.Open(sql, Program.cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);
                if (!recordset.EOF)
                {
                    string estado = recordset.Fields["Estado"].Value.ToString();
                    return JsonSerializer.Serialize(new { resultado = "true", estado = estado });
                }
                else
                {
                    return JsonSerializer.Serialize(new { resultado = "false", mensaje = "Lote no encontrado." });
                }
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new { resultado = "false", mensaje = ex.Message });
            }
        }
        public static string CompletarEntrega(int idLote)
        {
            ADODB.Command command = new ADODB.Command();
            string sql = $"UPDATE Lotes SET Estado = 'Entregado' WHERE IdLote = {idLote};";

            try
            {
                command.ActiveConnection = Program.cn;
                command.CommandText = sql;
                Program.cn.BeginTrans();
                command.Execute();
                Program.cn.CommitTrans();
                return JsonSerializer.Serialize(new { resultado = "true" });
            }
            catch (Exception ex)
            {
                Program.cn.RollbackTrans();
                return JsonSerializer.Serialize(new { resultado = "false", mensaje = ex.Message });
            }
        }
        public static string AsignarEstadoLote(int idLote, string estado)
        {
            ADODB.Command command = new ADODB.Command();
            string sql = $"UPDATE Lotes SET Estado = '{estado}' WHERE IdLote = {idLote};";

            try
            {
                command.ActiveConnection = Program.cn;
                command.CommandText = sql;
                Program.cn.BeginTrans();
                command.Execute();
                Program.cn.CommitTrans();
                return JsonSerializer.Serialize(new { resultado = "true" });
            }
            catch (Exception ex)
            {
                Program.cn.RollbackTrans();
                return JsonSerializer.Serialize(new { resultado = "false", mensaje = ex.Message });
            }
        }
        public static string ActualizarEstadoPaquete(int idPaquete, int? idLote)
        {
            string estado;
            if (idLote.HasValue)
            {
                estado = $"En lote {idLote.Value}";
            }
            else
            {
                estado = "En almacen"; // Si no proporcionamos un ID de lote, asumimos que el paquete está en almacen.
            }

            ADODB.Command command = new ADODB.Command();
            string sql = $"UPDATE Paquetes SET Estado = '{estado}' WHERE IdPaquete = {idPaquete};";

            try
            {
                command.ActiveConnection = Program.cn;
                command.CommandText = sql;
                Program.cn.BeginTrans();
                command.Execute();
                Program.cn.CommitTrans();
                return JsonSerializer.Serialize(new { resultado = "true" });
            }
            catch (Exception ex)
            {
                Program.cn.RollbackTrans();
                return JsonSerializer.Serialize(new { resultado = "false", mensaje = ex.Message });
            }
        }

    }
}
