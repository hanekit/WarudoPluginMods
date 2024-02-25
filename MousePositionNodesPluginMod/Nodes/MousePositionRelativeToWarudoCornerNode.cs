using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;


[NodeType(
    Id = "hanekit-15402f55-0d83-4f75-8bd5-2a6d1b573ef6",
    Title = "MOUSE_POSITION_RELATIVE_TO_WARUDO_CORNER",
    Category = "MOUSE_POSITION_NODES_NODE_CATEGORY")]
public class MousePositionRelativeToWarudoCornerNode : Node {

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("Pixel X")]
    public int MouseX() {
        return (int)Input.mousePosition.x;
    }

    [DataOutput]
    [Label("Pixel Y")]
    public int MouseY() {
        return (int)Input.mousePosition.y;
    }

    [DataOutput]
    [Label("Ratio X")]
    public float MouseRatioX() {
        return Input.mousePosition.x / Screen.width;
    }

    [DataOutput]
    [Label("Ratio Y")]
    public float MouseRatioY() {
        return Input.mousePosition.y / Screen.height;
    }

    [Markdown]
    public string Info = @"
---
|         |        |    |        |
|:-------:|:------:|:--:|:------:|
|         | (0, y) | ━━ | (x, y) |
| Pixel : |   ┃    |    |   ┃    |
|         | (0, 0) | ━━ | (x, 0) |
---
|         |        |    |        |
|:-------:|:------:|:--:|:------:|
|         | (0, 1) | ━━ | (1, 1) |
| Ratio : |   ┃    |    |   ┃    |
|         | (0, 0) | ━━ | (1, 0) |
---
";

}

