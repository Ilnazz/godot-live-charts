using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Pies.OutLabels;

namespace Samples.Pies.OutLabels;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        AddChild(new PieChart
        {
            Series = viewModel.Series,
            IsClockwise = false,
            InitialRotation = -90
        });
    }
}
