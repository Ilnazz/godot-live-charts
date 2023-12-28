using Godot;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Pies.Gauges;

namespace Samples.Pies.Gauges;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        var scrollContainer = new ScrollContainer
        {
            LayoutMode = 1,
            AnchorsPreset = (int)LayoutPreset.FullRect,
        };
        AddChild(scrollContainer);

        var vBoxContainer = new VBoxContainer
        {
            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ExpandFill
        };
        scrollContainer.AddChild(vBoxContainer);

        var flowContainer1 = new HFlowContainer
        {
            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ExpandFill
        };
        vBoxContainer.AddChild(flowContainer1);

        var pieChart = new PieChart
        {
            Series = viewModel.Series1,
            MaxValue = viewModel.GaugeTotal1,

            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ExpandFill
        };
        pieChart.SetDeferred("custom_minimum_size", new Vector2(200, 200));
        flowContainer1.AddChild(pieChart);

        pieChart = new PieChart
        {
            Series = viewModel.Series2,
            InitialRotation = viewModel.InitialRotation2,
            MaxValue = viewModel.GaugeTotal2,

            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ExpandFill
        };
        pieChart.SetDeferred("custom_minimum_size", new Vector2(200, 200));
        flowContainer1.AddChild(pieChart);

        pieChart = new PieChart
        {
            Series = viewModel.Series3,
            InitialRotation = viewModel.InitialRotation3,
            MaxValue = viewModel.GaugeTotal3,

            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ExpandFill
        };
        pieChart.SetDeferred("custom_minimum_size", new Vector2(200, 200));
        flowContainer1.AddChild(pieChart);

        pieChart = new PieChart
        {
            Series = viewModel.Series4,
            InitialRotation = viewModel.InitialRotation4,
            MaxValue = viewModel.GaugeTotal4,

            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ExpandFill
        };
        pieChart.SetDeferred("custom_minimum_size", new Vector2(200, 200));
        flowContainer1.AddChild(pieChart);

        pieChart = new PieChart
        {
            Series = viewModel.Series5,
            InitialRotation = viewModel.InitialRotation5,
            MaxValue = viewModel.GaugeTotal5,

            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ExpandFill
        };
        pieChart.SetDeferred("custom_minimum_size", new Vector2(200, 200));
        flowContainer1.AddChild(pieChart);

        pieChart = new PieChart
        {
            Series = viewModel.Series6,
            InitialRotation = viewModel.InitialRotation6,
            MaxValue = viewModel.GaugeTotal6,

            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ExpandFill
        };
        pieChart.SetDeferred("custom_minimum_size", new Vector2(200, 200));
        flowContainer1.AddChild(pieChart);

        pieChart = new PieChart
        {
            Series = viewModel.Series7,
            InitialRotation = viewModel.InitialRotation7,
            MaxValue = viewModel.GaugeTotal7,

            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ExpandFill
        };
        pieChart.SetDeferred("custom_minimum_size", new Vector2(200, 200));
        flowContainer1.AddChild(pieChart);

        pieChart = new PieChart
        {
            Series = viewModel.Series8,
            InitialRotation = viewModel.InitialRotation8,
            MaxAngle = viewModel.MaxAngle8,
            MaxValue = viewModel.GaugeTotal8,

            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ExpandFill
        };
        pieChart.SetDeferred("custom_minimum_size", new Vector2(200, 200));
        flowContainer1.AddChild(pieChart);

        pieChart = new PieChart
        {
            Series = viewModel.Series9,
            InitialRotation = viewModel.InitialRotation9,
            MaxAngle = viewModel.MaxAngle9,
            MaxValue = viewModel.GaugeTotal9,
        };
        pieChart.SetDeferred("custom_minimum_size", new Vector2(200, 200));
        flowContainer1.AddChild(pieChart);

        pieChart = new PieChart
        {
            Series = viewModel.Series10,
            InitialRotation = viewModel.InitialRotation10,
            MaxAngle = viewModel.MaxAngle10,
            MaxValue = viewModel.GaugeTotal10,
        };
        pieChart.SetDeferred("custom_minimum_size", new Vector2(200, 200));
        flowContainer1.AddChild(pieChart);

        var flowContainer2 = new HFlowContainer
        {
            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ExpandFill
        };
        vBoxContainer.AddChild(flowContainer2);

        pieChart = new PieChart
        {
            Series = viewModel.Series11,
            InitialRotation = viewModel.InitialRotation11,
            MaxAngle = viewModel.MaxAngle11,
            MaxValue = viewModel.GaugeTotal11,
        };
        pieChart.SetDeferred("custom_minimum_size", new Vector2(400, 400));
        flowContainer2.AddChild(pieChart);

        pieChart = new PieChart
        {
            Series = viewModel.Series12,
            InitialRotation = viewModel.InitialRotation12,
            MaxAngle = viewModel.MaxAngle12,
            MaxValue = viewModel.GaugeTotal12,
        };
        pieChart.SetDeferred("custom_minimum_size", new Vector2(400, 400));
        flowContainer2.AddChild(pieChart);

        pieChart = new PieChart
        {
            Series = viewModel.Series13,
            InitialRotation = viewModel.InitialRotation13,
            MaxAngle = viewModel.MaxAngle13,
            MaxValue = viewModel.GaugeTotal13,
        };
        pieChart.SetDeferred("custom_minimum_size", new Vector2(400, 400));
        flowContainer2.AddChild(pieChart);

        pieChart = new PieChart
        {
            Series = viewModel.Series14,
            InitialRotation = viewModel.InitialRotation14,
            MaxAngle = viewModel.MaxAngle14,
            MaxValue = viewModel.GaugeTotal14,
        };
        pieChart.SetDeferred("custom_minimum_size", new Vector2(400, 400));
        flowContainer2.AddChild(pieChart);
    }
}
