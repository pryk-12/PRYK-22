using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Listado_CXC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static List<E_Detalles_Cuotas_Web> Listar_CXP()
        {
            string condicion = ("C.NOMBRE LIKE'%" + "" + "%'");
            return S_Factura.Listar_Detalles_Cuotas_WEB(condicion);
        }
    }
}