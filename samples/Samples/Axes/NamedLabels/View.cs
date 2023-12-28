using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Axes.NamedLabels;

namespace Samples.Axes.NamedLabels;

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
            TooltipPosition = LiveChartsCore.Measure.TooltipPosition.Left,
            TooltipTextPaint = viewModel.TooltipTextPaint,
            TooltipBackgroundPaint = viewModel.TooltipBackgroundPaint,
            TooltipTextSize = 16
        });
    }
}
