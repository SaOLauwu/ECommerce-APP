namespace ProyectoFinal
{
    partial class frmBackoffice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackoffice));
            label1 = new Label();
            label2 = new Label();
            btnAlta = new Button();
            btnEliminar = new Button();
            btnConsulta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(775, 91);
            label1.TabIndex = 4;
            label1.Text = "Backoffice";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(249, 121);
            label2.Name = "label2";
            label2.Size = new Size(266, 38);
            label2.TabIndex = 5;
            label2.Text = "¿Qué desea hacer?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(289, 226);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(180, 74);
            btnAlta.TabIndex = 14;
            btnAlta.Text = "Ingresar nuevo empleado.";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(289, 337);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(180, 74);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar empleado existente.";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(289, 446);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(180, 74);
            btnConsulta.TabIndex = 16;
            btnConsulta.Text = "Consultar empleados.";
            btnConsulta.UseVisualStyleBackColor = true;
            // 
            // frmBackoffice
            // 
            AcceptButton = btnAlta;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(784, 620);
            Controls.Add(btnConsulta);
            Controls.Add(btnEliminar);
            Controls.Add(btnAlta);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBackoffice";
            Text = "frmProveedores";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAlta;
        private Button btnEliminar;
        private Button btnConsulta;
    }
}