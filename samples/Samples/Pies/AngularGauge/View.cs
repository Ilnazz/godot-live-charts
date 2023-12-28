using Godot;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Pies.AngularGauge;

namespace Samples.Pies.AngularGauge;

public partial class View : VBoxViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        var changeValueButton = new Button
        {
            Text = "Change value",
            SizeFlagsHorizontal = SizeFlags.ShrinkCenter
        };
        changeValueButton.Pressed += viewModel.DoRandomChange;
        AddChild(changeValueButton);

        AddChild(new PieChart
        {
            Series = viewModel.Series,
            VisualElements = viewModel.VisualElements,
            InitialRotation = -225,
            MaxAngle = 270,
            MinValue = 0,
            MaxValue = 100
        });
    }
}
