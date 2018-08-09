using DevExpress.XtraReports.UI;
using System;

namespace JSYS.Formularios
{
    public partial class Frm_Rep_Cuadre : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Rep_Cuadre()
        {
            InitializeComponent();
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            string condicion = "";
            condicion = @"([FECHA] Between('" + dt_desde.Value.Date + "', '" + dt_hasta.Value.Date + "'))";

            Reportes.Rep_Cuadre_Diario report = new Reportes.Rep_Cuadre_Diario();
            report.FilterString = condicion;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }
    }
}
