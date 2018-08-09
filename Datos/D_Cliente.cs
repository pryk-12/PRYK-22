using Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
   public class D_Cliente
    {
        public List<E_Cliente> Listar_Clientes(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Cliente>(@"SP_LISTAR_CLIENTES @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public void Insertar_Cliente(CLIENTES obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.CLIENTES.Add(obj);
                db.SaveChanges();
            }
        }

        public void Actualizar_Cliente(CLIENTES obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_cliente = db.CLIENTES.Where(r => r.REFERENCIA == obj.REFERENCIA).SingleOrDefault();
                obj_cliente.CASA_PROPIA = obj.CASA_PROPIA;
                obj_cliente.CELULAR = obj.CELULAR;
                obj_cliente.DIRECCION = obj.DIRECCION;
                obj_cliente.DIRECCION_REFERENCIA1 = obj.DIRECCION_REFERENCIA1;
                obj_cliente.DIRECCION_REFERENCIA2 = obj.DIRECCION_REFERENCIA2;
                obj_cliente.DIRECCION_TRABAJO = obj.DIRECCION_TRABAJO;
                obj_cliente.EMAIL = obj.EMAIL;
                obj_cliente.ESTADO = obj.ESTADO;
                obj_cliente.ID_TIPO_IDENTIFICACION = obj.ID_TIPO_IDENTIFICACION;
                obj_cliente.SUELDO = obj.SUELDO;
                obj_cliente.NOMBRE = obj.NOMBRE;
                obj_cliente.NOMBRE_CONYUGUE = obj.NOMBRE_CONYUGUE;
                obj_cliente.NOMBRE_REFERENCIA1 = obj.NOMBRE_REFERENCIA1;
                obj_cliente.NOMBRE_REFERENCIA2 = obj.NOMBRE_REFERENCIA2;
                obj_cliente.NUMERO_IDENTIFICACION = obj.NUMERO_IDENTIFICACION;
                obj_cliente.TELEFONO = obj.TELEFONO;
                obj_cliente.TELEFONO_CONYUGUE = obj.TELEFONO_CONYUGUE;
                obj_cliente.TELEFONO_REFERENCIA1 = obj.TELEFONO_REFERENCIA1;
                obj_cliente.TELEFONO_REFERENCIA2 = obj.TELEFONO_REFERENCIA2;
                obj_cliente.OBSERVACION = obj.OBSERVACION;
                obj_cliente.OBSERVACION_REFERENCIA1  = obj.OBSERVACION_REFERENCIA1 ;
                obj_cliente.OBSERVACION_REFERENCIA2  = obj.OBSERVACION_REFERENCIA2;
                db.SaveChanges();
            }
        }
    }
}
