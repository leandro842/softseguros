using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String StringDeConexao
        {
            get
            {
                return "datasource=localhost;port=3306;username=root;password=123456;database=softseguros";                 
            }
        }
    }
}
