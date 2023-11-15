using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoFinal
{
    public partial class frmPrincipal : Form
    {
        private Form frmActivo = new Form();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void MostrarFrmSeguimiento()
        {
            FormShow(new FrmSeguimiento());

        }
        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmActivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        private void ActiveFormClose()
        {
            if (frmActivo != null)
            {
                frmActivo.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            
            ActiveFormClose();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
           
            FormShow(new FrmSeguimiento());
        }

        private void btnAlmacenes_Click(object sender, EventArgs e)
        {
            FormShow(new frmAlmacenes());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormShow(new frmChoferes());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FormShow(new frmBackoffice());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            FormShow(new frmConfiguracion());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.btnHome.Visible = false;
            this.btnConfiguracion.Visible = false;
            this.btnSalir.Visible = false;
            this.btnSeguimiento.Visible = false;
            this.btnAlmacenes.Visible = false;
            this.btnBackoffice.Visible = false;
            this.btnChoferes.Visible = false;
            frmLogin log = new frmLogin();
            log.ShowDialog();

        }
    }
}
