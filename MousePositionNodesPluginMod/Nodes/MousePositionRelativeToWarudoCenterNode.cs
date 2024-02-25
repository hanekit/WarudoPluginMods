using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;


[NodeType(
    Id = "hanekit-76f664f2-ab58-4408-bcdc-407ac9d98452",
    Title = "MOUSE_POSITION_RELATIVE_TO_WARUDO_CENTER",
    Category = "MOUSE_POSITION_NODES_NODE_CATEGORY")]
public class MousePositionRelativeToWarudoCenterNode : Node {

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("Pixel X")]
    public int MouseX() {
        return (int)(Input.mousePosition.x - Screen.width / 2f);
    }

    [DataOutput]
    [Label("Pixel Y")]
    public int MouseY() {
        return (int)(Input.mousePosition.y - Screen.height / 2f);
    }

    [DataOutput]
    [Label("Ratio X")]
    public float MouseRatioX() {
        return (Input.mousePosition.x - Screen.width / 2f) / Screen.width;
    }

    [DataOutput]
    [Label("Ratio Y")]
    public float MouseRatioY() {
        return (Input.mousePosition.y - Screen.height / 2f) / Screen.height;
    }

    [Markdown]
    public string Info = @"
---
|         |     |     |     |
|:-------:|:---:|:---:|:---:|
|         | ┏━  | +y  | ━┓  |
| Pixel : | -x  |  0  | +x  |
|         | ┗━  | -y  | ━┛  |
---
|         |      |      |      |
|:-------:|:----:|:----:|:----:|
|         |  ┏   | +0.5 |  ┓   |
| Ratio : | -0.5 |  0   | +0.5 |
|         |  ┗   | -0.5 |  ┛   |
---
";

}

