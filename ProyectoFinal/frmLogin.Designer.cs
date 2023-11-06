namespace ProyectoFinal
{
    partial class frmLogin
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
            txtboxCi = new TextBox();
            txtboxPass = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            btnSalir = new Button();
            label4 = new Label();
            txtboxNombre = new TextBox();
            txtBoxApellido = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(823, 78);
            label1.TabIndex = 1;
            label1.Text = "Inicie sesión para continuar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(186, 241);
            label2.Name = "label2";
            label2.Size = new Size(45, 32);
            label2.TabIndex = 2;
            label2.Text = "C.I.";
            // 
            // txtboxCi
            // 
            txtboxCi.Location = new Point(357, 250);
            txtboxCi.Name = "txtboxCi";
            txtboxCi.Size = new Size(276, 23);
            txtboxCi.TabIndex = 3;
            // 
            // txtboxPass
            // 
            txtboxPass.Location = new Point(357, 317);
            txtboxPass.Name = "txtboxPass";
            txtboxPass.PasswordChar = '*';
            txtboxPass.Size = new Size(276, 23);
            txtboxPass.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(97, 308);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(134, 32);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(186, 388);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(186, 56);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(447, 388);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(186, 56);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(129, 122);
            label4.Name = "label4";
            label4.Size = new Size(102, 32);
            label4.TabIndex = 8;
            label4.Text = "Nombre";
            label4.Click += label4_Click;
            // 
            // txtboxNombre
            // 
            txtboxNombre.Location = new Point(357, 131);
            txtboxNombre.Name = "txtboxNombre";
            txtboxNombre.Size = new Size(276, 23);
            txtboxNombre.TabIndex = 9;
            // 
            // txtBoxApellido
            // 
            txtBoxApellido.Location = new Point(357, 190);
            txtBoxApellido.Name = "txtBoxApellido";
            txtBoxApellido.Size = new Size(276, 23);
            txtBoxApellido.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(129, 181);
            label5.Name = "label5";
            label5.Size = new Size(102, 32);
            label5.TabIndex = 10;
            label5.Text = "Apellido";
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(823, 484);
            ControlBox = false;
            Controls.Add(txtBoxApellido);
            Controls.Add(label5);
            Controls.Add(txtboxNombre);
            Controls.Add(label4);
            Controls.Add(btnSalir);
            Controls.Add(btnLogin);
            Controls.Add(txtboxPass);
            Controls.Add(label3);
            Controls.Add(txtboxCi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtboxPass;
        private Label label3;
        public Button btnLogin;
        public Button btnSalir;
        public TextBox txtboxCi;
        private Label label4;
        public TextBox txtboxNombre;
        public TextBox txtBoxApellido;
        private Label label5;
    }
}