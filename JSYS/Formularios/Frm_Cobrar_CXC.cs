using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Datos;
using DevExpress.XtraReports.UI;

namespace JSYS.Formularios
{
    public partial class Frm_Cobrar_CXC : JSYS.Formularios.Frm_Plantilla
    {
        BD_JSYSEntities db = new BD_JSYSEntities();
        public Frm_Cobrar_CXC()
        {
            InitializeComponent();
            dg_detalle_cuotas.AutoGenerateColumns = false;
        }

        public void Recibir_Datos(int id_factura)
        {
            //detalle cuotas
            List<E_Detalles_Cuota> Lista_Cuotas = S_Factura.Listar_Detalles_Cuotas_CXC("A.ID_FACTURA=" + id_factura + " AND A.MONTO_PENDIENTE>0");
            dg_detalle_cuotas.Rows.Clear();
            foreach (E_Detalles_Cuota p in Lista_Cuotas)
            {
                dg_detalle_cuotas.Rows.Add(p.NUMERO_CUOTA, p.FECHA.ToString("dd/MM/yyyy"), p.MONTO_PENDIENTE, p.SEL, p.A_PAGAR);
            }
            dg_detalle_cuotas.DataSource = null;

            Txt_ID.Text = id_factura.ToString();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (dg_detalle_cuotas.Rows.Count == 0)
            {
                return;
            }
            txt_total.Text = "0";
            decimal monto = 0;
            foreach (DataGridViewRow row in dg_detalle_cuotas.Rows)
            {
                try
                {
                    if (Convert.ToBoolean(row.Cells[3].Value) == true)
                    {
                        decimal valor_cuota = Convert.ToDecimal(row.Cells[2].Value);
                        decimal valor_pagado = Convert.ToDecimal(row.Cells[4].Value);
                        decimal diferencia = valor_cuota - valor_pagado;

                        if ((diferencia == valor_cuota) || (valor_pagado > valor_cuota) || (valor_cuota == valor_pagado))
                        {
                            monto = Convert.ToDecimal(row.Cells[2].Value) + Convert.ToDecimal(txt_total.Text);
                            txt_total.Text = monto.ToString("N2");
                        }
                        else if (valor_cuota > valor_pagado)
                        {
                            monto = Convert.ToDecimal(row.Cells[4].Value) + Convert.ToDecimal(txt_total.Text);
                            txt_total.Text = monto.ToString("N2");
                        }
                    }
                }
                catch (Exception ex)
                {
                    S_Utilidades.Mensaje_Error(ex.Message);
                }
            }
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (dg_detalle_cuotas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dg_detalle_cuotas.Rows)
                {
                    row.Cells[3].Value = true;
                }
            }
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (dg_detalle_cuotas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dg_detalle_cuotas.Rows)
                {
                    row.Cells[3].Value = false;
                }
            }
        }

        private void dg_detalle_cuotas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;

            dText.KeyPress -= new KeyPressEventHandler(OnlyNumbers_KeyPress);
            dText.KeyPress += new KeyPressEventHandler(OnlyNumbers_KeyPress);
        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.')
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) // Si no es numérico y si no es espacio
                {
                    // Invalidar la accion
                    e.Handled = true;
                    // Enviar el sonido de beep de windows
                    System.Media.SystemSounds.Beep.Play();
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_total.TextLength == 0)
            {
                S_Utilidades.Mensaje_Informacion("No hay Cuota(s) Seleccionada(s)");
                return;
            }

            DETALLES_CUOTAS obj_detalle = new DETALLES_CUOTAS();
            RECIBOS_COBRADOS obj_recibo = new RECIBOS_COBRADOS();
            FACTURAS obj_factura = new FACTURAS();
            try
            {
                foreach (DataGridViewRow row in dg_detalle_cuotas.Rows)
                {
                    obj_detalle.ID_FACTURA = Convert.ToInt32(Txt_ID.Text);
                    if (Convert.ToBoolean(row.Cells[3].Value) == true && Convert.ToDecimal(row.Cells[4].Value) > 0)
                    {
                        if (Convert.ToDecimal(row.Cells[4].Value) > Convert.ToDecimal(row.Cells[2].Value))
                        {
                            //actualizar totales de cuotas
                            obj_detalle.MONTO_PAGADO = Convert.ToDecimal(row.Cells[2].Value);
                            obj_detalle.MONTO_PENDIENTE = 0;
                            obj_detalle.NUMERO_CUOTA = Convert.ToInt32(row.Cells[0].Value);
                            S_Factura.Cobrar_Cuota(obj_detalle);

                            //actualizar totales de factura
                            obj_factura.ID_FACTURA = Convert.ToInt32(Txt_ID.Text);
                            obj_factura.MONTO_PAGADO = obj_detalle.MONTO_PAGADO;
                            S_Factura.Actualizar_Montos_Factura(obj_factura);

                            //asignar montos de recibos
                            obj_recibo.VALOR_PAGADO = Convert.ToDecimal(row.Cells[2].Value);
                            obj_recibo.VALOR_PENDIENTE = 0;
                        }
                        else
                        {
                            //actualizar totales de cuotas
                            obj_detalle.MONTO_PAGADO = Convert.ToDecimal(row.Cells[4].Value);
                            obj_detalle.MONTO_PENDIENTE = Convert.ToDecimal(row.Cells[2].Value) - Convert.ToDecimal(row.Cells[4].Value);
                            obj_detalle.NUMERO_CUOTA = Convert.ToInt32(row.Cells[0].Value);
                            S_Factura.Cobrar_Cuota(obj_detalle);

                            //actualizar totales de factura
                            obj_factura.ID_FACTURA = Convert.ToInt32(Txt_ID.Text);
                            obj_factura.MONTO_PAGADO = obj_detalle.MONTO_PAGADO;
                            S_Factura.Actualizar_Montos_Factura(obj_factura);

                            //asignar montos de recibos
                            obj_recibo.VALOR_PAGADO = Convert.ToDecimal(row.Cells[4].Value);
                            obj_recibo.VALOR_PENDIENTE = obj_detalle.MONTO_PENDIENTE;
                        }
                    }
                    else if (Convert.ToBoolean(row.Cells[3].Value) == true)
                    {
                        //actualizar totales de cuotas
                        obj_detalle.MONTO_PAGADO = Convert.ToDecimal(row.Cells[2].Value);
                        obj_detalle.MONTO_PENDIENTE = 0;
                        obj_detalle.NUMERO_CUOTA = Convert.ToInt32(row.Cells[0].Value);
                        S_Factura.Cobrar_Cuota(obj_detalle);

                        //actualizar totales de factura
                        obj_factura.ID_FACTURA = Convert.ToInt32(Txt_ID.Text);
                        obj_factura.MONTO_PAGADO = obj_detalle.MONTO_PAGADO;
                        S_Factura.Actualizar_Montos_Factura(obj_factura);

                        //asignar montos de recibos
                        obj_recibo.VALOR_PAGADO = Convert.ToDecimal(row.Cells[2].Value);
                        obj_recibo.VALOR_PENDIENTE = 0;
                    }

                    if (Convert.ToBoolean(row.Cells[3].Value) == true)
                    {
                        //insertar recibos de cobros
                        obj_recibo.ANULADO_POR = "";
                        obj_recibo.CREADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
                        int ID_FACTURA = Convert.ToInt32(Txt_ID.Text);
                        var obj_encabezado = db.ENCABEZADO_CUOTAS.Where(a => a.ID_FACTURA == ID_FACTURA).Single();
                        obj_recibo.CANTIDAD_CUOTAS = obj_encabezado.CANTIADA_CUOTA;
                        obj_recibo.CUOTA_COBRADA = Convert.ToInt32(row.Cells[0].Value);
                        obj_recibo.ESTADO = "V";
                        obj_recibo.FECHA_ANULADO = "";
                        obj_recibo.FECHA_CREADO = DateTime.Now;
                        obj_recibo.ID_FACTURA = Convert.ToInt32(Txt_ID.Text);
                        var obj_fact = db.FACTURAS.Where(f => f.ID_FACTURA == ID_FACTURA).Single();
                        obj_recibo.NOTA_ANULACION = "";
                        obj_recibo.VALOR_CUOTA = Convert.ToDecimal(row.Cells[2].Value);
                        S_Factura.Insertar_Recibo_Cobros(obj_recibo);
                    }
                }

                String arry="";
                int id_factura = Convert.ToInt32(Txt_ID.Text);
                
                foreach (DataGridViewRow row in dg_detalle_cuotas.Rows)
                {
                    int cuota=Convert.ToInt32(row.Cells[0].Value);
                    if(Convert.ToBoolean(row.Cells[3].Value) == true)
                    {
                        var id_recibo = db.RECIBOS_COBRADOS.Where(s => s.ID_FACTURA == id_factura && s.CUOTA_COBRADA == cuota).Max(s => s.ID_RECIBO);

                        arry += id_recibo.ToString() + ",";
                    }
                }
                String recibos = arry.TrimEnd(',');


               
                S_Utilidades.Mensaje_Informacion("Cobros Realizados con Correctamente por un Monto Total de: " + txt_total.Text);

                Reportes.Rep_Recibo_Pago report = new Reportes.Rep_Recibo_Pago();
                report.FilterString = "([ID_FACTURA] = " + Txt_ID.Text + " AND [ID_RECIBO] IN (" + recibos + "))";
                ReportPrintTool tool = new ReportPrintTool(report);
                tool.ShowPreview();

                Close();
            }
            catch (Exception ex)
            {
                S_Utilidades.Mensaje_Informacion(ex.Message);
            }
        }
    }
}
