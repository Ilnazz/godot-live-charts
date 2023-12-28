using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Heat.Basic;

namespace Samples.Heat.Basic;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            XAxes = viewModel.XAxes,
            YAxes = viewModel.YAxes
        });
    }
}
