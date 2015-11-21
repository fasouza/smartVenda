using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosConexao
    {
        public static String servidor   = @"SIDI\SQLEXPRESS";
        public static String banco      = "Venda";
        public static String usuario    = "UsuarioSidi";
        public static String senha      = "231619";
        

        public static String StringDeConexao 
        {
            get 
            {
                return "Data Source="+servidor+";Initial Catalog="+banco+";User ID="+usuario+";Password="+senha;
            }

        }

    }
}
