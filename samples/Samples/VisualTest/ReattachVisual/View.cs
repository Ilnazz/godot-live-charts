using Godot;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.VisualTest.ReattachVisual;

namespace Samples.VisualTest.ReattachVisual;

public partial class View : VBoxViewBase
{
    private CartesianChart _chart;

    public View()
    {
        var viewModel = new ViewModel();

        var toggleAttachButton = new Button { Text = "Toggle attach" };
        toggleAttachButton.Pressed += ToggleChartAttachment;
        AddChild(toggleAttachButton);

        _chart = new CartesianChart
        {
            Series = viewModel.Series,
            Sections = viewModel.Sections,
            ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X
        };
        ToggleChartAttachment();
    }

    private void ToggleChartAttachment()
    {
        if (_chart.GetParent() is null)
            AddChild(_chart);
        else
            RemoveChild(_chart);
    }
}
