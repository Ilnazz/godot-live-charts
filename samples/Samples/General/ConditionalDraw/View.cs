using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.General.ConditionalDraw;

namespace Samples.General.ConditionalDraw;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            Sections = viewModel.Sections,
            YAxes = viewModel.Y
        });
    }
}
