using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Datos
{
   public class D_Utilidades
    {
       

        TripleDESCryptoServiceProvider Des = new TripleDESCryptoServiceProvider();
        MD5CryptoServiceProvider Hashmd5 = new MD5CryptoServiceProvider();
        string MyKey = "MyKey2012";
        String Encriptar = "";
        String Desencriptar = "";

        public String Encriptar_Clave(string Clave)
        {
            if ((Clave.Trim() == ""))
            {
                Encriptar = "";
            }
            else
            {
                Des.Key = Hashmd5.ComputeHash(new UnicodeEncoding().GetBytes(MyKey));
                Des.Mode = CipherMode.ECB;
                ICryptoTransform encrypt = Des.CreateEncryptor();
                byte[] buff = UnicodeEncoding.ASCII.GetBytes(Clave);
                Encriptar = Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length));
            }
            return Encriptar;
        }

        public String Desencriptar_Clave(string texto)
        {

            if ((texto.Trim() == ""))
            {
                Desencriptar = "";
            }
            else
            {
                Des.Key = Hashmd5.ComputeHash(new UnicodeEncoding().GetBytes(MyKey));
                Des.Mode = CipherMode.ECB;
                ICryptoTransform desencrypta = Des.CreateDecryptor();
                byte[] buff = Convert.FromBase64String(texto);
                Desencriptar = UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length));
                buff.GetLength(0);
            }

            return Desencriptar;
        }

        public void Mensaje_Informacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Mensaje_Error(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Error Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult Mensaje_Confirmacion(string Mensaje)
        {
            DialogResult Resultado = MessageBox.Show(Mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return Resultado;
        }

        public void Permitir_Solo_Numero_y_Punto(object sender, KeyPressEventArgs e, TextBox text)
        {
            if (((e.KeyChar) < 48) && ((e.KeyChar) != 8) || ((e.KeyChar) > 57))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
                //si ya hay un punto no permite un nuevo ingreso de este
                if (text.Text.Contains("."))
                    e.Handled = true;
                else
                    e.Handled = false;
        }

        public void Permitir_Solo_Numero(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48) && ((e.KeyChar) != 8) || ((e.KeyChar) > 57))
            {
                e.Handled = true;
            }
        }

        public bool Validar_Fecha(MaskedTextBox Masked)
        {
            DateTime fecha;
            if (DateTime.TryParse(Masked.Text, out fecha))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Validar_Formato_Correo(String Correo)
        {
            String Expresion;
            Expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(Correo, Expresion))
            {
                if (Regex.Replace(Correo, Expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public void Llenar_ComboBox<T>(ComboBox Combo, string Valor_Mostrar, string Valor_Codigo, string Condicion,string Tabla)
        {
            using (var db = new BD_JSYSEntities())
            {
                var Query = db.Database.SqlQuery<T>(@"SP_LLENAR_COMBOBOX @TABLA,@VALOR_MOSTRAR,@VALOR_CODIGO,@CONDICION",
                                               new SqlParameter("@TABLA", Tabla),                             
                                               new SqlParameter("@VALOR_MOSTRAR", Valor_Mostrar),
                                               new SqlParameter("@VALOR_CODIGO", Valor_Codigo),
                                               new SqlParameter("@CONDICION", Condicion)).ToList();
                Combo.DataSource = Query;
                Combo.DisplayMember = Valor_Mostrar;
                Combo.ValueMember = Valor_Codigo;
                Combo.SelectedItem = null;
            }
        }

        public void Crear_Backup()
        {
            SqlConnection con = new SqlConnection(D_Conexion.cadena_conexion);
            SqlDataAdapter da = new SqlDataAdapter();

            con.Close();
            da.InsertCommand = new SqlCommand("SP_BACKUP", con);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            string ubicacion = @"C:\Dropbox\BD_JSYS_" + DateTime.Now.ToString("dd-MM-yyyy HHmmss") + ".bak";
            da.InsertCommand.Parameters.AddWithValue("@UBICACION", ubicacion);
            con.Open();
            da.InsertCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}
