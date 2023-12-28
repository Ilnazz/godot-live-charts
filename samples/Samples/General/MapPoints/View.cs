using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.General.MapPoints;

namespace Samples.General.MapPoints;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series
        });
    }
}
