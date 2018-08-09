namespace JSYS.Formularios
{
    partial class Frm_Rep_Facturas
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ch_incluir_fechas = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_desde = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_hasta = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.cb_cobrador = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cb_numero_loteria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_contrato = new System.Windows.Forms.TextBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ch_incluir_fechas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dt_desde);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dt_hasta);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.cb_cliente);
            this.groupBox1.Controls.Add(this.cb_cobrador);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.cb_numero_loteria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_contrato);
            this.groupBox1.Controls.Add(this.cb_estado);
            this.groupBox1.Location = new System.Drawing.Point(116, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 162);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // ch_incluir_fechas
            // 
            this.ch_incluir_fechas.AutoSize = true;
            this.ch_incluir_fechas.Location = new System.Drawing.Point(388, 111);
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
            this.label4.Location = new System.Drawing.Point(234, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 50;
            this.label4.Text = "Hasta";
            // 
            // dt_desde
            // 
            this.dt_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_desde.Location = new System.Drawing.Point(90, 108);
            this.dt_desde.Name = "dt_desde";
            this.dt_desde.Size = new System.Drawing.Size(103, 22);
            this.dt_desde.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 14);
            this.label8.TabIndex = 48;
            this.label8.Text = "Desde";
            // 
            // dt_hasta
            // 
            this.dt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_hasta.Location = new System.Drawing.Point(279, 108);
            this.dt_hasta.Name = "dt_hasta";
            this.dt_hasta.Size = new System.Drawing.Size(103, 22);
            this.dt_hasta.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::JSYS.Properties.Resources.Search_16x16;
            this.button1.Location = new System.Drawing.Point(388, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 24);
            this.button1.TabIndex = 46;
            this.button1.Text = "Consultar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(38, 62);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 14);
            this.label23.TabIndex = 45;
            this.label23.Text = "Cliente";
            // 
            // cb_cliente
            // 
            this.cb_cliente.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.cb_cliente.Location = new System.Drawing.Point(90, 58);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(296, 22);
            this.cb_cliente.TabIndex = 44;
            // 
            // cb_cobrador
            // 
            this.cb_cobrador.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_cobrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cobrador.FormattingEnabled = true;
            this.cb_cobrador.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.cb_cobrador.Location = new System.Drawing.Point(90, 83);
            this.cb_cobrador.Name = "cb_cobrador";
            this.cb_cobrador.Size = new System.Drawing.Size(103, 22);
            this.cb_cobrador.TabIndex = 41;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(23, 87);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 14);
            this.label31.TabIndex = 43;
            this.label31.Text = "Cobrador";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(356, 37);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 14);
            this.label25.TabIndex = 23;
            this.label25.Text = "No. Loteria";
            // 
            // cb_numero_loteria
            // 
            this.cb_numero_loteria.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_numero_loteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_numero_loteria.FormattingEnabled = true;
            this.cb_numero_loteria.Items.AddRange(new object[] {
            "",
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.cb_numero_loteria.Location = new System.Drawing.Point(433, 33);
            this.cb_numero_loteria.Name = "cb_numero_loteria";
            this.cb_numero_loteria.Size = new System.Drawing.Size(49, 22);
            this.cb_numero_loteria.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "No Contrato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(227, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Estado";
            // 
            // txt_contrato
            // 
            this.txt_contrato.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_contrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_contrato.Location = new System.Drawing.Point(90, 34);
            this.txt_contrato.MaxLength = 20;
            this.txt_contrato.Name = "txt_contrato";
            this.txt_contrato.Size = new System.Drawing.Size(90, 22);
            this.txt_contrato.TabIndex = 0;
            // 
            // cb_estado
            // 
            this.cb_estado.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.cb_estado.Location = new System.Drawing.Point(279, 83);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(203, 22);
            this.cb_estado.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_reporte);
            this.groupBox2.Location = new System.Drawing.Point(10, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 162);
            this.groupBox2.TabIndex = 30;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Txt_ID);
            this.panel1.Controls.Add(this.Lbl_Titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 41);
            this.panel1.TabIndex = 28;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ID.Location = new System.Drawing.Point(547, 13);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(70, 22);
            this.Txt_ID.TabIndex = 9;
            this.Txt_ID.Visible = false;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Titulo.Location = new System.Drawing.Point(9, 10);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(159, 18);
            this.Lbl_Titulo.TabIndex = 5;
            this.Lbl_Titulo.Text = "Reporte de Facturas";
            // 
            // Frm_Rep_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(630, 222);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Rep_Facturas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_contrato;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cb_numero_loteria;
        private System.Windows.Forms.ComboBox cb_cobrador;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.CheckBox ch_incluir_fechas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_desde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_hasta;
    }
}
