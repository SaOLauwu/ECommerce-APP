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

namespace ProyectoFinal
{
    public partial class AsignacionLotesCamiones : Form
    {
        private string matricula;
        private bool rutaSeleccionada = false; // Añade esta línea
        private int ciChofer;

        public AsignacionLotesCamiones(string matricula)
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.matricula = matricula;
            this.ciChofer = EntidadesJSON.SesionUsuario.CiChofer;
        }

        // Este método ahora invoca el método correcto de la API de choferes
        private void AsignacionLotesCamiones_Load_1(object sender, EventArgs e)
        {
            CargarLotesEnAlmacenConUbicaciones();
        }

        private void CargarLotesEnAlmacenConUbicaciones()
        {
            try
            {
                DataTable dt = API_Choferes.CargarLotesConUbicacion();
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cargar los lotes en almacén: " + ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int almacenDestino = Convert.ToInt32(dataGridView1.CurrentRow.Cells["AlmacenDestino"].Value);
                ActualizarVistaLotes(almacenDestino);
                rutaSeleccionada = true;
            }
        }

        private void ActualizarVistaLotes(int almacenDestino)
        {
            try
            {
                // Este método ahora obtiene los lotes que están en la misma ruta que el almacén destino.
                DataTable lotesFiltrados = API_Choferes.ObtenerLotesPorAlmacenDestino(almacenDestino);

                // Asignar el DataTable como DataSource del DataGridView.
                dataGridView1.DataSource = lotesFiltrados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al actualizar la vista de lotes: " + ex.Message);
            }
        }


        private void btnComenzar_Click(object sender, EventArgs e)
        {
            if (!rutaSeleccionada || dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un lote para comenzar la ruta.");
                return;
            }

            try
            {
                var idsLotes = dataGridView1.SelectedRows.Cast<DataGridViewRow>()
                                .Select(row => Convert.ToInt32(row.Cells["ID_Lote"].Value))
                                .ToList();

                List<int> idsPaquetes = API_Choferes.ObtenerPaquetesDeLotes(idsLotes);

                // Registrar el evento para cada paquete
                foreach (var idPaquete in idsPaquetes)
                {
                    CapaNegocios.RegistrarEventoPaquete(idPaquete, "Emprendió ruta al siguiente almacén", matricula);
                }

                int idRuta = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IDRuta"].Value);
                var rutaInfo = API_Choferes.ObtenerInformacionDeRuta(idRuta);

                API_Choferes.ActualizarEstadoYAlmacenLotes(idsLotes, "En viaje");
                CapaNegocios.RegistrarAsignacionRuta(idRuta, ciChofer);

                // Actualiza el estado del transporte a "en carretera"
                CapaNegocios.ActualizarEstadoTransporte(matricula, "en carretera");

                MessageBox.Show($"¡Buen viaje por la ruta {idRuta}! Su destino final es {rutaInfo.Destino} " +
                                $"con {rutaInfo.DuracionEstimada} horas aproximadas de viaje.");

                rutaSeleccionada = false; // Resetea el estado
                CargarLotesEnAlmacenConUbicaciones(); // Actualiza la vista del DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rutaSeleccionada = false;
            CargarLotesEnAlmacenConUbicaciones();
        }
    }
}
