namespace ProyectoFinal
{
    partial class CambioContrasena
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
            txtPass = new TextBox();
            label2 = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(45, 9);
            label1.Name = "label1";
            label1.Size = new Size(337, 84);
            label1.TabIndex = 2;
            label1.Text = "Por favor modifique su contraseña.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(190, 187);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(204, 23);
            txtPass.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(12, 174);
            label2.Name = "label2";
            label2.Size = new Size(149, 42);
            label2.TabIndex = 4;
            label2.Text = "Nueva contraseña:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(147, 280);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(127, 43);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Confirmar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // CambioContrasena
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 365);
            Controls.Add(btnAceptar);
            Controls.Add(txtPass);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CambioContrasena";
            Text = "CambioContrasena";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPass;
        private Label label2;
        private Button btnAceptar;
    }
}