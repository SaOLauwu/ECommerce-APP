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
    public partial class CambioContrasena : Form
    {
        private int ci;
        public CambioContrasena(int ci)
        {
            this.ci = ci;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            object filasAfectadas;
            string sql;
            if(Program.cn.State != 0)
            {
                sql = "UPDATE Empleados SET Pass = '" + txtPass.Text + "' WHERE Ci = '" + ci + "';";
                try
                {
                    Program.cn.Execute(sql, out filasAfectadas);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Ocurrió un error al cambiar la contraseña, intente nuevamente.");
                    return;
                }
                MessageBox.Show("Contraseña cambiada con éxito.");
                this.Close();
            }
        }
    }
}
