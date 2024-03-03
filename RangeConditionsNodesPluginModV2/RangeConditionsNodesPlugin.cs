using Warudo.Core.Attributes;
using Warudo.Core.Plugins;
using Warudo.Plugins.RangeConditionsNodes.Nodes;

namespace Warudo.Plugins.RangeConditionsNodes {

    [PluginType(
        Id = "hanekit.RangeConditionsNodesPlugin",
        Name = "RANGE_CONDITIONS_NODES_PLUGIN_NAME",
        Description = "RANGE_CONDITIONS_NODES_PLUGIN_DESCRIPTION",
        Author = "hanekit",
        Version = "1.1.0",
        NodeTypes = new[] {
            typeof(FloatRangeConditionsToBooleanNode),
            typeof(FloatRangeConditionsToIntegerNode),
            typeof(FloatRangeConditionsToStringNode),
        }
    )]
    public class RangeConditionsNodesPlugin : Plugin { }

}
