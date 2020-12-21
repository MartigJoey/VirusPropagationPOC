using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChartValues<double> values1 = new ChartValues<double> { 1, 2, 3, 100, 1000};
            ChartValues<double> values2 = new ChartValues<double> { 1000, 100, 3, 2, 1};

            chart.Series = new SeriesCollection { 
                new LineSeries
                {
                    Values = values1,
                },
                new LineSeries
                {
                    Values = values2,
                }
            };

            chart.AxisX.Add(new LiveCharts.Wpf.Axis{
                Title = "Month",
                Labels = new[] { "Jan", "Fev", "Mar", "April", "May", "Jun", "Jan", "Fev", "Mar", "April", "May", "Jun" }
            });

            chart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Nombre de cas",
                LabelFormatter = value=>value.ToString(),
                MinValue = 0
            });

            LiveCharts.WinForms.GeoMap geoMap1 = new LiveCharts.WinForms.GeoMap();

            Dictionary<string, double> valuesMap = new Dictionary<string, double>();
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
            geoMap1.Dock = DockStyle.Fill;
        }

        private void Map_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {
            MessageBox.Show(arg2.Name + " " + arg2.Id);
        }
    }
}
