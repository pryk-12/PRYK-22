using Datos;
using Servicios;
using System;
using System.Linq;

namespace JSYS.Formularios
{
    public partial class Frm_Cuadre_Diario : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Cuadre_Diario()
        {
            InitializeComponent();
        }

        public void Listar_Cuadre()
        {
            DateTime fecha = dt_fecha.Value;
            txt_recibo_pagado.Text = S_Factura.Listar_Cuadre(fecha)[0].VALOR_PAGADO.ToString("N2");
            txt_recibo_anulado.Text = S_Factura.Listar_Cuadre(fecha)[0].VALOR_ANULADO.ToString("N2");
            txt_valor_descuento.Text = S_Factura.Listar_Cuadre(fecha)[0].VALOR_DESCUENTO.ToString("N2");    
            decimal total_recibo = Convert.ToDecimal(txt_recibo_pagado.Text) - (Convert.ToDecimal(txt_recibo_anulado.Text) + Convert.ToDecimal(txt_valor_descuento.Text));
            txt_recibo_total.Text = total_recibo.ToString("N2");
        }

        private void Frm_Cuadre_Diario_Load(object sender, EventArgs e)
        {
            Listar_Cuadre();
        }

        private void dt_fecha_ValueChanged(object sender, EventArgs e)
        {
            Listar_Cuadre();
        }

        private void btn_entregar_Click(object sender, EventArgs e)
        {
            try
            {
                BD_JSYSEntities db = new BD_JSYSEntities();
                CUADRES_DIARIOS obj_cuadre = new CUADRES_DIARIOS();
                string fecha = dt_fecha.Value.Date.ToString("dd/MM/yyyy");
                obj_cuadre.FECHA = fecha;
                obj_cuadre.VALOR_ANULADO = Convert.ToDecimal(txt_recibo_anulado.Text);
                obj_cuadre.VALOR_PAGADO = Convert.ToDecimal(txt_recibo_pagado.Text);
                obj_cuadre.VALOR_DESCUENTO = Convert.ToDecimal(txt_valor_descuento.Text);
                obj_cuadre.VALOR_TOTAL = Convert.ToDecimal(txt_recibo_total.Text);

                var obj = db.CUADRES_DIARIOS.Where(c => c.FECHA == fecha);

                if(obj.Count() == 0)
                {                   
                    S_Factura.Insertar_Cuadre_Diario(obj_cuadre);
                }
                else
                {
                    S_Factura.Actualizar_Cuadre_Diario(obj_cuadre);
                }

                S_Utilidades.Mensaje_Informacion("Cuadre Guardado Correctamente");
                Close();

            }
            catch (Exception ex)
            {
                S_Utilidades.Mensaje_Error(ex.Message);
            }
        }
    }
}
