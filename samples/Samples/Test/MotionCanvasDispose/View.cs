using Godot;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Test.MotionCanvasDispose;

namespace Samples.Test.MotionCanvasDispose;

public partial class View : VBoxViewBase
{
	public View()
	{
		var contentControl = new Control
		{
			LayoutMode = 1,
			AnchorsPreset = (int)LayoutPreset.FullRect,

			SizeFlagsHorizontal = SizeFlags.ExpandFill,
			SizeFlagsVertical = SizeFlags.ExpandFill
		};
		contentControl.AddChild(CreateContent());

		var changeContentButton = new Button() { Text = "Change content" };
		changeContentButton.Pressed += () =>
		{
			contentControl.RemoveChild(contentControl.GetChild(0));
			contentControl.AddChild(CreateContent());
		};
		AddChild(changeContentButton);

		AddChild(contentControl);
	}

	private static Control CreateContent()
	{
		var canvas = new MotionCanvas
		{
			LayoutMode = 1,
			AnchorsPreset = (int)LayoutPreset.FullRect,

			SizeFlagsHorizontal = SizeFlags.ExpandFill,
			SizeFlagsVertical = SizeFlags.ExpandFill
		};
		canvas.Ready += () => ViewModel.Generate(canvas.CoreCanvas);
		return canvas;
	}
}
