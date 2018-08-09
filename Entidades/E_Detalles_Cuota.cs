using System;

namespace Entidades
{
   public class E_Detalles_Cuota
    {
        public int ID_FACTURA { get; set; }
        public int NUMERO_CUOTA { get; set; }
        public DateTime FECHA { get; set; }
        public decimal MONTO_CUOTA { get; set; }
        public decimal MONTO_PAGADO { get; set; }
        public decimal MONTO_PENDIENTE { get; set; }

        public string SEL { get; set; }
        public decimal A_PAGAR { get; set; }
    }
}
