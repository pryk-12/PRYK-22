//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class RECIBOS_COBRADOS
    {
        public int ID_RECIBO { get; set; }
        public int ID_FACTURA { get; set; }
        public int CUOTA_COBRADA { get; set; }
        public decimal VALOR_CUOTA { get; set; }
        public decimal VALOR_PAGADO { get; set; }
        public decimal VALOR_PENDIENTE { get; set; }
        public string ESTADO { get; set; }
        public System.DateTime FECHA_CREADO { get; set; }
        public string CREADO_POR { get; set; }
        public int CANTIDAD_CUOTAS { get; set; }
        public string ANULADO_POR { get; set; }
        public string FECHA_ANULADO { get; set; }
        public string NOTA_ANULACION { get; set; }
    }
}