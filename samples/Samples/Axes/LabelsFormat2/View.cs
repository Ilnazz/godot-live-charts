using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Axes.LabelsFormat2;

namespace Samples.Axes.LabelsFormat2;

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
