using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Pies.Doughnut;

namespace Samples.Pies.Doughnut;

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
