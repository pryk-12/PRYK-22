using Datos;
using Servicios;
using System;
using System.Data;
using System.Windows.Forms;

namespace JSYS.Formularios
{
    public partial class Frm_Permisos : JSYS.Formularios.Frm_Plantilla
    {
        public class _USUARIO
        {
            public int ID_USUARIO { get; set; }
            public string USUARIO { get; set; }
        }

        public Frm_Permisos()
        {
            InitializeComponent();
            S_Utilidades.Llenar_ComboBox<_USUARIO>(cb_usuario, "USUARIO", "ID_USUARIO", "USUARIO LIKE'%" + "" + "%' AND ESTADO='A'", "USUARIOS");
        }

       

        private void cb_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if(cb_usuario.Text =="" && DG.Rows.Count > 0)
            {
                DG.DataSource = null;
                return;
            }
            try
            {
                string condicion ="USUARIO='"+ cb_usuario.Text +"'";

                if( S_Permiso.Listar_Permisos(condicion).Count == 0 )
                {
                    DG.DataSource = S_Permiso.Listar_Pantallas("PANTALLA LIKE'%" + "" + "%'");
                    DG.Columns[0].Width = 345;
                    DG.Columns[1].Width = 80;
                }
                else
                {
                    DG.DataSource = S_Permiso.Listar_Permisos(condicion);
                    DG.Columns[0].Width = 345;
                    DG.Columns[1].Width = 80;

                }
            }
            catch
            {
                
            }
        }

        private void Frm_Permisos_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in this.DG.Rows)
            {
                fila.Cells[1].Value = true;
            }
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in this.DG.Rows)
            {
                fila.Cells[1].Value = false;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(cb_usuario.Text=="")
            {
                S_Utilidades.Mensaje_Informacion("Se debe seleccionar el Usuario");
                return;
            }
            if(DG.Rows.Count==0)
            {
                S_Utilidades.Mensaje_Informacion("No hay datos");
                return;
            }
            PERMISOS obj = new PERMISOS();
            obj.USUARIO = cb_usuario.Text;

            string condicion = "USUARIO='" + cb_usuario.Text + "'";
            if (S_Permiso.Listar_Permisos(condicion).Count > 0)
            {
                S_Permiso.Eliminar_Permiso(obj);
            }
            foreach (DataGridViewRow fila in this.DG.Rows)
            {
                obj.PANTALLA = fila.Cells[0].Value.ToString();
                obj.ACCESO= Convert.ToBoolean(fila.Cells[1].Value.ToString());

                S_Permiso.Insertar_Permiso(obj);
            }

            S_Utilidades.Mensaje_Informacion("Datos Guardados Con Exito");
            cb_usuario.Text = "";
            DG.DataSource = null;
        }
    }
}
