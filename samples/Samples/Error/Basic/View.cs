using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Error.Basic;

namespace Samples.Error.Basic;

public partial class View : VBoxViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series0
        });
        AddChild(new CartesianChart
        {
            Series = viewModel.Series1
        });
        AddChild(new CartesianChart
        {
            Series = viewModel.Series2,
            XAxes = viewModel.DateTimeAxis
        });
    }
}
