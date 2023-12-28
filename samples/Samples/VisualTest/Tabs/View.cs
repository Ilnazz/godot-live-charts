using Godot;

namespace Samples.VisualTest.Tabs;

public partial class View : ViewBase
{
    public View()
    {
        var tabContainer = new TabContainer
        {
            LayoutMode = 1,
            AnchorsPreset = (int)LayoutPreset.FullRect
        };
        AddChild(tabContainer);

        var tab1 = new MarginContainer { Name = "Tab 1" };
        tab1.AddChild(new Bars.AutoUpdate.View());
        tabContainer.AddChild(tab1);

        var tab2 = new MarginContainer { Name = "Tab 2" };
        tab2.AddChild(new Lines.AutoUpdate.View());
        tabContainer.AddChild(tab2);

        var tab3 = new MarginContainer { Name = "Tab 3" };
        tab3.AddChild(new Scatter.AutoUpdate.View());
        tabContainer.AddChild(tab3);
    }
}
