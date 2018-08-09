using System;
using Datos;
using System.Windows.Forms;
using System.Configuration;

namespace Servicios
{
   public class S_Utilidades
    {
       public static String Encriptar_Clave(string Clave)
       {
           D_Utilidades Metodo = new D_Utilidades();
           return Metodo.Encriptar_Clave(Clave);
       }

       public static String Desencriptar_Clave(string Clave)
       {
           D_Utilidades Metodo = new D_Utilidades();
           return Metodo.Desencriptar_Clave(Clave);
       }

       public static void Llenar_ComboBox<T>(ComboBox Combo, string Valor_Mostrar, string Valor_Codigo, string Condicion, string Tabla)
       {
           D_Utilidades Metodo = new D_Utilidades();
           Metodo.Llenar_ComboBox<T>(Combo, Valor_Mostrar, Valor_Codigo, Condicion,Tabla);
       }

       public static void Mensaje_Confirmacion(string Mensaje)
       {
           D_Utilidades Metodo = new D_Utilidades();
           Metodo.Mensaje_Confirmacion(Mensaje);
       }

       public static void Mensaje_Error(string Mensaje)
       {
           D_Utilidades Metodo = new D_Utilidades();
           Metodo.Mensaje_Error(Mensaje);
       }

       public static void Mensaje_Informacion(string Mensaje)
       {
           D_Utilidades Metodo = new D_Utilidades();
           Metodo.Mensaje_Informacion(Mensaje);
       }

       public static void Permitir_Solo_Numero(object sender, KeyPressEventArgs e)
       {
           D_Utilidades Metodo = new D_Utilidades();
           Metodo.Permitir_Solo_Numero(sender,e);
       }

       public static void Permitir_Solo_Numero_y_Punto(object sender, KeyPressEventArgs e, TextBox text)
       {
           D_Utilidades Metodo = new D_Utilidades();
           Metodo.Permitir_Solo_Numero_y_Punto(sender, e,text);
       }

       public static void Validar_Fecha(MaskedTextBox Masked)
       {
           D_Utilidades Metodo = new D_Utilidades();
           Metodo.Validar_Fecha(Masked);
       }

       public static bool Validar_Formato_Correo(string Correo)
       {
           D_Utilidades Metodo = new D_Utilidades();
          return Metodo.Validar_Formato_Correo(Correo);
       }

       public static class Datos_Usuario
       {
           public static int ID_USUARIO;
           public static string USUARIO;
           public static string NOMBRE_USUARIO;
       }

       public static class Datos_Entidades
       {
           public static string REFERENCIA;
           public static int ID_ARTICULO;
           public static int ID_RECIBO;
           public static string ARTICULO;
           public static int CANTIDAD;
           public static decimal PRECIO;
           public static decimal TOTAL;
           public static int ID_PROVEEDOR;
       }

       public static string FormatoFecha()
       {
           return ConfigurationManager.AppSettings["FormatoFecha"];
       }

       public static void Crear_Backup()
       {
           D_Utilidades Metodo = new D_Utilidades();
           Metodo.Crear_Backup();
       }

    }
}
