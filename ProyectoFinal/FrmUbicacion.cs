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
    public partial class FrmUbicacion : Form
    {
        public int IdAlmacenSeleccionado { get; private set; }

        public FrmUbicacion()
        {
            InitializeComponent();
        }

        private void CargarAlmacenesEnComboBox()
        {
            DataTable almacenes = CapaNegocios.ObtenerAlmacenesDataTable();
            comboBoxAlmacenes.DisplayMember = "Descripcion";
            comboBoxAlmacenes.ValueMember = "ID_Almacen";
            comboBoxAlmacenes.DataSource = almacenes;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (comboBoxAlmacenes.SelectedItem != null)
            {
                IdAlmacenSeleccionado = (int)comboBoxAlmacenes.SelectedValue;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un almacén.");
            }
        }

        private void FrmUbicacion_Load(object sender, EventArgs e)
        {
            CargarAlmacenesEnComboBox();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
