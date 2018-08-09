using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Servicios
{
   public class S_Factura
    {
       public static List<E_Factura> Listar_Facturas(string Condicion)
        {
            D_Factura Metodo = new D_Factura();
            return Metodo.Listar_Facturas(Condicion);
        }

       public static List<E_Detalles_Cuota> Listar_Detalles_Cuotas(string Condicion)
       {
           D_Factura Metodo = new D_Factura();
           return Metodo.Listar_Detalles_Cuotas(Condicion);
       }

       public static List<E_Detalles_Cuotas_Web> Listar_Detalles_Cuotas_WEB(string Condicion)
       {
           D_Factura Metodo = new D_Factura();
           return Metodo.Listar_Detalles_Cuotas_WEB(Condicion);
       }

        public static List<E_Detalles_Cuota> Listar_Detalles_Cuotas_CXC(string Condicion)
        {
            D_Factura Metodo = new D_Factura();
            return Metodo.Listar_Detalles_Cuotas_CXC(Condicion);
        }

        public static List<E_Recibo> Listar_Recibos(string Condicion)
        {
            D_Factura Metodo = new D_Factura();
            return Metodo.Listar_Recibos(Condicion);
        }

        public static List<E_Cuadre> Listar_Cuadre(DateTime Fecha)
        {
            D_Factura Metodo = new D_Factura();
            return Metodo.Listar_Cuadre(Fecha);
        }

        public static List<E_Cliente_X_Cobrador> Listar_Clientes_X_Cobrador(string Condicion)
        {
            D_Factura Metodo = new D_Factura();
            return Metodo.Listar_Clientes_X_Cobrador(Condicion);
        }

        public static void Insertar_Factura(FACTURAS obj)
        {
            D_Factura Metodo = new D_Factura();
            Metodo.Insertar_Factura(obj);
        }

        public static void Actualizar_Factura(FACTURAS obj)
        {
            D_Factura Metodo = new D_Factura();
            Metodo.Actualizar(obj);
        }

        public static void Cambiar_Estado_Factura(FACTURAS obj)
        {
            D_Factura Metodo = new D_Factura();
            Metodo.Cambiar_Estado_Factura(obj);
        }

       public static void Insertar_Detalle_Cuota(DETALLES_CUOTAS obj)
       {
           D_Factura Metodo = new D_Factura();
           Metodo.Insertar_Detalle_Cuota(obj);
       }

       public static void Insertar_Encabezado_Cuota(ENCABEZADO_CUOTAS obj)
       {
           D_Factura Metodo = new D_Factura();
           Metodo.Insertar_Encabezado_Cuota(obj);
       }

        public static void Actualizar_Encabezado_Cuota(ENCABEZADO_CUOTAS obj)
        {
            D_Factura Metodo = new D_Factura();
            Metodo.Actualizar_Encabezado_Cuota(obj);
        }

        public static void Actualizar_Montos_Factura(FACTURAS obj)
        {
            D_Factura Metodo = new D_Factura();
            Metodo.Actualizar_Montos_Factura(obj);
        }

        public static void Cobrar_Cuota(DETALLES_CUOTAS obj)
        {
            D_Factura Metodo = new D_Factura();
            Metodo.Cobrar_Cuota(obj);
        }

        public static void Insertar_Recibo_Cobros(RECIBOS_COBRADOS obj)
        {
            D_Factura Metodo = new D_Factura();
            Metodo.Insertar_Recibo_Cobros(obj);
        }

        public static void Actualizar_Montos_Factura_Recibo_Anulado(FACTURAS obj)
        {
            D_Factura Metodo = new D_Factura();
            Metodo.Actualizar_Montos_Factura_Recibo_Anulado(obj);
        }

        public static void Anular_Recibo(RECIBOS_COBRADOS obj)
        {
            D_Factura Metodo = new D_Factura();
            Metodo.Anular_Recibo(obj);
        }

        public static void Anular_Detalle_Cuota(DETALLES_CUOTAS obj)
        {
            D_Factura Metodo = new D_Factura();
            Metodo.Anular_Detalle_Cuota(obj);
        }

        public static void Actualizar_Cuotas(DETALLES_CUOTAS obj)
        {
            D_Factura Metodo = new D_Factura();
            Metodo.Actualizar_Cuotas(obj);
        }

        public static void Eliminar_Cuotas(int id)
        {
            D_Factura Metodo = new D_Factura();
            Metodo.Eliminar_Cuotas(id);
        }

        public static void Insertar_Cuadre_Diario(CUADRES_DIARIOS obj)
        {
            D_Factura Metodo = new D_Factura();
            Metodo.Insertar_Cuadre_Diario(obj);
        }

        public static void Actualizar_Cuadre_Diario(CUADRES_DIARIOS obj)
        {
            D_Factura Metodo = new D_Factura();
            Metodo.Actualizar_Cuadre_Diario(obj);
        }
    }
}
