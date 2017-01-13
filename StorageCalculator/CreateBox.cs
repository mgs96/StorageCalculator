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
        private Storage_unit su;
        private Storage storage;

        public CreateBox(Storage s)
        {
            InitializeComponent();

            storage = s;
            DBconnection = System.Configuration.ConfigurationManager.ConnectionStrings["Local"].ConnectionString;
        }

        /*private void BTNcrear_Click(object sender, EventArgs e)
        {

            if ((TXTtipo1.Text != "") && (TXTid1.Text != "") && (storage.Capacidad_ocupada + NUDc1.Value <= storage.Capacidad_total))
            {
                su = new Storage_unit((int)NUDc1.Value, TXTtipo1.Text, TXTid1.Text, (int)NUDfolios1.Value, (int)NUDml1.Value);
                addUnitsToDB((int)NUDc1.Value, TXTtipo1.Text, (int)NUDfolios1.Value, (int)NUDml1.Value, TXTid1.Text);
            }

            if ((TXTtipo2.Text != "") && (TXTid2.Text != "") && (storage.Capacidad_ocupada + NUDc2.Value <= storage.Capacidad_total))
            {
                su = new Storage_unit((int)NUDc2.Value, TXTtipo2.Text, TXTid1.Text, (int)NUDfolios2.Value, (int)NUDml2.Value);
                addUnitsToDB((int)NUDc2.Value, TXTtipo2.Text, (int)NUDfolios2.Value, (int)NUDml2.Value, TXTid2.Text);
            }

            if ((TXTtipo3.Text != "") && (TXTid3.Text != "") && (storage.Capacidad_ocupada + NUDc3.Value <= storage.Capacidad_total))
            {
                su = new Storage_unit((int)NUDc3.Value, TXTtipo3.Text, TXTid3.Text, (int)NUDfolios3.Value, (int)NUDml3.Value);
                addUnitsToDB((int)NUDc3.Value, TXTtipo3.Text, (int)NUDfolios3.Value, (int)NUDml3.Value, TXTid3.Text);
            }

            if ((TXTtipo4.Text != "") && (TXTid4.Text != "") && (storage.Capacidad_ocupada + NUDc4.Value <= storage.Capacidad_total))
            {
                su = new Storage_unit((int)NUDc4.Value, TXTtipo4.Text, TXTid4.Text, (int)NUDfolios4.Value, (int)NUDml4.Value);
                addUnitsToDB((int)NUDc4.Value, TXTtipo4.Text, (int)NUDfolios4.Value, (int)NUDml4.Value, TXTid4.Text);
            }

            this.Close();
        }*/

        private void addUnitsToDB(int cantidad, string tipo, int folios, int mlineal, string id)
        {
            using (SqlConnection conn = new SqlConnection(DBconnection))
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Unidad_Almacenamiento VALUES (@id, @cantidad, @tipo, @folios, @metroslineales, @storage_id)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@folios", folios);
                cmd.Parameters.AddWithValue("@metroslineales", mlineal);
                cmd.Parameters.AddWithValue("@storage_id", storage.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CreateBox_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("col1", "Cantidad");
            dataGridView1.Columns.Add("col2", "Tipo");
            dataGridView1.Columns.Add("col3", "Folios");
            dataGridView1.Columns.Add("col4", "Metros lineales");
            dataGridView1.Columns.Add("col5", "Siglas");
        }
    }
}