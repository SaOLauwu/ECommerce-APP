using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ProyectoFinal
{
    internal class APIAut
    {
        /* try
             {
                 Program.cn.Open("odbcproy", "admin", "admin");
             }
             catch
             {
                 MessageBox.Show("Existe un error con la conexion al servidor. Avise al administrador del programa.");
             }
             Program.cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient;*/

       

        public static string Login (String empleado)//devolver string serializado
        {
            return CapaNegocios.Login(empleado);
        }

        public static String Identificacion (String emp)//sql en capa de negocio, la api solo serializa o deserealiza
        {
            return CapaNegocios.identificacion(emp);
        }
    }
}
