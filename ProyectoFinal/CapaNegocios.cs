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
                empleadoo.resultado = "true";
                return JsonSerializer.Serialize(empleadoo);
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
            catch
            {
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
                a.resultado = "false";
                return JsonSerializer.Serialize(a);

        }


        
    }
}
