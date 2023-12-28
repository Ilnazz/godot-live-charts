using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Polar.Basic;

namespace Samples.Polar.Basic;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new PolarChart
        {
            Series = viewModel.Series,
            AngleAxes = viewModel.AngleAxes,
            RadiusAxes = viewModel.RadialAxes,
            Title = viewModel.Title
        });
    }
}
