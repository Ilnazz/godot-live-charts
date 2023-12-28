using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Lines.Custom;

namespace Samples.Lines.Custom;

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
