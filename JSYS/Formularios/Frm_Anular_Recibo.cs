using Datos;
using Servicios;
using System;
using System.Windows.Forms;

namespace JSYS.Formularios
{
    public partial class Frm_Anular_Recibo : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Anular_Recibo()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
            S_Utilidades.Llenar_ComboBox<JSYS.Formularios.Frm_Factura._USUARIO>(cb_cobrador, "NOMBRE", "ID_USUARIO", "NOMBRE LIKE'%" + "" + "%' AND ESTADO='A' AND TIPO='Cobrador'", "USUARIOS");
        }

        private void cb_buscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_buscar.Text =="Cobrador")
            {
                txt_buscar.Visible = false;
                cb_cobrador.Visible = true;
            }
            else
            {
                txt_buscar.Visible = true;
                cb_cobrador.Visible = false;
            }
        }

        public void Listar_Recibos()
        {
            string Condicion = "";
            DateTime desde = dt_desde.Value;
            DateTime hasta = dt_hasta.Value;
            try
            {
                if (cb_buscar.Text == "Cobrador")
                {
                    Condicion = "(B.ID_COBRADOR=" + cb_cobrador.SelectedValue + " AND A.ESTADO='V' AND E.RE_CALCULADO='NO' AND B.ID_ESTADO IN (1,5) AND (CONVERT(smalldatetime, CONVERT(char(10), A.FECHA_CREADO, 103), 103) >= '" + desde.Date.ToString("yyyy-MM-dd") + "' and CONVERT(smalldatetime, CONVERT(char(10), A.FECHA_CREADO, 103), 103) <= '" + hasta.Date.ToString("yyyy-MM-dd") + "'))";
                }
                if (cb_buscar.Text == "No. Contrato")
                {
                    Condicion = "(A.ID_FACTURA=" + txt_buscar.Text + " AND A.ESTADO='V' AND E.RE_CALCULADO='NO' AND B.ID_ESTADO IN (1,5) AND (CONVERT(smalldatetime, CONVERT(char(10), A.FECHA_CREADO, 103), 103) >= '" + desde.Date.ToString("yyyy-MM-dd") + "' and CONVERT(smalldatetime, CONVERT(char(10), A.FECHA_CREADO, 103), 103) <= '" + hasta.Date.ToString("yyyy-MM-dd") + "'))";
                }
                if (cb_buscar.Text == "No. Recibo")
                {
                    Condicion = "(A.ID_RECIBO=" + txt_buscar.Text + " AND A.ESTADO='V' AND E.RE_CALCULADO='NO' AND B.ID_ESTADO IN (1,5) AND (CONVERT(smalldatetime, CONVERT(char(10), A.FECHA_CREADO, 103), 103) >= '" + desde.Date.ToString("yyyy-MM-dd") + "' and CONVERT(smalldatetime, CONVERT(char(10), A.FECHA_CREADO, 103), 103) <= '" + hasta.Date.ToString("yyyy-MM-dd") + "'))";
                }
                DG.DataSource = S_Factura.Listar_Recibos(Condicion);
            }
            catch
            {

            }          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listar_Recibos();
        }

        private void btn_anular_Click(object sender, EventArgs e)
        {
            if(DG.Rows.Count == 0)
            {
                return;
            }
            if(txt_observacion.Text =="")
            {
                S_Utilidades.Mensaje_Informacion("La Observación es Obligatoria");
                return;
            }
            DialogResult Resultado = MessageBox.Show("Deseas Anular Recibo(s)", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.Yes)
            {
                FACTURAS obj_factura = new FACTURAS();
                DETALLES_CUOTAS obj_detelle = new DETALLES_CUOTAS();
                RECIBOS_COBRADOS obj_recibo = new RECIBOS_COBRADOS();

                foreach (DataGridViewRow row in DG.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[6].Value) == true)
                    {
                        int id_factura = Convert.ToInt32(row.Cells[2].Value);
                        decimal valor_pagado = Convert.ToDecimal(row.Cells[4].Value);

                        obj_factura.ID_FACTURA = id_factura;
                        obj_factura.MONTO_PAGADO = valor_pagado;
                        S_Factura.Actualizar_Montos_Factura_Recibo_Anulado(obj_factura);

                        obj_detelle.ID_FACTURA = id_factura;
                        obj_detelle.NUMERO_CUOTA = Convert.ToInt32(row.Cells[3].Value);
                        obj_detelle.MONTO_PAGADO = valor_pagado;
                        S_Factura.Anular_Detalle_Cuota(obj_detelle);

                        obj_recibo.ID_RECIBO = Convert.ToInt32(row.Cells[0].Value);
                        obj_recibo.ESTADO = "A";
                        obj_recibo.FECHA_ANULADO = DateTime.Now.ToString();
                        obj_recibo.ANULADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
                        obj_recibo.NOTA_ANULACION = txt_observacion.Text.Trim();
                        S_Factura.Anular_Recibo(obj_recibo);
                    }
                }

                S_Utilidades.Mensaje_Informacion("Recibos Anulados Correctamente");
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Condicion = "";
            try
            {
                if (cb_buscar.Text == "Cobrador")
                {
                    Condicion = "(B.ID_COBRADOR=" + cb_cobrador.SelectedValue + " AND A.ESTADO='V' AND E.RE_CALCULADO='NO' AND B.ID_ESTADO IN (1,5))";
                }
                if (cb_buscar.Text == "No. Contrato")
                {
                    Condicion = "(A.ID_FACTURA=" + txt_buscar.Text + " AND A.ESTADO='V' AND E.RE_CALCULADO='NO' B.ID_ESTADO IN (1,5))";
                }
                if (cb_buscar.Text == "No. Recibo")
                {
                    Condicion = "(A.ID_RECIBO=" + txt_buscar.Text + " AND A.ESTADO='V' AND E.RE_CALCULADO='NO' B.ID_ESTADO IN (1,5))";
                }
                DG.DataSource = S_Factura.Listar_Recibos(Condicion);
            }
            catch
            {

            }
        }
    }
}
