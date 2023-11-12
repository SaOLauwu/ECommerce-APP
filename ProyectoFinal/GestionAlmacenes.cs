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

    public partial class GestionAlmacenes : Form
    {

        private int idAlmacen;
        public GestionAlmacenes(int idAlmacen)
        {
            InitializeComponent();
            this.idAlmacen = idAlmacen;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void CargarPaquetes()
        {
            String sql = $"SELECT ID_Paquete, Descripcion, Peso, Estado FROM Paquetes WHERE ID_Almacen = {this.idAlmacen} AND ID_Lote IS NULL";
            Object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (Program.cn.State != 0)
            {
                try
                {
                    rs = Program.cn.Execute(sql, out filasAfectadas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los paquetes: " + ex.Message);
                    return;
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


        private void btnEstado_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un paquete para cambiar su estado.");
                return;
            }

            using (var form = new CambiarEstadoForm()) // Asegúrate de que este formulario tenga los estados posibles y un botón OK.
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string nuevoEstado = form.EstadoSeleccionado; // Esto debe ser una propiedad pública en CambiarEstadoForm que devuelva el estado seleccionado.
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        int idPaquete = Convert.ToInt32(row.Cells["ID_Paquete"].Value);
                        string sqlUpdatePaquete = nuevoEstado == "En almacén" ?
                            $"UPDATE Paquetes SET Estado = '{nuevoEstado}' WHERE ID_Paquete = {idPaquete}" :
                            $"UPDATE Paquetes SET Estado = '{nuevoEstado}', ID_Almacen = NULL WHERE ID_Paquete = {idPaquete}";

                        try
                        {
                            Program.cn.Execute(sqlUpdatePaquete, out var affected);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al actualizar el estado del paquete: " + ex.Message);
                        }
                    }
                    CargarPaquetes(); // Recarga los paquetes para reflejar los cambios.
                }
            }
        }

        private void btnLote_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un paquete para asignar a un lote.");
                return;
            }

            // Crear un nuevo lote
            string sqlInsertLote = $"INSERT INTO Lotes (Fecha_Creacion, ID_Almacen, Estado) VALUES (CURDATE(), {this.idAlmacen}, 'En almacén');";
            object filasAfectadas;
            int nuevoLoteId = 0;

            try
            {
                // Ejecuta la inserción del nuevo lote
                Program.cn.Execute(sqlInsertLote, out filasAfectadas, (int)ADODB.CommandTypeEnum.adCmdText);

                // Obtener el ID del último lote insertado
                string sqlLastId = "SELECT LAST_INSERT_ID();";
                ADODB.Recordset rs = Program.cn.Execute(sqlLastId, out filasAfectadas, (int)ADODB.CommandTypeEnum.adCmdText);
                if (!rs.EOF)
                {
                    nuevoLoteId = Convert.ToInt32(rs.Fields[0].Value);
                }
                rs.Close();

                // Verificar si se obtuvo un nuevo ID de lote
                if (nuevoLoteId > 0)
                {
                    // Asignar cada paquete seleccionado al nuevo lote
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        int idPaquete = Convert.ToInt32(row.Cells["ID_Paquete"].Value);
                        string sqlUpdatePaquete = $"UPDATE Paquetes SET ID_Lote = {nuevoLoteId}, ID_Almacen = NULL WHERE ID_Paquete = {idPaquete}";
                        Program.cn.Execute(sqlUpdatePaquete, out filasAfectadas, (int)ADODB.CommandTypeEnum.adCmdText);
                    }

                    // Recargar los paquetes para reflejar los cambios
                    CargarPaquetes();

                    // Muestra un MessageBox con la confirmación y el ID del nuevo lote
                    MessageBox.Show($"Paquetes asignados al lote con ID {nuevoLoteId} correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID del nuevo lote.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el lote o asignar paquetes: " + ex.Message);
            }
        }

        private void GestionAlmacenes_Load(object sender, EventArgs e)
        {
            CargarPaquetes();
        }
    }
}
