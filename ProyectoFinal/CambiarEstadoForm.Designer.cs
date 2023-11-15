namespace ProyectoFinal
{
    partial class CambiarEstadoForm
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
            comboBoxEstados = new ComboBox();
            label2 = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // comboBoxEstados
            // 
            comboBoxEstados.FormattingEnabled = true;
            comboBoxEstados.Items.AddRange(new object[] { "En almacén", "En viaje", "En viaje hacia destino final", "Entregado" });
            comboBoxEstados.Location = new Point(34, 167);
            comboBoxEstados.Name = "comboBoxEstados";
            comboBoxEstados.Size = new Size(283, 23);
            comboBoxEstados.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 30);
            label2.Name = "label2";
            label2.Size = new Size(292, 46);
            label2.TabIndex = 6;
            label2.Text = "Seleccione el estado deseado de la lista para los paquetes seleccionados.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(34, 277);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(129, 45);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(197, 277);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(129, 45);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // CambiarEstadoForm
            // 
            AcceptButton = btnConfirmar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(359, 351);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(label2);
            Controls.Add(comboBoxEstados);
            Name = "CambiarEstadoForm";
            Text = "CambiarEstadoForm";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxEstados;
        private Label label2;
        public Button btnConfirmar;
        public Button btnCancelar;
    }
}