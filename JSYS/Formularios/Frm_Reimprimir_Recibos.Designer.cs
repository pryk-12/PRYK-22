namespace JSYS.Formularios
{
    partial class Frm_Reimprimir_Recibos
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.ch_incluir_fechas = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_desde = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_hasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_numero_recibo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_cobrador = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Titulo.Location = new System.Drawing.Point(9, 10);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(147, 18);
            this.Lbl_Titulo.TabIndex = 5;
            this.Lbl_Titulo.Text = "Reimprimir Recibo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Txt_ID);
            this.panel1.Controls.Add(this.Lbl_Titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 41);
            this.panel1.TabIndex = 31;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ID.Location = new System.Drawing.Point(499, 13);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(70, 22);
            this.Txt_ID.TabIndex = 9;
            this.Txt_ID.Visible = false;
            // 
            // ch_incluir_fechas
            // 
            this.ch_incluir_fechas.AutoSize = true;
            this.ch_incluir_fechas.Location = new System.Drawing.Point(346, 138);
            this.ch_incluir_fechas.Name = "ch_incluir_fechas";
            this.ch_incluir_fechas.Size = new System.Drawing.Size(99, 18);
            this.ch_incluir_fechas.TabIndex = 51;
            this.ch_incluir_fechas.Text = "Incluir Fechas";
            this.ch_incluir_fechas.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 50;
            this.label4.Text = "Hasta";
            // 
            // dt_desde
            // 
            this.dt_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_desde.Location = new System.Drawing.Point(81, 135);
            this.dt_desde.Name = "dt_desde";
            this.dt_desde.Size = new System.Drawing.Size(103, 22);
            this.dt_desde.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 14);
            this.label8.TabIndex = 48;
            this.label8.Text = "Desde";
            // 
            // dt_hasta
            // 
            this.dt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_hasta.Location = new System.Drawing.Point(236, 135);
            this.dt_hasta.Name = "dt_hasta";
            this.dt_hasta.Size = new System.Drawing.Size(103, 22);
            this.dt_hasta.TabIndex = 47;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_reporte);
            this.groupBox2.Location = new System.Drawing.Point(10, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 195);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // btn_reporte
            // 
            this.btn_reporte.Image = global::JSYS.Properties.Resources._1450119000_reports;
            this.btn_reporte.Location = new System.Drawing.Point(8, 14);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(82, 47);
            this.btn_reporte.TabIndex = 29;
            this.btn_reporte.Text = "Ver Reporte";
            this.btn_reporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 18;
            this.label3.Text = "No Recibo";
            // 
            // txt_numero_recibo
            // 
            this.txt_numero_recibo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_numero_recibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_numero_recibo.Location = new System.Drawing.Point(81, 35);
            this.txt_numero_recibo.MaxLength = 20;
            this.txt_numero_recibo.Name = "txt_numero_recibo";
            this.txt_numero_recibo.Size = new System.Drawing.Size(60, 22);
            this.txt_numero_recibo.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cb_cobrador);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_cliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_estado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ch_incluir_fechas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dt_desde);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dt_hasta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_numero_recibo);
            this.groupBox1.Location = new System.Drawing.Point(116, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 195);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // cb_estado
            // 
            this.cb_estado.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estado.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "",
            "Vigente",
            "Anulado"});
            this.cb_estado.Location = new System.Drawing.Point(81, 110);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(159, 22);
            this.cb_estado.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 54;
            this.label5.Text = "Estado";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::JSYS.Properties.Resources.Search_16x16;
            this.button1.Location = new System.Drawing.Point(144, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 24);
            this.button1.TabIndex = 52;
            this.button1.Text = "Consultar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cb_cliente
            // 
            this.cb_cliente.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Items.AddRange(new object[] {
            "",
            "Vigente",
            "Anulado"});
            this.cb_cliente.Location = new System.Drawing.Point(81, 60);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(258, 22);
            this.cb_cliente.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 56;
            this.label1.Text = "Cliente";
            // 
            // cb_cobrador
            // 
            this.cb_cobrador.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_cobrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cobrador.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cobrador.FormattingEnabled = true;
            this.cb_cobrador.Items.AddRange(new object[] {
            "",
            "Vigente",
            "Anulado"});
            this.cb_cobrador.Location = new System.Drawing.Point(81, 85);
            this.cb_cobrador.Name = "cb_cobrador";
            this.cb_cobrador.Size = new System.Drawing.Size(159, 22);
            this.cb_cobrador.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 58;
            this.label2.Text = "Cobrador";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::JSYS.Properties.Resources.Search_16x16;
            this.button2.Location = new System.Drawing.Point(342, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 24);
            this.button2.TabIndex = 59;
            this.button2.Text = "Consultar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_Reimprimir_Recibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(582, 259);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Reimprimir_Recibos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.CheckBox ch_incluir_fechas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_desde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_hasta;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txt_numero_recibo;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_cobrador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cb_cliente;
    }
}
