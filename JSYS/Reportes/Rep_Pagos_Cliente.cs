using Servicios;

namespace JSYS.Reportes
{
    public partial class Rep_Pagos_Cliente : DevExpress.XtraReports.UI.XtraReport
    {
        public Rep_Pagos_Cliente()
        {
            InitializeComponent();
            lbl_usuario.Text = S_Utilidades.Datos_Usuario.USUARIO;
        }

    }
}
