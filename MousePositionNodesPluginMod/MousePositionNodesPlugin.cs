using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;
using Warudo.Core.Plugins;

[PluginType(
    Id = "hanekit.MousePositionNodesPlugin",
    Name = "MOUSE_POSITION_NODES_PLUGIN_NAME",
    Description = "MOUSE_POSITION_NODES_PLUGIN_DESCRIPTION",
    Author = "hanekit",
    Version = "1.0.0",
    NodeTypes = new[] {
        typeof(MousePositionRelativeToScreenNode),
        typeof(MousePositionRelativeToWarudoCenterNode),
        typeof(MousePositionRelativeToWarudoCornerNode),
        typeof(WarudoWindowPositionNode),
        typeof(WarudoWindowSizeNode)
    }
)]
public class MousePositionNodesPlugin : Plugin { }
