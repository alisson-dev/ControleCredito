using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCredito
{
    public class Dados
    {
        public static string stringConexao
        {
            get
            {
                //return @"Data Source = server; Initial Catalog = bd; User ID = sa; Password = sasa; Pooling = False";

                //return @"Data Source = server; Initial Catalog = bd; User ID = sa; Password = sasa; Pooling = False";

                return @"Data Source = server; Initial Catalog = bd; User ID = sa; Password = sasa; Pooling = False";
            }
        }
    }
}
