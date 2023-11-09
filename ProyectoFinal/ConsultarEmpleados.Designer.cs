namespace ProyectoFinal
{
    partial class ConsultarEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            btnSalir = new Button();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(151, 9);
            label1.Name = "label1";
            label1.Size = new Size(488, 84);
            label1.TabIndex = 2;
            label1.Text = "Visualización de empleados:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(739, 295);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(313, 408);
            label2.Name = "label2";
            label2.Size = new Size(157, 57);
            label2.TabIndex = 4;
            label2.Text = "Filtros:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(21, 465);
            label3.Name = "label3";
            label3.Size = new Size(47, 35);
            label3.TabIndex = 5;
            label3.Text = "CI:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 473);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 23);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(260, 465);
            label4.Name = "label4";
            label4.Size = new Size(88, 35);
            label4.TabIndex = 7;
            label4.Text = "Nombre:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(536, 465);
            label5.Name = "label5";
            label5.Size = new Size(88, 35);
            label5.TabIndex = 9;
            label5.Text = "Apellido:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(354, 473);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(630, 473);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 23);
            textBox3.TabIndex = 12;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(61, 530);
            label6.Name = "label6";
            label6.Size = new Size(66, 35);
            label6.TabIndex = 13;
            label6.Text = "Cargo:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Almacenero", "Chofer", "Administrativo" });
            comboBox1.Location = new Point(151, 539);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 23);
            comboBox1.TabIndex = 14;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(573, 527);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(161, 44);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(372, 527);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(161, 44);
            btnLogin.TabIndex = 22;
            btnLogin.Text = "Filtrar";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // ConsultarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 636);
            Controls.Add(btnSalir);
            Controls.Add(btnLogin);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "ConsultarEmpleados";
            Text = "ConsultarEmpleados";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label6;
        private ComboBox comboBox1;
        public Button btnSalir;
        public Button btnLogin;
    }
}