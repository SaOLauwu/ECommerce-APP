﻿namespace ProyectoFinal
{
    partial class GestionAlmacenes
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
            dataGridView1 = new DataGridView();
            btnLote = new Button();
            btnEstado = new Button();
            btnSalir = new Button();
            label2 = new Label();
            btnNuevoPaquete = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(902, 40);
            label1.TabIndex = 2;
            label1.Text = "Seleccione los paquetes y presione el botón correspondiente a la acción que desea realizar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(902, 387);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnLote
            // 
            btnLote.Location = new Point(486, 497);
            btnLote.Name = "btnLote";
            btnLote.Size = new Size(161, 44);
            btnLote.TabIndex = 19;
            btnLote.Text = "Asignar a lote";
            btnLote.UseVisualStyleBackColor = true;
            btnLote.Click += btnLote_Click;
            // 
            // btnEstado
            // 
            btnEstado.Location = new Point(285, 497);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(161, 44);
            btnEstado.TabIndex = 18;
            btnEstado.Text = "Cambiar estado";
            btnEstado.UseVisualStyleBackColor = true;
            btnEstado.Click += btnEstado_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(794, 565);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(161, 44);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(256, 49);
            label2.Name = "label2";
            label2.Size = new Size(452, 29);
            label2.TabIndex = 21;
            label2.Text = "(Puede seleccionar varios paquetes manteniendo la tecla CTRL)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNuevoPaquete
            // 
            btnNuevoPaquete.Location = new Point(29, 565);
            btnNuevoPaquete.Name = "btnNuevoPaquete";
            btnNuevoPaquete.Size = new Size(161, 44);
            btnNuevoPaquete.TabIndex = 23;
            btnNuevoPaquete.Text = "Ingresar nuevo paquete";
            btnNuevoPaquete.UseVisualStyleBackColor = true;
            btnNuevoPaquete.Click += btnNuevoPaquete_Click;
            // 
            // button1
            // 
            button1.Location = new Point(211, 565);
            button1.Name = "button1";
            button1.Size = new Size(161, 44);
            button1.TabIndex = 24;
            button1.Text = "Ingresar llegada de lote";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // GestionAlmacenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(967, 621);
            Controls.Add(button1);
            Controls.Add(btnNuevoPaquete);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(btnLote);
            Controls.Add(btnEstado);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "GestionAlmacenes";
            Text = "GestionAlmacenes";
            Load += GestionAlmacenes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        public Button btnLote;
        public Button btnEstado;
        public Button btnSalir;
        private Label label2;
        public Button btnNuevoPaquete;
        public Button button1;
    }
}