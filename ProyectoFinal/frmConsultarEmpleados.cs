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
using System.Data.OleDb;

namespace ProyectoFinal
{
    public partial class frmConsultarEmpleados : Form
    {
        public frmConsultarEmpleados()
        {
            InitializeComponent();
        }

        public void CargarEmpleados()
        {
            String sql;
            Object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (Program.cn.State != 0)
            {
                sql = "SELECT CI, Nombre, Apellido, Cargo, Fecha_Contratacion, Email, Telefono, Direccion, " +
                 "CASE WHEN isDeleted = 0 THEN 'Activo' ELSE 'Eliminado' END AS Estado " +
                 "FROM Empleados WHERE isDeleted = 0";
                try
                {
                    rs = Program.cn.Execute(sql, out filasAfectadas);
                }
                catch
                {
                    MessageBox.Show("Existe un error con la conexión al servidor. Intenta nuevamente");
                }

                DataTable dt = new DataTable();
                for (int i = 0; i < rs.Fields.Count; i++)
                {
                    dt.Columns.Add(rs.Fields[i].Name);
                }

                while (!rs.EOF)
                {
                    DataRow row = dt.NewRow();
                    for (int i = 0; i < rs.Fields.Count; i++)
                    {
                        row[i] = rs.Fields[i].Value;
                    }
                    dt.Rows.Add(row);
                    rs.MoveNext();
                }

                dataGridView1.DataSource = dt;

                rs.Close();

            }
        }

        private void CargarEmpleadosConFiltro()
        {
            object filasAfectadas;
            ADODB.Recordset rs = new Recordset();
            string sql = ConstruirConsultaSQL();
            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al realizar el filtro. Intente nuevamente.");
                return;
            }

            DataTable dt = new DataTable();

            // Rellenar el DataTable con las columnas
            for (int i = 0; i < rs.Fields.Count; i++)
            {
                dt.Columns.Add(rs.Fields[i].Name);
            }

            // Rellenar el DataTable con las filas
            while (!rs.EOF)
            {
                DataRow row = dt.NewRow();
                for (int i = 0; i < rs.Fields.Count; i++)
                {
                    row[i] = rs.Fields[i].Value;
                }
                dt.Rows.Add(row);
                rs.MoveNext();
            }

            dataGridView1.DataSource = dt;

            rs.Close();
        }

        private string ConstruirConsultaSQL()
        {
            List<string> condiciones = new List<string>();

            if (!chkMostrarEliminados.Checked)
            {
                condiciones.Add("isDeleted = 0");
            }

            if (!string.IsNullOrEmpty(txtCI.Text))
            {
                condiciones.Add("CI = " + txtCI.Text);
            }
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                condiciones.Add("Nombre LIKE '%" + txtNombre.Text.Replace("'", "''") + "%'");
            }
            if (!string.IsNullOrEmpty(txtApellido.Text))
            {
                condiciones.Add("Apellido LIKE '%" + txtApellido.Text.Replace("'", "''") + "%'");
            }
            if (cboRol.SelectedIndex > -1 && cboRol.SelectedItem.ToString() != "No filtrar")
            {
                condiciones.Add("Cargo = '" + cboRol.SelectedItem.ToString().Replace("'", "''") + "'");
            }

            string sql = "SELECT CI, Nombre, Apellido, Cargo, Fecha_Contratacion, Email, Telefono, Direccion, " +
                 "CASE WHEN isDeleted = 0 THEN 'Activo' ELSE 'Eliminado' END AS Estado " +
                 "FROM Empleados";

            if (condiciones.Count > 0)
            {
                sql += " WHERE " + string.Join(" AND ", condiciones);
            }

            return sql;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito ni una tecla de control (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada
            }
        }



        private void frmConsultarEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            CargarEmpleadosConFiltro();
        }
    }
}
