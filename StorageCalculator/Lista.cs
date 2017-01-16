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

        private string DBconnection;
        //private DataTable dt;

        public Lista()
        {
            InitializeComponent();

            DBconnection = System.Configuration.ConfigurationManager.ConnectionStrings["Local"].ConnectionString;
        }

        private void Lista_Load(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(DBconnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Nombre, CapacidadOcupada as [Capacidad ocupada], CapacidadTotal as [Capacidad total], Largo, Ancho, Identificador", conn);
                SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(adapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);
                BindingSource bs = new BindingSource();
                bs.DataSource = table;


                DGVlista.AutoResizeColumns();

                DGVlista.DataSource = bs;
            }
        }
    }
}
