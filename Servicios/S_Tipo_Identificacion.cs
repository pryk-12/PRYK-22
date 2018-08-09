using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
   public class S_Tipo_Identificacion
    {
       public static List<TIPOS_IDENTIFICACIONES> Listar_Tipos_Identificaciones(string Condicion)
        {
            D_Tipo_Identificacion Metodo = new D_Tipo_Identificacion();
            return Metodo.Listar_Tipos_Identificaciones(Condicion);
        }

       public static void Insertar_Tipo_Identificacion(TIPOS_IDENTIFICACIONES obj)
        {
            D_Tipo_Identificacion Metodo = new D_Tipo_Identificacion();
            Metodo.Insertar_Tipo_Identificacion(obj);
        }

       public static void Actualizar_Tipo_Identificacion(TIPOS_IDENTIFICACIONES obj)
        {
            D_Tipo_Identificacion Metodo = new D_Tipo_Identificacion();
            Metodo.Actualizar_Tipo_Identificacion(obj);
        }
    }
}
