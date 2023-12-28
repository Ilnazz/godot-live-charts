using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Lines.Basic;

namespace Samples.Lines.Basic;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            Title = viewModel.Title
        });
    }
}
