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
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {

        }
    }
}
