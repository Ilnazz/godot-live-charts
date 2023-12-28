using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.General.Sections2;

namespace Samples.General.Sections2;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            Sections = viewModel.Sections
        });
    }
}
