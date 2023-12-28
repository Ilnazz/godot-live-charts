using System.Collections.Generic;
using System.Diagnostics;
using LiveChartsCore.Kernel;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView.Godot;
using ViewModelsSamples.Events.Pie;

namespace Samples.Events.Pie;

public partial class View : ViewBase
{
    public View()
    {
        var viewModel = new ViewModel();

        var pieChart = new PieChart
        {
            Series = viewModel.Series,
            DataPointerDownCommand = viewModel.DataPointerDownCommand
        };
        pieChart.DataPointerDown += Chart_DataPointerDown;

        AddChild(pieChart);
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

            // handle more possible types here...
            // if (point.Context.DataSource is Foo foo)
            // {
            //     ...
            // }
        }
    }
}
