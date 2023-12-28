using System;
using Godot;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.General.Tooltips;

namespace Samples.General.Tooltips;

public partial class View : VBoxViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        var cartesianChart = new CartesianChart
        {
            Series = viewModel.Series,
            LegendPosition = LegendPosition.Left,
            TooltipPosition = TooltipPosition.Hidden
        };

        var tooltipPositionOptionButton = new OptionButton();
        tooltipPositionOptionButton.ItemSelected += index => cartesianChart.TooltipPosition = (TooltipPosition)index;
        AddChild(tooltipPositionOptionButton);

        foreach (var tooltipPosition in Enum.GetNames(typeof(TooltipPosition)))
            tooltipPositionOptionButton.AddItem(tooltipPosition);
        tooltipPositionOptionButton.Selected = 0;

        AddChild(cartesianChart);
    }
}
