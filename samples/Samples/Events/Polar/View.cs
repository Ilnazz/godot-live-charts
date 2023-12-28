using System.Collections.Generic;
using System.Diagnostics;
using LiveChartsCore.Kernel;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Events.Polar;

namespace Samples.Events.Polar;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        var polarChart = new PolarChart
        {
            Series = viewModel.Series,
            DataPointerDownCommand = viewModel.DataPointerDownCommand
        };
        polarChart.DataPointerDown += Chart_DataPointerDown;

        AddChild(polarChart);
    }

    private void Chart_DataPointerDown(IChartView chart, IEnumerable<ChartPoint> points)
    {
        // notice in the chart event we are not able to use strongly typed points
        // but we can cast the point.Context.DataSource to the actual type.

        foreach (var point in points)
        {
            if (point.Context.DataSource is City city)
            {
                Trace.WriteLine($"[chart.dataPointerDownEvent] clicked on {city.Name}");
                continue;
            }

            if (point.Context.DataSource is int integer)
            {
                Trace.WriteLine($"[chart.dataPointerDownEvent] clicked on number {integer}");
                continue;
            }

            // handle more possible types here...
            // if (point.Context.DataSource is Foo foo)
            // {
            //     ...
            // }
        }
    }
}
