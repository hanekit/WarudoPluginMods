using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;
using Warudo.Core.Plugins;

[PluginType(
    Id = "hanekit.MovingAveragePlugin",
    Name = "MOVING_AVERAGE_PLUGIN_NAME",
    Description = "MOVING_AVERAGE_PLUGIN_DESCRIPTION",
    Author = "hanekit",
    Version = "1.0.0",
    NodeTypes = new[] { typeof(FloatMovingAverageNode), typeof(Vector3MovingAverageNode) }
)]
public class MovingAveragePlugin : Plugin { }
