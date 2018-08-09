using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Servicios;

namespace JSYS.Reportes
{
    public partial class Rep_Detalle_Cuotas : DevExpress.XtraReports.UI.XtraReport
    {
        public Rep_Detalle_Cuotas()
        {
            InitializeComponent();
            lbl_usuario.Text = S_Utilidades.Datos_Usuario.USUARIO;
        }

    }
}
