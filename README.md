# The LiveCharts2 for the Godot

As the official web-site says, the LiveCharts2 is a data visualization library for the .Net that can run across multiple devices and frameworks,
It runs under the MIT license (free) and offers a paid package to improve performance and extend features.

The LiveCharts2 web-site: https://livecharts.dev

The LiveCharts2 source code: https://github.com/beto-rodriguez/LiveCharts2

![Lvc for GodotLiveChartsForGodot](https://github.com/Ilnazz/godot-live-charts/assets/24940119/fa332b34-e964-4649-b5a3-7f734f58e792)

### Prerequisites

Because this library is for the .Net platform, you need to make sure that you have created a C# solution as part of your Godot project.

## Installation

1. At this moment to install this library to your project as a plugin, you need download a build of this library for the desired version of .Net (6, 7 or 8) from builds directory and copy the live-charts plugin folder to the addons folder.

2. Install the following NuGet packages:

* [SkiaSharp.HarfBuzz](https://www.nuget.org/packages/SkiaSharp.HarfBuzz)
* [SkiaSharp.Views.Desktop.Common](https://www.nuget.org/packages/SkiaSharp.Views.Desktop.Common)

* or simply add the following package references to your *.csproj file:

```xaml
<ItemGroup>
    <PackageReference Include="SkiaSharp.HarfBuzz" Version="2.88.6" />
    <PackageReference Include="SkiaSharp.Views.Desktop.Common" Version="2.88.6" />
</ItemGroup>
```
 
3. Add the following references to DLL's to your *.csproj file (it is needed because SkiaSharp.Views.Godot and LiveChartsCore.SkiaSharpView.Godot are not official yet):

```xaml
<ItemGroup>
    <Reference Include="LiveChartsCore">
        <HintPath>addons\live_charts\libraries\LiveChartsCore.dll</HintPath>
    </Reference>
    <Reference Include="LiveChartsCore.SkiaSharpView">
        <HintPath>addons\live_charts\libraries\LiveChartsCore.SkiaSharpView.dll</HintPath>
    </Reference>
    <Reference Include="LiveChartsCore.SkiaSharpView.Godot">
        <HintPath>addons\live_charts\libraries\LiveChartsCore.SkiaSharpView.Godot.dll</HintPath>
    </Reference>
    <Reference Include="SkiaSharp.Views.Godot">
        <HintPath>addons\live_charts\libraries\SkiaSharp.Views.Godot.dll</HintPath>
    </Reference>
</ItemGroup>
```

4. Finally, your *.csproj file should look like this:
```xaml
<Project Sdk="Godot.NET.Sdk/4.2.0">
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <TargetFramework Condition=" '$(GodotTargetPlatform)' == 'android' ">net8.0</TargetFramework>
    <TargetFramework Condition=" '$(GodotTargetPlatform)' == 'ios' ">net8.0</TargetFramework>
    <EnableDynamicLoading>true</EnableDynamicLoading>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="CommunityToolkit.Mvvm" Version="8.2.2" />
    <PackageReference Include="SkiaSharp" Version="2.88.6" />
    <PackageReference Include="SkiaSharp.HarfBuzz" Version="2.88.6" />
    <PackageReference Include="SkiaSharp.Views.Desktop.Common" Version="2.88.6" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="LiveChartsCore">
      <HintPath>addons\live_charts\libraries\LiveChartsCore.dll</HintPath>
    </Reference>
    <Reference Include="LiveChartsCore.SkiaSharpView">
      <HintPath>..\New Game Project\addons\live_charts\libraries\LiveChartsCore.SkiaSharpView.dll</HintPath>
    </Reference>
    <Reference Include="LiveChartsCore.SkiaSharpView.Godot">
      <HintPath>addons\live_charts\libraries\LiveChartsCore.SkiaSharpView.Godot.dll</HintPath>
    </Reference>
    <Reference Include="SkiaSharp.Views.Godot">
      <HintPath>addons\live_charts\libraries\SkiaSharp.Views.Godot.dll</HintPath>
    </Reference>
  </ItemGroup>
</Project>
```

5. Rebuild your project and enable live-charts plugin.

## Usage

1. Create a View Model:

```csharp
using System.Collections.Generic;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace NewGameProject;

public class ViewModel
{
    // Create the collection of series to use in chart
    public IEnumerable<ISeries> Series { get; } = new ISeries[]
    {
        new LineSeries<double>
        {
            Values = new double[] { 2, 1, 3, 5, 3, 4, 6 },
            Fill = null
        }
    };
}
```

2. Create a new User Interface scene:

![creating-the-user-scene](https://github.com/Ilnazz/godot-live-charts/assets/24940119/2f2215e8-afd4-4b92-9e95-9b44dd252ea1)

3. Add a CartesianChart to the scene:

![image](https://github.com/Ilnazz/godot-live-charts/assets/24940119/a4ad317d-40a9-4b1f-b7b2-276b2c2955d1)

4. Attach the new script to the newly created scene with the following code:

```csharp
using Godot;
using GodotPlugins.LiveCharts;
using LiveChartsCore.Measure;

namespace NewGameProject;

public partial class Sample : Control
{
    public override void _Ready()
    {
        // Instantiate the view model for the chart
        var viewModel = new ViewModel();

        // Get the chart node
        var cartesianChart = (CartesianChart)FindChild("CartesianChart");

        // Set the chart series from the view model property
        cartesianChart.Series = viewModel.Series;
        
        // Optionally, set chart's legend position
        cartesianChart.LegendPosition = LegendPosition.Right;
    }
}
```

5. Run the scene:

![image](https://github.com/Ilnazz/godot-live-charts/assets/24940119/de7a3db6-4105-437c-ba63-5e3a0dc539a6)

## More samples

You can see all [official LiveCharts2 samples](https://livecharts.dev/docs/wpf/2.0.0-rc2/gallery) adapted to Godot in action in the samples/Samples folder. Just run MainScene.

![Demo](https://github.com/Ilnazz/LiveCharts2_Godot/blob/master/Example.gif)

## Some technical details

LiveCharts2 is designed as a UI-framework independent library. To accomplish this, it uses the feature-rich [SkiaSharp](https://github.com/mono/SkiaSharp) library (which is C# bindings for the Google's [Skia](https://skia.org/) 2D graphics library) as a rendering engine. So, it can be quite easily ported to .Net frameworks/platforms where it is possible to use SkiaSharp. To use SkiaSharp, there are separate so-called [views](https://github.com/mono/SkiaSharp/tree/main/source/SkiaSharp.Views) for different frameworks Just like SkiaSharp, LiveCharts2 provides different [views](https://github.com/beto-rodriguez/LiveCharts2/tree/master/src/skiasharp) for different frameworks.

There was no such SkiaSharp view for Godot, so I created it: [SkiaSharp.Views.Godot](https://github.com/Ilnazz/SkiaSharp.Views.Godot).
After that, I created LiveCharts2 view to Godot: [LiveChartsCore.SkiaSharpView.Godot](https://github.com/Ilnazz/LiveChartsCore.SkiaSharpView.Godot) based on SkiaSharp view for Godot.

Also, there is a technical issue in the current implementation that may require improvement: LiveCharts' types require to invoke a given action in the UI thread. At this moment, this is done by using [DeferringHelper](https://github.com/Ilnazz/LiveChartsCore.SkiaSharpView.Godot/blob/master/src/skiasharp/LiveChartsCore.SkiaSharpView.Godot/DeferringHelper.cs) class. Please create a discussion, if you know how to do it better.
