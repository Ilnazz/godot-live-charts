using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Bars.WithBackground;

namespace Samples.Bars.WithBackground;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            YAxes = viewModel.YAxes
        });
    }
}
