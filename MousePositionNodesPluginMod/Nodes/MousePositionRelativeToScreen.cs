using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;


[NodeType(
    Id = "hanekit-b1f59dd4-8e15-4e16-911d-ac19af203764",
    Title = "MOUSE_POSITION_RELATIVE_TO_SCREEN",
    Category = "MOUSE_POSITION_NODES_NODE_CATEGORY")]
public class MousePositionRelativeToScreenNode : Node {

    /* DATA INPUTS */
    [DataInput]
    [Label("OFFSET_X")]
    public int OffsetX = 0;

    [DataInput]
    [Label("OFFSET_Y")]
    public int OffsetY = 0;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("Pixel X")]
    public int MousePositionX() {
        return Screen.mainWindowPosition.x + (int)Input.mousePosition.x + 2 + OffsetX;
    }

    [DataOutput]
    [Label("Pixel Y")]
    public int MousePositionY() {
        return Screen.mainWindowPosition.y + Screen.height - (int)Input.mousePosition.y + 31 + OffsetY;
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
