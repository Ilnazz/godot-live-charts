using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.General.VisualElements;

namespace Samples.General.VisualElements;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            VisualElements = viewModel.VisualElements,
            ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X
        });
    }
}
