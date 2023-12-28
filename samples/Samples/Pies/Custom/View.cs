using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Pies.Custom;

namespace Samples.Pies.Custom;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new PieChart
        {
            Series = viewModel.Series,
            InitialRotation = -90
        });
    }
}
