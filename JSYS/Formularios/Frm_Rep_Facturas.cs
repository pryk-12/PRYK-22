using Datos;
using DevExpress.XtraReports.UI;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JSYS.Formularios
{
    public partial class Frm_Rep_Facturas : JSYS.Formularios.Frm_Plantilla
    {
        public class _CLIENTE
        {
            public string  REFERENCIA { get; set; }
            public string NOMBRE { get; set; }
        }

        public class _COBRADOR
        {
            public int ID_COBRADOR { get; set; }
            public string NOMBRE { get; set; }
        }
        public class _USUARIO
        {
            public int ID_USUARIO { get; set; }
            public string USUARIO { get; set; }
        }

        BD_JSYSEntities db = new BD_JSYSEntities();
        public Frm_Rep_Facturas()
        {
            InitializeComponent();
            S_Utilidades.Llenar_ComboBox<_CLIENTE>(cb_cliente, "NOMBRE", "REFERENCIA", "NOMBRE LIKE'%" + "" + "%' AND ESTADO='A'", "CLIENTES");
            S_Utilidades.Llenar_ComboBox<ESTADO_FACTURAS>(cb_estado, "DESCRIPCION", "ID_ESTADO", "DESCRIPCION LIKE'%" + "" + "%'", "ESTADO_FACTURAS");
            Llenar_ComboBox_Cobrador();
        }

        void Llenar_ComboBox_Cobrador()
        {
            List<_USUARIO> Lista = new List<_USUARIO>();
            var Lista_Cobrador = (from e in db.FACTURAS
                                  join u in db.USUARIOS on e.ID_COBRADOR equals u.ID_USUARIO
                                  select new _USUARIO()
                                    {  
                                        USUARIO = u.USUARIO,
                                    }).Distinct().ToList();

            Lista.AddRange(new _USUARIO[] { new _USUARIO { USUARIO = "" } });
            foreach (_USUARIO emp in Lista_Cobrador)
            {
                Lista.Add(emp);
            }
            cb_cobrador.DataSource = Lista;
            cb_cobrador.DisplayMember = "USUARIO";
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Consultar_Cliente_Para_Factura frm = new Frm_Consultar_Cliente_Para_Factura();
            frm.ShowDialog();
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            
            string condicion = "";
            int id_factura = 0;


            if (txt_contrato.Text.Equals(""))
            {
                id_factura = 0;
            }
            else
            {
                id_factura = Convert.ToInt32(txt_contrato.Text);
            }

            if (ch_incluir_fechas.Checked == true)
            {
                condicion = @"([ID_FACTURA] = " + id_factura + " OR 0 = " + id_factura + @")
                          and ([NUMERO_LOTERIA] = '" + cb_numero_loteria.Text + "' OR '' = '" + cb_numero_loteria.Text + @"')
                          and ([NOMBRE] = '" + cb_cliente.Text + "' OR '' = '" + cb_cliente.Text + @"')
                          and ([COBRADOR] = '" + cb_cobrador.Text + "' OR '' = '" + cb_cobrador.Text + @"')
                          and ([ESTADO] = '" + cb_estado.Text + "' OR '' = '" + cb_estado.Text + @"')
                          and ([FECHA] Between('" + dt_desde.Value.Date + "', '" + dt_hasta.Value.Date + "'))";
            }
            else
            {
                condicion = @"([ID_FACTURA] = " + id_factura + " OR 0 = " + id_factura + @")
                          and ([NUMERO_LOTERIA] = '" + cb_numero_loteria.Text + "' OR '' = '" + cb_numero_loteria.Text + @"')
                          and ([NOMBRE] = '" + cb_cliente.Text + "' OR '' = '" + cb_cliente.Text + @"')
                          and ([COBRADOR] = '" + cb_cobrador.Text + "' OR '' = '" + cb_cobrador.Text + @"')
                          and ([ESTADO] = '" + cb_estado.Text + "' OR '' = '" + cb_estado.Text + @"')";
            }

            Reportes.Rep_Listado_Facturas report = new Reportes.Rep_Listado_Facturas();
            report.FilterString = condicion;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }
    }
}
