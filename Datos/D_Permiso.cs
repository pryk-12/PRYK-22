using Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
   public class D_Permiso
    {
        public List<E_Permiso> Listar_Permisos(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Permiso>(@"SP_LISTAR_PERMISOS @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public List<E_Permiso> Listar_Pantallas(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Permiso>(@"SP_LISTAR_PANTALLAS @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public void Insertar_Permiso(PERMISOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.PERMISOS.Add(obj);
                db.SaveChanges();
            }
        }

        public void Eliminar_Permiso(PERMISOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_permiso = db.PERMISOS.Where(e => e.USUARIO == obj.USUARIO).ToList();
                db.PERMISOS.RemoveRange(obj_permiso);
                db.SaveChanges();
            }
        }
    }
}
