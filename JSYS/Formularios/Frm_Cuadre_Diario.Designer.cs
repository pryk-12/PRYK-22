namespace JSYS.Formularios
{
    partial class Frm_Cuadre_Diario
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_entregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_recibo_pagado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_recibo_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_recibo_anulado = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_valor_descuento = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.btn_entregar);
            this.groupBox2.Location = new System.Drawing.Point(8, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 206);
            this.groupBox2.TabIndex = 56;
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
            // btn_entregar
            // 
            this.btn_entregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_entregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_entregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_entregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_entregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entregar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entregar.ForeColor = System.Drawing.Color.White;
            this.btn_entregar.Image = global::JSYS.Properties.Resources.File_Save_WF;
            this.btn_entregar.Location = new System.Drawing.Point(8, 15);
            this.btn_entregar.Name = "btn_entregar";
            this.btn_entregar.Size = new System.Drawing.Size(71, 59);
            this.btn_entregar.TabIndex = 6;
            this.btn_entregar.Text = "Guardar";
            this.btn_entregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_entregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_entregar.UseVisualStyleBackColor = false;
            this.btn_entregar.Click += new System.EventHandler(this.btn_entregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 46);
            this.panel1.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cuadre Diario";
            // 
            // dt_fecha
            // 
            this.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha.Location = new System.Drawing.Point(284, 57);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(103, 22);
            this.dt_fecha.TabIndex = 58;
            this.dt_fecha.ValueChanged += new System.EventHandler(this.dt_fecha_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(169, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 14);
            this.label8.TabIndex = 57;
            this.label8.Text = "Fecha de Proceso";
            // 
            // txt_recibo_pagado
            // 
            this.txt_recibo_pagado.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_recibo_pagado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_recibo_pagado.Enabled = false;
            this.txt_recibo_pagado.Location = new System.Drawing.Point(118, 28);
            this.txt_recibo_pagado.MaxLength = 25;
            this.txt_recibo_pagado.Name = "txt_recibo_pagado";
            this.txt_recibo_pagado.Size = new System.Drawing.Size(113, 22);
            this.txt_recibo_pagado.TabIndex = 59;
            this.txt_recibo_pagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 60;
            this.label1.Text = "Pagado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_valor_descuento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_recibo_total);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_recibo_anulado);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_recibo_pagado);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(132, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 161);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagos de Recibos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Total";
            // 
            // txt_recibo_total
            // 
            this.txt_recibo_total.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_recibo_total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_recibo_total.Enabled = false;
            this.txt_recibo_total.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recibo_total.Location = new System.Drawing.Point(118, 122);
            this.txt_recibo_total.MaxLength = 25;
            this.txt_recibo_total.Name = "txt_recibo_total";
            this.txt_recibo_total.Size = new System.Drawing.Size(113, 24);
            this.txt_recibo_total.TabIndex = 63;
            this.txt_recibo_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 62;
            this.label3.Text = "Anulado";
            // 
            // txt_recibo_anulado
            // 
            this.txt_recibo_anulado.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_recibo_anulado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_recibo_anulado.Enabled = false;
            this.txt_recibo_anulado.Location = new System.Drawing.Point(118, 76);
            this.txt_recibo_anulado.MaxLength = 25;
            this.txt_recibo_anulado.Name = "txt_recibo_anulado";
            this.txt_recibo_anulado.Size = new System.Drawing.Size(113, 22);
            this.txt_recibo_anulado.TabIndex = 61;
            this.txt_recibo_anulado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(472, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 22);
            this.textBox1.TabIndex = 21;
            this.textBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 14);
            this.label4.TabIndex = 66;
            this.label4.Text = "Descuento";
            // 
            // txt_valor_descuento
            // 
            this.txt_valor_descuento.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_valor_descuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_valor_descuento.Enabled = false;
            this.txt_valor_descuento.Location = new System.Drawing.Point(118, 52);
            this.txt_valor_descuento.MaxLength = 25;
            this.txt_valor_descuento.Name = "txt_valor_descuento";
            this.txt_valor_descuento.Size = new System.Drawing.Size(113, 22);
            this.txt_valor_descuento.TabIndex = 65;
            this.txt_valor_descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Frm_Cuadre_Diario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(420, 275);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Cuadre_Diario";
            this.Load += new System.EventHandler(this.Frm_Cuadre_Diario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_entregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_recibo_pagado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_recibo_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_recibo_anulado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_valor_descuento;
    }
}
