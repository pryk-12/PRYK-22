using System;
using System.Windows.Forms;
using Servicios;

namespace JSYS.Formularios
{
    public partial class Frm_Login : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Login()
        {
            InitializeComponent();            
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
           
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Usuario es Obligatorio");
                return;
            }
            if (txt_clave.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("La Clave es Obligatorio");
                return;
            }

            if (S_Usuario.Listar_Usuario("USUARIO='" + txt_usuario.Text.Trim() + "'").Count == 0)
            {
                S_Utilidades.Mensaje_Informacion("Este Usuario no Existe o Esta Inactivo");
                txt_usuario.Clear();
                txt_clave.Clear();
                txt_usuario.Focus();
                txt_clave.Enabled = true;
                return;
            }

            if (S_Usuario.Listar_Usuario("(USUARIO='" + txt_usuario.Text.Trim() + "' AND CLAVE='" + S_Utilidades.Encriptar_Clave(txt_clave.Text.Trim()) + "') AND ESTADO = 'A'").Count >= 1)
            {
                S_Utilidades.Datos_Usuario.USUARIO = txt_usuario.Text.Trim();

                Frm_Menu frm = new Frm_Menu();
                this.Hide();
                frm.Show();
            }
            else
            {
                S_Utilidades.Mensaje_Informacion("Clave de Usuario es Incorrecta, O el Usuario esta Inactivo");
                txt_clave.Clear();
                txt_clave.Focus();
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Frm_Login_Activated(object sender, EventArgs e)
        {
            txt_usuario.Focus();
        }
    }
}
