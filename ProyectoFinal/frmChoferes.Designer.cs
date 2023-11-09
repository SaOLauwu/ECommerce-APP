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
            button2 = new Button();
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
            label2.Location = new Point(38, 119);
            label2.Name = "label2";
            label2.Size = new Size(366, 21);
            label2.TabIndex = 6;
            label2.Text = "Aquí tiene una lista de los lotes asignados para hoy:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(78, 166);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(638, 349);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(314, 552);
            button2.Name = "button2";
            button2.Size = new Size(159, 36);
            button2.TabIndex = 11;
            button2.Text = "Comenzar entrega";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmChoferes
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(784, 620);
            Controls.Add(button2);
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
        private Button button2;
    }
}