using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Events.AddPointOnClick;

namespace Samples.Events.AddPointOnClick;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.SeriesCollection,
            PointerPressedCommand = viewModel.PointerDownCommand,
            TooltipPosition = LiveChartsCore.Measure.TooltipPosition.Hidden
        });
    }
}
