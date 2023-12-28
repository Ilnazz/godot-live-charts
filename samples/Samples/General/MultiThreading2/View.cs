using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.General.MultiThreading2;

namespace Samples.General.MultiThreading2;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel(DeferringHelper.Instance.DeferActionInvocation);

        AddChild(new CartesianChart
        {
            Series = viewModel.Series
        });
    }
}
