using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class D_Tipo_Identificacion
    {
        public List<TIPOS_IDENTIFICACIONES> Listar_Tipos_Identificaciones(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<TIPOS_IDENTIFICACIONES>(@"SP_LISTAR_TIPOS_IDENTIFICACIONES @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public void Insertar_Tipo_Identificacion(TIPOS_IDENTIFICACIONES obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.TIPOS_IDENTIFICACIONES.Add(obj);
                db.SaveChanges();
            }
        }

        public void Actualizar_Tipo_Identificacion(TIPOS_IDENTIFICACIONES obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_tipo = db.TIPOS_IDENTIFICACIONES.Find(obj.ID_TIPO_IDENTIFICACION);
                obj_tipo.DESCRIPCION = obj.DESCRIPCION;
                db.SaveChanges();
            }
        }

    }
}
