using Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace Datos
{
   public class D_Usuario
    {
       public List<E_Usuario> Listar_Usuario(string Condicion)
       {
           using (var db = new BD_JSYSEntities())
           {
               return db.Database.SqlQuery<E_Usuario>(@"SP_LISTAR_USUARIOS @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
           }
       }

       public void Insertar_Usuario(USUARIOS obj)
       {
           using (var db = new BD_JSYSEntities())
           {
               db.USUARIOS.Add(obj);
               db.SaveChanges();
           }
       }

       public void Actualizar_Usuario(USUARIOS obj)
       {
           using (var db = new BD_JSYSEntities())
           {
               var obj_usuario = db.USUARIOS.Find(obj.ID_USUARIO);
               obj_usuario.NOMBRE = obj.NOMBRE;
               obj_usuario.USUARIO = obj.USUARIO;
               obj_usuario.ESTADO = obj.ESTADO;
               obj_usuario.SEXO = obj.SEXO;
               obj_usuario.TIPO = obj.TIPO;
               db.SaveChanges();
           }
       }

       public void Actualizar_Clave_Usuario(USUARIOS obj)
       {
           using (var db = new BD_JSYSEntities())
           {
               var obj_usuario = db.USUARIOS.Find(obj.ID_USUARIO);
               obj_usuario.CLAVE = obj.CLAVE;
               db.SaveChanges();
           }
       }
    }
}
