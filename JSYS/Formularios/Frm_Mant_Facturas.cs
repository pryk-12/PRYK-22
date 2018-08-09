using Datos;
using DevExpress.XtraReports.UI;
using Servicios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JSYS.Formularios
{
    public partial class Frm_Mant_Facturas : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Mant_Facturas()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void Listar_Facturas()
        {
            string Condicion = "(B.NOMBRE LIKE'%" + Txt_Buscar.Text + "%' OR A.ID_FACTURA LIKE'%" + Txt_Buscar.Text + "%') ORDER BY A.ID_FACTURA DESC";
            DG.DataSource = S_Factura.Listar_Facturas(Condicion);
            Lbl_Total.Text = "Total de Registros:  " + DG.RowCount.ToString();
            Cambiar_Color_Filas();
        }

        void frm_Closed(object sender, EventArgs e)
        {
            Listar_Facturas();
        }

        public void Cambiar_Color_Filas()
        {
            int activo = 0;
            int anulado = 0;
            int abandonado = 0;
            int entregado = 0;
            int premio = 0;

            foreach (DataGridViewRow row in DG.Rows)
            {
                if (row.Cells[7].Value.ToString() == "Activo")
                {
                    row.DefaultCellStyle.BackColor = Color.PaleGoldenrod;
                    activo++;
                }
                else if (row.Cells[7].Value.ToString() == "Anulado")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    anulado++;
                }
                 else if (row.Cells[7].Value.ToString() == "Abandonado")
                {
                    row.DefaultCellStyle.BackColor = Color.DodgerBlue;
                    abandonado++;
                }
                 else if (row.Cells[7].Value.ToString() == "Entregado")
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    entregado++;
                }

                else if (row.Cells[7].Value.ToString() == "Premio por Rifa")
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    premio++;
                }
            }

            lbl_activo.Text = activo.ToString();
            lbl_anulado.Text = anulado.ToString();
            lbl_abandonado.Text = abandonado.ToString();
            lbl_entregado.Text = entregado.ToString();
            lbl_premio.Text = premio.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            Listar_Facturas();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_Factura frm = new Frm_Factura();
            frm.Closed += new EventHandler(frm_Closed);
            frm.ShowDialog();
        }

        public void Pasar_Datos()
        {
            if (DG.RowCount == 0)
            {
                return;
            }
            FACTURAS obj = new FACTURAS();
            obj.ID_FACTURA = Convert.ToInt32(DG.SelectedCells[0].Value);
            Frm_Factura frm = new Frm_Factura();
            frm.Recibir_Datos(obj);
            frm.Titulo("Editar Factura");
            frm.Closed += new EventHandler(frm_Closed);
            frm.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Pasar_Datos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime desde = dt_desde.Value;
            DateTime hasta = dt_hasta.Value;
            string Condicion = "(CONVERT(smalldatetime, CONVERT(char(10), A.FECHA, 103), 103) >= '" + desde.Date.ToString("yyyy-MM-dd") + "' and CONVERT(smalldatetime, CONVERT(char(10), A.FECHA, 103), 103) <= '" + hasta.Date.ToString("yyyy-MM-dd") + "')";
            DG.DataSource = S_Factura.Listar_Facturas(Condicion);
            Lbl_Total.Text = "Total de Registros:  " + DG.RowCount.ToString();
            Cambiar_Color_Filas();
        }

        private void Frm_Mant_Facturas_Activated(object sender, EventArgs e)
        {
            Cambiar_Color_Filas();
        }

        private void Frm_Mant_Facturas_Load(object sender, EventArgs e)
        {
            Listar_Facturas();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            btn_editar.PerformClick();
        }

        private void verReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DG.Rows.Count==0)
            {
                return;
            }
            Reportes.Rep_Factura report = new Reportes.Rep_Factura();
            report.FilterString = "([ID_FACTURA] = " + DG.SelectedCells[0].Value + ")";
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void detalleCuotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DG.Rows.Count == 0)
            {
                return;
            }
            Reportes.Rep_Detalle_Cuotas report = new Reportes.Rep_Detalle_Cuotas();
            report.FilterString = "([ID_FACTURA] = " + DG.SelectedCells[0].Value + ")";
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }
    }
}
