using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Lines.Straight;

namespace Samples.Lines.Straight;

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
