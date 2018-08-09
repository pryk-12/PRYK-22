using System;

namespace Entidades
{
   public class E_Recibo
    {
        public int ID_RECIBO { get; set; }
        public DateTime FECHA_CREADO { get; set; }
        public int ID_FACTURA { get; set; }
        public int CUOTA_COBRADA { get; set; }
        public decimal VALOR_PAGADO { get; set; }
        public string ESTADO { get; set; }
        public int ID_COBRADOR { get; set; }
        public string COBRADOR { get; set; }
        public string NOMBRE { get; set; }
        public string ANULADO_POR { get; set; }
        public string FECHA_ANULADO { get; set; }
        public string NOTA_ANULACION { get; set; }
    }
}
