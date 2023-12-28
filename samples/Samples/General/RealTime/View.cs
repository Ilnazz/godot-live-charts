using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.General.RealTime;

namespace Samples.General.RealTime;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            SyncContext = viewModel.Sync,
            Series = viewModel.Series,
            XAxes = viewModel.XAxes
        });
    }
}
