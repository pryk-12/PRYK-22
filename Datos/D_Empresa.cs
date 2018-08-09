using Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
   public class D_Empresa
    {
       public List<E_Empresa> Listar_Empresa(string Condicion)
       {
           using (var db = new BD_JSYSEntities())
           {
               return db.Database.SqlQuery<E_Empresa>(@"SP_LISTAR_EMPRESA @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
           }
       }

       public void Actualizar_Empresa(EMPRESA obj)
       {
           using (var db = new BD_JSYSEntities())
           {
               var obj_empresa = db.EMPRESA.Find(obj.ID_EMPRESA);
               obj_empresa.CELULAR = obj.CELULAR;
               obj_empresa.DIRECCION = obj.DIRECCION;
               obj_empresa.EMAIL = obj.EMAIL;
               obj_empresa.ESLOGAN = obj.ESLOGAN;
               obj_empresa.FAX = obj.FAX;
               obj_empresa.ID_TIPO_IDENTIFICACION = obj.ID_TIPO_IDENTIFICACION;
               obj_empresa.IMPRESORA = obj.IMPRESORA;
               obj_empresa.LOGO = obj.LOGO;
               obj_empresa.NOMBRE = obj.NOMBRE;
               obj_empresa.NUMERO_IDENTIFICACION = obj.NUMERO_IDENTIFICACION;
               obj_empresa.PAGINA_WEB = obj.PAGINA_WEB;
               obj_empresa.TELEFONO = obj.TELEFONO;
               db.SaveChanges();
           }
       }
    }
}
