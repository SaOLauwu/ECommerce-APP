﻿namespace ProyectoFinal
{
    partial class frmBajaEmpleado
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
            btnSalir = new Button();
            btnDelete = new Button();
            txtCedula = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(337, 84);
            label1.TabIndex = 2;
            label1.Text = "Ingrese la cédula del empleado a eliminar:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(233, 305);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(161, 44);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(32, 305);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(161, 44);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Eliminar empleado";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnLogin_Click;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(190, 179);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(204, 23);
            txtCedula.TabIndex = 19;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(32, 166);
            label2.Name = "label2";
            label2.Size = new Size(87, 42);
            label2.TabIndex = 18;
            label2.Text = "CI:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BajaEmpleado
            // 
            AcceptButton = btnDelete;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(430, 379);
            Controls.Add(btnSalir);
            Controls.Add(btnDelete);
            Controls.Add(txtCedula);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BajaEmpleado";
            Text = "BajaEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Button btnSalir;
        public Button btnDelete;
        private TextBox txtCedula;
        private Label label2;
    }
}