using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Axes.DateTimeScaled;

namespace Samples.Axes.DateTimeScaled;

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
