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
                SqlCommand cmd = new SqlCommand("INSERT INTO Storage VALUES (@id, @nombre, @capacidadocupada, @capacidadtotal, @largo, @ancho)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@id", storage.Id);
                cmd.Parameters.AddWithValue("@nombre", storage.Nombre);
                cmd.Parameters.AddWithValue("@capacidadocupada", storage.Capacidad_ocupada);
                cmd.Parameters.AddWithValue("@capacidadtotal", storage.Capacidad_total);
                cmd.Parameters.AddWithValue("@largo", storage.Largo);
                cmd.Parameters.AddWithValue("@ancho", storage.Ancho);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            StorageManager m = new StorageManager(storage);
            m.Text = storage.Nombre;
            this.Close();
            m.Show();
        }
    }
}
