using Warudo.Core.Attributes;
using Warudo.Core.Plugins;

[PluginType(
    Id = "hanekit.SliderNodesPlugin",
    Name = "SLIDER_NODES_PLUGIN_NAME",
    Description = "SLIDER_NODES_PLUGIN_DESCRIPTION",
    Author = "hanekit",
    Version = "1.1.0",
    NodeTypes = new[] {
        typeof(IntegerSliderNode),
        typeof(FloatSliderNode),
        typeof(Vector3LerpSliderNode),
        typeof(QuaternionLerpSliderNode),
        typeof(Vector3ComponentsSliderNode),
        typeof(EulerAnglesComponentsSliderNode),
        typeof(QuaternionComponentsSliderNode),
    }
)]
public class SliderNodesPlugin : Plugin { }
