using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Pies.Gauge3;

namespace Samples.Pies.Gauge3;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new PieChart
        {
            Series = viewModel.Series,
            InitialRotation = 45,
            MaxAngle = 270,
            MinValue = 0,
            MaxValue = 100
        });
    }
}
