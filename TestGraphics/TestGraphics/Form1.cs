using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TestGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int iteration = 0;
        ChartValues<double> values1 = new ChartValues<double> { 1, 2, 3, 100, 1000 };
        ChartValues<double> values2 = new ChartValues<double> { 1000, 100, 3, 2, 1 };
        private void Form1_Load(object sender, EventArgs e)
        {

            /*chart.Series = new SeriesCollection { 
                new LineSeries
                {
                    Values = values1,
                },
                new LineSeries
                {
                    Values = values2,
                }
            };*/

            chart.Series.Add(new LineSeries
                            {
                                Values = values1,
                            });

            chart.Series.Add(new LineSeries
            {
                Values = values2,
            });

            chart.AxisX.Add(new Axis{
                Title = "Month",
                Labels = new[] { "Jan", "Fev", "Mar", "April", "May", "Jun", "Jan", "Fev", "Mar", "April", "May", "Jun" }
            });

            chart.AxisY.Add(new Axis
            {
                Title = "Nombre de cas",
                LabelFormatter = value=>value.ToString(),
                MinValue = 0
            });

            //LiveCharts.WinForms.GeoMap geoMap1 = new LiveCharts.WinForms.GeoMap();

            ChartValues<double> values3 = new ChartValues<double> { 50, 10 };
            ChartValues<double> values4 = new ChartValues<double> { 20 };
            ChartValues<double> values5 = new ChartValues<double> { 30 };
            pieChart.Series = new SeriesCollection
            {
                new PieSeries{ Values = values3, Name = "Mabite" },
                new PieSeries{ Values = values4, Name = "Mabie" },
                new PieSeries{ Values = values5, Name = "Mabit" }
            };

            Console.WriteLine(pieChart.Series[0].DataLabels);
            PieSeries value1 = new PieSeries(values3);
            /*Dictionary<string, double> valuesMap = new Dictionary<string, double>();
            Random r = new Random();

            for (int i = 2; i <= 20; i++)
            {
                valuesMap[i.ToString()] = r.Next(0, 100);
            }

            for (int i = 3304; i <= 3311; i++)
            {
                valuesMap[i.ToString()] = r.Next(0, 100);
            }

            geoMap1.HeatMap = valuesMap;
            geoMap1.Source = @"C:\Users\schad\OneDrive\Bureau\POC\TestGraphics\TestGraphics\Switzerland.xml";
            geoMap1.LandClick += Map_LandClick;

            groupBox1.Controls.Add(geoMap1);
            geoMap1.Dock = DockStyle.Fill;*/

           /* DataTable table = new DataTable();
            Random random = new Random();
            table.Columns.Add("X", typeof(int));
                table.Columns.Add("Y", typeof(int));
                for (int i = 0; i < 10; i++)
                    table.Rows.Add(i+1, random.Next(100));
                chart2.Series[0].ChartType = 
                    System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart2.Series[0].XValueMember = "X";
                chart2.Series[0].YValueMembers = "Y";
                chart2.DataSource = table;
                chart2.ChartAreas[0].AxisX.Interval = 1;
                chart2.ChartAreas[0].AxisX.Minimum = 0;
                chart2.ChartAreas[0].AxisX.Maximum = 10;
                chart2.ChartAreas[0].AxisY.Interval = 10;
                chart2.ChartAreas[0].AxisY.Minimum = 0;
                chart2.ChartAreas[0].AxisY.Maximum = 100;
                chart2.DataBind();
                var timer = new Timer() { Interval= 300};
                timer.Tick += timer_Tick;
                timer.Start();
             
             */
        }

        /*private void Map_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {
            MessageBox.Show(arg2.Name + " " + arg2.Id);
        }*/

        private void timer1_Tick(object sender, EventArgs e)
        {
            iteration += 10;
            values1[0] = iteration;
        }
    }
}
