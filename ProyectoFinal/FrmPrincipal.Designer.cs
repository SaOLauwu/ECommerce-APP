namespace ProyectoFinal
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            panelPrincipal = new Panel();
            btnSalir = new Button();
            btnConfiguracion = new Button();
            btnBackoffice = new Button();
            btnAlmacenes = new Button();
            btnChoferes = new Button();
            btnSeguimiento = new Button();
            btnHome = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelForm = new Panel();
            label1 = new Label();
            panelPrincipal.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(86, 92, 94);
            panelPrincipal.Controls.Add(btnSalir);
            panelPrincipal.Controls.Add(btnConfiguracion);
            panelPrincipal.Controls.Add(btnBackoffice);
            panelPrincipal.Controls.Add(btnAlmacenes);
            panelPrincipal.Controls.Add(btnChoferes);
            panelPrincipal.Controls.Add(btnSeguimiento);
            panelPrincipal.Controls.Add(btnHome);
            panelPrincipal.Controls.Add(panelLogo);
            panelPrincipal.Dock = DockStyle.Left;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(200, 620);
            panelPrincipal.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatAppearance.BorderColor = Color.Indigo;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(122, 163, 154);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(181, 194, 199);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.FromArgb(223, 219, 216);
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 538);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(10, 0, 0, 0);
            btnSalir.Size = new Size(200, 73);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Dock = DockStyle.Top;
            btnConfiguracion.FlatAppearance.BorderColor = Color.Indigo;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatAppearance.MouseDownBackColor = Color.FromArgb(122, 163, 154);
            btnConfiguracion.FlatAppearance.MouseOverBackColor = Color.FromArgb(181, 194, 199);
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfiguracion.ForeColor = Color.FromArgb(223, 219, 216);
            btnConfiguracion.Image = (Image)resources.GetObject("btnConfiguracion.Image");
            btnConfiguracion.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.Location = new Point(0, 465);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Padding = new Padding(10, 0, 0, 0);
            btnConfiguracion.Size = new Size(200, 73);
            btnConfiguracion.TabIndex = 6;
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // btnBackoffice
            // 
            btnBackoffice.Dock = DockStyle.Top;
            btnBackoffice.FlatAppearance.BorderColor = Color.Indigo;
            btnBackoffice.FlatAppearance.BorderSize = 0;
            btnBackoffice.FlatAppearance.MouseDownBackColor = Color.FromArgb(122, 163, 154);
            btnBackoffice.FlatAppearance.MouseOverBackColor = Color.FromArgb(181, 194, 199);
            btnBackoffice.FlatStyle = FlatStyle.Flat;
            btnBackoffice.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackoffice.ForeColor = Color.FromArgb(223, 219, 216);
            btnBackoffice.Image = (Image)resources.GetObject("btnBackoffice.Image");
            btnBackoffice.ImageAlign = ContentAlignment.MiddleLeft;
            btnBackoffice.Location = new Point(0, 392);
            btnBackoffice.Name = "btnBackoffice";
            btnBackoffice.Padding = new Padding(10, 0, 0, 0);
            btnBackoffice.Size = new Size(200, 73);
            btnBackoffice.TabIndex = 5;
            btnBackoffice.Text = "Backoffice";
            btnBackoffice.TextAlign = ContentAlignment.MiddleLeft;
            btnBackoffice.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBackoffice.UseVisualStyleBackColor = true;
            btnBackoffice.Click += btnProveedores_Click;
            // 
            // btnAlmacenes
            // 
            btnAlmacenes.Dock = DockStyle.Top;
            btnAlmacenes.FlatAppearance.BorderColor = Color.Indigo;
            btnAlmacenes.FlatAppearance.BorderSize = 0;
            btnAlmacenes.FlatAppearance.MouseDownBackColor = Color.FromArgb(122, 163, 154);
            btnAlmacenes.FlatAppearance.MouseOverBackColor = Color.FromArgb(181, 194, 199);
            btnAlmacenes.FlatStyle = FlatStyle.Flat;
            btnAlmacenes.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlmacenes.ForeColor = Color.FromArgb(223, 219, 216);
            btnAlmacenes.Image = (Image)resources.GetObject("btnAlmacenes.Image");
            btnAlmacenes.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlmacenes.Location = new Point(0, 319);
            btnAlmacenes.Name = "btnAlmacenes";
            btnAlmacenes.Padding = new Padding(10, 0, 0, 0);
            btnAlmacenes.Size = new Size(200, 73);
            btnAlmacenes.TabIndex = 4;
            btnAlmacenes.Text = "Almacenes";
            btnAlmacenes.TextAlign = ContentAlignment.MiddleLeft;
            btnAlmacenes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlmacenes.UseVisualStyleBackColor = true;
            btnAlmacenes.Click += btnAlmacenes_Click;
            // 
            // btnChoferes
            // 
            btnChoferes.Dock = DockStyle.Top;
            btnChoferes.FlatAppearance.BorderColor = Color.Indigo;
            btnChoferes.FlatAppearance.BorderSize = 0;
            btnChoferes.FlatAppearance.MouseDownBackColor = Color.FromArgb(122, 163, 154);
            btnChoferes.FlatAppearance.MouseOverBackColor = Color.FromArgb(181, 194, 199);
            btnChoferes.FlatStyle = FlatStyle.Flat;
            btnChoferes.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnChoferes.ForeColor = Color.FromArgb(223, 219, 216);
            btnChoferes.Image = (Image)resources.GetObject("btnChoferes.Image");
            btnChoferes.ImageAlign = ContentAlignment.MiddleLeft;
            btnChoferes.Location = new Point(0, 246);
            btnChoferes.Name = "btnChoferes";
            btnChoferes.Padding = new Padding(10, 0, 0, 0);
            btnChoferes.Size = new Size(200, 73);
            btnChoferes.TabIndex = 3;
            btnChoferes.Text = "Choferes";
            btnChoferes.TextAlign = ContentAlignment.MiddleLeft;
            btnChoferes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChoferes.UseVisualStyleBackColor = true;
            btnChoferes.Click += btnClientes_Click;
            // 
            // btnSeguimiento
            // 
            btnSeguimiento.Dock = DockStyle.Top;
            btnSeguimiento.FlatAppearance.BorderColor = Color.Indigo;
            btnSeguimiento.FlatAppearance.BorderSize = 0;
            btnSeguimiento.FlatAppearance.MouseDownBackColor = Color.FromArgb(122, 163, 154);
            btnSeguimiento.FlatAppearance.MouseOverBackColor = Color.FromArgb(181, 194, 199);
            btnSeguimiento.FlatStyle = FlatStyle.Flat;
            btnSeguimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeguimiento.ForeColor = Color.FromArgb(223, 219, 216);
            btnSeguimiento.Image = (Image)resources.GetObject("btnSeguimiento.Image");
            btnSeguimiento.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeguimiento.Location = new Point(0, 173);
            btnSeguimiento.Name = "btnSeguimiento";
            btnSeguimiento.Padding = new Padding(10, 0, 0, 0);
            btnSeguimiento.Size = new Size(200, 73);
            btnSeguimiento.TabIndex = 2;
            btnSeguimiento.Text = "Seguimiento";
            btnSeguimiento.TextAlign = ContentAlignment.MiddleLeft;
            btnSeguimiento.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSeguimiento.UseVisualStyleBackColor = true;
            btnSeguimiento.Click += btnProductos_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderColor = Color.Indigo;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(122, 163, 154);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(181, 194, 199);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.FromArgb(223, 219, 216);
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 100);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.Size = new Size(200, 73);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(69, 89, 84);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 100);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(label1);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(200, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(784, 620);
            panelForm.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(775, 91);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(984, 620);
            Controls.Add(panelForm);
            Controls.Add(panelPrincipal);
            IsMdiContainer = true;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Feat Tech";
            Load += frmPrincipal_Load;
            panelPrincipal.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Panel panelForm;
        private Label label1;
        public Button btnHome;
        public Button btnSalir;
        public Button btnConfiguracion;
        public Button btnBackoffice;
        public Button btnAlmacenes;
        public Button btnChoferes;
        public Button btnSeguimiento;
    }
}