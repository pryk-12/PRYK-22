using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
    public class D_Factura
    {
        public List<E_Factura> Listar_Facturas(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Factura>(@"SP_LISTAR_FACTURAS @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }


        public List<E_Detalles_Cuota> Listar_Detalles_Cuotas(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Detalles_Cuota>(@"SP_LISTAR_DETALLES_CUOTAS @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public List<E_Detalles_Cuota> Listar_Detalles_Cuotas_CXC(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Detalles_Cuota>(@"SP_LISTAR_DETALLES_CUOTAS_CXC @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public List<E_Detalles_Cuotas_Web> Listar_Detalles_Cuotas_WEB(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Detalles_Cuotas_Web>(@"SP_LISTAR_DETALLES_CUOTAS_CXC_WEB @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public List<E_Recibo> Listar_Recibos(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Recibo>(@"SP_LISTAR_RECIBOS @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public List<E_Cuadre> Listar_Cuadre(DateTime Fecha)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Cuadre>(@"SP_LISTAR_CUADRE_DEL_DIA @FECHA", new SqlParameter("@FECHA", Fecha)).ToList();
            }
        }

        public List<E_Cliente_X_Cobrador> Listar_Clientes_X_Cobrador(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Cliente_X_Cobrador>(@"SP_LISTAR_CLIENTES_X_COBRADOR @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }
        
        public void Insertar_Factura(FACTURAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.FACTURAS.Add(obj);
                db.SaveChanges();
            }
        }

        public void Insertar_Encabezado_Cuota(ENCABEZADO_CUOTAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.ENCABEZADO_CUOTAS.Add(obj);
                db.SaveChanges();
            }
        }

        public void Actualizar_Encabezado_Cuota(ENCABEZADO_CUOTAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_enc = db.ENCABEZADO_CUOTAS.Find(obj.ID_FACTURA);
                obj_enc.CANTIADA_CUOTA  = obj.CANTIADA_CUOTA;
                obj_enc.FECHA_PRIMERA_CUOTA  = obj.FECHA_PRIMERA_CUOTA;
                obj_enc.MODO_CALCULO = obj.MODO_CALCULO;
                db.SaveChanges();
            }
        }

        public void Eliminar_Cuotas(int id)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_det = db.DETALLES_CUOTAS.Where(e => e.ID_FACTURA == id).Where(e=>e.MONTO_PAGADO == 0).ToList();
                db.DETALLES_CUOTAS.RemoveRange(obj_det);
                db.SaveChanges();
            }
        }

        public void Actualizar_Cuotas(DETALLES_CUOTAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_det = db.DETALLES_CUOTAS.Where(e => e.ID_FACTURA == obj.ID_FACTURA ).Where(e => e.MONTO_PAGADO > 0).ToList();
                if (obj_det.Count()>0)
                {
                    obj_det[0].RE_CALCULADO = obj.RE_CALCULADO;
                    db.SaveChanges();
                }
               
            }
        }

        public void Insertar_Detalle_Cuota(DETALLES_CUOTAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.DETALLES_CUOTAS.Add(obj);
                db.SaveChanges();
            }
        }

        public void Cambiar_Estado_Factura(FACTURAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_factura = db.FACTURAS.Find(obj.ID_FACTURA);
                obj_factura.ID_ESTADO = obj.ID_ESTADO;
                obj_factura.CAMBIO_ESTADO_POR = obj.CAMBIO_ESTADO_POR;
                obj_factura.FECHA_CAMBIO_ESTADO = obj.FECHA_CAMBIO_ESTADO;
                obj_factura.NOTA_CAMBIO_ESTADO = obj.NOTA_CAMBIO_ESTADO;
                db.SaveChanges();
            }
        }

        public void Actualizar(FACTURAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_factura = db.FACTURAS.Find(obj.ID_FACTURA);
                obj_factura.ID_COBRADOR = obj.ID_COBRADOR ;
                obj_factura.ID_ESTADO = obj.ID_ESTADO;
                obj_factura.MONTO_TOTAL = obj.MONTO_TOTAL;
                obj_factura.NUMERO_LOTERIA = obj.NUMERO_LOTERIA;
                obj_factura.OBSERVACION = obj.OBSERVACION;
                obj_factura.GARANTIA1 = obj.GARANTIA1;
                obj_factura.GARANTIA2 = obj.GARANTIA2;
                obj_factura.GARANTIA3 = obj.GARANTIA3;
                obj_factura.GARANTIA4 = obj.GARANTIA4;
                obj_factura.GARANTIA5 = obj.GARANTIA5;
                obj_factura.GARANTIA6 = obj.GARANTIA6;
                obj_factura.GARANTIA7 = obj.GARANTIA7;
                obj_factura.MONTO_DESCONTADO = obj.MONTO_DESCONTADO;
                obj_factura.RUTA = obj.RUTA;
                obj_factura.FECHA_DESCUENTO = obj.FECHA_DESCUENTO;               
                db.SaveChanges();
            }
        }

        public void Actualizar_Montos_Factura(FACTURAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_factura = db.FACTURAS.Find(obj.ID_FACTURA);
                obj_factura.MONTO_PAGADO  = obj_factura.MONTO_PAGADO + obj.MONTO_PAGADO;
                obj_factura.MONTO_PENDIENTE = obj_factura.MONTO_PENDIENTE - obj.MONTO_PAGADO;
                db.SaveChanges();
            }
        }

        public void Cobrar_Cuota(DETALLES_CUOTAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_detalle = db.DETALLES_CUOTAS.Where(a => a.ID_FACTURA == obj.ID_FACTURA).Where(a => a.NUMERO_CUOTA == obj.NUMERO_CUOTA).Where(a => a.RE_CALCULADO == "NO").Single();
                obj_detalle.MONTO_PAGADO = obj_detalle.MONTO_PAGADO + obj.MONTO_PAGADO;
                obj_detalle.MONTO_PENDIENTE = obj.MONTO_PENDIENTE;
                db.SaveChanges();
            }
        }

        public void Insertar_Recibo_Cobros(RECIBOS_COBRADOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.RECIBOS_COBRADOS.Add(obj);
                db.SaveChanges();
            }
        }

        public void Actualizar_Montos_Factura_Recibo_Anulado(FACTURAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_factura = db.FACTURAS.Find(obj.ID_FACTURA);
                obj_factura.MONTO_PAGADO = obj_factura.MONTO_PAGADO - obj.MONTO_PAGADO;
                obj_factura.MONTO_PENDIENTE = obj_factura.MONTO_PENDIENTE + obj.MONTO_PAGADO;
                db.SaveChanges();
            }
        }

        public void Anular_Recibo(RECIBOS_COBRADOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_recibo = db.RECIBOS_COBRADOS.Find(obj.ID_RECIBO);
                obj_recibo.ESTADO = obj.ESTADO;
                obj_recibo.FECHA_ANULADO = obj.FECHA_ANULADO;
                obj_recibo.ANULADO_POR = obj.ANULADO_POR;
                obj_recibo.NOTA_ANULACION = obj.NOTA_ANULACION;
                db.SaveChanges();
            }
        }

        public void Anular_Detalle_Cuota(DETALLES_CUOTAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_detalle = db.DETALLES_CUOTAS.Where(a => a.ID_FACTURA == obj.ID_FACTURA).Where(a => a.NUMERO_CUOTA == obj.NUMERO_CUOTA).Where(a => a.RE_CALCULADO == "NO").Single();
                obj_detalle.MONTO_PAGADO = obj_detalle.MONTO_PAGADO - obj.MONTO_PAGADO;
                obj_detalle.MONTO_PENDIENTE = obj_detalle.MONTO_PENDIENTE + obj.MONTO_PAGADO;
                db.SaveChanges();
            }
        }

        public void Insertar_Cuadre_Diario(CUADRES_DIARIOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.CUADRES_DIARIOS.Add(obj);
                db.SaveChanges();
            }
        }

        public void Actualizar_Cuadre_Diario(CUADRES_DIARIOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_cuadre = db.CUADRES_DIARIOS.Where(f => f.FECHA == obj.FECHA).Single();
                obj_cuadre.VALOR_ANULADO = obj.VALOR_ANULADO;
                obj_cuadre.VALOR_PAGADO = obj.VALOR_PAGADO;
                obj_cuadre.VALOR_TOTAL = obj.VALOR_TOTAL;
                obj_cuadre.VALOR_DESCUENTO = obj.VALOR_DESCUENTO;
                db.SaveChanges();
            }
        }
    }
}
