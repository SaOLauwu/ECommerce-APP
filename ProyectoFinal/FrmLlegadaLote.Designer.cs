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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(816, 418);
            dataGridView1.TabIndex = 0;
            // 
            // btnConfirmarIngreso
            // 
            btnConfirmarIngreso.Location = new Point(342, 522);
            btnConfirmarIngreso.Name = "btnConfirmarIngreso";
            btnConfirmarIngreso.Size = new Size(161, 44);
            btnConfirmarIngreso.TabIndex = 19;
            btnConfirmarIngreso.Text = "Cambiar estado";
            btnConfirmarIngreso.UseVisualStyleBackColor = true;
            btnConfirmarIngreso.Click += btnConfirmarIngreso_Click;
            // 
            // FrmLlegadaLote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 589);
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
    }
}