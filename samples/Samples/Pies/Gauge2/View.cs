using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Pies.Gauge2;

namespace Samples.Pies.Gauge2;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new PieChart
        {
            Series = viewModel.Series,
            InitialRotation = -225,
            MaxAngle = 270,
            MinValue = 0,
            MaxValue = 100
        });
    }
}
