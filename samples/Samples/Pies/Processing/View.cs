using Godot;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Pies.Processing;
using SkiaSharp.Views.Godot;

namespace Samples.Pies.Processing;

public partial class View : ViewBase
{
	public View()
	{
		var viewModel = new ViewModel();

		var hBoxContainer = new HBoxContainer
		{
			LayoutMode = 1,
			AnchorsPreset = (int)LayoutPreset.FullRect
		};
		AddChild(hBoxContainer);

		var labels = new VBoxContainer
		{
			SizeFlagsHorizontal = SizeFlags.ShrinkCenter,
			SizeFlagsVertical = SizeFlags.ShrinkCenter
		};

		var label1 = new Label();
		labels.AddChild(label1);

		var label2 = new Label();
		labels.AddChild(label2);

		var label3 = new Label();
		labels.AddChild(label3);

		var pieChart = new PieChart
		{
			Series = viewModel.Series,
			SizeFlagsStretchRatio = 3
		};
		pieChart.UpdateStarted += _ =>
		{
			var series = (PieSeries<ObservableValue>)viewModel.Series[0];
			var values = (ObservableValue[])series.Values;
			label1.Text = values[0].Value + " " + series.Name;
			label1.SelfModulate = GetForeColor(series);

			series = (PieSeries<ObservableValue>)viewModel.Series[1];
			values = (ObservableValue[])series.Values;
			label2.Text = values[0].Value + " " + series.Name;
			label2.SelfModulate = GetForeColor(series);

			series = (PieSeries<ObservableValue>)viewModel.Series[2];
			values = (ObservableValue[])series.Values;
			label3.Text = values[0].Value + " " + series.Name;
			label3.SelfModulate = GetForeColor(series);
		};

		hBoxContainer.AddChild(pieChart);
		hBoxContainer.AddChild(labels);
	}

	private static Color GetForeColor(PieSeries<ObservableValue> pieSeries)
	{
		return pieSeries.Fill is not SolidColorPaint solidColorBrush
			? new Color()
			: solidColorBrush.Color.ToGDColor();
	}
}
