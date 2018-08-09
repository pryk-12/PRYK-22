using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Servicios;

namespace JSYS.Reportes
{
    public partial class Rep_Listado_Facturas : DevExpress.XtraReports.UI.XtraReport
    {
        public Rep_Listado_Facturas()
        {
            InitializeComponent();
            lbl_usuario.Text = S_Utilidades.Datos_Usuario.USUARIO;
        }

    }
}
