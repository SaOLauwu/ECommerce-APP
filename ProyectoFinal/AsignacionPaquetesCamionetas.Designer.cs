namespace ProyectoFinal
{
    partial class AsignacionPaquetesCamionetas
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
            dataGridView1 = new DataGridView();
            btnSalir = new Button();
            btnComenzar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(157, 9);
            label2.Name = "label2";
            label2.Size = new Size(433, 47);
            label2.TabIndex = 11;
            label2.Text = "Seleccione los paquetes a enviar en su ruta: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(747, 356);
            dataGridView1.TabIndex = 10;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(390, 452);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(165, 48);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnComenzar
            // 
            btnComenzar.Location = new Point(188, 452);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Size = new Size(165, 48);
            btnComenzar.TabIndex = 12;
            btnComenzar.Text = "Comenzar ruta";
            btnComenzar.UseVisualStyleBackColor = true;
            btnComenzar.Click += btnComenzar_Click;
            // 
            // AsignacionPaquetesCamionetas
            // 
            AcceptButton = btnComenzar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(765, 511);
            Controls.Add(btnSalir);
            Controls.Add(btnComenzar);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "AsignacionPaquetesCamionetas";
            Text = "AsignacionPaquetesCamionetas";
            Load += AsignacionPaquetesCamionetas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private DataGridView dataGridView1;
        public Button btnSalir;
        public Button btnComenzar;
    }
}