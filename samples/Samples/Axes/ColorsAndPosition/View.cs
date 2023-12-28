using Godot;

using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Axes.ColorsAndPosition;

namespace Samples.Axes.ColorsAndPosition;

public partial class View : VBoxViewBase
{
	public View()
	{
		var viewModel = new ViewModel();

		var buttonsBox = new HBoxContainer();
        AddChild(buttonsBox);

		var togglePositionButton = new Button { Text = "Toggle position" };
		togglePositionButton.Pressed += viewModel.TogglePosition;
		buttonsBox.AddChild(togglePositionButton);

		var setNewColorButton = new Button { Text = "Set new color" };
		setNewColorButton.Pressed += viewModel.SetNewColor;
		buttonsBox.AddChild(setNewColorButton);

		AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            XAxes = viewModel.XAxes,
            YAxes = viewModel.YAxes
        });
	}
}
