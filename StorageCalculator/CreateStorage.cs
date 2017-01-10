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
    public partial class CreateStorage : Form
    {
        private string DBconnection;

        public CreateStorage()
        {
            InitializeComponent();

            DBconnection = System.Configuration.ConfigurationManager.ConnectionStrings["Local"].ConnectionString;
        }

        private void BTNcrear_Click(object sender, EventArgs e)
        {
            Storage storage = new Storage(TXTname.Text, (int)NUDlinealCapacity.Value);
            StorageManager m = new StorageManager(storage);

            using (SqlConnection conn = new SqlConnection(DBconnection))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Storage VALUES (@n, @totalC, @currentC)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@n", storage.Name);
                cmd.Parameters.AddWithValue("@totalC", storage.LinearMeterCapacity);
                cmd.Parameters.AddWithValue("@currentC", storage.OccupiedCapacity);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            m.MdiParent = this.MdiParent;
            m.Show();
            this.Close();
        }
    }
}
