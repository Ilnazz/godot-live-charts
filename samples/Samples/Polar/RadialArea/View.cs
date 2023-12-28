using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Polar.RadialArea;

namespace Samples.Polar.RadialArea;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new PolarChart
        {
            Series = viewModel.Series,
            AngleAxes = viewModel.AngleAxes,
            InitialRotation = -45
        });
    }
}
