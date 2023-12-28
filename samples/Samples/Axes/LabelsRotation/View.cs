using Godot;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Axes.LabelsRotation;

namespace Samples.Axes.LabelsRotation;

public partial class View : VBoxViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        var sliderContainer = new VBoxContainer();
        AddChild(sliderContainer);

        var rotationSliderLabel = new Label
        {
            SelfModulate = Colors.Black,
            Text = $"Rotation: {viewModel.SliderValue} deg."
        };
        sliderContainer.AddChild(rotationSliderLabel);

        var rotationSlider = new HSlider() { MinValue = -360, MaxValue = 720 };
        rotationSlider.ValueChanged += value =>
        {
            viewModel.SliderValue = value;
            rotationSliderLabel.Text = $"Rotation: {value} deg.";
        };
        sliderContainer.AddChild(rotationSlider);

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            XAxes = viewModel.XAxes,
            YAxes = viewModel.YAxes
        });
    }
}
