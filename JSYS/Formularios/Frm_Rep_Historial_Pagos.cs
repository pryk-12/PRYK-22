
using DevExpress.XtraReports.UI;
using Servicios;
using System.Collections.Generic;
using Datos;
using System.Linq;
using System.Data;
using System;
namespace JSYS.Formularios
{
    public partial class Frm_Rep_Historial_Pagos : JSYS.Formularios.Frm_Plantilla
    {
        public class _ID
        {
            public int id_factura { get; set; }
        }

        BD_JSYSEntities db = new BD_JSYSEntities();

        public Frm_Rep_Historial_Pagos()
        {
            InitializeComponent();
            S_Utilidades.Llenar_ComboBox<JSYS.Formularios.Frm_Factura._CLIENTE>(cb_cliente, "NOMBRE", "REFERENCIA", "NOMBRE LIKE'%" + "" + "%' AND ESTADO='A'", "CLIENTES");
        }


        void Llenar_ComboBox_facturas(string REF)
        {
            List<_ID> Lista = new List<_ID>();
            var numero_factura = (from e in db.FACTURAS
                                  where e.REFERENCIA == REF && e.MONTO_PAGADO > 0
                                  select new _ID()
                                  {
                                      id_factura = e.ID_FACTURA,
                                  }).Distinct().ToList();

            Lista.AddRange(new _ID[] { new _ID { id_factura = 0 } });
            foreach (_ID emp in numero_factura)
            {
                Lista.Add(emp);
            }
            cb_facturas.DataSource = Lista;
            cb_facturas.DisplayMember = "id_factura";
        }


        private void cb_facturas_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void btn_reporte_Click(object sender, System.EventArgs e)
        {
            if(cb_cliente.Text =="")
            {
                S_Utilidades.Mensaje_Informacion("Se debe Seleccionar el Cliente");
                return;
            }

            string condicion = "";
            if(cb_facturas.Text =="0")
            {
                condicion = @"([REFERENCIA] = '" + cb_cliente.SelectedValue + "')";
            }
            else if (cb_facturas.Text != "0")
            {
                condicion = @"([REFERENCIA] = '" + cb_cliente.SelectedValue + "' AND [ID_FACTURA] = " + cb_facturas.Text + ")";
            }
           


            Reportes.Rep_Pagos_Cliente report = new Reportes.Rep_Pagos_Cliente();
            report.FilterString = condicion;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void cb_cliente_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           
            try
            {
                string REF = cb_cliente.SelectedValue.ToString();
                Llenar_ComboBox_facturas(REF);

            }
            catch
            {

            }
        }
    }
}
