using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Scatter.Bubbles;

namespace Samples.Scatter.Bubbles;

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
