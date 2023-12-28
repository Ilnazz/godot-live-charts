using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.StackedBars.Basic;

namespace Samples.StackedBars.Basic;

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
