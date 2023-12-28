using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Pies.NightingaleRose;

namespace Samples.Pies.NightingaleRose;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new PieChart
        {
            Series = viewModel.Series
        });
    }
}
