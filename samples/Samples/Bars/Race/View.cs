using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Bars.Race;

namespace Samples.Bars.Race;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            XAxes = viewModel.XAxes,
            YAxes = viewModel.YAxes,
            TooltipPosition = LiveChartsCore.Measure.TooltipPosition.Hidden
        });
    }
}
