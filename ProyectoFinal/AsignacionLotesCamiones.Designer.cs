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
            button1 = new Button();
            label1 = new Label();
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
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(162, 9);
            label2.Name = "label2";
            label2.Size = new Size(433, 47);
            label2.TabIndex = 4;
            label2.Text = "Seleccione los lotes a trasladar en su ruta: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            btnSalir.Location = new Point(627, 489);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(132, 40);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(394, 471);
            button1.Name = "button1";
            button1.Size = new Size(165, 48);
            button1.TabIndex = 10;
            button1.Text = "Deseleccionar lote";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(101, 56);
            label1.Name = "label1";
            label1.Size = new Size(555, 29);
            label1.TabIndex = 22;
            label1.Text = "(Da doble click sobre uno de los lotes para ver los lotes que comparten ruta)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AsignacionLotesCamiones
            // 
            AcceptButton = btnComenzar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(771, 541);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnSalir);
            Controls.Add(btnComenzar);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "AsignacionLotesCamiones";
            Text = "AsignacionLotesCamiones";
            Load += AsignacionLotesCamiones_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label2;
        public Button btnComenzar;
        public Button btnSalir;
        public Button button1;
        private Label label1;
    }
}