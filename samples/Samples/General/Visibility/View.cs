using Godot;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.General.Visibility;

namespace Samples.General.Visibility;

public partial class View : VBoxViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        var buttons = new HBoxContainer();
        AddChild(buttons);

        var toggleSeries1Button = new Button { Text = "Toggle series 1" };
        toggleSeries1Button.Pressed += viewModel.ToggleSeries0;
        buttons.AddChild(toggleSeries1Button);

        var toggleSeries2Button = new Button { Text = "Toggle series 2" };
        toggleSeries2Button.Pressed += viewModel.ToggleSeries1;
        buttons.AddChild(toggleSeries2Button);

        var toggleSeries3Button = new Button { Text = "Toggle series 3" };
        toggleSeries3Button.Pressed += viewModel.ToggleSeries2;
        buttons.AddChild(toggleSeries3Button);

        AddChild(new CartesianChart
        {
            Series = viewModel.Series
        });
    }
}
