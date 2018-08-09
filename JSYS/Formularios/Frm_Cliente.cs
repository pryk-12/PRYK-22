using Datos;
using Servicios;
using System;
using System.Windows.Forms;
using System.Linq;

namespace JSYS.Formularios
{
    public partial class Frm_Cliente : JSYS.Formularios.Frm_Plantilla
    {

        public Frm_Cliente()
        {
            InitializeComponent();
            S_Utilidades.Llenar_ComboBox<TIPOS_IDENTIFICACIONES>(cb_tipo_identificacion, "DESCRIPCION", "ID_TIPO_IDENTIFICACION", "DESCRIPCION LIKE'%" + "" + "%'", "TIPOS_IDENTIFICACIONES");
        }

        public void Recibir_Datos(CLIENTES obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_cliente = db.CLIENTES.Where(r=>r.REFERENCIA == obj.REFERENCIA).SingleOrDefault();
                txt_nombre.Text = obj_cliente.NOMBRE;
                txt_celular.Text = obj_cliente.CELULAR;
                txt_direccion.Text = obj_cliente.DIRECCION;
                txt_direccion_referencia1.Text = obj_cliente.DIRECCION_REFERENCIA1;
                txt_direccion_referencia2.Text = obj_cliente.DIRECCION_REFERENCIA2;
                txt_direccion_trabajo.Text = obj_cliente.DIRECCION_TRABAJO;
                txt_email.Text = obj_cliente.EMAIL;
                txt_nombre_conyugue.Text = obj_cliente.NOMBRE_CONYUGUE;
                txt_nombre_referencia1.Text = obj_cliente.NOMBRE_REFERENCIA1;
                txt_nombre_referencia2.Text = obj_cliente.NOMBRE_REFERENCIA2;
                txt_numero_identificacion.Text = obj_cliente.NUMERO_IDENTIFICACION;
                txt_referencia.Text = obj_cliente.REFERENCIA;
                txt_sueldo.Text = obj_cliente.SUELDO.ToString();
                txt_telefono.Text = obj_cliente.TELEFONO;
                txt_telefono_conyugue.Text = obj_cliente.TELEFONO_CONYUGUE;
                txt_telefono_referencia1.Text = obj_cliente.TELEFONO_REFERENCIA1;
                txt_telefono_referencia2.Text = obj_cliente.TELEFONO_REFERENCIA2;
                txt_observacion_referencia1.Text = obj_cliente.OBSERVACION_REFERENCIA1;
                txt_observacion_referencia2.Text = obj_cliente.OBSERVACION_REFERENCIA2;
                cb_casa_propia.Text = obj_cliente.CASA_PROPIA;
                cb_estado.Text = obj_cliente.ESTADO == "A" ? "Activo" : "Inactivo";
                cb_tipo_identificacion.SelectedValue = obj_cliente.ID_TIPO_IDENTIFICACION;
                txt_observacion.Text = obj_cliente.OBSERVACION;

                txt_referencia.Enabled = false;
            }
        }

        public void Titulo(string Titulo)
        {
            Lbl_Titulo.Text = Titulo;
        }

        public void Insertar()
        {
            string Mensaje = "";
            CLIENTES  obj = new CLIENTES();
            obj.CASA_PROPIA = cb_casa_propia.Text;
            obj.CELULAR = txt_celular.Text == "   -   -" ? "" : txt_celular.Text.Trim();
            obj.CREADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
            obj.DIRECCION = txt_direccion.Text.Trim();
            obj.DIRECCION_REFERENCIA1 = txt_direccion_referencia1.Text.Trim();
            obj.DIRECCION_REFERENCIA2 = txt_direccion_referencia2.Text.Trim();
            obj.DIRECCION_TRABAJO = txt_direccion_trabajo.Text.Trim();
            obj.EMAIL = txt_email.Text.Trim();
            obj.ESTADO = cb_estado.Text == "Activo" ? "A" : "I";
            obj.FECHA_CREADO = DateTime.Now;
            obj.ID_TIPO_IDENTIFICACION = Convert.ToInt32(cb_tipo_identificacion.SelectedValue);
            obj.NOMBRE = txt_nombre.Text.Trim();
            obj.NOMBRE_CONYUGUE = txt_nombre_conyugue.Text.Trim();
            obj.NOMBRE_REFERENCIA1 = txt_nombre_referencia1.Text.Trim();
            obj.NOMBRE_REFERENCIA2 = txt_nombre_referencia2.Text.Trim();
            obj.NUMERO_IDENTIFICACION = txt_numero_identificacion.Text.Trim();
            obj.REFERENCIA = txt_referencia.Text.Trim();
            obj.SUELDO = txt_sueldo.Text == "" ? 0 : Convert.ToDecimal(txt_sueldo.Text);
            obj.TELEFONO = txt_telefono.Text == "   -   -" ? "" : txt_telefono.Text.Trim();
            obj.TELEFONO_CONYUGUE = txt_telefono_conyugue.Text == "   -   -" ? "" : txt_telefono_conyugue.Text.Trim();
            obj.TELEFONO_REFERENCIA1 = txt_telefono_referencia1.Text == "   -   -" ? "" : txt_telefono_referencia1.Text.Trim();
            obj.TELEFONO_REFERENCIA2 = txt_telefono_referencia2.Text == "   -   -" ? "" : txt_telefono_referencia2.Text.Trim();
            obj.OBSERVACION = txt_observacion.Text.Trim();
            obj.OBSERVACION_REFERENCIA1 = txt_observacion_referencia1.Text.Trim();
            obj.OBSERVACION_REFERENCIA2 = txt_observacion_referencia2.Text.Trim();
            try
            {
                if (txt_referencia.Enabled ==true)
                {
                    S_Cliente.Insertar_Cliente(obj);
                    Mensaje = "Datos Insertados con Exito";
                }
                else
                {
                    obj.REFERENCIA  = txt_referencia.Text.Trim();
                    S_Cliente.Actualizar_Cliente(obj);
                    Mensaje = "Datos Actualizados con Exito";
                }
                S_Utilidades.Mensaje_Informacion(Mensaje);
                Close();
        }
            catch (Exception ex)
            {
                S_Utilidades.Mensaje_Error(ex.Message);
            }

}

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_referencia.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("La Referencia o Código Es Obligatorio");
                txt_referencia.Focus();
                return;
            }

            if(txt_referencia.Enabled == true)
            {
                BD_JSYSEntities db = new BD_JSYSEntities();
                var obj = db.CLIENTES.Where(r => r.REFERENCIA == txt_referencia.Text.Trim()).ToList();
                if(obj.Count>0)
                {
                    S_Utilidades.Mensaje_Informacion("Esta Referencia ya existe, Intente con otra Diferente");
                    return;
                }
            }

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

            if (cb_estado.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Estado Es Obligatorio");
                cb_estado.Focus();
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

            if (!txt_email.Text.Trim().Equals(""))
            {
                if (!S_Utilidades.Validar_Formato_Correo(txt_email.Text))
                {
                    S_Utilidades.Mensaje_Informacion("El Formato del E-Mail es Incorrecto");
                    txt_email.Focus();
                    return;
                }
            }

            if (!txt_telefono_conyugue.Text.Equals("   -   -"))
            {
                if (txt_telefono_conyugue.Text.Length < 12)
                {
                    S_Utilidades.Mensaje_Informacion("El Número de Teléfono del Conyugue Esta Incompleto");
                    txt_telefono_conyugue.Focus();
                    return;
                }
            }
            if (!txt_telefono_referencia1.Text.Equals("   -   -"))
            {
                if (txt_telefono_referencia1.Text.Length < 12)
                {
                    S_Utilidades.Mensaje_Informacion("El Número de Teléfono de la Referencia 1 Esta Incompleto");
                    txt_telefono_referencia1.Focus();
                    return;
                }
            }

            if (!txt_telefono_referencia2.Text.Equals("   -   -"))
            {
                if (txt_telefono_referencia2.Text.Length < 12)
                {
                    S_Utilidades.Mensaje_Informacion("El Número de Teléfono de la Referencia 2 Esta Incompleto");
                    txt_telefono_referencia2.Focus();
                    return;
                }
            }

            Insertar();
        }

        private void txt_sueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            S_Utilidades.Permitir_Solo_Numero_y_Punto(sender, e, txt_sueldo);
        }
    }
}
