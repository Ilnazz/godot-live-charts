using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.StepLines.Zoom;

namespace Samples.StepLines.Zoom;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.SeriesCollection,
            ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X
        });
    }
}
