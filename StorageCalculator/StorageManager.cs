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
using System.Windows.Forms.DataVisualization.Charting;

namespace StorageCalculator
{
    public partial class StorageManager : Form
    {

        private Storage storage;
        private int ocupado;
        private int total;
        Chart pieChart;

        public StorageManager(Storage s)
        {
            InitializeComponent();
            initChart();
            storage = s;
        }

        private void updateBoxes()
        {
            using (SqlConnection conn = new SqlConnection(Utilities.Connection))
            {
                DGVcajas.DataSource = Utilities.GetDataToSource("SELECT Id AS Identificador, Cantidad, Tipo AS Tipo, Folios as [Número de folios], Metros_lineales as [Metros lineales ocupados] FROM Unidad_Almacenamiento", conn);
            }
        }

        private void StorageManager_Load(object sender, EventArgs e)
        {
            updateBoxes();
            total = storage.Capacidad_total;
            ocupado = storage.Capacidad_ocupada;
            loadpieChart();
            //LoadBarChart();
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBox cb = new CreateBox(storage);
            cb.ShowDialog();
            updateBoxes();
            total = storage.Capacidad_total;
            ocupado = storage.Capacidad_ocupada;
            loadpieChart();
        }

        private void initChart()
        {
            this.components = new System.ComponentModel.Container();
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend() { BackColor = Color.Green, ForeColor = Color.Black, Title = "Espacio de almacenamiento" };
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

            //====Bar Chart
            chartArea1 = new ChartArea();
            chartArea1.Name = "BarChartArea";

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(284, 262);           
            ((ISupportInitialize)(this.pieChart)).EndInit();
            this.ResumeLayout(false);
        }

        private void loadpieChart()
        {
            pieChart.Series.Clear();
            pieChart.Palette = ChartColorPalette.Fire;
            pieChart.BackColor = Color.LightYellow;
            pieChart.Titles.Add("Almacenamiento");
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
            series1.Points.Add(total/total);
            series1.Points.Add(ocupado/total);
            var p1 = series1.Points[0];
            p1.LegendText = "Espacio disponible";
            var p2 = series1.Points[1];
            p2.LegendText = "Espacio ocupado";
            pieChart.Invalidate();
            pnlPie.Controls.Add(pieChart);
        }

        /*void LoadBarChart()
        {
            barChart.Series.Clear();
            barChart.BackColor = Color.LightYellow;
            barChart.Palette = ChartColorPalette.Fire;
            barChart.ChartAreas[0].BackColor = Color.Transparent;
            barChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            barChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            Series series = new Series
            {
                Name = "series2",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column
            };
            barChart.Series.Add(series);
            series.Points.Add(70000);
            var p1 = series.Points[0];
            p1.Color = Color.Red;
            p1.AxisLabel = "Hiren Khirsaria";
            p1.LegendText = "Hiren Khirsaria";
            p1.Label = "70000";

            series.Points.Add(30000);
            var p2 = series.Points[1];
            p2.Color = Color.Yellow;
            p2.AxisLabel = "ABC XYZ";
            p2.LegendText = "ABC XYZ";
            p2.Label = "30000";
            barChart.Invalidate();

            pnlBar.Controls.Add(barChart);
        }*/
    }
}
