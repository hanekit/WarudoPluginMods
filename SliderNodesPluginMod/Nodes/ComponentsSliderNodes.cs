using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;

[NodeType(
     Id = "QuaternionComponentsSliderNode",
     Title = "Quaternion Components Slider",
     Category = "Components Slider")]
public class QuaternionComponentsSliderNode : Node {

    /* DATA INPUTS */
    [DataInput]
    [FloatSlider(-1, 1)]
    [Label("X")]
    public float x = 0f;

    [DataInput]
    [FloatSlider(-1, 1)]
    [Label("Y")]
    public float y = 0f;

    [DataInput]
    [FloatSlider(-1, 1)]
    [Label("Z")]
    public float z = 0f;

    [DataInput]
    [FloatSlider(-1, 1)]
    [Label("W")]
    public float w = 1f;

    [DataInput]
    [Label("Normalize")]
    public bool normalize = true;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("OUTPUT_EULER_ANGLES")]
    public Vector3 Output3() {
        return new Quaternion(x, y, z, w).eulerAngles;
    }

    [DataOutput]
    [Label("OUTPUT_QUATERNION")]
    public Quaternion Output1() {
        if (normalize) {
            return new Quaternion(x, y, z, w).normalized;
        } else {
            return new Quaternion(x, y, z, w);
        }
    }

    [Trigger]
    [Label("RESET_DATA")]
    public void Reset() {
        x = 0f;
        y = 0f;
        z = 0f;
        w = 1f;
        BroadcastDataInput(nameof(x));
        BroadcastDataInput(nameof(y));
        BroadcastDataInput(nameof(z));
        BroadcastDataInput(nameof(w));
    }

}

[NodeType(
     Id = "EulerAnglesComponentsSliderNode",
     Title = "Euler Angles Components Slider",
     Category = "Components Slider")]
public class EulerAnglesComponentsSliderNode : Node {

    /* DATA INPUTS */
    [DataInput]
    [FloatSlider(-360, 360)]
    [Label("X")]
    public float x = 0f;

    [DataInput]
    [FloatSlider(-360, 360)]
    [Label("Y")]
    public float y = 0f;

    [DataInput]
    [FloatSlider(-360, 360)]
    [Label("Z")]
    public float z = 0f;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("OUTPUT_EULER_ANGLES")]
    public Vector3 Output3() {
        return new Vector3(x, y, z);
    }

    [DataOutput]
    [Label("OUTPUT_QUATERNION")]
    public Quaternion Output1() {
        Quaternion rotation = Quaternion.Euler(x, y, z);
        return rotation;
    }

    [Trigger]
    [Label("RESET_DATA")]
    public void Reset() {
        x = 0f;
        y = 0f;
        z = 0f;
        BroadcastDataInput(nameof(x));
        BroadcastDataInput(nameof(y));
        BroadcastDataInput(nameof(z));
    }

}