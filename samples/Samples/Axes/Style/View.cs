using Godot;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Axes.Style;

namespace Samples.Axes.Style;

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
            DrawMarginFrame = viewModel.Frame,
            ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.Both,
            TooltipPosition = LiveChartsCore.Measure.TooltipPosition.Hidden,
            Background = Color.Color8(51, 51, 51)
        });
    }
}
