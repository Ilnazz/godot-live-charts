using Godot;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Pies.Gauge5;

namespace Samples.Pies.Gauge5;

public partial class View : VBoxViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        var changeValueButton = new Button { Text = "Change value", SizeFlagsHorizontal = SizeFlags.ShrinkCenter };
        changeValueButton.Pressed += viewModel.DoRandomChange;
        AddChild(changeValueButton);

        AddChild(new PieChart
        {
            Series = viewModel.Series,
            InitialRotation = -90,
            MaxAngle = 270,
            MinValue = 0,
            MaxValue = 100,
            LegendPosition = LiveChartsCore.Measure.LegendPosition.Bottom
        });
    }
}
