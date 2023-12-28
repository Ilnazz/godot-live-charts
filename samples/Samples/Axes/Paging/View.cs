using Godot;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Axes.Paging;

namespace Samples.Axes.Paging;

public partial class View : VBoxViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        var buttonsBox = new HBoxContainer();
        AddChild(buttonsBox);

        var goToPage1Button = new Button { Text = "Go to page 1" };
        goToPage1Button.Pressed += viewModel.GoToPage1;
        buttonsBox.AddChild(goToPage1Button);

        var goToPage2Button = new Button { Text = "Go to page 2" };
        goToPage2Button.Pressed += viewModel.GoToPage2;
        buttonsBox.AddChild(goToPage2Button);

        var goToPage3Button = new Button { Text = "Go to page 3" };
        goToPage3Button.Pressed += viewModel.GoToPage3;
        buttonsBox.AddChild(goToPage3Button);

        var clearButton = new Button { Text = "Clear" };
        clearButton.Pressed += viewModel.SeeAll;
        buttonsBox.AddChild(clearButton);

        AddChild(new CartesianChart
        {
            Series = viewModel.Series,
            XAxes = viewModel.XAxes,
            ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X
        });
    }
}
