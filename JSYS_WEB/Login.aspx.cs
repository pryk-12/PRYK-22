using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Servicios;
using Datos;

namespace JSYS_WEB
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.AppendHeader("Cache-Control", "no-store");
            Page.Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Page.Response.Cache.SetValidUntilExpires(false);
        }

        public void login()
        {
            try
            {
                if (S_Usuario.Listar_Usuario("(USUARIO='" + txt_usuario.Text.Trim() + "' AND CLAVE='" + S_Utilidades.Encriptar_Clave(txt_clave.Text.Trim()) + "') AND ESTADO = 'A'").Count >= 1)
                {
                    S_Utilidades.Datos_Usuario.USUARIO = txt_usuario.Text.Trim();
                    BD_JSYSEntities db = new BD_JSYSEntities();
                    var obj_usuario = db.USUARIOS.Where(u => u.USUARIO == txt_usuario.Text).Single();
                    S_Utilidades.Datos_Usuario.ID_USUARIO = obj_usuario.ID_USUARIO;
                    Response.Redirect("Principal.aspx");                   
                }
                else
                {
                    lbl_mensaje.Text = "Clave de Usuario es Incorrecta, O el Usuario esta Inactivo";
                }
            }
            catch
            {
              
            }
           
        }
        protected void btnIngresar_Click1(object sender, EventArgs e)
        {
            login();
        }

    }
}