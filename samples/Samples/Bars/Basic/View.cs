using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Bars.Basic;

namespace Samples.Bars.Basic;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            XAxes = viewModel.XAxes,
            LegendPosition = LiveChartsCore.Measure.LegendPosition.Right
        });
    }
}
