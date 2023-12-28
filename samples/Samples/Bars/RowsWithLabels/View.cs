using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Bars.RowsWithLabels;

namespace Samples.Bars.RowsWithLabels;

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
