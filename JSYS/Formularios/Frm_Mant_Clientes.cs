using Datos;
using Servicios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JSYS.Formularios
{
    public partial class Frm_Mant_Clientes : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Mant_Clientes()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void Listar_Clientes()
        {
            string Condicion = "(C.NUMERO_IDENTIFICACION LIKE'%" + Txt_Buscar.Text + "%' OR C.NOMBRE LIKE'%" + Txt_Buscar.Text + "%' OR C.REFERENCIA LIKE'%" + Txt_Buscar.Text + "%')";
            DG.DataSource = S_Cliente.Listar_Clientes(Condicion);
            Lbl_Total.Text = "Total de Registros:  " + DG.RowCount.ToString();
            Cambiar_Color_Filas();
        }

        public void Cambiar_Color_Filas()
        {
            int activo = 0;
            int inactivo = 0;
            foreach (DataGridViewRow row in DG.Rows)
            {
                if (row.Cells[10].Value.ToString() == "Inactivo")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    inactivo++;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.PaleGoldenrod;
                    activo++;
                }
            }
            lbl_activo.Text = activo.ToString();
            lbl_inactivo.Text = inactivo.ToString();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            Listar_Clientes();
        }

        void frm_Closed(object sender, EventArgs e)
        {
            Listar_Clientes();
        }

        public void Pasar_Datos()
        {
            if (DG.RowCount == 0)
            {
                return;
            }
            CLIENTES obj = new CLIENTES();
            obj.REFERENCIA = DG.SelectedCells[0].Value.ToString();
            Frm_Cliente frm = new Frm_Cliente();
            frm.Recibir_Datos(obj);
            frm.Titulo("Editar Cliente");
            frm.Closed += new EventHandler(frm_Closed);
            frm.ShowDialog();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            btn_editar.PerformClick();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_Cliente frm = new Frm_Cliente();
            frm.Closed += new EventHandler(frm_Closed);
            frm.Titulo("Agregar Cliente");
            frm.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Pasar_Datos();
        }

        private void Frm_Mant_Clientes_Load(object sender, EventArgs e)
        {
            Listar_Clientes();
        }

        private void Frm_Mant_Clientes_Activated(object sender, EventArgs e)
        {
            Cambiar_Color_Filas();
        }
    }
}
