using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JSYS_WEB
{
    public partial class Lista_Pendientes : System.Web.UI.Page
    {
        static string cliente = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (S_Utilidades.Datos_Usuario.USUARIO == null)
            {
                Response.Redirect("Login.aspx");
            }

            if(!Page.IsPostBack)
            {
                GridView1.DataSource = null;
                Lbl_usuario.Text = "Usuario:  " + S_Utilidades.Datos_Usuario.USUARIO;

                cb_cliente.DataSource = S_Factura.Listar_Clientes_X_Cobrador("B.NOMBRE LIKE'%" + "" + "%' AND A.ID_COBRADOR=" + S_Utilidades.Datos_Usuario.ID_USUARIO + "");
                cb_cliente.DataTextField = "NOMBRE";
                cb_cliente.DataValueField = "REFERENCIA";                
                cb_cliente.DataBind();
                cb_cliente.SelectedIndex = -1;
                
                GridView1.DataSource = Listar_CXP();
                GridView1.DataBind();
            }

        }

        public static List<E_Detalles_Cuotas_Web> Listar_CXP()
        {
            string condicion = ("C.NOMBRE ='" + cliente + "' AND A.MONTO_PENDIENTE>0 AND F.ID_COBRADOR=" + S_Utilidades.Datos_Usuario.ID_USUARIO + "");
            return S_Factura.Listar_Detalles_Cuotas_WEB(condicion);
        }

        public static List<E_Detalles_Cuotas_Web> Listar_CXP_Con_Parametros(string condicion)
        {          
            return S_Factura.Listar_Detalles_Cuotas_WEB(condicion);
        }

        protected void cb_cliente_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            try
            {

                GridView1.DataSource = S_Factura.Listar_Detalles_Cuotas_WEB("C.NOMBRE = '" + cb_cliente.Text + "' AND A.MONTO_PENDIENTE>0 AND F.ID_COBRADOR=" + S_Utilidades.Datos_Usuario.ID_USUARIO + "");
                cliente = cb_cliente.Text;
                GridView1.DataBind();
            }
            catch
            {

            }
        }

        public void Buscar_Fechas()
        {
            string Condicion = "(CONVERT(smalldatetime, CONVERT(char(10), A.FECHA, 103), 103) >= '" + dt_desde.SelectedDate.Value.ToString("yyyy-MM-dd") + "' and CONVERT(smalldatetime, CONVERT(char(10), A.FECHA, 103), 103) <= '" + dt_hasta.SelectedDate.Value.ToString("yyyy-MM-dd") + "') AND A.MONTO_PENDIENTE>0 AND F.ID_COBRADOR=" + S_Utilidades.Datos_Usuario.ID_USUARIO + "";
            GridView1.DataSource = S_Factura.Listar_Detalles_Cuotas_WEB(Condicion);
            GridView1.DataBind();
        }

        protected void RadButton2_Click(object sender, EventArgs e)
        {
            Buscar_Fechas();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            Session["id_factura"] = row.Cells[0].Text;
            Session["numero_cuota"] = row.Cells[1].Text;
            Session["cliente"] = row.Cells[3].Text;
            Session["monto_cuota"] = row.Cells[4].Text;
            Session["lista_pendiente"] = "si";
            Response.Redirect("Editar_Cobro.aspx");
        }

        protected void RadButton3_Click(object sender, EventArgs e)
        {
            string Condicion = "";
            try
            {
                if (cb_buscar.Text == "Cliente" || cb_buscar.Text == "")
                {
                    Condicion = ("C.NOMBRE LIKE'%" + txt_buscar.Text + "%' AND A.MONTO_PENDIENTE>0 AND F.ID_COBRADOR=" + S_Utilidades.Datos_Usuario.ID_USUARIO + "");
                }
                else if(cb_buscar.Text =="Contrato")
                {
                    Condicion = ("F.NUMERO_CONTRATO = " + txt_buscar.Text + " AND A.MONTO_PENDIENTE>0 AND F.ID_COBRADOR=" + S_Utilidades.Datos_Usuario.ID_USUARIO + "");
                }
                else if(cb_buscar.Text =="Factura")
                {
                    Condicion = ("A.ID_FACTURA = " + txt_buscar.Text + " AND A.MONTO_PENDIENTE>0 AND F.ID_COBRADOR=" + S_Utilidades.Datos_Usuario.ID_USUARIO + "");
                }

                GridView1.DataSource = Listar_CXP_Con_Parametros(Condicion);
                GridView1.DataBind();
            }
            catch
            {

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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx");
        }
    }
}