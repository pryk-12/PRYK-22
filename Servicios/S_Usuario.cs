using System.Collections.Generic;
using Datos;
using Entidades;
namespace Servicios
{
  public class S_Usuario
    {
        public static List<E_Usuario> Listar_Usuario(string Condicion)
        {
            D_Usuario Metodo = new D_Usuario();
            return Metodo.Listar_Usuario(Condicion);
        }

        public static void Insertar_Usuario(USUARIOS obj)
        {
            D_Usuario Metodo = new D_Usuario();
            Metodo.Insertar_Usuario(obj); 
        }

        public static void Actualizar_Usuario(USUARIOS obj)
        {
            D_Usuario Metodo = new D_Usuario();
            Metodo.Actualizar_Usuario(obj); 
        }

        public static void Actualizar_Clave_Usuario(USUARIOS obj)
        {
            D_Usuario Metodo = new D_Usuario();
            Metodo.Actualizar_Clave_Usuario(obj);
        }
    }
}
