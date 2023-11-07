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
    public partial class frmBackoffice : Form
    {
        public frmBackoffice()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AltaUsuario a = new AltaUsuario();
            a.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
