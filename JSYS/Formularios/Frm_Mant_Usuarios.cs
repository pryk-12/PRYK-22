using System;
using Servicios;
using Datos;
using System.Windows.Forms;
using System.Drawing;


namespace JSYS.Formularios
{
    public partial class Frm_Mant_Usuarios : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Mant_Usuarios()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void Lista_Usuarios()
        {
            string Condicion = "ID_USUARIO LIKE'%" + Txt_Buscar.Text + "%' OR USUARIO LIKE'%" + Txt_Buscar.Text + "%' OR NOMBRE LIKE'%" + Txt_Buscar.Text + "%'";
            DG.DataSource = S_Usuario.Listar_Usuario(Condicion);
            Lbl_Total.Text = "Total de Registros:  "+DG.RowCount.ToString();
            Cambiar_Color_Filas();
        }

        public void Cambiar_Color_Filas()
        {
            int activo = 0;
            int inactivo = 0;
            foreach (DataGridViewRow row in DG.Rows)
            {
                if (row.Cells[5].Value.ToString() == "Inactivo")
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
            Lista_Usuarios();
        }

        void frm_Closed(object sender, EventArgs e)
        {
            Lista_Usuarios();
        }

        public void Pasar_Datos()
        {
            if(DG.RowCount == 0)
            {
                return;
            }
            USUARIOS obj = new USUARIOS();
            obj.ID_USUARIO = Convert.ToInt32(DG.SelectedCells[0].Value);
            Frm_Usuario frm = new Frm_Usuario();
            frm.Recibir_Datos(obj);
            frm.Titulo("Editar Usuario");
            frm.Closed += new EventHandler(frm_Closed);
            frm.ShowDialog();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            btn_editar.PerformClick();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_Usuario frm = new Frm_Usuario();
            frm.Closed += new EventHandler(frm_Closed);
            frm.Titulo("Agregar Usuario");
            frm.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Pasar_Datos();
        }

        private void Frm_Mant_Usuarios_Load(object sender, EventArgs e)
        {
            Lista_Usuarios();
        }

        private void Frm_Mant_Usuarios_Activated(object sender, EventArgs e)
        {
            Cambiar_Color_Filas();
        }

       
    }
}
