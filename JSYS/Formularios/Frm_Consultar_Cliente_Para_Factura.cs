using Servicios;
using System;
using System.Windows.Forms;

namespace JSYS.Formularios
{
    public partial class Frm_Consultar_Cliente_Para_Factura : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Consultar_Cliente_Para_Factura()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void Listar_Clientes()
        {
            string Condicion = "(NUMERO_IDENTIFICACION LIKE'%" + Txt_Buscar.Text + "%' OR NOMBRE LIKE'%" + Txt_Buscar.Text + "%' OR REFERENCIA LIKE'%" + Txt_Buscar.Text + "%') AND ESTADO='A'";
            DG.DataSource = S_Cliente.Listar_Clientes(Condicion);
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            if (DG.Rows.Count > 0)
            {
                Frm_Factura dato = new Frm_Factura();
                Frm_Rep_Facturas dato1 = new Frm_Rep_Facturas();
                Frm_Reimprimir_Recibos dato2 = new Frm_Reimprimir_Recibos();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "Frm_Factura")
                    {
                        dato = (Frm_Factura)frm;
                        dato.cb_cliente.Text = DG.SelectedCells[2].Value.ToString();
                        this.Close();
                        break;
                    }
                    else if (frm.Name == "Frm_Rep_Facturas")
                    {
                        dato1 = (Frm_Rep_Facturas)frm;
                        dato1.cb_cliente.Text = DG.SelectedCells[2].Value.ToString();
                        this.Close();
                        break;
                    }
                    else if (frm.Name == "Frm_Reimprimir_Recibos")
                    {
                        dato2 = (Frm_Reimprimir_Recibos)frm;
                        dato2.cb_cliente.Text = DG.SelectedCells[2].Value.ToString();
                        this.Close();
                        break;
                    }
                }
            }
        }

        private void Frm_Consultar_Cliente_Para_Factura_Load(object sender, EventArgs e)
        {
            Listar_Clientes();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            Listar_Clientes();
        }
    }
}
