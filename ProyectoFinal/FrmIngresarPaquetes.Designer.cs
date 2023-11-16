namespace ProyectoFinal
{
    partial class FrmIngresarPaquetes
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
            btnSalir = new Button();
            btnCrear = new Button();
            txtPeso = new TextBox();
            label4 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtCiCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(232, 354);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(161, 44);
            btnSalir.TabIndex = 34;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(36, 354);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(161, 44);
            btnCrear.TabIndex = 33;
            btnCrear.Text = "Crear paquete";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnLogin_Click;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(213, 271);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(204, 23);
            txtPeso.TabIndex = 25;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(14, 258);
            label4.Name = "label4";
            label4.Size = new Size(87, 42);
            label4.TabIndex = 24;
            label4.Text = "Peso:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(213, 210);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(204, 23);
            txtDescripcion.TabIndex = 23;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(14, 197);
            label3.Name = "label3";
            label3.Size = new Size(96, 42);
            label3.TabIndex = 22;
            label3.Text = "Descripción:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCiCliente
            // 
            txtCiCliente.Location = new Point(213, 148);
            txtCiCliente.Name = "txtCiCliente";
            txtCiCliente.Size = new Size(204, 23);
            txtCiCliente.TabIndex = 21;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(14, 135);
            label2.Name = "label2";
            label2.Size = new Size(106, 42);
            label2.TabIndex = 20;
            label2.Text = "CI del cliente:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(46, 18);
            label1.Name = "label1";
            label1.Size = new Size(337, 84);
            label1.TabIndex = 19;
            label1.Text = "Ingrese los datos del nuevo paquete:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmIngresarPaquetes
            // 
            AcceptButton = btnCrear;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(443, 440);
            Controls.Add(btnSalir);
            Controls.Add(btnCrear);
            Controls.Add(txtPeso);
            Controls.Add(label4);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(txtCiCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmIngresarPaquetes";
            Text = "FrmIngresarPaquetes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnSalir;
        public Button btnCrear;
        private TextBox txtPeso;
        private Label label4;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtCiCliente;
        private Label label2;
        private Label label1;
    }
}