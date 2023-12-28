using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Lines.Zoom;

namespace Samples.Lines.Zoom;

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
