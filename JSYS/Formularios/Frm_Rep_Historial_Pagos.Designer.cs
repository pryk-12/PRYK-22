namespace JSYS.Formularios
{
    partial class Frm_Rep_Historial_Pagos
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
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_facturas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.Lbl_Titulo.Size = new System.Drawing.Size(208, 18);
            this.Lbl_Titulo.TabIndex = 5;
            this.Lbl_Titulo.Text = "Reporte Historial de Pagos";
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
            this.panel1.Size = new System.Drawing.Size(528, 41);
            this.panel1.TabIndex = 34;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ID.Location = new System.Drawing.Point(445, 13);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(70, 22);
            this.Txt_ID.TabIndex = 9;
            this.Txt_ID.Visible = false;
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
            this.cb_cliente.Location = new System.Drawing.Point(74, 46);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(292, 22);
            this.cb_cliente.TabIndex = 41;
            this.cb_cliente.SelectedIndexChanged += new System.EventHandler(this.cb_cliente_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_reporte);
            this.groupBox2.Location = new System.Drawing.Point(11, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 107);
            this.groupBox2.TabIndex = 36;
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
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(22, 50);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(49, 14);
            this.label31.TabIndex = 43;
            this.label31.Text = "Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_facturas);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cb_cliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Location = new System.Drawing.Point(117, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 107);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // cb_facturas
            // 
            this.cb_facturas.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_facturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_facturas.FormattingEnabled = true;
            this.cb_facturas.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.cb_facturas.Location = new System.Drawing.Point(74, 71);
            this.cb_facturas.Name = "cb_facturas";
            this.cb_facturas.Size = new System.Drawing.Size(69, 22);
            this.cb_facturas.TabIndex = 44;
            this.cb_facturas.SelectedIndexChanged += new System.EventHandler(this.cb_facturas_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::JSYS.Properties.Resources.Search_16x16;
            this.button1.Location = new System.Drawing.Point(74, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 24);
            this.button1.TabIndex = 48;
            this.button1.Text = "Consultar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 45;
            this.label1.Text = "Contrato";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_Rep_Historial_Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(528, 169);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Rep_Historial_Pagos";
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
        private System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cb_facturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
