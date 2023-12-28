using Godot;
using System;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.General.Legends;

namespace Samples.General.Legends;

public partial class View : VBoxViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        var cartesianChart = new CartesianChart
        {
            Series = viewModel.Series,
            LegendPosition = LegendPosition.Hidden
        };

        var legedPositionOptionButton = new OptionButton();
        legedPositionOptionButton.ItemSelected += index => cartesianChart.LegendPosition = (LegendPosition)index;
        AddChild(legedPositionOptionButton);

        foreach (var legendPosition in Enum.GetNames(typeof(LegendPosition)))
            legedPositionOptionButton.AddItem(legendPosition);
        legedPositionOptionButton.Selected = 0;

        AddChild(cartesianChart);
    }
}
