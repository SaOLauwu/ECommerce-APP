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
    public partial class frmChoferes : Form
    {
        public frmChoferes()
        {
            InitializeComponent();
            dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
        }

        private void frnClientes_Load(object sender, EventArgs e)
        {
            CargarTransportesDisponibles();
        }

        private void CargarTransportesDisponibles()
        {
            string transportesJson = API_Choferes.CargarTransportesDisponibles();
            List<EntidadesJSON.Transporte> transportes = JsonSerializer.Deserialize<List<EntidadesJSON.Transporte>>(transportesJson);

            DataTable dt = new DataTable();
            dt.Columns.Add("Matricula", typeof(string));
            dt.Columns.Add("Tipo", typeof(string));
            dt.Columns.Add("Estado", typeof(string));

            foreach (var transporte in transportes)
            {
                dt.Rows.Add(transporte.Matricula, transporte.Tipo, transporte.Estado);
            }

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                string matricula = Convert.ToString(dataGridView1.CurrentRow.Cells["Matricula"].Value);
                if (!string.IsNullOrWhiteSpace(matricula))
                {
                    string tipo = Convert.ToString(dataGridView1.CurrentRow.Cells["Tipo"].Value);
                    Form frmAsignacion = tipo == "Camioneta"
                        ? new AsignacionPaquetesCamionetas(matricula)
                        : new AsignacionLotesCamiones(matricula);
                    frmAsignacion.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una fila que contenga datos.");
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada o la fila seleccionada está vacía.");
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
