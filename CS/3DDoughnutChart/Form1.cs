using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace _DDoughnutChart {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create an empty chart.
            ChartControl DoughnutChart3D = new ChartControl();

            // Create a doughnut series.
            Series series1 = new Series("Doughnut Series 1", ViewType.Doughnut3D);

            // Populate the series with points.
            series1.Points.Add(new SeriesPoint("Russia", 17.0752));
            series1.Points.Add(new SeriesPoint("Canada", 9.98467));
            series1.Points.Add(new SeriesPoint("USA", 9.63142));
            series1.Points.Add(new SeriesPoint("China", 9.59696));
            series1.Points.Add(new SeriesPoint("Brazil", 8.511965));
            series1.Points.Add(new SeriesPoint("Australia", 7.68685));
            series1.Points.Add(new SeriesPoint("India", 3.28759));
            series1.Points.Add(new SeriesPoint("Others", 81.2));

            // Add the series to the chart.
            DoughnutChart3D.Series.Add(series1);

            // Adjust the value numeric options of the series.
            series1.Label.TextPattern = "{VP:p2}";

            // Adjust the view-type-specific options of the series.
            ((Doughnut3DSeriesView)series1.View).HoleRadiusPercent = 30;
            ((Doughnut3DSeriesView)series1.View).ExplodedPoints.Add(series1.Points[0]);

            // Access the diagram's options.
            ((SimpleDiagram3D)DoughnutChart3D.Diagram).RotationType = RotationType.UseAngles;
            ((SimpleDiagram3D)DoughnutChart3D.Diagram).RotationAngleX = -35;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "3D Doughnut Chart";
            DoughnutChart3D.Titles.Add(chartTitle1);
            DoughnutChart3D.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Add the chart to the form.
            DoughnutChart3D.Dock = DockStyle.Fill;
            this.Controls.Add(DoughnutChart3D);
        }

    }
}