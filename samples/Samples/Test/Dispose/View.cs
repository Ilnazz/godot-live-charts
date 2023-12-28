using System.Linq;
using Godot;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Test.Dispose;

namespace Samples.Test.Dispose;

public partial class View : VBoxViewBase
{
    public View()
    {
        var contentControl = new Control
        {
            LayoutMode = 1,
            AnchorsPreset = (int)LayoutPreset.FullRect,

            SizeFlagsHorizontal = SizeFlags.ExpandFill,
            SizeFlagsVertical = SizeFlags.ExpandFill
        };
        contentControl.AddChild(CreateContent());

        var changeContentButton = new Button() { Text = "Change content" };
        changeContentButton.Pressed += () =>
        {
            contentControl.RemoveChild(contentControl.GetChild(0));
            contentControl.AddChild(CreateContent());
        };
        AddChild(changeContentButton);

        AddChild(contentControl);
    }

    private static Control CreateContent()
    {
        var viewModel = new ViewModel();

        var vBoxView = new VBoxViewBase();
        vBoxView.AddChild(new CartesianChart
        {
            Series = viewModel.CartesianSeries
        });
        vBoxView.AddChild(new PieChart
        {
            Series = viewModel.PieSeries
        });
        vBoxView.AddChild(new PolarChart
        {
            Series = viewModel.PolarSeries
        });
        vBoxView.AddChild(new GeoMap
        {
            Series = viewModel.GeoSeries
        });
        return vBoxView;
    }
}
