using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.General.TemplatedTooltips;

namespace Samples.General.TemplatedTooltips;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            TooltipPosition = LiveChartsCore.Measure.TooltipPosition.Top,
            Tooltip = new CustomTooltip()
        });
    }
}
