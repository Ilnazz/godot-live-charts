using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Pies.Pushout;

namespace Samples.Pies.Pushout;

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
