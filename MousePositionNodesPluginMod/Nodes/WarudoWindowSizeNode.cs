using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;


[NodeType(
    Id = "hanekit-ba836451-2d4f-4de3-987e-0f71ba29dd21",
    Title = "WARUDO_WINDOW_SIZE",
    Category = "MOUSE_POSITION_NODES_NODE_CATEGORY")]
public class WarudoWindowSizeNode : Node {

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("WIDTH")]
    public int WarudoWindowWidth() {
        return Screen.width;
    }

    [DataOutput]
    [Label("HEIGHT")]
    public int WarudoWindowHeight() {
        return Screen.height;
    }

}
