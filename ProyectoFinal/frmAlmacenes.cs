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
    public partial class frmAlmacenes : Form
    {
        public frmAlmacenes()
        {
            InitializeComponent();
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
        }


        public void CargarAlmacenes()
        {
            string datosJson = API_Almacenes.CargarAlmacenes();
            List<EntidadesJSON.Almacen> almacenes = JsonSerializer.Deserialize<List<EntidadesJSON.Almacen>>(datosJson);

            DataTable dt = ConvertirADataTable(almacenes);
            dataGridView1.DataSource = dt;
        }

        private DataTable ConvertirADataTable(List<EntidadesJSON.Almacen> almacenes)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Almacen", typeof(int));
            dt.Columns.Add("Ubicacion", typeof(string));
            dt.Columns.Add("Responsable", typeof(int));
            dt.Columns.Add("IDRuta", typeof(int));

            foreach (var almacen in almacenes)
            {
                dt.Rows.Add(
                    almacen.ID_Almacen,
                    almacen.Ubicacion,
                    almacen.Responsable,
                    almacen.IDRuta
                );
            }

            return dt;
        }

        private void frmAlmacenes_Load(object sender, EventArgs e)
        {
            CargarAlmacenes();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                int idAlmacen = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Almacen"].Value);
                GestionAlmacenes frmGestion = new GestionAlmacenes(idAlmacen);
                frmGestion.ShowDialog();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
