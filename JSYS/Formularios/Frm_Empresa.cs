using Datos;
using Servicios;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace JSYS.Formularios
{
    public partial class Frm_Empresa : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Empresa()
        {
            InitializeComponent();
            S_Utilidades.Llenar_ComboBox<TIPOS_IDENTIFICACIONES>(cb_tipo_identificacion, "DESCRIPCION", "ID_TIPO_IDENTIFICACION", "DESCRIPCION LIKE'%" + "" + "%'", "TIPOS_IDENTIFICACIONES");
        }

        public void Recibir_Datos()
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_empresa = db.EMPRESA.Single();
                txt_celular.Text = obj_empresa.CELULAR;
                txt_direccion.Text = obj_empresa.DIRECCION;
                txt_email.Text = obj_empresa.EMAIL;
                txt_eslogan.Text = obj_empresa.ESLOGAN;
                txt_fax.Text = obj_empresa.FAX;
                Txt_ID.Text = obj_empresa.ID_EMPRESA.ToString();
                txt_impresora.Text = obj_empresa.IMPRESORA;
                txt_nombre.Text = obj_empresa.NOMBRE;
                txt_numero_identificacion.Text = obj_empresa.NUMERO_IDENTIFICACION;
                txt_pagina_web.Text = obj_empresa.PAGINA_WEB;
                txt_telefono.Text = obj_empresa.TELEFONO;
                cb_tipo_identificacion.SelectedValue = obj_empresa.ID_TIPO_IDENTIFICACION;
                byte[] Logo = (byte[])obj_empresa.LOGO;
                System.IO.MemoryStream ms = new MemoryStream(Logo);
                pb_imagen.Image = Image.FromStream(ms);
            }
        }

        public void Insertar()
        {
            string Mensaje = "";
            System.IO.MemoryStream ms = new MemoryStream();
            this.pb_imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] ruta_imagen = ms.GetBuffer();
            try
            {
                EMPRESA obj = new EMPRESA();
                obj.CELULAR = txt_celular.Text == "   -   -" ? "" : txt_celular.Text.Trim();
                obj.DIRECCION = txt_direccion.Text;
                obj.EMAIL = txt_email.Text.Trim();
                obj.ESLOGAN = txt_eslogan.Text.Trim();
                obj.LOGO = ruta_imagen;
                obj.FAX = lbl_fax.Text == "   -   -" ? "" : lbl_fax.Text.Trim();
                obj.ID_EMPRESA = Convert.ToInt32(Txt_ID.Text);
                obj.ID_TIPO_IDENTIFICACION = Convert.ToInt32(cb_tipo_identificacion.SelectedValue);
                obj.IMPRESORA = txt_impresora.Text.Trim();
                obj.NOMBRE = txt_nombre.Text.Trim();
                obj.NUMERO_IDENTIFICACION = txt_numero_identificacion.Text.Trim();
                obj.PAGINA_WEB = txt_pagina_web.Text.Trim();
                obj.TELEFONO = txt_telefono.Text == "   -   -" ? "" : txt_telefono.Text.Trim();

                S_Empresa.Actualizar_Empresa(obj);
                Mensaje = "Registro Actualizado con Éxito";

                S_Utilidades.Mensaje_Informacion(Mensaje);
                this.Close();
            }
            catch (Exception ex)
            {
                S_Utilidades.Mensaje_Error(ex.Message);
            }
        }

        private void btn_agregar_imagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png|GIF(*… *.Png, *.Gif, *.Tiff, *.Jpeg, *.Bmp)|*.Jpg; *.Png; *.Gif; *.Tiff; *.Jpeg; *.Bmp"; //formatos soportados
            openFileDialog1.FilterIndex = 4;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pb_imagen.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else
            {
                if (string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    S_Utilidades.Mensaje_Informacion("No ha Seleccionado Ninguna Imagen");
                    return;
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Nombre Es Obligatorio");
                txt_nombre.Focus();
                return;
            }

            if (cb_tipo_identificacion.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Tipo de Identificación Es Obligatorio");
                cb_tipo_identificacion.Focus();
                return;
            }

            if (Convert.ToInt32(cb_tipo_identificacion.SelectedValue) != 5 && txt_numero_identificacion.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Número de Identificación es Obligatorio");
                txt_numero_identificacion.Focus();
                return;
            }

            if (txt_direccion.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("La Dirección Es Obligatoria");
                txt_direccion.Focus();
                return;
            }

            if (!txt_telefono.Text.Equals("   -   -"))
            {
                if (txt_telefono.Text.Length < 12)
                {
                    S_Utilidades.Mensaje_Informacion("El Número de Teléfono Esta Incompleto");
                    txt_telefono.Focus();
                    return;
                }
            }

            if (!txt_celular.Text.Equals("   -   -"))
            {
                if (txt_celular.Text.Length < 12)
                {
                    S_Utilidades.Mensaje_Informacion("El Número de Celular Esta Incompleto");
                    txt_celular.Focus();
                    return;
                }
            }

            if (!txt_fax.Text.Equals("   -   -"))
            {
                if (txt_celular.Text.Length < 12)
                {
                    S_Utilidades.Mensaje_Informacion("El Número de Fax Esta Incompleto");
                    lbl_fax.Focus();
                    return;
                }
            }

            if (!txt_email.Text.Trim().Equals(""))
            {
                if (!S_Utilidades.Validar_Formato_Correo(txt_email.Text))
                {
                    S_Utilidades.Mensaje_Informacion("El Formato del E-Mail es Incorrecto");
                    txt_email.Focus();
                    return;
                }
            }

            Insertar();
            groupBox1.Enabled = false;
            btn_editar.Enabled = true;
            btn_guardar.Enabled = false;
            btn_agregar_imagen.Enabled = false;
            btn_borrar_imagen.Enabled = false;
        }

        private void btn_borrar_imagen_Click(object sender, EventArgs e)
        {
            pb_imagen.Image = global::JSYS.Properties.Resources.Logo_Transparente;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btn_guardar.Enabled = true;
            btn_editar.Enabled = false;
            btn_agregar_imagen.Enabled = true;
            btn_borrar_imagen.Enabled = true;
        }

        private void Frm_Empresa_Load(object sender, EventArgs e)
        {
            Recibir_Datos();
        }

    }
}
