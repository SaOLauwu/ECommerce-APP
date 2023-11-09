namespace ProyectoFinal
{
    partial class frmChoferes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoferes));
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label4 = new Label();
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
            label1.TabIndex = 2;
            label1.Text = "Choferes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(306, 100);
            label2.Name = "label2";
            label2.Size = new Size(146, 21);
            label2.TabIndex = 6;
            label2.Text = "Ingreso de choferes";
            label2.Click += label2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(149, 285);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(512, 274);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 141);
            label3.Name = "label3";
            label3.Size = new Size(299, 15);
            label3.TabIndex = 12;
            label3.Text = "Digite la matricula de su vehiculo a operar(sin espacios)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(410, 168);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 267);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 15;
            label4.Text = "Vehiculos activos";
            // 
            // frmChoferes
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(784, 620);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmChoferes";
            Text = "frnClientes";
            Load += frnClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Label label4;
    }
}