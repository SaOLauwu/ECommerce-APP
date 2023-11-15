using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;

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
            string datosJson = API_Almacenes.CargarPaquetesPorAlmacen(this.idAlmacen);
            List<EntidadesJSON.Paquete> paquetes = JsonSerializer.Deserialize<List<EntidadesJSON.Paquete>>(datosJson);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Paquete", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("Peso", typeof(decimal));
            dt.Columns.Add("Estado", typeof(string));

            foreach (var paquete in paquetes)
            {
                dt.Rows.Add(paquete.ID_Paquete, paquete.Descripcion, paquete.Peso, paquete.Estado);
            }

            dataGridView1.DataSource = dt;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un paquete para cambiar su estado.");
                return;
            }

            using (var form = new CambiarEstadoForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string nuevoEstado = form.EstadoSeleccionado;
                    List<EntidadesJSON.Paquete> paquetesParaActualizar = new List<EntidadesJSON.Paquete>();

                    foreach (DataGridViewRow row in selectedRows)
                    {
                        paquetesParaActualizar.Add(new EntidadesJSON.Paquete
                        {
                            ID_Paquete = Convert.ToInt32(row.Cells["ID_Paquete"].Value),
                            Estado = nuevoEstado
                        });
                    }

                    string paquetesJSON = JsonSerializer.Serialize(paquetesParaActualizar);
                    string resultado = API_Almacenes.CambiarEstadoPaquetes(paquetesParaActualizar);
                    MessageBox.Show(resultado);
                    CargarPaquetes(); // Recargar los datos para reflejar los cambios
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

            List<int> idsPaquetes = new List<int>();
            foreach (DataGridViewRow row in selectedRows)
            {
                idsPaquetes.Add(Convert.ToInt32(row.Cells["ID_Paquete"].Value));
            }

            string resultado = API_Almacenes.AsignarPaquetesLote(idAlmacen, idsPaquetes);
            MessageBox.Show(resultado);
            CargarPaquetes(); // Recargar los datos para reflejar los cambios
        }

        private void GestionAlmacenes_Load(object sender, EventArgs e)
        {
            CargarPaquetes();
        }

        private void btnNuevoPaquete_Click(object sender, EventArgs e)
        {
            using (var formIngresarPaquete = new FrmIngresarPaquetes(this.idAlmacen))
            {
                formIngresarPaquete.ShowDialog();
                CargarPaquetes();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
