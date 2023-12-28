using System.Threading.Tasks;
using Godot;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.StepLines.AutoUpdate;

namespace Samples.StepLines.AutoUpdate;

public partial class View : VBoxViewBase
{
    private readonly ViewModel _viewModel;
    private bool _isStreaming;

    public View()
    {
        _viewModel = new ViewModel();

        var buttonsBox = new HBoxContainer();
        AddChild(buttonsBox);

        var addItemButton = new Button { Text = "Add item" };
        addItemButton.Pressed += _viewModel.AddItem;
        buttonsBox.AddChild(addItemButton);

        var removeItemButton = new Button { Text = "Remove item" };
        removeItemButton.Pressed += _viewModel.RemoveItem;
        buttonsBox.AddChild(removeItemButton);

        var updateItemButton = new Button { Text = "Update item" };
        updateItemButton.Pressed += _viewModel.UpdateItem;
        buttonsBox.AddChild(updateItemButton);

        var replaceItemButton = new Button { Text = "Replace item" };
        replaceItemButton.Pressed += _viewModel.ReplaceItem;
        buttonsBox.AddChild(replaceItemButton);

        var addSeriesButton = new Button { Text = "Add series" };
        addSeriesButton.Pressed += _viewModel.AddSeries;
        buttonsBox.AddChild(addSeriesButton);

        var removeSeriesButton = new Button { Text = "Remove series" };
        removeSeriesButton.Pressed += _viewModel.RemoveSeries;
        buttonsBox.AddChild(removeSeriesButton);

        var constantChangesButton = new Button { Text = "Constant changes" };
        constantChangesButton.Pressed += OnConstantChanges;
        buttonsBox.AddChild(constantChangesButton);

        AddChild(new CartesianChart
        {
            Series = _viewModel.Series
        });
    }

    private async void OnConstantChanges()
    {
        _isStreaming = !_isStreaming;

        while (_isStreaming)
        {
            _viewModel.RemoveItem();
            _viewModel.AddItem();
            await Task.Delay(1000);
        }
    }
}
