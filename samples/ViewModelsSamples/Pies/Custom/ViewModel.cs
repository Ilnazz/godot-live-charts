﻿using System.Collections.Generic;
using LiveChartsCore;
using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System;
using LiveChartsCore.SkiaSharpView.Extensions;

namespace ViewModelsSamples.Pies.Custom;

public partial class ViewModel : ObservableObject
{
    public ViewModel()
    {
        var outer = 0;
        var data = new[] { 6, 5, 4, 3 };

        // you can convert any array, list or IEnumerable<T> to a pie series collection:
        Series = data.AsPieSeries((value, series) =>
        {
            // this method is called once per element in the array, so:

            // for the series with the value 6, we set the OuterRadiusOffset to 0
            // for the series with the value 5, the OuterRadiusOffset is 50
            // for the series with the value 4, the OuterRadiusOffset is 100
            // for the series with the value 3, the OuterRadiusOffset is 150

            series.OuterRadiusOffset = outer;
            outer += 50;

            series.DataLabelsPaint = new SolidColorPaint(SKColors.White)
            {
                SKTypeface = SKTypeface.FromFamilyName("Arial", SKFontStyle.Bold)
            };

            series.ToolTipLabelFormatter =
                point =>
                {
                    var pv = point.Coordinate.PrimaryValue;
                    var sv = point.StackedValue!;

                    var a = $"{pv}/{sv.Total}{Environment.NewLine}{sv.Share:P2}";
                    return a;
                };

            series.DataLabelsFormatter =
                point =>
                {
                    var pv = point.Coordinate.PrimaryValue;
                    var sv = point.StackedValue!;

                    var a = $"{pv}/{sv.Total}{Environment.NewLine}{sv.Share:P2}";
                    return a;
                };
        });
    }

    public IEnumerable<ISeries> Series { get; set; }
}
