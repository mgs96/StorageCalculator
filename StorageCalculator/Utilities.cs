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

        public static BindingSource GetData(string query, SqlConnection conn)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(adapter);
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            return bs;
        }
    }
}
