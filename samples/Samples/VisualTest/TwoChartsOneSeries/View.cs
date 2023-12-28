using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.VisualTest.TwoChartsOneSeries;

namespace Samples.VisualTest.TwoChartsOneSeries;

public partial class View : VBoxViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X
        });
        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X
        });
    }
}
