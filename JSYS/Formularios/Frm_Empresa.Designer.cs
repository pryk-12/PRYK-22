namespace JSYS.Formularios
{
    partial class Frm_Empresa
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_celular = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.MaskedTextBox();
            this.txt_numero_identificacion = new System.Windows.Forms.TextBox();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_tipo_identificacion = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_impresora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_eslogan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pagina_web = new System.Windows.Forms.TextBox();
            this.lbl_fax = new System.Windows.Forms.Label();
            this.txt_fax = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_borrar_imagen = new System.Windows.Forms.Button();
            this.btn_agregar_imagen = new System.Windows.Forms.Button();
            this.pb_imagen = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_editar);
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Location = new System.Drawing.Point(9, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 261);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Image = global::JSYS.Properties.Resources.File_Edit_WF;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_editar.Location = new System.Drawing.Point(8, 17);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(71, 59);
            this.btn_editar.TabIndex = 9;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_guardar.Enabled = false;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Image = global::JSYS.Properties.Resources.File_Save_WF;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.Location = new System.Drawing.Point(8, 82);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(71, 59);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 14);
            this.label9.TabIndex = 25;
            this.label9.Text = "E-Mail";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_email.Location = new System.Drawing.Point(94, 136);
            this.txt_email.MaxLength = 50;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(175, 22);
            this.txt_email.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(252, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 14);
            this.label8.TabIndex = 23;
            this.label8.Text = "Celular";
            // 
            // txt_celular
            // 
            this.txt_celular.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_celular.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celular.Location = new System.Drawing.Point(303, 112);
            this.txt_celular.Mask = "000-000-0000";
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(86, 22);
            this.txt_celular.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 14);
            this.label7.TabIndex = 21;
            this.label7.Text = "Teléfono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_telefono.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(94, 112);
            this.txt_telefono.Mask = "000-000-0000";
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(86, 22);
            this.txt_telefono.TabIndex = 4;
            // 
            // txt_numero_identificacion
            // 
            this.txt_numero_identificacion.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_numero_identificacion.Location = new System.Drawing.Point(209, 42);
            this.txt_numero_identificacion.MaxLength = 20;
            this.txt_numero_identificacion.Name = "txt_numero_identificacion";
            this.txt_numero_identificacion.Size = new System.Drawing.Size(180, 22);
            this.txt_numero_identificacion.TabIndex = 2;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ID.Location = new System.Drawing.Point(624, 13);
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
            this.Lbl_Titulo.Size = new System.Drawing.Size(152, 18);
            this.Lbl_Titulo.TabIndex = 5;
            this.Lbl_Titulo.Text = "Actualizar Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_nombre.Location = new System.Drawing.Point(94, 18);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(295, 22);
            this.txt_nombre.TabIndex = 0;
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_direccion.Location = new System.Drawing.Point(94, 66);
            this.txt_direccion.MaxLength = 500;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(295, 44);
            this.txt_direccion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo Identif.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dirección";
            // 
            // cb_tipo_identificacion
            // 
            this.cb_tipo_identificacion.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_tipo_identificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo_identificacion.FormattingEnabled = true;
            this.cb_tipo_identificacion.Location = new System.Drawing.Point(94, 42);
            this.cb_tipo_identificacion.Name = "cb_tipo_identificacion";
            this.cb_tipo_identificacion.Size = new System.Drawing.Size(113, 22);
            this.cb_tipo_identificacion.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_impresora);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_eslogan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_pagina_web);
            this.groupBox1.Controls.Add(this.lbl_fax);
            this.groupBox1.Controls.Add(this.txt_fax);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_celular);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Controls.Add(this.txt_numero_identificacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_tipo_identificacion);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(102, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 261);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 14);
            this.label11.TabIndex = 35;
            this.label11.Text = "Impresora";
            // 
            // txt_impresora
            // 
            this.txt_impresora.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_impresora.Location = new System.Drawing.Point(94, 230);
            this.txt_impresora.MaxLength = 50;
            this.txt_impresora.Name = "txt_impresora";
            this.txt_impresora.Size = new System.Drawing.Size(295, 22);
            this.txt_impresora.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 14);
            this.label6.TabIndex = 31;
            this.label6.Text = "Eslogan";
            // 
            // txt_eslogan
            // 
            this.txt_eslogan.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_eslogan.Location = new System.Drawing.Point(94, 184);
            this.txt_eslogan.MaxLength = 50;
            this.txt_eslogan.Multiline = true;
            this.txt_eslogan.Name = "txt_eslogan";
            this.txt_eslogan.Size = new System.Drawing.Size(295, 44);
            this.txt_eslogan.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "Pagina Web";
            // 
            // txt_pagina_web
            // 
            this.txt_pagina_web.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_pagina_web.Location = new System.Drawing.Point(94, 160);
            this.txt_pagina_web.MaxLength = 50;
            this.txt_pagina_web.Name = "txt_pagina_web";
            this.txt_pagina_web.Size = new System.Drawing.Size(295, 22);
            this.txt_pagina_web.TabIndex = 8;
            // 
            // lbl_fax
            // 
            this.lbl_fax.AutoSize = true;
            this.lbl_fax.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fax.Location = new System.Drawing.Point(272, 140);
            this.lbl_fax.Name = "lbl_fax";
            this.lbl_fax.Size = new System.Drawing.Size(27, 14);
            this.lbl_fax.TabIndex = 27;
            this.lbl_fax.Text = "Fax";
            // 
            // txt_fax
            // 
            this.txt_fax.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_fax.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fax.Location = new System.Drawing.Point(303, 136);
            this.txt_fax.Mask = "000-000-0000";
            this.txt_fax.Name = "txt_fax";
            this.txt_fax.Size = new System.Drawing.Size(86, 22);
            this.txt_fax.TabIndex = 7;
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
            this.panel1.Size = new System.Drawing.Size(707, 41);
            this.panel1.TabIndex = 23;
            // 
            // btn_borrar_imagen
            // 
            this.btn_borrar_imagen.Enabled = false;
            this.btn_borrar_imagen.Image = global::JSYS.Properties.Resources.Delete_16x16;
            this.btn_borrar_imagen.Location = new System.Drawing.Point(601, 243);
            this.btn_borrar_imagen.Name = "btn_borrar_imagen";
            this.btn_borrar_imagen.Size = new System.Drawing.Size(96, 40);
            this.btn_borrar_imagen.TabIndex = 28;
            this.btn_borrar_imagen.Text = "Borrar";
            this.btn_borrar_imagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_borrar_imagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_borrar_imagen.UseVisualStyleBackColor = true;
            this.btn_borrar_imagen.Click += new System.EventHandler(this.btn_borrar_imagen_Click);
            // 
            // btn_agregar_imagen
            // 
            this.btn_agregar_imagen.Enabled = false;
            this.btn_agregar_imagen.Image = global::JSYS.Properties.Resources.Add_16x16;
            this.btn_agregar_imagen.Location = new System.Drawing.Point(504, 243);
            this.btn_agregar_imagen.Name = "btn_agregar_imagen";
            this.btn_agregar_imagen.Size = new System.Drawing.Size(96, 40);
            this.btn_agregar_imagen.TabIndex = 27;
            this.btn_agregar_imagen.Text = "Agregar";
            this.btn_agregar_imagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar_imagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_agregar_imagen.UseVisualStyleBackColor = true;
            this.btn_agregar_imagen.Click += new System.EventHandler(this.btn_agregar_imagen_Click);
            // 
            // pb_imagen
            // 
            this.pb_imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_imagen.Image = global::JSYS.Properties.Resources.Logo_Transparente;
            this.pb_imagen.Location = new System.Drawing.Point(505, 51);
            this.pb_imagen.Name = "pb_imagen";
            this.pb_imagen.Size = new System.Drawing.Size(191, 189);
            this.pb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imagen.TabIndex = 26;
            this.pb_imagen.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(707, 316);
            this.Controls.Add(this.btn_borrar_imagen);
            this.Controls.Add(this.btn_agregar_imagen);
            this.Controls.Add(this.pb_imagen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Empresa";
            this.Load += new System.EventHandler(this.Frm_Empresa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.MaskedTextBox txt_celular;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.MaskedTextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_numero_identificacion;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_tipo_identificacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_impresora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_eslogan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pagina_web;
        private System.Windows.Forms.Label lbl_fax;
        internal System.Windows.Forms.MaskedTextBox txt_fax;
        private System.Windows.Forms.Button btn_borrar_imagen;
        private System.Windows.Forms.Button btn_agregar_imagen;
        private System.Windows.Forms.PictureBox pb_imagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_editar;
    }
}
