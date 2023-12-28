using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.StepLines.Custom;

namespace Samples.StepLines.Custom;

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
