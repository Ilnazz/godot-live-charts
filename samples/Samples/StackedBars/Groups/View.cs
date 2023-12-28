using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.StackedBars.Groups;

namespace Samples.StackedBars.Groups;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            XAxes = viewModel.XAxis
        });
    }
}
