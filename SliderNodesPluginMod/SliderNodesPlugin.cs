using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;
using Warudo.Core.Plugins;

[PluginType(
    Id = "hanekit.SliderNodesPlugin",
    Name = "SLIDER_NODES_PLUGIN_NAME",
    Description = "SLIDER_NODES_PLUGIN_DESCRIPTION",
    Author = "hanekit",
    Version = "1.0.0",
    NodeTypes = new[] {
        typeof(FloatSliderNode),
        typeof(IntegerSliderNode),
        typeof(Vector3LerpSliderNode),
        typeof(QuaternionLerpSliderNode),
        typeof(EulerAnglesComponentsSliderNode),
        typeof(QuaternionComponentsSliderNode),
    }
)]
public class SliderNodesPlugin : Plugin { }
