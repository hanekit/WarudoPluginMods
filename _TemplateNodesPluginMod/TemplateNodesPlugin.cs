using Warudo.Core.Attributes;
using Warudo.Core.Plugins;
using Warudo.Plugins.TemplateNodes.Nodes;

namespace Warudo.Plugins.TemplateNodes {

    [PluginType(
        Id = "hanekit.TemplateNodesPlugin",
        Name = "[TEMPLATE]_NODES_PLUGIN_NAME",
        Description = "[TEMPLATE]_NODES_PLUGIN_DESCRIPTION",
        Author = "hanekit",
        Version = "1.0.0",
        NodeTypes = new[] {
            typeof(TemplateNode),
        }
    )]
    public class TemplateNodesPlugin : Plugin { }

}
