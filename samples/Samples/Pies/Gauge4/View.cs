using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Pies.Gauge4;

namespace Samples.Pies.Gauge4;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new PieChart
        {
            Series = viewModel.Series,
            InitialRotation = -90,
            MaxAngle = 350,
            MinValue = 0,
            MaxValue = 100
        });
    }
}
