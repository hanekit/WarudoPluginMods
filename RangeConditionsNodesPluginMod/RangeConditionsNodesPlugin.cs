using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;
using Warudo.Core.Plugins;


[PluginType(
    Id = "hanekit.RangeConditionsNodesPlugin",
    Name = "RANGE_CONDITIONS_NODES_PLUGIN_NAME",
    Description = "RANGE_CONDITIONS_NODES_PLUGIN_DESCRIPTION",
    Author = "hanekit",
    Version = "1.0.0",
    NodeTypes = new[] {
        typeof(FloatRangeConditionsToIntegerNode),
        typeof(FloatRangeConditionsToStringNode)
    }
)]
public class RangeConditionsNodesPlugin : Plugin { }
