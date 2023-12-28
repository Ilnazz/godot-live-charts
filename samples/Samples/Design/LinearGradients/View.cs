using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Design.LinearGradients;

namespace Samples.Design.LinearGradients;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            LegendPosition = LiveChartsCore.Measure.LegendPosition.Right
        });
    }
}
