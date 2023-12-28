using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Pies.Gauge1;

namespace Samples.Pies.Gauge1;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new PieChart
        {
            Series = viewModel.Series,
            InitialRotation = -90,
            MinValue = 0,
            MaxValue = 100
        });
    }
}
