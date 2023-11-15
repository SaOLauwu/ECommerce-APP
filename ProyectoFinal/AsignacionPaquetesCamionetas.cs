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
    public partial class AsignacionPaquetesCamionetas : Form
    {
        private string matricula;
        public AsignacionPaquetesCamionetas(string matricula)
        {
            InitializeComponent();
            this.matricula = matricula;
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            var idsPaquetes = dataGridView1.SelectedRows.Cast<DataGridViewRow>()
                         .Select(row => Convert.ToInt32(row.Cells["ID_Paquete"].Value))
                         .ToList();
            var idsAlmacenes = dataGridView1.SelectedRows.Cast<DataGridViewRow>()
                                .Select(row => Convert.ToInt32(row.Cells["ID_Almacen"].Value))
                                .Distinct();

            if (idsPaquetes.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un paquete para comenzar la ruta.");
                return;
            }

            if (idsAlmacenes.Count() > 1)
            {
                MessageBox.Show("No se puede comenzar envíos con paquetes de distintos almacenes.");
                return;
            }

            CapaNegocios.ActualizarEstadoTransporte(matricula, "en carretera");

            API_Choferes.ActualizarEstadoPaquetes(idsPaquetes, "En viaje hacia destino final", matricula);

            MessageBox.Show("La ruta ha comenzado y los paquetes están en camino hacia su destino final.");

            CargarPaquetesEnAlmacen();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AsignacionPaquetesCamionetas_Load(object sender, EventArgs e)
        {
            CargarPaquetesEnAlmacen();
        }

        private void CargarPaquetesEnAlmacen()
        {
            try
            {
                DataTable dt = API_Choferes.CargarPaquetesEnAlmacenOrdenadosPorAlmacen();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cargar los paquetes en almacén: " + ex.Message);
            }
        }

    }
}
