namespace ProyectoFinal
{
    partial class AltaUsuario
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
            label2 = new Label();
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label7 = new Label();
            txtDireccion = new TextBox();
            label8 = new Label();
            btnSalir = new Button();
            btnLogin = new Button();
            cboRol = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(62, 9);
            label1.Name = "label1";
            label1.Size = new Size(337, 84);
            label1.TabIndex = 1;
            label1.Text = "Ingrese los siguientes datos del nuevo empleado:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(21, 119);
            label2.Name = "label2";
            label2.Size = new Size(87, 42);
            label2.TabIndex = 2;
            label2.Text = "CI:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(220, 132);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(204, 23);
            txtCedula.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(220, 174);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 23);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(21, 161);
            label3.Name = "label3";
            label3.Size = new Size(87, 42);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(220, 216);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(204, 23);
            txtApellido.TabIndex = 7;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(21, 203);
            label4.Name = "label4";
            label4.Size = new Size(87, 42);
            label4.TabIndex = 6;
            label4.Text = "Apellido:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(21, 245);
            label5.Name = "label5";
            label5.Size = new Size(87, 42);
            label5.TabIndex = 8;
            label5.Text = "Rol:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(220, 300);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 23);
            txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(21, 287);
            label6.Name = "label6";
            label6.Size = new Size(87, 42);
            label6.TabIndex = 10;
            label6.Text = "Email:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(220, 342);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(204, 23);
            txtTelefono.TabIndex = 13;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(21, 329);
            label7.Name = "label7";
            label7.Size = new Size(87, 42);
            label7.TabIndex = 12;
            label7.Text = "Teléfono:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(220, 384);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(204, 23);
            txtDireccion.TabIndex = 15;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(21, 371);
            label8.Name = "label8";
            label8.Size = new Size(87, 42);
            label8.TabIndex = 14;
            label8.Text = "Dirección:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(263, 472);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(161, 44);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(62, 472);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(161, 44);
            btnLogin.TabIndex = 16;
            btnLogin.Text = "Crear empleado";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Items.AddRange(new object[] { "Chofer", "Almacenero", "Administrativo" });
            cboRol.Location = new Point(220, 258);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(204, 23);
            cboRol.TabIndex = 18;
            // 
            // AltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 551);
            Controls.Add(cboRol);
            Controls.Add(btnSalir);
            Controls.Add(btnLogin);
            Controls.Add(txtDireccion);
            Controls.Add(label8);
            Controls.Add(txtTelefono);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtCedula);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaUsuario";
            Text = "AltaUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCedula;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtRol;
        private Label label5;
        private TextBox txtEmail;
        private TextBox textBox5;
        private Label label6;
        private TextBox txtTelefono;
        private TextBox textBox6;
        private Label label7;
        private TextBox txtDireccion;
        private Label label8;
        public Button btnSalir;
        public Button btnLogin;
        private ComboBox cboRol;
    }
}