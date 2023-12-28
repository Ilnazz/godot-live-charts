using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Design.RadialGradients;

namespace Samples.Design.RadialGradients;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new PieChart
        {
            Series = viewModel.Series,
            LegendPosition = LiveChartsCore.Measure.LegendPosition.Right
        });
    }
}
