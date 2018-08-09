using Servicios;
using System;
using System.Windows.Forms;

namespace JSYS.Formularios
{
    public partial class Frm_Consultar_Recibos : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Consultar_Recibos()
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
            string Cond = "";
            if(cb_buscar.Text=="Numero Recibo")
            {
                Cond = "(A.ID_RECIBO="+ Txt_Buscar.Text +")";
            }
            else if(cb_buscar.Text =="Numero Factura")
            {
                Cond = "(A.ID_FACTURA=" + Txt_Buscar.Text + ")";
            }
            else if (cb_buscar.Text == "Cliente")
            {
                Cond = "(C.NOMBRE LIKE'%" + Txt_Buscar.Text + "%')";
            }
            else if (cb_buscar.Text == "Cedula")
            {
                Cond = "(C.NUMERO_IDENTIFICACION LIKE'%" + Txt_Buscar.Text + "%')";
            }
            else if (cb_buscar.Text == "Cobrador" || cb_buscar.Text =="")
            {
                Cond = "(D.USUARIO LIKE'%" + Txt_Buscar.Text + "%')";
            }

            Listar_Recibos(Cond+" ORDER BY A.ID_RECIBO DESC");
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            if (DG.Rows.Count > 0)
            {
                Frm_Reimprimir_Recibos dato = new Frm_Reimprimir_Recibos();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "Frm_Reimprimir_Recibos")
                    {
                        dato = (Frm_Reimprimir_Recibos)frm;
                        dato.txt_numero_recibo.Text  = DG.SelectedCells[0].Value.ToString();
                        this.Close();
                        break;
                    }
                   
                }
            }
        }
    }
}
