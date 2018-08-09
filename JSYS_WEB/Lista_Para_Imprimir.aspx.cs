using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JSYS_WEB
{
    public partial class Lista_Para_Imprimir : System.Web.UI.Page
    {
        static string cliente = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (S_Utilidades.Datos_Usuario.USUARIO == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (!Page.IsPostBack)
            {
                GridView1.DataSource = null;
                Lbl_usuario.Text = "Usuario:  " + S_Utilidades.Datos_Usuario.USUARIO;

                cb_cliente.DataSource = S_Factura.Listar_Clientes_X_Cobrador("B.NOMBRE LIKE'%" + "" + "%' AND A.ID_COBRADOR=" + S_Utilidades.Datos_Usuario.ID_USUARIO + "");
                cb_cliente.DataTextField = "NOMBRE";
                cb_cliente.DataValueField = "REFERENCIA";
                cb_cliente.DataBind();
                cb_cliente.SelectedIndex = -1;

                GridView1.DataSource = Listar_Recibos();
                GridView1.DataBind();
            }

        }

        public static List<E_Recibo> Listar_Recibos()
        {
            string condicion = ("C.NOMBRE ='" + cliente + "' AND B.ID_COBRADOR=" + S_Utilidades.Datos_Usuario.ID_USUARIO + "");
            return S_Factura.Listar_Recibos(condicion);
        }

        public static List<E_Recibo> Listar_Recibos_Con_Parametros(string condicion)
        {
            return S_Factura.Listar_Recibos(condicion);
        }

        protected void cb_cliente_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            try
            {
                GridView1.DataSource = S_Factura.Listar_Recibos("C.NOMBRE = '" + cb_cliente.Text + "' AND B.ID_COBRADOR=" + S_Utilidades.Datos_Usuario.ID_USUARIO + " ORDER BY A.ID_RECIBO DESC");
                cliente = cb_cliente.Text;
                GridView1.DataBind();
            }
            catch
            {

            }
        }

        protected void RadButton3_Click(object sender, EventArgs e)
        {
            string Condicion = "";
            try
            {
                if (cb_buscar.Text == "Cliente" || cb_buscar.Text == "")
                {
                    Condicion = ("C.NOMBRE LIKE'%" + txt_buscar.Text + "%' AND B.ID_COBRADOR=" + S_Utilidades.Datos_Usuario.ID_USUARIO + " ORDER BY A.ID_RECIBO DESC");
                }
                else if (cb_buscar.Text == "Recibo")
                {
                    Condicion = ("A.ID_RECIBO = " + txt_buscar.Text + " AND B.ID_COBRADOR=" + S_Utilidades.Datos_Usuario.ID_USUARIO + "");
                }

                GridView1.DataSource = Listar_Recibos_Con_Parametros(Condicion);
                GridView1.DataBind();
            }
            catch
            {

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            S_Utilidades.Datos_Entidades.ID_RECIBO = Convert.ToInt32(row.Cells[0].Text);
            Session["lista_pendiente"] = "no";
            Response.Redirect("Visor_Reporte.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.AppendHeader("Cache-Control", "no-store");
            S_Utilidades.Datos_Usuario.ID_USUARIO = 0;
            S_Utilidades.Datos_Usuario.USUARIO  = null;
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx");
        }
    }
}