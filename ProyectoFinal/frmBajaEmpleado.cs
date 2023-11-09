using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmBajaEmpleado : Form
    {
        public frmBajaEmpleado()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ADODB.Recordset rs;
            object filasAfectadas;
            string sql;
            int ci;

            if (!int.TryParse(txtCedula.Text, out ci))
            {
                MessageBox.Show("El valor del campo Cédula debe ser numérico, sin guiones ni puntos.");
                return;
            }
            else if (ci > 99999999)
            {
                MessageBox.Show("La cédula de identidad no puede tener más de 8 dígitos.");
                return;
            }

            if (Program.cn.State != 0)
            {
                sql = "SELECT isDeleted FROM Empleados WHERE CI = " + ci + ";";
                try
                {
                    rs = Program.cn.Execute(sql, out filasAfectadas);

                    if (rs.RecordCount == 0)
                    {
                        MessageBox.Show("No existe un empleado con esta cédula de identidad.");
                        return;
                    }

                    string yaEliminado = Convert.ToString(rs.Fields["isDeleted"].Value);

                    if (yaEliminado == "0")
                    {
                        sql = "SELECT nombre FROM Empleados WHERE Ci = " + ci;
                        try
                        {
                            rs = Program.cn.Execute(sql, out filasAfectadas);
                        }
                        catch
                        {
                            MessageBox.Show("Ha ocurrido un error al eliminar el empleado. Intente nuevamente.");
                        }
                        String nombre = Convert.ToString(rs.Fields[0].Value);

                        sql = "UPDATE Empleados SET isDeleted = 1 WHERE Ci = " + ci + " AND isDeleted = 0;";
                        String sqll = "DROP USER '" + nombre + ci +"'@'%';";
                        try
                        {
                            Program.cn.Execute(sql, out filasAfectadas);
                            Program.cn.Execute(sqll, out filasAfectadas);
                        }
                        catch
                        {
                            MessageBox.Show("Ha ocurrido un error al eliminar el empleado. Intente nuevamente.");
                        }                        
                        MessageBox.Show("El empleado ha sido eliminado correctamente.");
                    }
                    else if (yaEliminado == "1")
                    {
                        MessageBox.Show("El empleado ya había sido eliminado anteriormente.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Existe un problema con la conexión al servidor. Intente nuevamente, si el problema persiste avise a un administrador.\nDetalle del error: " + ex.Message);
                    return;
                }
            }
            else
            {
                MessageBox.Show("No hay conexión con el servidor. Por favor verifique su conexión a la red.");
            }

            this.Close();
        }
    }
}
