using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace StorageCalculator
{
    public partial class Form1 : Form
    {

        private Storage st;
        private List<Storage> storages;
        private int total = 0;
        private int ocupado = 0;

        public Form1()
        {
            InitializeComponent();
            initChart();
            storages = new List<Storage>();
            loadStorages();
        }

        Chart pieChart;

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateStorage ns = new CreateStorage();
            ns.ShowDialog();
            loadStorages(); //Primero inicia
            loadpieChart(); //Luego dibuja
            this.SendToBack();
        }

        private void bodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista ls = new Lista();
            ls.Show();
        }

        private void loadStorages()
        {
            using (SqlConnection con = new SqlConnection(Utilities.Connection))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Storage", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                st = new Storage(reader["Id"].ToString(), reader["Nombre"].ToString(), (int)reader["CapacidadOcupada"], (int)reader["CapacidadTotal"], (int)reader["Ancho"], (int)reader["Largo"]);
                                storages.Add(st);
                                total += st.Capacidad_total;
                                ocupado += st.Capacidad_ocupada;
                            }
                        }
                    }
                }
            }
        }

        private void initChart()
        {
            this.components = new System.ComponentModel.Container();
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend() { BackColor = Color.Green, ForeColor = Color.Black, Title = "Salary" };
            pieChart = new Chart();

            ((ISupportInitialize)(pieChart)).BeginInit();

            SuspendLayout();

            //===Pie chart
            chartArea1.Name = "PieChartArea";
            pieChart.ChartAreas.Add(chartArea1);
            pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            pieChart.Legends.Add(legend1);
            pieChart.Location = new System.Drawing.Point(0, 50);

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(284, 262);           
            ((ISupportInitialize)(this.pieChart)).EndInit();
            this.ResumeLayout(false);
        }

        private void loadpieChart()
        {
            pieChart.Series.Clear();
            pieChart.Palette = ChartColorPalette.Pastel;
            pieChart.BackColor = Color.White;
            pieChart.Titles.Add("Metros lineales");
            pieChart.ChartAreas[0].BackColor = Color.Transparent;
            Series series1 = new Series
            {
                Name = "series1",
                IsVisibleInLegend = true,
                Color = System.Drawing.Color.Green,
                ChartType = SeriesChartType.Pie
            };
            pieChart.Series.Add(series1);
            //series.Points.Add controla el tamaño de la tajada, deben ser tamaños complementarios
            series1.Points.Add((total - ocupado) / total);
            var p1 = series1.Points[0];
            series1.Points.Add(ocupado / total);
            var p2 = series1.Points[1];

            if (ocupado != 0)
            {
                p1.AxisLabel = ((total - ocupado) / total) * 100 + "%";
                p2.AxisLabel = (ocupado / total) * 100 + "%";
            }
            p1.LegendText = "Espacio Disponible";
            p2.LegendText = "Espacio Ocupado";
            pieChart.Invalidate();
            pnlPie.Controls.Add(pieChart);
        }
    }
}
