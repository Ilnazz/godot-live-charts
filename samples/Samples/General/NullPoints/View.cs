using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.General.NullPoints;

namespace Samples.General.NullPoints;

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
