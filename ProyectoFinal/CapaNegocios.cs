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
            String rol = empleadoo.rol;
            if (Program.cn.State != 1)
            {
                if (rol.Equals("Administrativo"))
                {
                    try
                    {
                        Program.cn.Open("database", "administrador", "admin123");
                    }
                    catch
                    {
                        empleadoo.resultado = "false";
                        return JsonSerializer.Serialize(empleadoo);
                    }
                    Program.cn.CursorLocation = CursorLocationEnum.adUseClient;
                    empleadoo.resultado = "true";
                    empleadoo.rol = "Administrativo";
                    return JsonSerializer.Serialize(empleadoo);
                }
                else if (rol.Equals("Almacenero"))
                {
                    try
                    {
                        Program.cn.Open("database", "almacenero", "almacenero123");
                    }
                    catch
                    {
                        empleadoo.resultado = "false";
                        return JsonSerializer.Serialize(empleadoo);
                    }
                    Program.cn.CursorLocation = CursorLocationEnum.adUseClient;
                    empleadoo.resultado = "true";
                    empleadoo.rol = "Almacenero";
                    return JsonSerializer.Serialize(empleadoo);
                }else if (rol.Equals("Chofer"))
                {
                    try
                    {
                        Program.cn.Open("database", "chofer", "chofer123");
                    }
                    catch
                    {
                        empleadoo.resultado = "false";
                        return JsonSerializer.Serialize(empleadoo);
                    }
                    Program.cn.CursorLocation = CursorLocationEnum.adUseClient;
                    empleadoo.resultado = "true";
                    empleadoo.rol = "Chofer";
                    return JsonSerializer.Serialize(empleadoo);
                }
                empleadoo.rol = "null";
                empleadoo.resultado="null";
                return JsonSerializer.Serialize(empleadoo);

            }
            else
            {
                Program.cn.Close();
                if (rol.Equals("Administrativo"))
                {
                    try
                    {
                        Program.cn.Open("database", "administrador", "admin123");
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
                else if (rol.Equals("Almacenero"))
                {
                    try
                    {
                        Program.cn.Open("database", "almacenero", "almacenero123");
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
                else if (rol.Equals("Chofer"))
                {
                    try
                    {
                        Program.cn.Open("database", "chofer", "chofer123");
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
                empleadoo.rol = "null";
                empleadoo.resultado = "null";
                return JsonSerializer.Serialize(empleadoo);
            }
        }

        public static string identificacion(string emp)
        {
            empleado a = JsonSerializer.Deserialize<empleado>(emp);
            if (Program.cn.State != 1)
            {

                try
                {
                    Program.cn.Open("database", "administrador", "admin123");
                }
                catch
                {
                    a.resultado = "false";
                    return JsonSerializer.Serialize(a);
                }
            }
            else
            {
                Program.cn.Close();
                try
                {
                    Program.cn.Open("database", "administrador", "admin123");
                }
                catch
                {
                    a.resultado = "false";
                    return JsonSerializer.Serialize(a);
                }
            }

                Program.cn.CursorLocation = CursorLocationEnum.adUseClient;
            
            
            Recordset rs = new Recordset();
            string sql = "SELECT Cargo FROM empleados WHERE CI =" + a.ci + " AND Pass = '" + a.clave + "'";
            Object filasAfectadas;
            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error con la conexión al servidor, revise su conexión a internet o avise a un administrador." + ex.Message);
                a.resultado = "false";
                a.rol = "null";


                return JsonSerializer.Serialize(a);
            }
            
            if (rs.RecordCount > 0)
            {
                
                String rol = Convert.ToString(rs.Fields[0].Value);
                a.rol = rol;
                a.resultado = "true";
                if (a.clave == "contrasena")
                {
                    CambioContrasena c = new CambioContrasena(a.ci);
                    c.ShowDialog();
                }
                return Login(JsonSerializer.Serialize(a));
            }
            else
            { 
                a.rol = "null";
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
                string sqlUpdatePaquete = $"UPDATE Paquetes SET Estado = '{nuevoEstado}' WHERE ID_Paquete = {idPaquete}";

                try
                {
                    Program.cn.Execute(sqlUpdatePaquete, out filasAfectadas, (int)CommandTypeEnum.adCmdText);
                    // Si el paquete se envía o se entrega, elimínelo del lote actual.
                    if (nuevoEstado == "En viaje hacia destino final" || nuevoEstado == "Entregado")
                    {
                        string sqlDeleteFromLote = $"DELETE FROM Paquete_Lote WHERE ID_Paquete = {idPaquete}";
                        Program.cn.Execute(sqlDeleteFromLote, out filasAfectadas, (int)CommandTypeEnum.adCmdText);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar el estado del paquete: " + ex.Message);
                    return "Error al actualizar el estado de los paquetes.";
                }
            }

            return "Estado de paquetes actualizado correctamente.";
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
                    // Adicionalmente, insertar en Paquete_Lote.
                    string sqlInsertPaqueteLote = $"INSERT INTO Paquete_Lote (ID_Paquete, ID_Lote) VALUES ({idPaquete}, {nuevoLoteId})";
                    Program.cn.Execute(sqlInsertPaqueteLote, out filasAfectadas, (int)CommandTypeEnum.adCmdText);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al asignar paquetes al nuevo lote: " + ex.Message);
                return "Error al asignar paquetes al lote.";
            }

            return $"Paquetes asignados al lote con ID {nuevoLoteId} correctamente.";
        }

        public static string ObtenerTransportesDisponibles(string sentenciaSerializada)
        {
            var sentencia = JsonSerializer.Deserialize<EntidadesJSON.sentenciaSQL>(sentenciaSerializada);
            List<EntidadesJSON.Transporte> transportes = new List<EntidadesJSON.Transporte>();
            Recordset rs = new Recordset();
            object filasAfectadas;

            try
            {
                rs = Program.cn.Execute(sentencia.sql, out filasAfectadas, (int)CommandTypeEnum.adCmdText);
                while (!rs.EOF)
                {
                    transportes.Add(new EntidadesJSON.Transporte
                    {
                        Matricula = Convert.ToString(rs.Fields["Matricula"].Value),
                        Tipo = Convert.ToString(rs.Fields["Tipo"].Value),
                        Estado = Convert.ToString(rs.Fields["Estado"].Value),
                    });
                    rs.MoveNext();
                }
                rs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en CapaNegocios - ObtenerTransportesDisponibles: " + ex.Message);
            }

            return JsonSerializer.Serialize(transportes);
        }


    }
}




        

        

        
    

