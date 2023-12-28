@tool
extends EditorPlugin


func _enter_tree():
    add_custom_type("CartesianChart", "Panel", preload("CartesianChart.cs"), null)
    add_custom_type("GeoMap", "Panel", preload("GeoMap.cs"), null)
    add_custom_type("PieChart", "Panel", preload("PieChart.cs"), null)
    add_custom_type("PolarChart", "Panel", preload("PolarChart.cs"), null)

func _exit_tree():
    remove_custom_type("CartesianChart")
    remove_custom_type("GeoMap")
    remove_custom_type("PieChart")
    remove_custom_type("PolarChart")
