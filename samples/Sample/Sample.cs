using Godot;
using GodotPlugins.LiveCharts;
using LiveChartsCore.Measure;

namespace Sample;

public partial class Sample : Control
{
    public override void _Ready()
    {
        var viewModel = new ViewModel();

        var cartesianChart = (CartesianChart)FindChild("CartesianChart");

        cartesianChart.Series = viewModel.Series;
        cartesianChart.LegendPosition = LegendPosition.Right;
    }
}