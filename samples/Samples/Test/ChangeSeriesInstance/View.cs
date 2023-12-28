using Godot;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Test.ChangeSeriesInstance;

namespace Samples.Test.ChangeSeriesInstance;

public partial class View : VBoxViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        var changeDataButton = new Button() { Text = "Change data" };
        AddChild(changeDataButton);

        var cartesianChart = new CartesianChart
        {
            Series = viewModel.CartesianSeries
        };
        AddChild(cartesianChart);

        var pieChart = new PieChart
        {
            Series = viewModel.PieSeries
        };
        AddChild(pieChart);

        var polarChart = new PolarChart
        {
            Series = viewModel.PolarSeries
        };
        AddChild(polarChart);

        var geoMap = new GeoMap
        {
            Series = viewModel.GeoSeries,
            MapProjection = LiveChartsCore.Geo.MapProjection.Mercator
        };
        AddChild(geoMap);

        changeDataButton.Pressed += () =>
        {
            viewModel.GenerateData();
            cartesianChart.Series = viewModel.CartesianSeries;
            pieChart.Series = viewModel.PieSeries;
            polarChart.Series = viewModel.PolarSeries;
            geoMap.Series = viewModel.GeoSeries;
        };
    }
}
