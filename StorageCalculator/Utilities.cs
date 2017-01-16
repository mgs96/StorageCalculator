using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace StorageCalculator
{
    public static class Utilities
    {
        private static string connection = System.Configuration.ConfigurationManager.ConnectionStrings["Local"].ConnectionString;

        public static string Connection
        {
            get { return connection; }
        }
    }
}
