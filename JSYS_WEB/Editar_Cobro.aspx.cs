using System;
using System.Linq;
using System.Web;
using Datos;
using Servicios;


namespace JSYS_WEB
{
    public partial class Editar_Cobro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txt_no_factura.Text = Session["id_factura"].ToString();
                txt_no_cuota.Text = Session["numero_cuota"].ToString();
                txt_cliente.Text = HttpUtility.HtmlDecode(Session["cliente"].ToString());
                txt_monto_cuota.Text = Session["monto_cuota"].ToString();

            }

        }

        protected void btn_regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Lista_Pendientes.aspx");
        }

        public void Actualizar_Montos()
        {
            BD_JSYSEntities db = new BD_JSYSEntities();
            FACTURAS obj_factura = new FACTURAS();
            DETALLES_CUOTAS obj_detalle = new DETALLES_CUOTAS();
            RECIBOS_COBRADOS obj_recibo = new RECIBOS_COBRADOS();

            //actualizar detalle cxc
            if (ch_pago_total.Checked == true)
            {
                obj_detalle.MONTO_PAGADO = Convert.ToDecimal(txt_monto_cuota.Text);
                obj_detalle.MONTO_PENDIENTE = 0;
                obj_recibo.VALOR_PAGADO = Convert.ToDecimal(txt_monto_cuota.Text);
                obj_factura.MONTO_PAGADO = Convert.ToDecimal(txt_monto_cuota.Text);
                obj_recibo.VALOR_PENDIENTE = 0;
            }
            else if(ch_pago_total.Checked==false && Convert.ToDecimal(txt_valor_a_pagar.Text)>=Convert.ToDecimal(txt_monto_cuota.Text))
            {
                obj_detalle.MONTO_PAGADO = Convert.ToDecimal(txt_monto_cuota.Text);
                obj_detalle.MONTO_PENDIENTE = 0;
                obj_recibo.VALOR_PAGADO = Convert.ToDecimal(txt_monto_cuota.Text);
                obj_factura.MONTO_PAGADO = Convert.ToDecimal(txt_monto_cuota.Text);
                obj_recibo.VALOR_PENDIENTE = 0;
            }
            else if (ch_pago_total.Checked == false && Convert.ToDecimal(txt_valor_a_pagar.Text) < Convert.ToDecimal(txt_monto_cuota.Text))
            {
                obj_detalle.MONTO_PAGADO = Convert.ToDecimal(txt_valor_a_pagar.Text);
                obj_detalle.MONTO_PENDIENTE = Convert.ToDecimal(txt_monto_cuota.Text) - Convert.ToDecimal(txt_valor_a_pagar.Text);
                obj_recibo.VALOR_PAGADO = Convert.ToDecimal(txt_valor_a_pagar.Text);
                obj_factura.MONTO_PAGADO = Convert.ToDecimal(txt_valor_a_pagar.Text);
                obj_recibo.VALOR_PENDIENTE = Convert.ToDecimal(txt_monto_cuota.Text) - Convert.ToDecimal(txt_valor_a_pagar.Text);
            }

            obj_detalle.NUMERO_CUOTA = Convert.ToInt32(txt_no_cuota.Text);
            obj_detalle.ID_FACTURA = Convert.ToInt32(txt_no_factura.Text);
            S_Factura.Cobrar_Cuota(obj_detalle);

            //insertar recibo
            obj_recibo.ANULADO_POR = "";
            obj_recibo.CREADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
            int ID_FACTURA = Convert.ToInt32(txt_no_factura.Text);
            var obj_encabezado = db.ENCABEZADO_CUOTAS.Where(a => a.ID_FACTURA == ID_FACTURA).Single();
            obj_recibo.CANTIDAD_CUOTAS = obj_encabezado.CANTIADA_CUOTA;
            obj_recibo.CUOTA_COBRADA = Convert.ToInt32(txt_no_cuota.Text);
            obj_recibo.ESTADO = "V";
            obj_recibo.FECHA_ANULADO = "";
            obj_recibo.FECHA_CREADO = DateTime.Now;
            obj_recibo.ID_FACTURA = ID_FACTURA;
            var obj_fact = db.FACTURAS.Where(f => f.ID_FACTURA == ID_FACTURA).Single();
            obj_recibo.NOTA_ANULACION = "";
            obj_recibo.VALOR_CUOTA = Convert.ToDecimal(txt_monto_cuota.Text);
            S_Factura.Insertar_Recibo_Cobros(obj_recibo);

            //actualizar monto factura
            obj_factura.ID_FACTURA = ID_FACTURA;
            S_Factura.Actualizar_Montos_Factura(obj_factura);
        }

        protected void btn_cobrar_Click(object sender, EventArgs e)
        {
            if (ch_pago_total.Checked == false && (txt_valor_a_pagar.Text == "" || Convert.ToDecimal(txt_valor_a_pagar.Text) <= 0))
            {
                lbl_error.Text = "Formato de Valor Incorrecto";
                return;
            }

            try
            {
                BD_JSYSEntities db = new BD_JSYSEntities();

                Actualizar_Montos();
                var ultimo_recibo = db.RECIBOS_COBRADOS.Where(r => r.CREADO_POR == S_Utilidades.Datos_Usuario.USUARIO).Max(r => r.ID_RECIBO);
                S_Utilidades.Datos_Entidades.ID_RECIBO = ultimo_recibo;
                Response.Redirect("Visor_Reporte.aspx");
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
            Response.Redirect("Lista_Pendientes.aspx");
        }
    }
}