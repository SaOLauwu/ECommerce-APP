namespace ProyectoFinal
{
    partial class FrmLlegadaLote
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
            btnConfirmarIngreso = new Button();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(816, 418);
            dataGridView1.TabIndex = 0;
            // 
            // btnConfirmarIngreso
            // 
            btnConfirmarIngreso.Location = new Point(241, 523);
            btnConfirmarIngreso.Name = "btnConfirmarIngreso";
            btnConfirmarIngreso.Size = new Size(161, 44);
            btnConfirmarIngreso.TabIndex = 19;
            btnConfirmarIngreso.Text = "Confirmar ingreso lote";
            btnConfirmarIngreso.UseVisualStyleBackColor = true;
            btnConfirmarIngreso.Click += btnConfirmarIngreso_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(167, 18);
            label1.Name = "label1";
            label1.Size = new Size(495, 42);
            label1.TabIndex = 20;
            label1.Text = "Seleccione el lote que ha ingresado al almacén";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(434, 523);
            button1.Name = "button1";
            button1.Size = new Size(161, 44);
            button1.TabIndex = 21;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmLlegadaLote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 589);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnConfirmarIngreso);
            Controls.Add(dataGridView1);
            Name = "FrmLlegadaLote";
            Text = "FrmLlegadaLote";
            Load += FrmLlegadaLote_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        public Button btnConfirmarIngreso;
        private Label label1;
        public Button button1;
    }
}