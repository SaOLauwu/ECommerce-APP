namespace ProyectoFinal
{
    partial class AsignacionLotesCamiones
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            btnComenzar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(747, 356);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(164, 25);
            label2.Name = "label2";
            label2.Size = new Size(433, 47);
            label2.TabIndex = 4;
            label2.Text = "Seleccione los lotes a trasladar en su ruta: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // btnComenzar
            // 
            btnComenzar.Location = new Point(193, 471);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Size = new Size(165, 48);
            btnComenzar.TabIndex = 8;
            btnComenzar.Text = "Comenzar ruta";
            btnComenzar.UseVisualStyleBackColor = true;
            btnComenzar.Click += btnComenzar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(395, 471);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(165, 48);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // AsignacionLotesCamiones
            // 
            AcceptButton = btnComenzar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(771, 541);
            Controls.Add(btnSalir);
            Controls.Add(btnComenzar);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "AsignacionLotesCamiones";
            Text = "AsignacionLotesCamiones";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label2;
        public Button btnComenzar;
        public Button btnSalir;
    }
}