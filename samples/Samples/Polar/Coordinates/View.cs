using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Polar.Coordinates;

namespace Samples.Polar.Coordinates;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new PolarChart
        {
            Series = viewModel.Series,
            AngleAxes = viewModel.AngleAxes
        });
    }
}
