using Servicios;
using System;
using System.Windows.Forms;

namespace JSYS.Formularios
{
    public partial class Frm_Consultar_Facturas_Anuladas : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Consultar_Facturas_Anuladas()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void Listar_Facturas()
        {
            try
            {
                string Condicion = "";

                if (cb_buscar.Text == "No. Contrato")
                {
                    Condicion = "(A.ID_FACTURA =" + Txt_Buscar.Text + ")";
                }
                if (cb_buscar.Text == "Cedula" || cb_buscar.Text == "")
                {
                    Condicion = "(B.NUMERO_IDENTIFICACION LIKE'%" + Txt_Buscar.Text + "%')";
                }
                if (cb_buscar.Text == "Cliente" || cb_buscar.Text =="")
                {
                    Condicion = "(B.NOMBRE LIKE'%" + Txt_Buscar.Text + "%')";
                }
                if (cb_buscar.Text == "Cobrador")
                {
                    Condicion = "(C.NOMBRE LIKE'%" + Txt_Buscar.Text + "%')";
                }
                if (cb_buscar.Text == "Estado")
                {
                    Condicion = "(E.DESCRIPCION LIKE'%" + Txt_Buscar.Text + "%')";
                }
                DG.DataSource = S_Factura.Listar_Facturas(Condicion + " AND A.ID_ESTADO<>1 ORDER BY A.ID_FACTURA DESC");
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listar_Facturas();
        }

        private void DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DG.RowCount == 0)
            {
                return;
            }
            txt_observacion.Text = DG.SelectedCells[10].Value.ToString();
        }
    }
}
