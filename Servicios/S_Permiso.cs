using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
   public class S_Permiso
    {
       public static List<E_Permiso> Listar_Permisos(string Condicion)
        {
            D_Permiso Metodo = new D_Permiso();
            return Metodo.Listar_Permisos(Condicion);
        }

       public static List<E_Permiso> Listar_Pantallas(string Condicion)
       {
           D_Permiso Metodo = new D_Permiso();
           return Metodo.Listar_Pantallas(Condicion);
       }

       public static void Insertar_Permiso(PERMISOS obj)
        {
            D_Permiso Metodo = new D_Permiso();
            Metodo.Insertar_Permiso(obj);
        }

        public static void Eliminar_Permiso(PERMISOS obj)
        {
            D_Permiso Metodo = new D_Permiso();
            Metodo.Eliminar_Permiso(obj);
        }
    }
}
