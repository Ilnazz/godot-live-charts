using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Lines.Area;

namespace Samples.Lines.Area;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            DrawMarginFrame = viewModel.DrawMarginFrame
        });
    }
}
