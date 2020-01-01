using System;
using System.IO;

namespace DAL
{
    public class DadosDaConexao

    {
        public static String servidor;
        public static String usuario;
        public static String senha;



       
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
