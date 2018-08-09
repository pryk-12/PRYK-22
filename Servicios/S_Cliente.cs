using Datos;
using Entidades;
using System.Collections.Generic;

namespace Servicios
{
   public class S_Cliente
    {
       public static List<E_Cliente> Listar_Clientes(string Condicion)
        {
            D_Cliente Metodo = new D_Cliente();
            return Metodo.Listar_Clientes(Condicion);
        }

        public static void Insertar_Cliente(CLIENTES obj)
        {
            D_Cliente Metodo = new D_Cliente();
            Metodo.Insertar_Cliente(obj);
        }

        public static void Actualizar_Cliente(CLIENTES obj)
        {
            D_Cliente Metodo = new D_Cliente();
            Metodo.Actualizar_Cliente(obj);
        }
    }
}
