using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.General.Scrollable;

namespace Samples.General.Scrollable;

public partial class View : VBoxViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            XAxes = viewModel.ScrollableAxes,
            ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X,
            DrawMargin = viewModel.Margin,
            UpdateStartedCommand = viewModel.ChartUpdatedCommand,
            SizeFlagsStretchRatio = 4
        });
        AddChild(new CartesianChart
        {
            Series = viewModel.ScrollbarSeries,
            DrawMargin = viewModel.Margin,
            Sections = viewModel.Thumbs,
            XAxes = viewModel.InvisibleX,
            YAxes = viewModel.InvisibleY,
            PointerPressedCommand = viewModel.PointerDownCommand,
            PointerMoveCommand = viewModel.PointerMoveCommand,
            PointerReleasedCommand = viewModel.PointerUpCommand,
            TooltipPosition = LiveChartsCore.Measure.TooltipPosition.Hidden
        });
    }
}
