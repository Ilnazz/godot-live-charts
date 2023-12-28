using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.General.UserDefinedTypes;

namespace Samples.General.UserDefinedTypes;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new CartesianChart
        {
            Series = viewModel.Series
        });
    }
}
