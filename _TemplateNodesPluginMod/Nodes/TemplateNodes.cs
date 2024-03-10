using Warudo.Core.Attributes;
using Warudo.Core.Graphs;
using Warudo.Core.Data;

namespace Warudo.Plugins.TemplateNodes.Nodes {

    [NodeType(
        Id = "hanekit-GUID",
        Title = "TEMPLATE_NODE_TITLE",
        Category = "TEMPLATE")]
    public class TemplateNode : Node {

        /* DATA OUTPUTS */
        [DataOutput]
        [Label("OUTPUT")]
        public int Output() {
            return 0;
        }

    }

}
