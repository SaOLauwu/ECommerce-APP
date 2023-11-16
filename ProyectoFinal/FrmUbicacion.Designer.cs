namespace ProyectoFinal
{
    partial class FrmUbicacion
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
            label2 = new Label();
            comboBoxAlmacenes = new ComboBox();
            btnAceptar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 46);
            label2.Name = "label2";
            label2.Size = new Size(318, 25);
            label2.TabIndex = 6;
            label2.Text = "Seleccione el destino del nuevo lote:";
            // 
            // comboBoxAlmacenes
            // 
            comboBoxAlmacenes.FormattingEnabled = true;
            comboBoxAlmacenes.Location = new Point(55, 149);
            comboBoxAlmacenes.Name = "comboBoxAlmacenes";
            comboBoxAlmacenes.Size = new Size(250, 23);
            comboBoxAlmacenes.TabIndex = 7;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(22, 255);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(137, 44);
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "Asignar ubicación";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(203, 255);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(137, 44);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmUbicacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 335);
            Controls.Add(btnSalir);
            Controls.Add(btnAceptar);
            Controls.Add(comboBoxAlmacenes);
            Controls.Add(label2);
            Name = "FrmUbicacion";
            Text = "FrmUbicacion";
            Load += FrmUbicacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboBoxAlmacenes;
        public Button btnAceptar;
        public Button btnSalir;
    }
}