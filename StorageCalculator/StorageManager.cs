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
    public partial class StorageManager : Form
    {

        private Storage storage;
        private DataTable dt;
        private string DBconnection;

        public StorageManager(Storage s)
        {
            InitializeComponent();

            storage = s;

            DBconnection = System.Configuration.ConfigurationManager.ConnectionStrings["Local"].ConnectionString;

        }

        private void updateBoxes()
        {
            using (SqlConnection conn = new SqlConnection(DBconnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Box", conn);
                SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(adapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);
                BindingSource bs = new BindingSource();
                bs.DataSource = table;

                DGVcajas.AutoResizeColumns();

                DGVcajas.DataSource = bs;
            }
        }

        private void StorageManager_Load(object sender, EventArgs e)
        {
           
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBox cb = new CreateBox(this.Text);
            cb.Show();
        }
    }
}
