using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using static ProyectoFinal.EntidadesJSON;

namespace ProyectoFinal
{
    public partial class FrmLlegadaLote : Form
    {
        private int idAlmacen;
        public FrmLlegadaLote(int idAlmacen)
        {
            InitializeComponent();
            this.idAlmacen = idAlmacen;
        }

        private void FrmLlegadaLote_Load(object sender, EventArgs e)
        {
            CargarLotesEnViaje();
        }

        private void CargarLotesEnViaje()
        {
            try
            {
                // Crear un DataTable para almacenar los datos de los lotes.
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID_Lote", typeof(int));
                dataTable.Columns.Add("Fecha_Creacion", typeof(DateTime));
                dataTable.Columns.Add("Estado", typeof(string));
                dataTable.Columns.Add("AlmacenDestino", typeof(int));

                // Llamar al método de la capa de negocios para obtener los lotes en viaje.
                List<Lote> lotesEnViaje = CapaNegocios.ObtenerLotesEnViaje();

                // Rellenar el DataTable con los lotes en viaje.
                foreach (var lote in lotesEnViaje)
                {
                    dataTable.Rows.Add(lote.ID_Lote, lote.Fecha_Creacion, lote.Estado, lote.AlmacenDestino);
                }

                // Asignar el DataTable como DataSource del DataGridView.
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los lotes: " + ex.Message);
            }
        }

        private void btnConfirmarIngreso_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un lote.");
                return;
            }

            int idLote = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Lote"].Value);
            string resultado = CapaNegocios.ProcesarLlegadaLote(idLote, idAlmacen);
            MessageBox.Show(resultado);
            CargarLotesEnViaje();
        }
    }
}
