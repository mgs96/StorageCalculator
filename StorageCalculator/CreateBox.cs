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
using System.Configuration;

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

        private bool verificar()
        {
            bool sw = true;
            int folios, mlineal;

            for (int i = 0; i < DGVsu.Rows.Count - 1; i++)
            {

                if (Convert.ToString(DGVsu.Rows[i].Cells[0].Value).Equals(""))
                {
                    RTXTlog.AppendText(Environment.NewLine + "Error en la linea " + (i + 1) + " debe digitar un valor");
                    sw = false;
                }

                if (!(Int32.TryParse(DGVsu.Rows[i].Cells[1].Value.ToString(), out folios)))
                {
                    //MessageBox.Show("Digite una cantidad válida");
                    RTXTlog.AppendText(Environment.NewLine + "Error en la linea " + (i + 1) + " el valor debe ser un número");
                    sw = false;
                }

                if (!(Int32.TryParse(DGVsu.Rows[i].Cells[2].Value.ToString(), out mlineal)))
                {
                    //MessageBox.Show("Digite una cantidad válida");
                    RTXTlog.AppendText(Environment.NewLine + "Error en la linea " + (i + 1) + " el valor debe ser un número");
                    sw = false;
                }

                if (Convert.ToString(DGVsu.Rows[i].Cells[3].Value).Equals(""))
                {
                    RTXTlog.AppendText(Environment.NewLine + "Error en la linea " + (i + 1) + " debe digitar un valor");
                    sw = false;
                }
            }

            return sw;
        }

        private void BTNcrear_Click(object sender, EventArgs e)
        {

            try
            {

                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = config.AppSettings.Settings;

                if (settings["Nombre"] == null)
                {
                    settings.Add("Nombre",TXTnombre.Text);
                }
                else
                {
                    settings["Nombre"].Value = TXTnombre.Text;
                }

                if (settings["NIT"] == null)
                {
                    settings.Add("Nit",TXTnombre.Text);
                }
                else
                {
                    settings["NIT"].Value = TXTnombre.Text;
                }

                if (settings["Folios"] == null)
                {
                    settings.Add("Folios", NUDfolios.Value.ToString());
                }
                else
                {
                    settings["Folios"].Value = NUDfolios.Value.ToString();
                }

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);

            }
            catch(ConfigurationErrorsException)
            {
                MessageBox.Show("Error al guardar la configuración de la empresa");
            }

            // Save the changes in App.config file.

            // Force a reload of a changed section.
            //ConfigurationManager.RefreshSection("appSettings");

            RTXTlog.Clear();

            if (verificar())
            {
                for (int i = 0; i < DGVsu.Rows.Count - 1; i++)
                {
                    string tipo = DGVsu.Rows[i].Cells[0].Value.ToString();
                    int folios = Int32.Parse(DGVsu.Rows[i].Cells[1].Value.ToString());
                    int mlineal = Int32.Parse(DGVsu.Rows[i].Cells[2].Value.ToString());
                    string sigla = DGVsu.Rows[i].Cells[3].Value.ToString();

                    addUnitsToDB(tipo, folios, mlineal, sigla);
                }
            }
        }

        private void addUnitsToDB(string tipo, int folios, int mlineal, string sigla)
        {
            using (SqlConnection conn = new SqlConnection(DBconnection))
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Unidad_Almacenamiento VALUES (@tipo, @folios, @metroslineales, @identificador)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@folios", folios);
                cmd.Parameters.AddWithValue("@metroslineales", mlineal);
                cmd.Parameters.AddWithValue("@identificador", sigla);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void CreateBox_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Utilities.Connection))
            {
                DataTable table = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT Tipo, Folios, Metros_lineales, Identificador FROM Unidad_Almacenamiento", conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader != null)
                    {
                        table.Load(reader);
                    }
                }

                DGVsu.DataSource = table;
            }

            try
            {

                var settings = ConfigurationManager.AppSettings;

                if (settings["Nombre"] != null)
                {
                    TXTnombre.Text = settings["Nombre"];
                }

                if (settings["NIT"] != null)
                {
                    TXTnit.Text = settings["NIT"];
                }

                if (settings["Folios"] != null)
                {
                    NUDfolios.Value = Convert.ToDecimal(settings["Folios"]);
                }

            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Error al leer la configuración");
            }
        }
    }
}