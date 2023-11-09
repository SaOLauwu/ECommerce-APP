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
        public GestionAlmacenes()
        {
            InitializeComponent();
        }

        private void GestionAlmacenes_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            label2 = new Label();
            listBox1 = new ListBox();
            btnLogin = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(65, 42);
            label2.Name = "label2";
            label2.Size = new Size(729, 23);
            label2.TabIndex = 7;
            label2.Text = "Seleccione los paquetes y presione el botón correspondiente a la acción que desea realizar";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(42, 95);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(791, 349);
            listBox1.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(240, 469);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(155, 44);
            btnLogin.TabIndex = 24;
            btnLogin.Text = "Cambiar estado";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(442, 469);
            button1.Name = "button1";
            button1.Size = new Size(155, 44);
            button1.TabIndex = 25;
            button1.Text = "Asignar a lote";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(725, 505);
            button2.Name = "button2";
            button2.Size = new Size(132, 39);
            button2.TabIndex = 26;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // GestionAlmacenes
            // 
            ClientSize = new Size(887, 556);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Name = "GestionAlmacenes";
            ResumeLayout(false);
            PerformLayout();
        }

        private void GestionAlmacenes_Load_1(object sender, EventArgs e)
        {
        }

        private Label label2;
        public Button btnLogin;
        public Button button1;
        public Button button2;
        private ListBox listBox1;
    }
}
