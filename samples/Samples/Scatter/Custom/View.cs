using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Scatter.Custom;

namespace Samples.Scatter.Custom;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series
        });
    }
}
