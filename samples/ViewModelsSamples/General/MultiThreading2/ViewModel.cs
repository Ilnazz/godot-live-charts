﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace ViewModelsSamples.General.MultiThreading2;

public partial class ViewModel : ObservableObject
{
    private readonly Random _r = new();
    private readonly int _delay = 100;
    private readonly ObservableCollection<int> _values;
    private static int s_current;
    private readonly Action<Action> _uiThreadInvoker;

    public ViewModel(Action<Action> uiThreadInvoker)
    {
        // lets create some initial data. // mark
        var items = new List<int>();
        for (var i = 0; i < 1500; i++)
        {
            s_current += _r.Next(-9, 10);
            items.Add(s_current);
        }

        _values = new ObservableCollection<int>(items);

        // create a series with the data // mark
        Series = new ISeries[]
        {
            new LineSeries<int>
            {
                Values = _values,
                GeometryFill = null,
                GeometryStroke = null,
                LineSmoothness = 0,
                Stroke = new SolidColorPaint(SKColors.Blue, 1)
            }
        };

        // There are simplier ways to do this, but since we are using a MVVM pattern, // mark
        // we need to inject a delegate that will run an action in the UI thread. // mark
        _uiThreadInvoker = uiThreadInvoker;
        _delay = 1;
        var readTasks = 10;

        // Finally, we need to start the tasks that will add points to the series. // mark
        // we are creating {readTasks} tasks // mark
        // that will add a point every {_delay} milliseconds // mark
        for (var i = 0; i < readTasks; i++)
        {
            _ = Task.Run(ReadData);
        }
    }

    public ISeries[] Series { get; set; }

    public bool IsReading { get; set; } = true;

    public async Task ReadData()
    {
        await Task.Delay(1000);

        // to keep this sample simple, we run the next infinite loop // mark
        // in a real application you should stop the loop/task when the view is disposed // mark

        while (IsReading)
        {
            await Task.Delay(_delay);

            // force the change to happen in the UI thread. // mark
            _uiThreadInvoker(() =>
            {
                s_current += _r.Next(-9, 10);
                _values.Add(s_current);
                _values.RemoveAt(0);
            });
        }
    }
}
