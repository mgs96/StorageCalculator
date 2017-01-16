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
            Storage storage = new Storage(TXTidentificador.Text, TXTname.Text, 0, (int)NUDlinealCapacity.Value, (int)NUDancho.Value, (int)NUDlargo.Value);

            using (SqlConnection conn = new SqlConnection(Utilities.Connection))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Storage VALUES (@nombre, @capacidadoc, @capacidadtot, @largo, @ancho, @identificador)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@nombre", storage.Nombre);
                cmd.Parameters.AddWithValue("@capacidadoc", storage.Capacidad_ocupada);
                cmd.Parameters.AddWithValue("@capacidadtot", storage.Capacidad_total);
                cmd.Parameters.AddWithValue("@largo", storage.Largo);
                cmd.Parameters.AddWithValue("@ancho", storage.Ancho);
                cmd.Parameters.AddWithValue("@identificador", storage.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            StorageManager m = new StorageManager(storage);
            m.Text = storage.Nombre;
            this.Close();
            m.Show();
        }

        private void CreateStorage_Load(object sender, EventArgs e)
        {
            TXTidentificador.Focus();
        }
    }
}
