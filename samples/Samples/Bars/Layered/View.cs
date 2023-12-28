using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Bars.Layered;

namespace Samples.Bars.Layered;

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
