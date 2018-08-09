using System;
using System.Web;
using Servicios;

namespace JSYS_WEB
{
    public partial class Visor_Reporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(S_Utilidades.Datos_Usuario.USUARIO == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btn_regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Lista_Pendientes.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(Session["lista_pendiente"].ToString() == "si")
            {
                Response.Redirect("Lista_Pendientes.aspx");
            }
            else if (Session["lista_pendiente"].ToString() == "no")
            {
                Response.Redirect("Lista_Para_Imprimir.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.AppendHeader("Cache-Control", "no-store");
            S_Utilidades.Datos_Usuario.ID_USUARIO = 0;
            S_Utilidades.Datos_Usuario.USUARIO = null;
            S_Utilidades.Datos_Entidades.ARTICULO = "";
            S_Utilidades.Datos_Entidades.CANTIDAD = 0;
            S_Utilidades.Datos_Entidades.ID_ARTICULO = 0;
            S_Utilidades.Datos_Entidades.ID_PROVEEDOR = 0;
            S_Utilidades.Datos_Entidades.ID_RECIBO = 0;
            S_Utilidades.Datos_Entidades.PRECIO = 0;
            S_Utilidades.Datos_Entidades.REFERENCIA = "";
            S_Utilidades.Datos_Entidades.TOTAL = 0;
            Response.Redirect("Login.aspx");
        }
    }
}