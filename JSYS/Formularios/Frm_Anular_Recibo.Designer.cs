namespace JSYS.Formularios
{
    partial class Frm_Anular_Recibo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_observacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.cb_buscar = new System.Windows.Forms.ComboBox();
            this.cb_cobrador = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_desde = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_hasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_anular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DG = new System.Windows.Forms.DataGridView();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO_IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_observacion
            // 
            this.txt_observacion.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_observacion.Location = new System.Drawing.Point(100, 431);
            this.txt_observacion.MaxLength = 500;
            this.txt_observacion.Multiline = true;
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(731, 66);
            this.txt_observacion.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 14);
            this.label3.TabIndex = 51;
            this.label3.Text = "Observación ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_buscar);
            this.groupBox1.Controls.Add(this.cb_buscar);
            this.groupBox1.Controls.Add(this.cb_cobrador);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dt_desde);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dt_hasta);
            this.groupBox1.Location = new System.Drawing.Point(100, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 76);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::JSYS.Properties.Resources.Search_16x16;
            this.button1.Location = new System.Drawing.Point(297, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 51;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_buscar.Location = new System.Drawing.Point(23, 45);
            this.txt_buscar.MaxLength = 25;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(271, 22);
            this.txt_buscar.TabIndex = 50;
            this.txt_buscar.Visible = false;
            // 
            // cb_buscar
            // 
            this.cb_buscar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_buscar.FormattingEnabled = true;
            this.cb_buscar.Items.AddRange(new object[] {
            "",
            "Cobrador",
            "No. Recibo",
            "No. Contrato"});
            this.cb_buscar.Location = new System.Drawing.Point(98, 20);
            this.cb_buscar.Name = "cb_buscar";
            this.cb_buscar.Size = new System.Drawing.Size(196, 22);
            this.cb_buscar.TabIndex = 49;
            this.cb_buscar.SelectedIndexChanged += new System.EventHandler(this.cb_buscar_SelectedIndexChanged);
            // 
            // cb_cobrador
            // 
            this.cb_cobrador.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_cobrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cobrador.FormattingEnabled = true;
            this.cb_cobrador.Items.AddRange(new object[] {
            "",
            "Cobrador",
            "Numero Factura"});
            this.cb_cobrador.Location = new System.Drawing.Point(23, 45);
            this.cb_cobrador.Name = "cb_cobrador";
            this.cb_cobrador.Size = new System.Drawing.Size(271, 22);
            this.cb_cobrador.TabIndex = 47;
            this.cb_cobrador.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 41;
            this.label1.Text = "Buscar Por";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 46;
            this.label4.Text = "Hasta";
            // 
            // dt_desde
            // 
            this.dt_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_desde.Location = new System.Drawing.Point(540, 19);
            this.dt_desde.Name = "dt_desde";
            this.dt_desde.Size = new System.Drawing.Size(103, 22);
            this.dt_desde.TabIndex = 45;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::JSYS.Properties.Resources.Search_16x16;
            this.button2.Location = new System.Drawing.Point(646, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 48);
            this.button2.TabIndex = 42;
            this.button2.Text = "Buscar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(414, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 14);
            this.label8.TabIndex = 44;
            this.label8.Text = "Fecha Cobro Desde";
            // 
            // dt_hasta
            // 
            this.dt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_hasta.Location = new System.Drawing.Point(540, 42);
            this.dt_hasta.Name = "dt_hasta";
            this.dt_hasta.Size = new System.Drawing.Size(103, 22);
            this.dt_hasta.TabIndex = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.btn_anular);
            this.groupBox2.Location = new System.Drawing.Point(6, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 377);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(472, 28);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(93, 22);
            this.txt_id.TabIndex = 21;
            this.txt_id.Visible = false;
            // 
            // btn_anular
            // 
            this.btn_anular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_anular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_anular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_anular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_anular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anular.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anular.ForeColor = System.Drawing.Color.White;
            this.btn_anular.Image = global::JSYS.Properties.Resources.Money_Coin_02_WF;
            this.btn_anular.Location = new System.Drawing.Point(8, 15);
            this.btn_anular.Name = "btn_anular";
            this.btn_anular.Size = new System.Drawing.Size(71, 59);
            this.btn_anular.TabIndex = 6;
            this.btn_anular.Text = "Anular";
            this.btn_anular.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_anular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_anular.UseVisualStyleBackColor = false;
            this.btn_anular.Click += new System.EventHandler(this.btn_anular_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 46);
            this.panel1.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Anular Recibos";
            // 
            // DG
            // 
            this.DG.AllowUserToAddRows = false;
            this.DG.AllowUserToDeleteRows = false;
            this.DG.AllowUserToResizeColumns = false;
            this.DG.AllowUserToResizeRows = false;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CLIENTE,
            this.REFERENCIA,
            this.NOMBRE,
            this.DIRECCION,
            this.ID_TIPO_IDENTIFICACION,
            this.DESCRIPCION,
            this.SEL});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG.Location = new System.Drawing.Point(100, 130);
            this.DG.Name = "DG";
            this.DG.RowHeadersVisible = false;
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(731, 295);
            this.DG.TabIndex = 39;
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_RECIBO";
            this.ID_CLIENTE.HeaderText = "No. Recibo";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.ReadOnly = true;
            this.ID_CLIENTE.Width = 120;
            // 
            // REFERENCIA
            // 
            this.REFERENCIA.DataPropertyName = "FECHA_CREADO";
            this.REFERENCIA.HeaderText = "Fecha";
            this.REFERENCIA.Name = "REFERENCIA";
            this.REFERENCIA.ReadOnly = true;
            this.REFERENCIA.Width = 120;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "ID_FACTURA";
            this.NOMBRE.HeaderText = "No Factura";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 120;
            // 
            // DIRECCION
            // 
            this.DIRECCION.DataPropertyName = "CUOTA_COBRADA";
            this.DIRECCION.HeaderText = "No Cuota";
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.ReadOnly = true;
            this.DIRECCION.Width = 120;
            // 
            // ID_TIPO_IDENTIFICACION
            // 
            this.ID_TIPO_IDENTIFICACION.DataPropertyName = "VALOR_PAGADO";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.ID_TIPO_IDENTIFICACION.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID_TIPO_IDENTIFICACION.HeaderText = "Valor Pagado";
            this.ID_TIPO_IDENTIFICACION.Name = "ID_TIPO_IDENTIFICACION";
            this.ID_TIPO_IDENTIFICACION.ReadOnly = true;
            this.ID_TIPO_IDENTIFICACION.Width = 120;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "ESTADO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.DESCRIPCION.DefaultCellStyle = dataGridViewCellStyle2;
            this.DESCRIPCION.HeaderText = "Estado";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 80;
            // 
            // SEL
            // 
            this.SEL.DataPropertyName = "SEL";
            this.SEL.HeaderText = "Sel";
            this.SEL.Name = "SEL";
            this.SEL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SEL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SEL.Width = 40;
            // 
            // Frm_Anular_Recibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(841, 500);
            this.Controls.Add(this.txt_observacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DG);
            this.Name = "Frm_Anular_Recibo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_anular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_desde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_hasta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_cobrador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.TextBox txt_observacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO_IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SEL;
        private System.Windows.Forms.Button button1;
    }
}
