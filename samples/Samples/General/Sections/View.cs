using Godot;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.General.Sections;

namespace Samples.General.Sections;

public partial class View : VBoxViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        var toggleFirstButton = new Button { Text = "Toggle first" };
        toggleFirstButton.Pressed += viewModel.ToggleFirst;
        AddChild(toggleFirstButton);

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            Sections = viewModel.Sections
        });
    }
}
