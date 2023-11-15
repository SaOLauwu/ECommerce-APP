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
    public partial class FrmIngresarPaquetes : Form
    {
        private int idAlmacen;
        public FrmIngresarPaquetes(int idAlmacen)
        {
            InitializeComponent();
            this.idAlmacen = idAlmacen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CapaNegocios.ExisteCliente(int.Parse(txtCiCliente.Text)))
            {
                MessageBox.Show("El cliente con la cédula ingresada no existe.");
                return;
            }
            try
            {
                var paquete = new EntidadesJSON.Paquete
                {
                    Ci = int.Parse(txtCiCliente.Text),
                    Descripcion = txtDescripcion.Text,
                    Peso = decimal.Parse(txtPeso.Text),
                    Estado = "En almacén", // Suponiendo que el estado inicial es "En almacén"
                    ID_Almacen = this.idAlmacen
                };

                string resultado = API_Almacenes.CrearPaquete(paquete);
                MessageBox.Show(resultado);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el paquete: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
