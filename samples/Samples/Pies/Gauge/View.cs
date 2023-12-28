using Godot;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Pies.Gauge;

namespace Samples.Pies.Gauge;

public partial class View : VBoxViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        var box = new HBoxContainer();
        AddChild(box);

        var initialRotationLabel = new Label
        {
            Text = $"Initial rotation: {viewModel.InitialRotation} deg",
            SelfModulate = Colors.Black
        };
        box.AddChild(initialRotationLabel);

        var initialRotationSlider = new HSlider()
        {
            Value = viewModel.InitialRotation,
            MinValue = -360,
            MaxValue = 720,
            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ShrinkCenter
        };
        initialRotationSlider.ValueChanged += value =>
        {
            viewModel.InitialRotation = value;
            initialRotationLabel.Text = $"Initial rotation: {value}";
        };
        box.AddChild(initialRotationSlider);

        box = new HBoxContainer();
        AddChild(box);

        var maxAngleLabel = new Label
        {
            Text = $"Max angle: {viewModel.MaxAngle} deg",
            SelfModulate = Colors.Black
        };
        box.AddChild(maxAngleLabel);

        var maxAngleSlider = new HSlider()
        {
            Value = viewModel.MaxAngle,
            MinValue = 0,
            MaxValue = 360,
            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ShrinkCenter
        };
        maxAngleSlider.ValueChanged += value =>
        {
            viewModel.MaxAngle = value;
            maxAngleLabel.Text = $"Max angle: {value} deg";
        };
        box.AddChild(maxAngleSlider);

        box = new HBoxContainer();
        AddChild(box);

        var innerRadiusLabel = new Label
        {
            Text = $"Inner radius: {viewModel.InnerRadius}",
            SelfModulate = Colors.Black
        };
        box.AddChild(innerRadiusLabel);

        var innerRadiusSlider = new HSlider()
        {
            Value = viewModel.InnerRadius,
            MinValue = 0,
            MaxValue = 50,
            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ShrinkCenter
        };
        innerRadiusSlider.ValueChanged += value =>
        {
            viewModel.InnerRadius = value;
            innerRadiusLabel.Text = $"Inner radius: {value}";
        };
        box.AddChild(innerRadiusSlider);

        box = new HBoxContainer();
        AddChild(box);

        var offsetRadiusLabel = new Label
        {
            Text = $"Offset radius: {viewModel.OffsetRadius}",
            SelfModulate = Colors.Black
        };
        box.AddChild(offsetRadiusLabel);

        var offsetRadiusSlider = new HSlider()
        {
            Value = viewModel.OffsetRadius,
            MinValue = 0,
            MaxValue = 50,
            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ShrinkCenter
        };
        offsetRadiusSlider.ValueChanged += value =>
        {
            viewModel.OffsetRadius = value;
            offsetRadiusLabel.Text = $"Offset radius: {value}";
        };
        box.AddChild(offsetRadiusSlider);

        box = new HBoxContainer();
        AddChild(box);

        var backgroundInnerRadiusLabel = new Label
        {
            Text = $"Background inner radius: {viewModel.BackgroundInnerRadius}",
            SelfModulate = Colors.Black
        };
        box.AddChild(backgroundInnerRadiusLabel);

        var backgroundInnerRadiusSlider = new HSlider()
        {
            Value = viewModel.BackgroundInnerRadius,
            MinValue = 0,
            MaxValue = 50,
            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ShrinkCenter
        };
        backgroundInnerRadiusSlider.ValueChanged += value =>
        {
            viewModel.BackgroundInnerRadius = value;
            backgroundInnerRadiusLabel.Text = $"Background inner radius: {value}";
        };
        box.AddChild(backgroundInnerRadiusSlider);

        box = new HBoxContainer();
        AddChild(box);

        var backgroundOffsetRadiusLabel = new Label
        {
            Text = $"Background offset radius: {viewModel.BackgroundOffsetRadius}",
            SelfModulate = Colors.Black
        };
        box.AddChild(backgroundOffsetRadiusLabel);

        var backgroundOffsetRadiusSlider = new HSlider()
        {
            Value = viewModel.BackgroundOffsetRadius,
            MinValue = 0,
            MaxValue = 50,
            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ShrinkCenter
        };
        backgroundOffsetRadiusSlider.ValueChanged += value =>
        {
            viewModel.BackgroundOffsetRadius = value;
            backgroundOffsetRadiusLabel.Text = $"Background offset radius: {value}";
        };
        box.AddChild(backgroundOffsetRadiusSlider);

        AddChild(new PieChart
        {
            Series = viewModel.Series
        });
    }
}
