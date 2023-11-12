using System;
using System.Collections.Generic;
using ADODB;
using System.Text.Json;
using System.Windows.Forms; // Asegúrate de que esto esté presente si estás utilizando MessageBox
using static ProyectoFinal.EntidadesJSON;

namespace ProyectoFinal
{
    internal class CapaNegocios
    {
        public static string Login(string user)
        {
            empleado empleadoo = JsonSerializer.Deserialize<empleado>(user);
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
                Program.cn.CursorLocation = CursorLocationEnum.adUseClient;
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
                Program.cn.CursorLocation = CursorLocationEnum.adUseClient;

                return identificacion(JsonSerializer.Serialize(empleadoo));
            }
        }

        public static string identificacion(string emp)
        {
            empleado a = JsonSerializer.Deserialize<empleado>(emp);

            Recordset rs = new Recordset();
            string sql = "SELECT Cargo FROM empleados WHERE CI =" + a.ci;
            Object filasAfectadas;
            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas);
            }
            catch (Exception ex)
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

        public static string ObtenerAlmacenes(string sentenciaSerializada)
        {
            EntidadesJSON.sentenciaSQL sentencia = JsonSerializer.Deserialize<EntidadesJSON.sentenciaSQL>(sentenciaSerializada);
            List<EntidadesJSON.Almacen> listaAlmacenes = new List<EntidadesJSON.Almacen>();

            Recordset rs = new Recordset();
            string sql = sentencia.sql;
            object filasAfectadas;

            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas, (int)CommandTypeEnum.adCmdText);

                while (!rs.EOF)
                {
                    var almacen = new EntidadesJSON.Almacen
                    {
                        ID_Almacen = Convert.ToInt32(rs.Fields["ID_Almacen"].Value),
                        Ubicacion = Convert.ToString(rs.Fields["Ubicacion"].Value),
                        Capacidad_Maxima = Convert.ToDecimal(rs.Fields["Capacidad_Maxima"].Value),
                        Productos_Actuales = Convert.ToInt32(rs.Fields["Productos_Actuales"].Value),
                        Responsable = rs.Fields["Responsable"].Value is DBNull ? (int?)null : Convert.ToInt32(rs.Fields["Responsable"].Value),
                        IDRuta = rs.Fields["IDRuta"].Value is DBNull ? (int?)null : Convert.ToInt32(rs.Fields["IDRuta"].Value)
                    };
                    listaAlmacenes.Add(almacen);
                    rs.MoveNext();
                }
                rs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener almacenes: " + ex.Message);
            }

            return JsonSerializer.Serialize(listaAlmacenes);
        }

        
        public static string EjecutarConsulta(string sentenciaJSON)
        {
            var sentencia = JsonSerializer.Deserialize<EntidadesJSON.sentenciaSQL>(sentenciaJSON);
            Recordset rs = new Recordset();
            object filasAfectadas;
            List<EntidadesJSON.Paquete> paquetes = new List<EntidadesJSON.Paquete>();

            try
            {
                rs = Program.cn.Execute(sentencia.sql, out filasAfectadas, (int)CommandTypeEnum.adCmdText);
                while (!rs.EOF)
                {
                    paquetes.Add(new EntidadesJSON.Paquete
                    {
                        ID_Paquete = Convert.ToInt32(rs.Fields["ID_Paquete"].Value),
                        Descripcion = Convert.ToString(rs.Fields["Descripcion"].Value),
                        Peso = Convert.ToDecimal(rs.Fields["Peso"].Value),
                        Estado = Convert.ToString(rs.Fields["Estado"].Value),
                        ID_Almacen = Convert.ToInt32(rs.Fields["ID_Almacen"].Value)
                        // Asegúrate de que el campo "ID_Almacen" exista en tu base de datos.
                    });
                    rs.MoveNext();
                }
                rs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en CapaNegocios - EjecutarConsulta: " + ex.Message);
            }

            return JsonSerializer.Serialize(paquetes);
        }


        public static string ActualizarEstadoPaquetes(string paquetesJSON)
        {
            List<EntidadesJSON.Paquete> paquetes = JsonSerializer.Deserialize<List<EntidadesJSON.Paquete>>(paquetesJSON);
            object filasAfectadas = null;

            foreach (var paquete in paquetes)
            {
                string nuevoEstado = paquete.Estado;
                int idPaquete = paquete.ID_Paquete;
                string sqlUpdatePaquete;

                if (nuevoEstado != "En almacén")
                {
                    sqlUpdatePaquete = $"UPDATE Paquetes SET Estado = '{nuevoEstado}', ID_Almacen = NULL WHERE ID_Paquete = {idPaquete}";
                }
                else
                {
                    sqlUpdatePaquete = $"UPDATE Paquetes SET Estado = '{nuevoEstado}' WHERE ID_Paquete = {idPaquete}";
                }

                try
                {
                    Program.cn.Execute(sqlUpdatePaquete, out filasAfectadas, (int)CommandTypeEnum.adCmdText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar el estado del paquete: " + ex.Message);
                    
                }
            }

            return "Estado de paquetes actualizado";
        }

        public static string AsignarPaquetesANuevoLote(string paquetesLoteJSON)
        {
            var infoLote = JsonSerializer.Deserialize<EntidadesJSON.InfoLote>(paquetesLoteJSON);
            int idAlmacen = infoLote.ID_Almacen;
            List<int> idsPaquetes = infoLote.IDsPaquetes;
            object filasAfectadas = null;
            int nuevoLoteId = 0;

            try
            {
                string sqlInsertLote = $"INSERT INTO Lotes (Fecha_Creacion, ID_Almacen, Estado) VALUES (NOW(), {idAlmacen}, 'En almacén');";
                Program.cn.Execute(sqlInsertLote, out filasAfectadas, (int)CommandTypeEnum.adCmdText);

                string sqlLastId = "SELECT LAST_INSERT_ID();";
                Recordset rs = Program.cn.Execute(sqlLastId, out filasAfectadas, (int)CommandTypeEnum.adCmdText);
                if (!rs.EOF)
                {
                    nuevoLoteId = Convert.ToInt32(rs.Fields[0].Value);
                }
                rs.Close();

                foreach (int idPaquete in idsPaquetes)
                {
                    string sqlUpdatePaquete = $"UPDATE Paquetes SET ID_Lote = {nuevoLoteId} WHERE ID_Paquete = {idPaquete}";
                    Program.cn.Execute(sqlUpdatePaquete, out filasAfectadas, (int)CommandTypeEnum.adCmdText);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al asignar paquetes al nuevo lote: " + ex.Message);
            }

            return $"Paquetes asignados al lote con ID {nuevoLoteId} correctamente.";
        }
    }
}




        

        

        
    

