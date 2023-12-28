using LiveChartsCore.SkiaSharpView.SKCharts;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.General.ChartToImage;

namespace Samples.General.ChartToImage;

public partial class View : VBoxViewBase
{
    private CartesianChart _cartesian;
    private PieChart _pie;
    private GeoMap _map;

    public override void _Ready()
    {
        var viewModel = new ViewModel();

        _cartesian = new CartesianChart
        {
            Series = viewModel.CatesianSeries
        };
        AddChild(_cartesian);

        _pie = new PieChart
        {
            Series = viewModel.PieSeries
        };
        AddChild(_pie);

        _map = new GeoMap
        {
            Series = viewModel.GeoSeries
        };
        AddChild(_map);

        CreateImageFromCartesianControl();
        CreateImageFromPieControl();
        CreateImageFromGeoControl();
    }

    private void CreateImageFromCartesianControl()
    {
        // you can take any chart in the UI, and build an image from it // mark
        var chartControl = _cartesian;
        var skChart = new SKCartesianChart(chartControl) { Width = 900, Height = 600, };
        skChart.SaveImage("CartesianImageFromControl.png");
    }

    private void CreateImageFromPieControl()
    {
        var chartControl = _pie;
        var skChart = new SKPieChart(chartControl) { Width = 900, Height = 600, };
        skChart.SaveImage("PieImageFromControl.png");
    }

    private void CreateImageFromGeoControl()
    {
        var chartControl = _map;
        var skChart = new SKGeoMap(chartControl) { Width = 900, Height = 600, };
        skChart.SaveImage("MapImageFromControl.png");
    }
}
