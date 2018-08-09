
namespace Entidades
{
   public class E_Empresa
    {
        public int ID_EMPRESA { get; set; }
        public string NOMBRE { get; set; }
        public string DIRECCION { get; set; }
        public int ID_TIPO_IDENTIFICACION { get; set; }
        public string DESCRIPCION { get; set; }
        public string NUMERO_IDENTIFICACION { get; set; }
        public string TELEFONO { get; set; }
        public string CELULAR { get; set; }
        public string FAX { get; set; }
        public string EMAIL { get; set; }
        public string PAGINA_WEB { get; set; }
        public string ESLOGAN { get; set; }
        public string IMPRESORA { get; set; }
        public byte[] LOGO { get; set; }
    }
}
