using ADODB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace ProyectoFinal
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static frmPrincipal principal = new frmPrincipal();
        public static ADODB.Connection cn = new ADODB.Connection();

        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.Run(principal);

        }
        public static byte login(string empleado)
        {
            EntidadesJSON.empleado a = JsonSerializer.Deserialize<EntidadesJSON.empleado>(empleado);
            String empdes = APIAut.Login(empleado);
            a = JsonSerializer.Deserialize<EntidadesJSON.empleado>(empdes);

                    switch (a.rol)
                    {
                        case "Chofer":
                            
                            principal.btnHome.Visible = true;
                            principal.btnChoferes.Visible = true;
                            principal.btnConfiguracion.Visible = false;
                            principal.btnSalir.Visible = true;
                            return 0;
                            
                        case "Almacenero":
                           
                            principal.btnHome.Visible = true;
                            principal.btnConfiguracion.Visible = false;
                            principal.btnSalir.Visible = true;
                            principal.btnAlmacenes.Visible = true;
                            return 0;

                        case "Administrativo":
                            
                            principal.btnHome.Visible = true;
                            principal.btnConfiguracion.Visible = false;
                            principal.btnSalir.Visible = true;
                            principal.btnAlmacenes.Visible = true;
                            principal.btnBackoffice.Visible = true;
                            principal.btnChoferes.Visible = true;
                            return 0;

                        case "none":
                            MessageBox.Show("Existe un error con el rol de este usuario. Avise a un administrador.");
                            return 3;

                        case "error":
                            MessageBox.Show("Existe un error con la conexión a la base de datos. Avise a un administrador");
                            return 2;

                        default:
                            MessageBox.Show("Existe un error con el rol de este usuario. Avise a un administrador.");
                            return 3;
                            
                    }
               
           
        }

        
        
    }
}