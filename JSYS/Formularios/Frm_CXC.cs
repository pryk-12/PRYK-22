using Servicios;
using System;

namespace JSYS.Formularios
{
    public partial class Frm_CXC : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_CXC()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        void frm_Closed(object sender, EventArgs e)
        {
            Listar_Facturas();
        }

        public void Listar_Facturas()
        {
            string Condicion = "(B.NOMBRE LIKE'%" + Txt_Buscar.Text + "%' OR A.ID_FACTURA LIKE'%" + Txt_Buscar.Text + "%') AND A.MONTO_PENDIENTE>0 AND A.ID_ESTADO=1 ORDER BY A.ID_FACTURA DESC";
            DG.DataSource = S_Factura.Listar_Facturas(Condicion);
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            Listar_Facturas();
        }

        private void Frm_CXC_Load(object sender, EventArgs e)
        {
            Listar_Facturas();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if(DG.Rows.Count ==0)
            {
                return;
            }

            Frm_Cobrar_CXC frm = new Formularios.Frm_Cobrar_CXC();
            frm.Recibir_Datos(Convert.ToInt32(DG.SelectedCells[0].Value));
            frm.Closed += new EventHandler(frm_Closed);
            frm.ShowDialog();
        }
    }
}
