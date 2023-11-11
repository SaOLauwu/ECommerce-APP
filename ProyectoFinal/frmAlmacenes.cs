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
    public partial class frmAlmacenes : Form
    {
        public frmAlmacenes()
        {
            InitializeComponent();
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
        }


        public void CargarAlmacenes()
        {
            String sql;
            Object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (Program.cn.State != 0)
            {
                sql = "SELECT * FROM Almacenes";
                try
                {
                    rs = Program.cn.Execute(sql, out filasAfectadas);
                }
                catch
                {
                    MessageBox.Show("Existe un error con la conexión al servidor. Intenta nuevamente");
                }

                DataTable dt = new DataTable();
                for (int i = 0; i < rs.Fields.Count; i++)
                {
                    dt.Columns.Add(rs.Fields[i].Name);
                }

                while (!rs.EOF)
                {
                    DataRow row = dt.NewRow();
                    for (int i = 0; i < rs.Fields.Count; i++)
                    {
                        row[i] = rs.Fields[i].Value;
                    }
                    dt.Rows.Add(row);
                    rs.MoveNext();
                }

                dataGridView1.DataSource = dt;

                rs.Close();
            }
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
    }
}
