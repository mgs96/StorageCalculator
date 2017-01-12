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

namespace StorageCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            initChart();
        }

        Chart pieChart;

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateStorage ns = new CreateStorage();
            ns.ShowDialog();
            loadpieChart();
        }

        private void bodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista ls = new Lista();
            ls.Show();
        }

        private void initChart()
        {
            this.components = new System.ComponentModel.Container();
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend() { BackColor = Color.Green, ForeColor = Color.Black, Title = "Salary" };
            Legend legend2 = new Legend() { BackColor = Color.Green, ForeColor = Color.Black, Title = "Salary" };
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
            legend2.Name = "Legend3";

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
            pieChart.BackColor = Color.White;
            pieChart.Titles.Add("Employee Salary");
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
            series1.Points.Add(0.7);
            series1.Points.Add(0.3);
            var p1 = series1.Points[0];
            p1.AxisLabel = "70000";
            p1.LegendText = "Hiren Khirsaria";
            var p2 = series1.Points[1];
            p2.AxisLabel = "30000";
            p2.LegendText = "ABC XYZ";
            pieChart.Invalidate();
            pnlPie.Controls.Add(pieChart);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
