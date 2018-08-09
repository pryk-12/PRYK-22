using Datos;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using Servicios;

namespace JSYS.Formularios
{
    public partial class Frm_Reimprimir_Recibos : JSYS.Formularios.Frm_Plantilla
    {
        BD_JSYSEntities db = new BD_JSYSEntities();

        public class _CLIENTE
        {
            public string  REFERENCIA { get; set; }
            public string NOMBRE { get; set; }
        }

        public class _USUARIO
        {
            public int ID_USUARIO { get; set; }
            public string USUARIO { get; set; }
        }

        public Frm_Reimprimir_Recibos()
        {
            InitializeComponent();
            S_Utilidades.Llenar_ComboBox<_CLIENTE>(cb_cliente, "NOMBRE", "REFERENCIA", "NOMBRE LIKE'%" + "" + "%' AND ESTADO='A'", "CLIENTES");
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

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            int numero = 0;
            string condicion = "";
            if (txt_numero_recibo.Text.Equals(""))
            {
                numero = 0;
            }
            else
            {
                numero = Convert.ToInt32(txt_numero_recibo.Text);
            }

            if (ch_incluir_fechas.Checked == true)
            {
                condicion = @"([ID_RECIBO] = " + numero + " OR 0 = " + numero + @")
                          and ([ESTADO] = '" + cb_estado.Text + "' OR '' = '" + cb_estado.Text + @"')
                          and ([NOMBRE] = '" + cb_cliente.Text + "' OR '' = '" + cb_cliente.Text + @"')
                          and ([COBRADOR] = '" + cb_cobrador.Text + "' OR '' = '" + cb_cobrador.Text + @"')
                          and ([FECHA_CREADO] Between('" + dt_desde.Value.Date + "', '" + dt_hasta.Value.Date + "'))";
            }
            else
            {
                condicion = @"([ID_RECIBO] = " + numero + " OR 0 = " + numero  + @")
                          and ([ESTADO] = '" + cb_estado.Text + "' OR '' = '" + cb_estado.Text + @"')
                          and ([NOMBRE] = '" + cb_cliente.Text + "' OR '' = '" + cb_cliente.Text + @"')
                          and ([COBRADOR] = '" + cb_cobrador.Text + "' OR '' = '" + cb_cobrador.Text + @"')";
            }

            Reportes.Rep_Recibo_Pago report = new Reportes.Rep_Recibo_Pago();
            report.FilterString = condicion;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Consultar_Recibos frm = new Frm_Consultar_Recibos();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Consultar_Cliente_Para_Factura frm = new Frm_Consultar_Cliente_Para_Factura();
            frm.ShowDialog();
        }
    }
}
