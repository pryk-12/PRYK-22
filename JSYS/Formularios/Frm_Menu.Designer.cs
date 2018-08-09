namespace JSYS.Formularios
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_consultas = new System.Windows.Forms.Button();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_configuraciones = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_procesos = new System.Windows.Forms.Button();
            this.btn_Mantenimiento = new System.Windows.Forms.Button();
            this.pn_matenimientos = new System.Windows.Forms.Panel();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_usuario = new System.Windows.Forms.Button();
            this.pn_procesos = new System.Windows.Forms.Panel();
            this.btn_anular_recibo = new System.Windows.Forms.Button();
            this.btn_cuadre = new System.Windows.Forms.Button();
            this.btn_cxc = new System.Windows.Forms.Button();
            this.btn_facturacion = new System.Windows.Forms.Button();
            this.pn_configuraciones = new System.Windows.Forms.Panel();
            this.btn_permiso = new System.Windows.Forms.Button();
            this.btn_empresa = new System.Windows.Forms.Button();
            this.pn_reporte = new System.Windows.Forms.Panel();
            this.btn_rep_historial = new System.Windows.Forms.Button();
            this.btn_rep_reimprimir_recibos = new System.Windows.Forms.Button();
            this.btn_rep_cuadre = new System.Windows.Forms.Button();
            this.btn_rep_cobros_realizados = new System.Windows.Forms.Button();
            this.btn_rep_facturas = new System.Windows.Forms.Button();
            this.pn_consultas = new System.Windows.Forms.Panel();
            this.btn_facturas_no_activas = new System.Windows.Forms.Button();
            this.btn_recibos_anulados = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_matenimientos.SuspendLayout();
            this.pn_procesos.SuspendLayout();
            this.pn_configuraciones.SuspendLayout();
            this.pn_reporte.SuspendLayout();
            this.pn_consultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btn_consultas);
            this.panel1.Controls.Add(this.lbl_usuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_configuraciones);
            this.panel1.Controls.Add(this.btn_reportes);
            this.panel1.Controls.Add(this.btn_procesos);
            this.panel1.Controls.Add(this.btn_Mantenimiento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 560);
            this.panel1.TabIndex = 0;
            // 
            // btn_consultas
            // 
            this.btn_consultas.FlatAppearance.BorderSize = 0;
            this.btn_consultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultas.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultas.ForeColor = System.Drawing.Color.White;
            this.btn_consultas.Image = ((System.Drawing.Image)(resources.GetObject("btn_consultas.Image")));
            this.btn_consultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consultas.Location = new System.Drawing.Point(4, 326);
            this.btn_consultas.Name = "btn_consultas";
            this.btn_consultas.Size = new System.Drawing.Size(177, 56);
            this.btn_consultas.TabIndex = 7;
            this.btn_consultas.Text = "   Consultas";
            this.btn_consultas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_consultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_consultas.UseVisualStyleBackColor = true;
            this.btn_consultas.Click += new System.EventHandler(this.btn_consultas_Click);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(6, 537);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(12, 16);
            this.lbl_usuario.TabIndex = 5;
            this.lbl_usuario.Text = ".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_configuraciones
            // 
            this.btn_configuraciones.FlatAppearance.BorderSize = 0;
            this.btn_configuraciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_configuraciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_configuraciones.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_configuraciones.ForeColor = System.Drawing.Color.White;
            this.btn_configuraciones.Image = ((System.Drawing.Image)(resources.GetObject("btn_configuraciones.Image")));
            this.btn_configuraciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_configuraciones.Location = new System.Drawing.Point(4, 386);
            this.btn_configuraciones.Name = "btn_configuraciones";
            this.btn_configuraciones.Size = new System.Drawing.Size(189, 56);
            this.btn_configuraciones.TabIndex = 3;
            this.btn_configuraciones.Text = "   Configuraciónes";
            this.btn_configuraciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_configuraciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_configuraciones.UseVisualStyleBackColor = true;
            this.btn_configuraciones.Click += new System.EventHandler(this.btn_configuraciones_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.ForeColor = System.Drawing.Color.White;
            this.btn_reportes.Image = ((System.Drawing.Image)(resources.GetObject("btn_reportes.Image")));
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Location = new System.Drawing.Point(4, 266);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(177, 56);
            this.btn_reportes.TabIndex = 2;
            this.btn_reportes.Text = "   Reportes";
            this.btn_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // btn_procesos
            // 
            this.btn_procesos.FlatAppearance.BorderSize = 0;
            this.btn_procesos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_procesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_procesos.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procesos.ForeColor = System.Drawing.Color.White;
            this.btn_procesos.Image = ((System.Drawing.Image)(resources.GetObject("btn_procesos.Image")));
            this.btn_procesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_procesos.Location = new System.Drawing.Point(4, 206);
            this.btn_procesos.Name = "btn_procesos";
            this.btn_procesos.Size = new System.Drawing.Size(177, 56);
            this.btn_procesos.TabIndex = 1;
            this.btn_procesos.Text = "   Procesos";
            this.btn_procesos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_procesos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_procesos.UseVisualStyleBackColor = true;
            this.btn_procesos.Click += new System.EventHandler(this.btn_procesos_Click);
            // 
            // btn_Mantenimiento
            // 
            this.btn_Mantenimiento.FlatAppearance.BorderSize = 0;
            this.btn_Mantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mantenimiento.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mantenimiento.ForeColor = System.Drawing.Color.White;
            this.btn_Mantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mantenimiento.Image")));
            this.btn_Mantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Mantenimiento.Location = new System.Drawing.Point(4, 146);
            this.btn_Mantenimiento.Name = "btn_Mantenimiento";
            this.btn_Mantenimiento.Size = new System.Drawing.Size(189, 56);
            this.btn_Mantenimiento.TabIndex = 0;
            this.btn_Mantenimiento.Text = "   Mantenimientos";
            this.btn_Mantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Mantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Mantenimiento.UseVisualStyleBackColor = true;
            this.btn_Mantenimiento.Click += new System.EventHandler(this.btn_Mantenimiento_Click);
            // 
            // pn_matenimientos
            // 
            this.pn_matenimientos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pn_matenimientos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_matenimientos.Controls.Add(this.btn_cliente);
            this.pn_matenimientos.Controls.Add(this.btn_usuario);
            this.pn_matenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_matenimientos.Location = new System.Drawing.Point(196, 0);
            this.pn_matenimientos.Name = "pn_matenimientos";
            this.pn_matenimientos.Size = new System.Drawing.Size(1105, 48);
            this.pn_matenimientos.TabIndex = 2;
            this.pn_matenimientos.Visible = false;
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.ForeColor = System.Drawing.Color.Black;
            this.btn_cliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_cliente.Image")));
            this.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cliente.Location = new System.Drawing.Point(150, 2);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(145, 42);
            this.btn_cliente.TabIndex = 3;
            this.btn_cliente.Text = " Clientes";
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_usuario
            // 
            this.btn_usuario.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_usuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuario.ForeColor = System.Drawing.Color.Black;
            this.btn_usuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_usuario.Image")));
            this.btn_usuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_usuario.Location = new System.Drawing.Point(3, 2);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(145, 42);
            this.btn_usuario.TabIndex = 2;
            this.btn_usuario.Text = "   Usuarios";
            this.btn_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_usuario.UseVisualStyleBackColor = false;
            this.btn_usuario.Click += new System.EventHandler(this.btn_usuario_Click);
            // 
            // pn_procesos
            // 
            this.pn_procesos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pn_procesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_procesos.Controls.Add(this.btn_anular_recibo);
            this.pn_procesos.Controls.Add(this.btn_cuadre);
            this.pn_procesos.Controls.Add(this.btn_cxc);
            this.pn_procesos.Controls.Add(this.btn_facturacion);
            this.pn_procesos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_procesos.Location = new System.Drawing.Point(196, 48);
            this.pn_procesos.Name = "pn_procesos";
            this.pn_procesos.Size = new System.Drawing.Size(1105, 48);
            this.pn_procesos.TabIndex = 3;
            this.pn_procesos.Visible = false;
            // 
            // btn_anular_recibo
            // 
            this.btn_anular_recibo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_anular_recibo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_anular_recibo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_anular_recibo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_anular_recibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anular_recibo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anular_recibo.ForeColor = System.Drawing.Color.Black;
            this.btn_anular_recibo.Image = ((System.Drawing.Image)(resources.GetObject("btn_anular_recibo.Image")));
            this.btn_anular_recibo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_anular_recibo.Location = new System.Drawing.Point(444, 2);
            this.btn_anular_recibo.Name = "btn_anular_recibo";
            this.btn_anular_recibo.Size = new System.Drawing.Size(145, 42);
            this.btn_anular_recibo.TabIndex = 13;
            this.btn_anular_recibo.Text = " Anular Recibos";
            this.btn_anular_recibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_anular_recibo.UseVisualStyleBackColor = false;
            this.btn_anular_recibo.Click += new System.EventHandler(this.btn_anular_recibo_Click);
            // 
            // btn_cuadre
            // 
            this.btn_cuadre.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_cuadre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cuadre.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cuadre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cuadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cuadre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cuadre.ForeColor = System.Drawing.Color.Black;
            this.btn_cuadre.Image = ((System.Drawing.Image)(resources.GetObject("btn_cuadre.Image")));
            this.btn_cuadre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cuadre.Location = new System.Drawing.Point(297, 2);
            this.btn_cuadre.Name = "btn_cuadre";
            this.btn_cuadre.Size = new System.Drawing.Size(145, 42);
            this.btn_cuadre.TabIndex = 10;
            this.btn_cuadre.Text = "Cuadre";
            this.btn_cuadre.UseVisualStyleBackColor = false;
            this.btn_cuadre.Click += new System.EventHandler(this.btn_cuadre_Click);
            // 
            // btn_cxc
            // 
            this.btn_cxc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_cxc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cxc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cxc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cxc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cxc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cxc.ForeColor = System.Drawing.Color.Black;
            this.btn_cxc.Image = ((System.Drawing.Image)(resources.GetObject("btn_cxc.Image")));
            this.btn_cxc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cxc.Location = new System.Drawing.Point(150, 2);
            this.btn_cxc.Name = "btn_cxc";
            this.btn_cxc.Size = new System.Drawing.Size(145, 42);
            this.btn_cxc.TabIndex = 9;
            this.btn_cxc.Text = " CXC";
            this.btn_cxc.UseVisualStyleBackColor = false;
            this.btn_cxc.Click += new System.EventHandler(this.btn_cxc_Click);
            // 
            // btn_facturacion
            // 
            this.btn_facturacion.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_facturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_facturacion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_facturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_facturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facturacion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturacion.ForeColor = System.Drawing.Color.Black;
            this.btn_facturacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_facturacion.Image")));
            this.btn_facturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_facturacion.Location = new System.Drawing.Point(3, 2);
            this.btn_facturacion.Name = "btn_facturacion";
            this.btn_facturacion.Size = new System.Drawing.Size(145, 42);
            this.btn_facturacion.TabIndex = 1;
            this.btn_facturacion.Text = "     Préstamos";
            this.btn_facturacion.UseVisualStyleBackColor = false;
            this.btn_facturacion.Click += new System.EventHandler(this.btn_facturacion_Click);
            // 
            // pn_configuraciones
            // 
            this.pn_configuraciones.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pn_configuraciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_configuraciones.Controls.Add(this.btn_permiso);
            this.pn_configuraciones.Controls.Add(this.btn_empresa);
            this.pn_configuraciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_configuraciones.Location = new System.Drawing.Point(196, 96);
            this.pn_configuraciones.Name = "pn_configuraciones";
            this.pn_configuraciones.Size = new System.Drawing.Size(1105, 48);
            this.pn_configuraciones.TabIndex = 7;
            this.pn_configuraciones.Visible = false;
            // 
            // btn_permiso
            // 
            this.btn_permiso.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_permiso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_permiso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_permiso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_permiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_permiso.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_permiso.ForeColor = System.Drawing.Color.Black;
            this.btn_permiso.Image = ((System.Drawing.Image)(resources.GetObject("btn_permiso.Image")));
            this.btn_permiso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_permiso.Location = new System.Drawing.Point(150, 2);
            this.btn_permiso.Name = "btn_permiso";
            this.btn_permiso.Size = new System.Drawing.Size(145, 42);
            this.btn_permiso.TabIndex = 22;
            this.btn_permiso.Text = "Permisos";
            this.btn_permiso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_permiso.UseVisualStyleBackColor = false;
            this.btn_permiso.Click += new System.EventHandler(this.btn_permiso_Click);
            // 
            // btn_empresa
            // 
            this.btn_empresa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_empresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_empresa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_empresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empresa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empresa.ForeColor = System.Drawing.Color.Black;
            this.btn_empresa.Image = ((System.Drawing.Image)(resources.GetObject("btn_empresa.Image")));
            this.btn_empresa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_empresa.Location = new System.Drawing.Point(3, 2);
            this.btn_empresa.Name = "btn_empresa";
            this.btn_empresa.Size = new System.Drawing.Size(145, 42);
            this.btn_empresa.TabIndex = 2;
            this.btn_empresa.Text = "Empresa";
            this.btn_empresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_empresa.UseVisualStyleBackColor = false;
            this.btn_empresa.Click += new System.EventHandler(this.btn_empresa_Click);
            // 
            // pn_reporte
            // 
            this.pn_reporte.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pn_reporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_reporte.Controls.Add(this.btn_rep_historial);
            this.pn_reporte.Controls.Add(this.btn_rep_reimprimir_recibos);
            this.pn_reporte.Controls.Add(this.btn_rep_cuadre);
            this.pn_reporte.Controls.Add(this.btn_rep_cobros_realizados);
            this.pn_reporte.Controls.Add(this.btn_rep_facturas);
            this.pn_reporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_reporte.Location = new System.Drawing.Point(196, 144);
            this.pn_reporte.Name = "pn_reporte";
            this.pn_reporte.Size = new System.Drawing.Size(1105, 48);
            this.pn_reporte.TabIndex = 9;
            this.pn_reporte.Visible = false;
            // 
            // btn_rep_historial
            // 
            this.btn_rep_historial.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_rep_historial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rep_historial.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_rep_historial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_rep_historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rep_historial.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rep_historial.ForeColor = System.Drawing.Color.Black;
            this.btn_rep_historial.Image = ((System.Drawing.Image)(resources.GetObject("btn_rep_historial.Image")));
            this.btn_rep_historial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rep_historial.Location = new System.Drawing.Point(629, 2);
            this.btn_rep_historial.Name = "btn_rep_historial";
            this.btn_rep_historial.Size = new System.Drawing.Size(167, 42);
            this.btn_rep_historial.TabIndex = 8;
            this.btn_rep_historial.Text = "Historial de Pagos";
            this.btn_rep_historial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_rep_historial.UseVisualStyleBackColor = false;
            this.btn_rep_historial.Click += new System.EventHandler(this.btn_rep_historial_Click);
            // 
            // btn_rep_reimprimir_recibos
            // 
            this.btn_rep_reimprimir_recibos.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_rep_reimprimir_recibos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rep_reimprimir_recibos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_rep_reimprimir_recibos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_rep_reimprimir_recibos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rep_reimprimir_recibos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rep_reimprimir_recibos.ForeColor = System.Drawing.Color.Black;
            this.btn_rep_reimprimir_recibos.Image = ((System.Drawing.Image)(resources.GetObject("btn_rep_reimprimir_recibos.Image")));
            this.btn_rep_reimprimir_recibos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rep_reimprimir_recibos.Location = new System.Drawing.Point(460, 2);
            this.btn_rep_reimprimir_recibos.Name = "btn_rep_reimprimir_recibos";
            this.btn_rep_reimprimir_recibos.Size = new System.Drawing.Size(167, 42);
            this.btn_rep_reimprimir_recibos.TabIndex = 7;
            this.btn_rep_reimprimir_recibos.Text = "Reimprimir Recibos";
            this.btn_rep_reimprimir_recibos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_rep_reimprimir_recibos.UseVisualStyleBackColor = false;
            this.btn_rep_reimprimir_recibos.Click += new System.EventHandler(this.btn_rep_reimprimir_recibos_Click);
            // 
            // btn_rep_cuadre
            // 
            this.btn_rep_cuadre.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_rep_cuadre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rep_cuadre.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_rep_cuadre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_rep_cuadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rep_cuadre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rep_cuadre.ForeColor = System.Drawing.Color.Black;
            this.btn_rep_cuadre.Image = ((System.Drawing.Image)(resources.GetObject("btn_rep_cuadre.Image")));
            this.btn_rep_cuadre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rep_cuadre.Location = new System.Drawing.Point(313, 2);
            this.btn_rep_cuadre.Name = "btn_rep_cuadre";
            this.btn_rep_cuadre.Size = new System.Drawing.Size(145, 42);
            this.btn_rep_cuadre.TabIndex = 5;
            this.btn_rep_cuadre.Text = "Cuadre Diario";
            this.btn_rep_cuadre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_rep_cuadre.UseVisualStyleBackColor = false;
            this.btn_rep_cuadre.Click += new System.EventHandler(this.btn_rep_cuadre_Click);
            // 
            // btn_rep_cobros_realizados
            // 
            this.btn_rep_cobros_realizados.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_rep_cobros_realizados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rep_cobros_realizados.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_rep_cobros_realizados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_rep_cobros_realizados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rep_cobros_realizados.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rep_cobros_realizados.ForeColor = System.Drawing.Color.Black;
            this.btn_rep_cobros_realizados.Image = ((System.Drawing.Image)(resources.GetObject("btn_rep_cobros_realizados.Image")));
            this.btn_rep_cobros_realizados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rep_cobros_realizados.Location = new System.Drawing.Point(150, 2);
            this.btn_rep_cobros_realizados.Name = "btn_rep_cobros_realizados";
            this.btn_rep_cobros_realizados.Size = new System.Drawing.Size(161, 42);
            this.btn_rep_cobros_realizados.TabIndex = 4;
            this.btn_rep_cobros_realizados.Text = "Cobros Realizados";
            this.btn_rep_cobros_realizados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_rep_cobros_realizados.UseVisualStyleBackColor = false;
            this.btn_rep_cobros_realizados.Click += new System.EventHandler(this.btn_rep_cobros_realizados_Click);
            // 
            // btn_rep_facturas
            // 
            this.btn_rep_facturas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_rep_facturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rep_facturas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_rep_facturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_rep_facturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rep_facturas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rep_facturas.ForeColor = System.Drawing.Color.Black;
            this.btn_rep_facturas.Image = ((System.Drawing.Image)(resources.GetObject("btn_rep_facturas.Image")));
            this.btn_rep_facturas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rep_facturas.Location = new System.Drawing.Point(3, 2);
            this.btn_rep_facturas.Name = "btn_rep_facturas";
            this.btn_rep_facturas.Size = new System.Drawing.Size(145, 42);
            this.btn_rep_facturas.TabIndex = 3;
            this.btn_rep_facturas.Text = "Préstamos";
            this.btn_rep_facturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_rep_facturas.UseVisualStyleBackColor = false;
            this.btn_rep_facturas.Click += new System.EventHandler(this.btn_rep_facturas_Click);
            // 
            // pn_consultas
            // 
            this.pn_consultas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pn_consultas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_consultas.Controls.Add(this.btn_facturas_no_activas);
            this.pn_consultas.Controls.Add(this.btn_recibos_anulados);
            this.pn_consultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_consultas.Location = new System.Drawing.Point(196, 192);
            this.pn_consultas.Name = "pn_consultas";
            this.pn_consultas.Size = new System.Drawing.Size(1105, 48);
            this.pn_consultas.TabIndex = 11;
            this.pn_consultas.Visible = false;
            // 
            // btn_facturas_no_activas
            // 
            this.btn_facturas_no_activas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_facturas_no_activas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_facturas_no_activas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_facturas_no_activas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_facturas_no_activas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facturas_no_activas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturas_no_activas.ForeColor = System.Drawing.Color.Black;
            this.btn_facturas_no_activas.Image = ((System.Drawing.Image)(resources.GetObject("btn_facturas_no_activas.Image")));
            this.btn_facturas_no_activas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_facturas_no_activas.Location = new System.Drawing.Point(172, 2);
            this.btn_facturas_no_activas.Name = "btn_facturas_no_activas";
            this.btn_facturas_no_activas.Size = new System.Drawing.Size(175, 42);
            this.btn_facturas_no_activas.TabIndex = 4;
            this.btn_facturas_no_activas.Text = " Facturas No Activas";
            this.btn_facturas_no_activas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_facturas_no_activas.UseVisualStyleBackColor = false;
            this.btn_facturas_no_activas.Click += new System.EventHandler(this.btn_facturas_no_activas_Click);
            // 
            // btn_recibos_anulados
            // 
            this.btn_recibos_anulados.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_recibos_anulados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_recibos_anulados.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_recibos_anulados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_recibos_anulados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recibos_anulados.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recibos_anulados.ForeColor = System.Drawing.Color.Black;
            this.btn_recibos_anulados.Image = ((System.Drawing.Image)(resources.GetObject("btn_recibos_anulados.Image")));
            this.btn_recibos_anulados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_recibos_anulados.Location = new System.Drawing.Point(3, 2);
            this.btn_recibos_anulados.Name = "btn_recibos_anulados";
            this.btn_recibos_anulados.Size = new System.Drawing.Size(167, 42);
            this.btn_recibos_anulados.TabIndex = 2;
            this.btn_recibos_anulados.Text = " Recibos Anulados";
            this.btn_recibos_anulados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_recibos_anulados.UseVisualStyleBackColor = false;
            this.btn_recibos_anulados.Click += new System.EventHandler(this.btn_recibos_anulados_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JSYS.Properties.Resources.ventas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1301, 560);
            this.Controls.Add(this.pn_consultas);
            this.Controls.Add(this.pn_reporte);
            this.Controls.Add(this.pn_configuraciones);
            this.Controls.Add(this.pn_procesos);
            this.Controls.Add(this.pn_matenimientos);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Frm_Menu";
            this.Text = "Pantalla Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Menu_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_matenimientos.ResumeLayout(false);
            this.pn_procesos.ResumeLayout(false);
            this.pn_configuraciones.ResumeLayout(false);
            this.pn_reporte.ResumeLayout(false);
            this.pn_consultas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Mantenimiento;
        private System.Windows.Forms.Button btn_procesos;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Button btn_configuraciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pn_matenimientos;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_usuario;
        private System.Windows.Forms.Panel pn_procesos;
        private System.Windows.Forms.Button btn_anular_recibo;
        private System.Windows.Forms.Button btn_cuadre;
        private System.Windows.Forms.Button btn_cxc;
        private System.Windows.Forms.Button btn_facturacion;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Panel pn_configuraciones;
        private System.Windows.Forms.Button btn_empresa;
        private System.Windows.Forms.Panel pn_reporte;
        private System.Windows.Forms.Button btn_rep_cuadre;
        private System.Windows.Forms.Button btn_rep_cobros_realizados;
        private System.Windows.Forms.Button btn_rep_facturas;
        private System.Windows.Forms.Button btn_rep_reimprimir_recibos;
        private System.Windows.Forms.Button btn_consultas;
        private System.Windows.Forms.Panel pn_consultas;
        private System.Windows.Forms.Button btn_recibos_anulados;
        private System.Windows.Forms.Button btn_facturas_no_activas;
        private System.Windows.Forms.Button btn_permiso;
        private System.Windows.Forms.Button btn_rep_historial;
    }
}