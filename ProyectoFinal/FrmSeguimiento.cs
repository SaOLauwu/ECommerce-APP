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
    public partial class FrmSeguimiento : Form
    {
        public FrmSeguimiento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int ci;
            if (!int.TryParse(txtboxCi.Text, out ci))
            {
                MessageBox.Show("La cédula de identidad debe ser numérica.");
                return;
            }

            // Buscar eventos relacionados con los paquetes encontrados
            string sqlEventos = $"SELECT * FROM Eventos WHERE ID_Paquete IN (SELECT ID_Paquete FROM Paquetes WHERE Ci = {ci})";
            var eventosDataTable = CapaNegocios.ObtenerDatosSeguimiento(sqlEventos);
            // Suponiendo que tiene un DataGridView llamado dgvEventos
            dataGridView1.DataSource = eventosDataTable;

        }

    }
}
