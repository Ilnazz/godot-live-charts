using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Axes.Shared;

namespace Samples.Axes.Shared;

public partial class View : VBoxViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.SeriesCollection1,
            ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X,
            DrawMargin = viewModel.DrawMargin,
            XAxes = viewModel.X1
        });
        AddChild(new CartesianChart
        {
            Series = viewModel.SeriesCollection2,
            ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X,
            DrawMargin = viewModel.DrawMargin,
            XAxes = viewModel.X2
        });
    }
}
