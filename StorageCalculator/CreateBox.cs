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
        private List<Storage_unit> listU;
        private Storage_unit su;
        private Storage storage;

        public CreateBox(Storage s)
        {
            InitializeComponent();

            storage = s;
            DBconnection = System.Configuration.ConfigurationManager.ConnectionStrings["Local"].ConnectionString;
        }

        private bool verificar()
        {
            bool sw = true;
            int total = 0;

            for (int i = 0; i < DGVsu.Rows.Count - 1; i++)
            {
                int cantidad = 0, folios = 0, mlineal = 0;

                if (!(Int32.TryParse(DGVsu.Rows[i].Cells[0].Value.ToString(), out cantidad)))
                {
                    //MessageBox.Show("Digite una cantidad válida");
                    RTXTlog.AppendText(Environment.NewLine + "Error en la linea " + (i + 1) + " el valor debe ser un número");
                    sw = false;
                }

                if (Convert.ToString(DGVsu.Rows[i].Cells[1].Value).Equals(""))
                {
                    RTXTlog.AppendText(Environment.NewLine + "Error en la linea " + (i + 1) + " debe digitar un valor");
                    sw = false;
                }
                
                if (!(Int32.TryParse(DGVsu.Rows[i].Cells[2].Value.ToString(), out folios)))
                {
                    //MessageBox.Show("Digite una cantidad válida");
                    RTXTlog.AppendText(Environment.NewLine + "Error en la linea " + (i + 1) + " el valor debe ser un número");
                    sw = false;
                }

                if (!(Int32.TryParse(DGVsu.Rows[i].Cells[3].Value.ToString(), out mlineal)))
                {
                    //MessageBox.Show("Digite una cantidad válida");
                    RTXTlog.AppendText(Environment.NewLine + "Error en la linea " + (i + 1) + " el valor debe ser un número");
                    sw = false;
                }
                else
                {
                    total += mlineal;
                }

                if (Convert.ToString(DGVsu.Rows[i].Cells[4].Value).Equals(""))
                {
                    RTXTlog.AppendText(Environment.NewLine + "Error en la linea " + (i + 1) + " debe digitar un valor");
                    sw = false;
                }
            }

            if (total > storage.Capacidad_total)
            {
                sw = false;
                RTXTlog.AppendText(Environment.NewLine + "Las unidades de almacenaiento a crear exceden el tamaño de la bodega");
            }

            return sw;
        }

        private void BTNcrear_Click(object sender, EventArgs e)
        {
            RTXTlog.Clear();

            if (verificar())
            {
                for (int i = 0; i < DGVsu.Rows.Count - 1; i++)
                {
                    int cantidad = Int32.Parse(DGVsu.Rows[i].Cells[0].Value.ToString());
                    string tipo = DGVsu.Rows[i].Cells[1].Value.ToString();
                    int folios = Int32.Parse(DGVsu.Rows[i].Cells[2].Value.ToString());
                    int mlineal = Int32.Parse(DGVsu.Rows[i].Cells[3].Value.ToString());
                    string sigla = DGVsu.Rows[i].Cells[4].Value.ToString();

                    su = new Storage_unit(cantidad, tipo, folios, mlineal, sigla, storage.Id);
                    addUnitsToDB(su);
                }
            }
        }

        private void addUnitsToDB(Storage_unit su)
        {
            using (SqlConnection conn = new SqlConnection(DBconnection))
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Unidad_Almacenamiento VALUES (@id, @cantidad, @tipo, @folios, @metroslineales, @storage_id)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@id", su.Id);
                cmd.Parameters.AddWithValue("@cantidad", su.Cantidad);
                cmd.Parameters.AddWithValue("@tipo", su.Tipo);
                cmd.Parameters.AddWithValue("@folios", su.Folios);
                cmd.Parameters.AddWithValue("@metroslineales", su.Mlineal);
                cmd.Parameters.AddWithValue("@storage_id", storage.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void CreateBox_Load(object sender, EventArgs e)
        {
            DGVsu.Columns.Add("col1", "Cantidad");
            DGVsu.Columns.Add("col2", "Tipo");
            DGVsu.Columns.Add("col3", "Folios");
            DGVsu.Columns.Add("col4", "Metros lineales");
            DGVsu.Columns.Add("col5", "Siglas");
        }
    }
}