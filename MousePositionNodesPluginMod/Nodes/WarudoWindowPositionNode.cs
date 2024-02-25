using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;


[NodeType(
    Id = "hanekit-eaf572f3-b6bb-4901-a3f2-b3a06dfa74fc",
    Title = "WARUDO_WINDOW_POSITION",
    Category = "MOUSE_POSITION_NODES_NODE_CATEGORY")]
public class WarudoWindowPositionNode : Node {

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("Pixel X")]
    public int WarudoWindowPositionX() {
        return Screen.mainWindowPosition.x; 
    }

    [DataOutput]
    [Label("Pixel Y")]
    public int WarudoWindowPositionY() {
        return Screen.mainWindowPosition.y; 
    }

    [Markdown]
    public string Info = @"
---
|         |        |    |        |
|:-------:|:------:|:--:|:------:|
|         | (0, 0) | ━━ | (x, 0) |
| Pixel : |   ┃    |    |   ┃    |
|         | (0, y) | ━━ | (x, y) |
---
";
}
