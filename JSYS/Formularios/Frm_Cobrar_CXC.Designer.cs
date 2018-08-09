namespace JSYS.Formularios
{
    partial class Frm_Cobrar_CXC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.dg_detalle_cuotas = new System.Windows.Forms.DataGridView();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detalle_cuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Location = new System.Drawing.Point(8, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 402);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Image = global::JSYS.Properties.Resources.File_Save_WF;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.Location = new System.Drawing.Point(9, 15);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(71, 59);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
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
            this.panel1.Size = new System.Drawing.Size(650, 41);
            this.panel1.TabIndex = 26;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ID.Location = new System.Drawing.Point(567, 13);
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
            this.Lbl_Titulo.Size = new System.Drawing.Size(128, 18);
            this.Lbl_Titulo.TabIndex = 5;
            this.Lbl_Titulo.Text = "Cobrar Cuota(s)";
            // 
            // dg_detalle_cuotas
            // 
            this.dg_detalle_cuotas.AllowUserToAddRows = false;
            this.dg_detalle_cuotas.AllowUserToDeleteRows = false;
            this.dg_detalle_cuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_detalle_cuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.sel,
            this.pag,
            this.DIFERENCIA});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_detalle_cuotas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dg_detalle_cuotas.Location = new System.Drawing.Point(109, 77);
            this.dg_detalle_cuotas.Name = "dg_detalle_cuotas";
            this.dg_detalle_cuotas.RowHeadersVisible = false;
            this.dg_detalle_cuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_detalle_cuotas.Size = new System.Drawing.Size(373, 368);
            this.dg_detalle_cuotas.TabIndex = 188;
            this.dg_detalle_cuotas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dg_detalle_cuotas_EditingControlShowing);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Image = global::JSYS.Properties.Resources.if_calculator_17218;
            this.btn_calcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_calcular.Location = new System.Drawing.Point(502, 271);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(133, 60);
            this.btn_calcular.TabIndex = 191;
            this.btn_calcular.Text = "Calcular Monto";
            this.btn_calcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_calcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar.Image = global::JSYS.Properties.Resources.Delete_16x16;
            this.btn_quitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quitar.Location = new System.Drawing.Point(234, 48);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(124, 27);
            this.btn_quitar.TabIndex = 190;
            this.btn_quitar.Text = "Quitar Selección";
            this.btn_quitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar.Image = global::JSYS.Properties.Resources.Add_16x16;
            this.btn_seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_seleccionar.Location = new System.Drawing.Point(109, 48);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(124, 27);
            this.btn_seleccionar.TabIndex = 189;
            this.btn_seleccionar.Text = "Seleccionar Todo";
            this.btn_seleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(530, 423);
            this.txt_total.MaxLength = 25;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(105, 22);
            this.txt_total.TabIndex = 192;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(489, 427);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(38, 14);
            this.label27.TabIndex = 193;
            this.label27.Text = "Total";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NUMERO_CUOTA";
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FECHA";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MONTO_PENDIENTE";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "n2";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // sel
            // 
            this.sel.DataPropertyName = "SEL";
            this.sel.HeaderText = "Sel";
            this.sel.Name = "sel";
            this.sel.Width = 40;
            // 
            // pag
            // 
            this.pag.DataPropertyName = "A_PAGAR";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "n2";
            this.pag.DefaultCellStyle = dataGridViewCellStyle2;
            this.pag.HeaderText = "A Pagar";
            this.pag.Name = "pag";
            // 
            // DIFERENCIA
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            this.DIFERENCIA.DefaultCellStyle = dataGridViewCellStyle3;
            this.DIFERENCIA.HeaderText = "Diferencia";
            this.DIFERENCIA.Name = "DIFERENCIA";
            this.DIFERENCIA.ReadOnly = true;
            this.DIFERENCIA.Visible = false;
            // 
            // Frm_Cobrar_CXC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(650, 454);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.dg_detalle_cuotas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Frm_Cobrar_CXC";
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detalle_cuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.DataGridView dg_detalle_cuotas;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Button btn_calcular;
        public System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn pag;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIFERENCIA;
    }
}
