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
    public partial class Addunit : Form
    {
        public Addunit()
        {
            InitializeComponent();
        }

        private void Addunit_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Utilities.Connection))
            {

                DataTable t = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT Tipo FROM Unidad_Almacenamiento", conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader != null)
                    {
                        t.Load(reader);
                    }

                    CMBtipo.DataSource = t;

                }
            }
        }
    }
}
