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
    public partial class frmBackoffice : Form
    {
        public frmBackoffice()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            int ci;
            if (!int.TryParse(txtCedula.Text, out ci))
            {
                MessageBox.Show("El valor del campo Cedula debe ser numerico, sin guiones ni puntos.");
                return;
            }
            else if (ci > 99999999)
            {
                MessageBox.Show("La cédula de identidad no puede tener más de 8 digitos.");
            }
            else
            {
                ADODB.Recordset rs = new ADODB.Recordset();
                Object filasAfectadas;
                String sql;
                if (Program.cn.State != 0)
                {
                    sql = "select * from empleados where CI =" + ci;
                    try
                    {
                        rs = Program.cn.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        MessageBox.Show("guaoExiste un problema con la conexion al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                        return;
                    }
                    if (rs.RecordCount > 0)
                    {
                        MessageBox.Show("Ya existe un usuario con esta cédula de identidad.");
                        return;
                    }
                    else
                    {
                        sql = "insert into empleados(CI,Nombre,Apellido,Cargo,Fecha_Contratacion,Email,Telefono,Direccion) VALUES (" + ci + ",'" + txtNombre.Text + "','" + txtApellido.Text + "','" + cboRol.Text + "')";
                        try
                        {
                            Program.cn.Execute(sql, out filasAfectadas);
                        }
                        catch
                        {
                            MessageBox.Show("ronronExiste un problema con la conexion al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                            return;
                        }
                        sql = "insert into trabajan(idEmpresa, CI) VALUES (214873040021, " + ci + ")";
                        try
                        {
                            Program.cn.Execute(sql, out filasAfectadas);
                        }
                        catch
                        {
                            MessageBox.Show("ronronronExiste un problema con la conexion al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                            return;
                        }
                        sql = "CREATE USER '" + txtNombre.Text + "' IDENTIFIED BY 'contrasena'";
                        try
                        {
                            Program.cn.Execute(sql, out filasAfectadas);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            MessageBox.Show("ronronronronExiste un problema con la conexion al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                            return;
                        }
                        switch (cboRol.Text)
                        {
                            case "Camionero":
                                sql = "GRANT insert, select, update on proyectofinal.lotes to '" + txtNombre.Text + "'; GRANT insert, select on proyectofinal.transporta to '" + txtNombre.Text + "'; GRANT insert, select on proyectofinal.descarga to '" + txtNombre.Text + "'; GRANT select on proyectofinal.transportes to '" + txtNombre.Text + "'; GRANT insert, select, update on proyectofinal.retira to '" + txtNombre.Text + "';";
                                try
                                {
                                    Program.cn.Execute(sql, out filasAfectadas);
                                }
                                catch
                                {
                                    MessageBox.Show("miauExiste un problema con la conexión al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                                    return;
                                }
                                break;
                            case "Almacenero":
                                sql = "GRANT select on proyectofinal.descarga to '" + txtNombre.Text + "'; GRANT select on proyectofinal.almacenes to '" + txtNombre.Text + "'; GRANT insert, select on proyectofinal.almacenan to '" + txtNombre.Text + "'; GRANT insert, select on proyectofinal.envios to '" + txtNombre.Text + "';";
                                try
                                {
                                    Program.cn.Execute(sql, out filasAfectadas);
                                }
                                catch
                                {
                                    MessageBox.Show("Existe un problema con la conexión al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                                    return;
                                }
                                break;
                            case "Administrativo":
                                sql = "GRANT ALL PRIVILEGES ON proyectofinal TO '" + txtNombre.Text + "'@'%';";
                                try
                                {
                                    Program.cn.Execute(sql, out filasAfectadas);
                                }
                                catch
                                {
                                    MessageBox.Show("Existe un problema con la conexión al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                                    return;
                                }
                                break;
                        }


                        MessageBox.Show("Empleado ingresado con éxito.");
                    }


                }
                else
                {
                    MessageBox.Show("Existe un problema con la conexion al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                    return;
                }


            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
