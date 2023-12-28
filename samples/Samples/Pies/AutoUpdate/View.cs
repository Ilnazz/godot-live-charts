using System.Threading.Tasks;
using Godot;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Pies.AutoUpdate;

namespace Samples.Pies.AutoUpdate;

public partial class View : VBoxViewBase
{
    private readonly ViewModel _viewModel;
    private bool _isStreaming = false;

    public View()
    {
        _viewModel = new ViewModel();

        var buttonsBox = new HBoxContainer();
        AddChild(buttonsBox);

        var addSeriesButton = new Button { Text = "Add series" };
        addSeriesButton.Pressed += _viewModel.AddSeries;
        buttonsBox.AddChild(addSeriesButton);

        var removeSeriesButton = new Button { Text = "Remove series" };
        removeSeriesButton.Pressed += _viewModel.RemoveSeries;
        buttonsBox.AddChild(removeSeriesButton);

        var updateAllButton = new Button { Text = "Update all" };
        updateAllButton.Pressed += _viewModel.UpdateAll;
        buttonsBox.AddChild(updateAllButton);

        var constantChangesButton = new Button { Text = "Constant changes" };
        constantChangesButton.Pressed += OnConstantChangesClick;
        buttonsBox.AddChild(constantChangesButton);

        AddChild(new PieChart
        {
            Series = _viewModel.Series
        });
    }

    private async void OnConstantChangesClick()
    {
        _isStreaming = !_isStreaming;

        while (_isStreaming)
        {
            _viewModel.RemoveSeries();
            _viewModel.AddSeries();
            await Task.Delay(1000);
        }
    }
}
