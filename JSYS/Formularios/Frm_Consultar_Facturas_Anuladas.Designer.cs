namespace JSYS.Formularios
{
    partial class Frm_Consultar_Facturas_Anuladas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_observacion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DG = new System.Windows.Forms.DataGridView();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO_IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creado_Por = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_CAMBIO_ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_buscar = new System.Windows.Forms.ComboBox();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_observacion
            // 
            this.txt_observacion.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_observacion.Enabled = false;
            this.txt_observacion.Location = new System.Drawing.Point(12, 412);
            this.txt_observacion.Multiline = true;
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(912, 89);
            this.txt_observacion.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DG);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cb_buscar);
            this.groupBox1.Controls.Add(this.Txt_Buscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 356);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // DG
            // 
            this.DG.AllowUserToAddRows = false;
            this.DG.AllowUserToDeleteRows = false;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CLIENTE,
            this.REFERENCIA,
            this.NOMBRE,
            this.DIRECCION,
            this.ID_TIPO_IDENTIFICACION,
            this.DESCRIPCION,
            this.IDENTIFICACION,
            this.ESTADO,
            this.Creado_Por,
            this.FECHA_CAMBIO_ESTADO,
            this.NOTA});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG.DefaultCellStyle = dataGridViewCellStyle6;
            this.DG.Location = new System.Drawing.Point(6, 45);
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.RowHeadersVisible = false;
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(919, 301);
            this.DG.TabIndex = 21;
            this.DG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellClick);
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_FACTURA";
            this.ID_CLIENTE.HeaderText = "No";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.ReadOnly = true;
            this.ID_CLIENTE.Width = 40;
            // 
            // REFERENCIA
            // 
            this.REFERENCIA.DataPropertyName = "NUMERO_CONTRATO";
            this.REFERENCIA.HeaderText = "No Contrato";
            this.REFERENCIA.Name = "REFERENCIA";
            this.REFERENCIA.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "FECHA";
            this.NOMBRE.HeaderText = "Fecha";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 80;
            // 
            // DIRECCION
            // 
            this.DIRECCION.DataPropertyName = "CLIENTE";
            this.DIRECCION.HeaderText = "Cliente";
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.ReadOnly = true;
            this.DIRECCION.Width = 200;
            // 
            // ID_TIPO_IDENTIFICACION
            // 
            this.ID_TIPO_IDENTIFICACION.DataPropertyName = "MONTO_TOTAL";
            this.ID_TIPO_IDENTIFICACION.HeaderText = "Total";
            this.ID_TIPO_IDENTIFICACION.Name = "ID_TIPO_IDENTIFICACION";
            this.ID_TIPO_IDENTIFICACION.ReadOnly = true;
            this.ID_TIPO_IDENTIFICACION.Width = 90;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "MONTO_PAGADO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.DESCRIPCION.DefaultCellStyle = dataGridViewCellStyle4;
            this.DESCRIPCION.HeaderText = "Pagado";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 90;
            // 
            // IDENTIFICACION
            // 
            this.IDENTIFICACION.DataPropertyName = "MONTO_PENDIENTE";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.IDENTIFICACION.DefaultCellStyle = dataGridViewCellStyle5;
            this.IDENTIFICACION.HeaderText = "Pendiente";
            this.IDENTIFICACION.Name = "IDENTIFICACION";
            this.IDENTIFICACION.ReadOnly = true;
            this.IDENTIFICACION.Width = 90;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "Estado";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // Creado_Por
            // 
            this.Creado_Por.DataPropertyName = "CAMBIO_ESTADO_POR";
            this.Creado_Por.HeaderText = "Cambiado_Por";
            this.Creado_Por.Name = "Creado_Por";
            this.Creado_Por.ReadOnly = true;
            // 
            // FECHA_CAMBIO_ESTADO
            // 
            this.FECHA_CAMBIO_ESTADO.DataPropertyName = "FECHA_CREADO";
            this.FECHA_CAMBIO_ESTADO.HeaderText = "Fecha Cambio";
            this.FECHA_CAMBIO_ESTADO.Name = "FECHA_CAMBIO_ESTADO";
            this.FECHA_CAMBIO_ESTADO.ReadOnly = true;
            this.FECHA_CAMBIO_ESTADO.Width = 110;
            // 
            // NOTA
            // 
            this.NOTA.DataPropertyName = "NOTA_CAMBIO_ESTADO";
            this.NOTA.HeaderText = "NOTA";
            this.NOTA.Name = "NOTA";
            this.NOTA.ReadOnly = true;
            this.NOTA.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::JSYS.Properties.Resources.Search_16x16;
            this.button1.Location = new System.Drawing.Point(469, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 24);
            this.button1.TabIndex = 20;
            this.button1.Text = "Consultar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_buscar
            // 
            this.cb_buscar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_buscar.FormattingEnabled = true;
            this.cb_buscar.Items.AddRange(new object[] {
            "",
            "No. Contrato",
            "Cliente",
            "Cedula",
            "Cobrador",
            "Estado"});
            this.cb_buscar.Location = new System.Drawing.Point(69, 18);
            this.cb_buscar.Name = "cb_buscar";
            this.cb_buscar.Size = new System.Drawing.Size(141, 22);
            this.cb_buscar.TabIndex = 6;
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Txt_Buscar.Location = new System.Drawing.Point(216, 18);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(250, 22);
            this.Txt_Buscar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Consultar Facturas No Activa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 46);
            this.panel1.TabIndex = 27;
            // 
            // Frm_Consultar_Facturas_Anuladas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(938, 513);
            this.Controls.Add(this.txt_observacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Consultar_Facturas_Anuladas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_observacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_buscar;
        private System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO_IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creado_Por;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CAMBIO_ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA;
    }
}
