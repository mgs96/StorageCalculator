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

        public CreateStorage()
        {
            InitializeComponent();
            
        }

        private void BTNcrear_Click(object sender, EventArgs e)
        {
            Storage storage = new Storage(TXTname.Text, (int)NUDlinealCapacity.Value);

            using (SqlConnection conn = new SqlConnection(Utilities.Connection))
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

            StorageManager m = new StorageManager(storage);
            m.Text = storage.Name;
            m.Show();
            this.Close();
        }
    }
}
