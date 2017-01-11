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
    public partial class CreateBox : Form
    {

        private string DBconnection;
        private string name;

        public CreateBox(String s)
        {
            InitializeComponent();

            name = s;
            DBconnection = System.Configuration.ConfigurationManager.ConnectionStrings["Local"].ConnectionString;
        }

        private void BTNcrear_Click(object sender, EventArgs e)
        {
            
            Box b = new Box((int)NUDmetrosLineales.Value, TXTrotulo.Text, TXTtipo.Text);

            using (SqlConnection conn = new SqlConnection(DBconnection))
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Box VALUES (@label, @linearMeter, @squareMeter, @type, @storage_name)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@label", b.Label);
                cmd.Parameters.AddWithValue("@linearMeter", b.LinealMeter);
                cmd.Parameters.AddWithValue("@squareMeter", b.SquareMeter);
                cmd.Parameters.AddWithValue("@type", b.Type);
                cmd.Parameters.AddWithValue("@storage_name", name);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            this.Close();
        }
    }
}