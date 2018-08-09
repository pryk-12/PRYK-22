using System;
using Datos;
using Servicios;

namespace JSYS.Formularios
{
    public partial class Frm_Usuario : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Usuario()
        {
            InitializeComponent();
        }

        public void Recibir_Datos(USUARIOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_usuario = db.USUARIOS.Find(obj.ID_USUARIO);
                Txt_ID.Text = obj_usuario.ID_USUARIO.ToString();
                Txt_Nombre.Text = obj_usuario.NOMBRE;
                Txt_Usuario.Text = obj_usuario.USUARIO;
                Txt_Clave.Text = S_Utilidades.Desencriptar_Clave(obj_usuario.CLAVE);
                Cb_Estado.Text = obj_usuario.ESTADO =="A" ? "Activo" : "Inactivo";
                Cb_Sexo.Text = obj_usuario.SEXO == "M" ? "Masculino" : "Femenino";
                cb_tipo.Text = obj_usuario.TIPO;
            }
        }

        public void Titulo(string Titulo)
        {
            Lbl_Titulo.Text = Titulo;
        }

        public void Insertar()
        {
            string Mensaje = "";
            USUARIOS obj = new USUARIOS();
            obj.CLAVE = S_Utilidades.Encriptar_Clave(Txt_Clave.Text.Trim());
            obj.CREADO_POR = "JMENA";
            obj.ESTADO = Cb_Estado.Text == "Activo" ? "A" : "I";
            obj.FECHA_CREADO = DateTime.Now;
            obj.NOMBRE = Txt_Nombre.Text.Trim();
            obj.SEXO = Cb_Sexo.Text == "Masculino" ? "M" : "F";
            obj.USUARIO = Txt_Usuario.Text.Trim();
            obj.TIPO = cb_tipo.Text;
            try
            {
                if (Txt_ID.Text.Equals(""))
                {
                    S_Usuario.Insertar_Usuario(obj);
                    Mensaje = "Datos Insertados con Exito";
                }
                else
                {
                    obj.ID_USUARIO = Convert.ToInt32(Txt_ID.Text);
                    S_Usuario.Actualizar_Usuario(obj);
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


        private void Frm_Usuario_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Nombre Es Obligatorio");
                Txt_Nombre.Focus();
                return;
            }
            if (Txt_Usuario.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Usuario Es Obligatorio");
                Txt_Usuario.Focus();
                return;
            }
            if (Txt_Clave.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("La Clave Es Obligatoria");
                Txt_Clave.Focus();
                return;
            }
            if (Cb_Sexo.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Sexo Es Obligatorio");
                Cb_Sexo.Focus();
                return;
            }
            if (Cb_Estado.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Estado Es Obligatorio");
                Cb_Estado.Focus();
                return;
            }
            if (cb_tipo.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Tipo Es Obligatorio");
                cb_tipo.Focus();
                return;
            }
            Insertar();
        }
    }
}
