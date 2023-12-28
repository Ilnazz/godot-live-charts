using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.General.TemplatedLegends;

namespace Samples.General.TemplatedLegends;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            LegendPosition = LiveChartsCore.Measure.LegendPosition.Right,
            Legend = new CustomLegend()
        });
    }
}
