namespace ProyectoFinal
{
    partial class frmConsultarEmpleados
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboRol = new ComboBox();
            btnSalir = new Button();
            btnFiltro = new Button();
            txtCI = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            chkMostrarEliminados = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(224, 9);
            label1.Name = "label1";
            label1.Size = new Size(488, 84);
            label1.TabIndex = 2;
            label1.Text = "Visualización de empleados:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(874, 295);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(386, 403);
            label2.Name = "label2";
            label2.Size = new Size(157, 57);
            label2.TabIndex = 4;
            label2.Text = "Filtros:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(23, 465);
            label3.Name = "label3";
            label3.Size = new Size(47, 35);
            label3.TabIndex = 5;
            label3.Text = "CI:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(279, 465);
            label4.Name = "label4";
            label4.Size = new Size(88, 35);
            label4.TabIndex = 7;
            label4.Text = "Nombre:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(610, 465);
            label5.Name = "label5";
            label5.Size = new Size(88, 35);
            label5.TabIndex = 9;
            label5.Text = "Apellido:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(33, 535);
            label6.Name = "label6";
            label6.Size = new Size(56, 30);
            label6.TabIndex = 13;
            label6.Text = "Cargo:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Items.AddRange(new object[] { "Almacenero", "Chofer", "Administrativo", "No filtrar" });
            cboRol.Location = new Point(95, 537);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(220, 23);
            cboRol.TabIndex = 14;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(746, 530);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(161, 44);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnFiltro
            // 
            btnFiltro.Location = new Point(551, 530);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(161, 44);
            btnFiltro.TabIndex = 22;
            btnFiltro.Text = "Filtrar";
            btnFiltro.UseVisualStyleBackColor = true;
            btnFiltro.Click += btnFiltro_Click;
            // 
            // txtCI
            // 
            txtCI.Location = new Point(61, 473);
            txtCI.Name = "txtCI";
            txtCI.Size = new Size(171, 23);
            txtCI.TabIndex = 25;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(373, 473);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(187, 23);
            txtNombre.TabIndex = 26;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(704, 473);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(187, 23);
            txtApellido.TabIndex = 27;
            // 
            // chkMostrarEliminados
            // 
            chkMostrarEliminados.AutoSize = true;
            chkMostrarEliminados.Location = new Point(339, 541);
            chkMostrarEliminados.Name = "chkMostrarEliminados";
            chkMostrarEliminados.Size = new Size(189, 19);
            chkMostrarEliminados.TabIndex = 28;
            chkMostrarEliminados.Text = "Mostrar empleados eliminados";
            chkMostrarEliminados.UseVisualStyleBackColor = true;
            // 
            // frmConsultarEmpleados
            // 
            AcceptButton = btnFiltro;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(923, 636);
            Controls.Add(chkMostrarEliminados);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtCI);
            Controls.Add(btnSalir);
            Controls.Add(btnFiltro);
            Controls.Add(cboRol);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "frmConsultarEmpleados";
            Text = "ConsultarEmpleados";
            Load += frmConsultarEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboRol;
        public Button btnSalir;
        public Button btnFiltro;
        private TextBox txtCI;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private CheckBox chkMostrarEliminados;
    }
}