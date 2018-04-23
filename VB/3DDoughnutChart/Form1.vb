Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace _DDoughnutChart
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create an empty chart.
            Dim DoughnutChart3D As New ChartControl()

            ' Create a doughnut series.
            Dim series1 As New Series("Doughnut Series 1", ViewType.Doughnut3D)

            ' Populate the series with points.
            series1.Points.Add(New SeriesPoint("Russia", 17.0752))
            series1.Points.Add(New SeriesPoint("Canada", 9.98467))
            series1.Points.Add(New SeriesPoint("USA", 9.63142))
            series1.Points.Add(New SeriesPoint("China", 9.59696))
            series1.Points.Add(New SeriesPoint("Brazil", 8.511965))
            series1.Points.Add(New SeriesPoint("Australia", 7.68685))
            series1.Points.Add(New SeriesPoint("India", 3.28759))
            series1.Points.Add(New SeriesPoint("Others", 81.2))

            ' Add the series to the chart.
            DoughnutChart3D.Series.Add(series1)

            ' Adjust the value numeric options of the series.
            series1.Label.TextPattern = "{VP:p2}"

            ' Adjust the view-type-specific options of the series.
            CType(series1.View, Doughnut3DSeriesView).HoleRadiusPercent = 30
            CType(series1.View, Doughnut3DSeriesView).ExplodedPoints.Add(series1.Points(0))

            ' Access the diagram's options.
            CType(DoughnutChart3D.Diagram, SimpleDiagram3D).RotationType = RotationType.UseAngles
            CType(DoughnutChart3D.Diagram, SimpleDiagram3D).RotationAngleX = -35

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "3D Doughnut Chart"
            DoughnutChart3D.Titles.Add(chartTitle1)
            DoughnutChart3D.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False

            ' Add the chart to the form.
            DoughnutChart3D.Dock = DockStyle.Fill
            Me.Controls.Add(DoughnutChart3D)
        End Sub

    End Class
End Namespace