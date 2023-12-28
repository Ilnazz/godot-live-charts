using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Axes.TimeSpanScaled;

namespace Samples.Axes.TimeSpanScaled;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            XAxes = viewModel.XAxes
        });
    }
}
