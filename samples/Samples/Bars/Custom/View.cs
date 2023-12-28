using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Bars.Custom;

namespace Samples.Bars.Custom;

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
