using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String servidor = "WINT";
        public static String usuario = "TABAJARA";
        public static String senha = "SU9FTA3A";
        public static String StringDeConexao
        {
            get
            {
                // Data Source = WINT; User ID = TABAJARA; Password = ***********; Unicode = True
                return @"Data Source=" + servidor + "; User ID=" + usuario + ";Password=" + senha + ";Unicode = True";
            }
        }
    }
}
