using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StorageCalculator
{
    public partial class Lista : Form
    {

        string DBconnection;

        public Lista()
        {
            InitializeComponent();

            DBconnection = System.Configuration.ConfigurationManager.ConnectionStrings["Local"].ConnectionString;
        }

        private void Lista_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(DBconnection))
            {
                using (SqlCommand cmd = new SqlCommand("SELECET * FROM Storage", conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DGVlista.DataSource = reader;
                    }
                }
            }
        }
    }
}
