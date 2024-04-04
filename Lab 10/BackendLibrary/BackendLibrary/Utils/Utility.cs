using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendLibrary.Utils
{
    public class Utility
    {
        private static string ConnectionString = "Data Source=AHMAD-HP;Initial Catalog=OopLab10;Integrated Security=True;";

        public static string GetConnectionString()
        {
            return ConnectionString;
        }
    }
}
