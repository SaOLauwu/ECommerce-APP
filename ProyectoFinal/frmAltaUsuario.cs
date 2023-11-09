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
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string fechaParaMySQL = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            int ci;
            if (string.IsNullOrEmpty(fechaParaMySQL))
            {
                MessageBox.Show("Existe un error con la fecha de su dispositivo. Verifíquela.");
                return;
            }
            if (!int.TryParse(txtTelefono.Text, out int telefono))
            {
                MessageBox.Show("El campo 'Teléfono' debe contener únicamente números.");
                return;
            }
            if (!int.TryParse(txtCedula.Text, out ci))
            {
                MessageBox.Show("El valor del campo Cédula debe ser numérico, sin guiones ni puntos.");
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("1Existe un problema con la conexion al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                        return;
                    }
                    if (rs.RecordCount > 0)
                    {
                        MessageBox.Show("Ya existe un usuario con esta cédula de identidad.");
                        return;
                    }
                    sql = "select * from empleados where Email ='" + txtEmail.Text + "'";
                    try
                    {
                        rs = Program.cn.Execute(sql, out filasAfectadas);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("1Existe un problema con la conexion al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                        return;
                    }
                    if (rs.RecordCount > 0)
                    {
                        MessageBox.Show("Esta dirección de correo electrónico ya está asignada a un empleado.");
                        return;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro de que desea crear el siguiente empleado?\nCI: " + ci + "\nNombre: " + txtNombre.Text + "\nApellido: " + txtApellido.Text + "\nCargo: " + cboRol.Text + "\nFecha de contratación: " + fechaParaMySQL + "\nE-Mail: " + txtEmail.Text + "\nTeléfono: " + txtTelefono.Text + "\nDirección: " + txtDireccion.Text, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                        sql = "insert into empleados(CI,Nombre,Apellido,Cargo,Fecha_Contratacion,Email,Telefono,Direccion) VALUES (" + ci + ",'" + txtNombre.Text + "','" + txtApellido.Text + "','" + cboRol.Text + "','" + fechaParaMySQL + "','" + txtEmail.Text + "'," + txtTelefono.Text + ",'" + txtDireccion.Text + "')";
                        try
                        {
                            Program.cn.Execute(sql, out filasAfectadas);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            MessageBox.Show("2Existe un problema con la conexion al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                            return;
                        }
                        string nombreusu = txtNombre.Text + txtCedula.Text;
                        sql = "CREATE USER '" + nombreusu + "' IDENTIFIED BY 'contrasena'";
                        try
                        {
                            Program.cn.Execute(sql, out filasAfectadas);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            MessageBox.Show("3Existe un problema con la conexion al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                            return;
                        }
                        switch (cboRol.Text)
                        {
                            case "Almacenero":
                                string grantLotes = "GRANT insert, select, update on sistemapaqueteria.lotes to '" + nombreusu + "'@'%';";
                                string grantAlmacenes = "GRANT insert, select on sistemapaqueteria.almacenes to '" + nombreusu + "'@'%';";
                                string grantEventos = "GRANT insert, select on sistemapaqueteria.eventos to '" + nombreusu + "'@'%';";
                                string grantTransportes = "GRANT select on sistemapaqueteria.transportes to '" + nombreusu + "'@'%';";
                                string grantPaqueteLote = "GRANT insert, select, update on sistemapaqueteria.paquete_lote to '" + nombreusu + "'@'%';";
                                string grantRuta = "GRANT select on sistemapaqueteria.ruta to '" + nombreusu + "'@'%';";
                                try
                                {
                                    Program.cn.Execute(grantLotes, out filasAfectadas);
                                    Program.cn.Execute(grantAlmacenes, out filasAfectadas);
                                    Program.cn.Execute(grantEventos, out filasAfectadas);
                                    Program.cn.Execute(grantTransportes, out filasAfectadas);
                                    Program.cn.Execute(grantPaqueteLote, out filasAfectadas);
                                    Program.cn.Execute(grantRuta, out filasAfectadas);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);

                                    return;
                                }

                                break;
                            case "Chofer":
                                string grantTransportess = "GRANT select on sistemapaqueteria.transportes to '" + nombreusu + "'@'%';";
                                string grantAlmaceness = "GRANT select on sistemapaqueteria.almacenes to '" + nombreusu + "'@'%';";
                                string grantEventoss = "GRANT insert, select on sistemapaqueteria.eventos to '" + nombreusu + "'@'%';";
                                string grantPaqueteLotee = "GRANT insert, select on sistemapaqueteria.paquete_lote to '" + nombreusu + "'@'%';";
                                string grantPaquetes = "GRANT select on sistemapaqueteria.paquetes to '" + nombreusu + "'@'localhost';";
                                string grantRutaa = "GRANT select on sistemapaqueteria.ruta to '" + nombreusu + "'@'%';";
                                string grantRutasAsignadas = "GRANT select on sistemapaqueteria.rutasasignadas to '" + nombreusu + "'@'%';";
                                try
                                {
                                    Program.cn.Execute(grantTransportess, out filasAfectadas);
                                    Program.cn.Execute(grantAlmaceness, out filasAfectadas);
                                    Program.cn.Execute(grantEventoss, out filasAfectadas);
                                    Program.cn.Execute(grantPaqueteLotee, out filasAfectadas);
                                    Program.cn.Execute(grantPaquetes, out filasAfectadas);
                                    Program.cn.Execute(grantRutaa, out filasAfectadas);
                                    Program.cn.Execute(grantRutasAsignadas, out filasAfectadas);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    MessageBox.Show("Existe un problema con la conexión al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                                    return;
                                }

                                break;
                            case "Administrativo":
                                string grantSelect = "GRANT SELECT ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';"; //*.*
                                string grantInsert = "GRANT INSERT ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantUpdate = "GRANT UPDATE ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantDelete = "GRANT DELETE ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantCreate = "GRANT CREATE ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantCreateUser = "GRANT CREATE USER ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantDrop = "GRANT DROP ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantIndex = "GRANT INDEX ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantAlter = "GRANT ALTER ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantLockTables = "GRANT LOCK TABLES ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantReferences = "GRANT REFERENCES ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantTemporary = "GRANT TEMPORARY ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantExecute = "GRANT EXECUTE ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantCreateView = "GRANT CREATE VIEW ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantShowView = "GRANT SHOW VIEW ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantCreateRoutine = "GRANT CREATE ROUTINE ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantAlterRoutine = "GRANT ALTER ROUTINE ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantEvent = "GRANT EVENT ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantTrigger = "GRANT TRIGGER ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";
                                string grantGrantOption = "GRANT GRANT OPTION ON sistemapaqueteria.* TO '" + nombreusu + "'@'%';";

                                try
                                {
                                    Program.cn.Execute(grantSelect, out filasAfectadas);
                                    Program.cn.Execute(grantInsert, out filasAfectadas);
                                    Program.cn.Execute(grantUpdate, out filasAfectadas);
                                    Program.cn.Execute(grantDelete, out filasAfectadas);
                                    Program.cn.Execute(grantCreate, out filasAfectadas);
                                    Program.cn.Execute(grantCreateUser, out filasAfectadas);
                                    Program.cn.Execute(grantDrop, out filasAfectadas);
                                    Program.cn.Execute(grantIndex, out filasAfectadas);
                                    Program.cn.Execute(grantAlter, out filasAfectadas);
                                    Program.cn.Execute(grantLockTables, out filasAfectadas);
                                    Program.cn.Execute(grantReferences, out filasAfectadas);
                                    Program.cn.Execute(grantTemporary, out filasAfectadas);
                                    Program.cn.Execute(grantExecute, out filasAfectadas);
                                    Program.cn.Execute(grantCreateView, out filasAfectadas);
                                    Program.cn.Execute(grantShowView, out filasAfectadas);
                                    Program.cn.Execute(grantCreateRoutine, out filasAfectadas);
                                    Program.cn.Execute(grantAlterRoutine, out filasAfectadas);
                                    Program.cn.Execute(grantEvent, out filasAfectadas);
                                    Program.cn.Execute(grantTrigger, out filasAfectadas);
                                    Program.cn.Execute(grantGrantOption, out filasAfectadas);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    MessageBox.Show("Existe un problema con la conexión al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                                    return;
                                }

                                break;
                        }


                        MessageBox.Show("Empleado ingresado con éxito.");
                        this.Close();
                    }


                }
                else
                {
                    MessageBox.Show("7Existe un problema con la conexion al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                    return;
                }


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
