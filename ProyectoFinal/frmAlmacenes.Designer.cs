namespace ProyectoFinal
{
    partial class frmAlmacenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlmacenes));
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(775, 91);
            label1.TabIndex = 3;
            label1.Text = "Almacenes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(31, 149);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(791, 349);
            listBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(134, 100);
            label2.Name = "label2";
            label2.Size = new Size(527, 21);
            label2.TabIndex = 5;
            label2.Text = "Haga doble click sobre uno de los almacenes para gestionar sus productos:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Almacenero", "Chofer", "Administrativo" });
            comboBox1.Location = new Point(318, 544);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 23);
            comboBox1.TabIndex = 16;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(92, 535);
            label6.Name = "label6";
            label6.Size = new Size(208, 35);
            label6.TabIndex = 15;
            label6.Text = "Filtrar por departamento:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(590, 535);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(155, 35);
            btnLogin.TabIndex = 23;
            btnLogin.Text = "Filtrar";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // frmAlmacenes
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(852, 620);
            Controls.Add(btnLogin);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAlmacenes";
            Text = "frmAlmacenes";
            Load += frmAlmacenes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label6;
        public Button btnLogin;
    }
}