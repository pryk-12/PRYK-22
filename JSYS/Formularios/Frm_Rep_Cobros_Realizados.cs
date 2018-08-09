using System;
using System.Collections.Generic;
using Datos;
using System.Linq;
using DevExpress.XtraReports.UI;
namespace JSYS.Formularios
{
    public partial class Frm_Rep_Cobros_Realizados : JSYS.Formularios.Frm_Plantilla
    {
        BD_JSYSEntities db = new BD_JSYSEntities();
        
        public Frm_Rep_Cobros_Realizados()
        {
            InitializeComponent();
            Llenar_ComboBox_Cobrador();
        }


        public class _USUARIO
        {
            public int ID_USUARIO { get; set; }
            public string USUARIO { get; set; }
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
            string condicion = "";
                condicion = @"([CREADO_POR] = '" + cb_cobrador.Text + "' OR '' = '" + cb_cobrador.Text + @"')
                          and ([FECHA_CREADO] Between('" + dt_desde.Value.Date + "', '" + dt_hasta.Value.Date + "'))";

            Reportes.Rep_Detalle_Cobros report = new Reportes.Rep_Detalle_Cobros();
            report.FilterString = condicion;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

    }
}
