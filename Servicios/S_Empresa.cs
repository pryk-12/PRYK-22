using Datos;
using Entidades;
using System.Collections.Generic;

namespace Servicios
{
   public class S_Empresa
    {
       public static List<E_Empresa> Listar_Empresa(string Condicion)
        {
            D_Empresa Metodo = new D_Empresa();
            return Metodo.Listar_Empresa(Condicion);
        }

        public static void Actualizar_Empresa(EMPRESA obj)
        {
            D_Empresa Metodo = new D_Empresa();
            Metodo.Actualizar_Empresa(obj);
        }
    }
}
