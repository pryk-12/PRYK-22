using Servicios;
using System;
using System.Windows.Forms;

namespace JSYS.Formularios
{
    public partial class Frm_Consultar_Recibos_Anulados : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Consultar_Recibos_Anulados()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void Listar_Recibos(string Condicion)
        {
            DG.DataSource = S_Factura.Listar_Recibos(Condicion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Cond = "";
                if (cb_buscar.Text == "No. Recibo")
                {
                    Cond = "(A.ID_RECIBO=" + Txt_Buscar.Text + " AND A.ESTADO='A')";
                }
                else if (cb_buscar.Text == "No. Contrato")
                {
                    Cond = "(A.ID_FACTURA=" + Txt_Buscar.Text + " AND A.ESTADO='A')";
                }
                else if (cb_buscar.Text == "Cliente")
                {
                    Cond = "(C.NOMBRE LIKE'%" + Txt_Buscar.Text + "%' AND A.ESTADO='A')";
                }
                else if (cb_buscar.Text == "Cedula")
                {
                    Cond = "(C.NUMERO_IDENTIFICACION LIKE'%" + Txt_Buscar.Text + "%' AND A.ESTADO='A')";
                }
                else if (cb_buscar.Text == "Cobrador" || cb_buscar.Text == "")
                {
                    Cond = "(D.USUARIO LIKE'%" + Txt_Buscar.Text + "%'  AND A.ESTADO='A')";
                }

                Listar_Recibos(Cond + " ORDER BY A.ID_RECIBO DESC");
            }
            catch
            {
            }
        }

        private void DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DG.RowCount == 0)
            {
                return;
            }
            txt_observacion.Text = DG.SelectedCells[9].Value.ToString();
        }
    }
}
