using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;

[NodeType(
     Id = "FloatSlider",
     Title = "Float Slider",
     Category = "Slider")]
public class FloatSliderNode : Node {

    /* DATA INPUTS */
    [DataInput]
    [Label("A")]
    public float a = 0f;

    [DataInput]
    [Label("B")]
    public float b = 1f;

    [DataInput]
    [FloatSlider(0, 1)]
    [Label("A <--------> B")]
    public float k = 0.5f;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("OUTPUT_FLOAT")]
    public float OutputFloat() {
        return (1 - k) * a + k * b;
    }

    [Markdown]
    public string Info = "";

    public override void OnUpdate() {
        Info = "Output: " + OutputFloat().ToString();
        BroadcastDataInput(nameof(Info));
    }

}

[NodeType(
     Id = "IntegerSlider",
     Title = "Integer Slider",
     Category = "Slider")]
public class IntegerSliderNode : Node {

    /* DATA INPUTS */
    [DataInput]
    [Label("A")]
    public int a = 0;

    [DataInput]
    [Label("B")]
    public int b = 10;

    [DataInput]
    [FloatSlider(0, 1)]
    [Label("A <--------> B")]
    public float k = 0.5f;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("OUTPUT_INTEGER")]
    public int OutputInt() {
        var result = (1 - k) * a + k * b;
        return (int)result;
    }

    [Markdown]
    public string Info = "";

    public override void OnUpdate() {
        Info = "Output: " + OutputInt().ToString();
        BroadcastDataInput(nameof(Info));
    }

}

[NodeType(
    Id = "Vector3Slider",
    Title = "Vector3 Lerp Slider",
    Category = "Slider")]
public class Vector3LerpSliderNode : Node {

    /* DATA INPUTS */
    [DataInput]
    [Label("A")]
    public Vector3 a = Vector3.zero;

    [DataInput]
    [Label("B")]
    public Vector3 b = Vector3.one;

    [DataInput]
    [FloatSlider(0, 1)]
    [Label("A <--------> B")]
    public float k = 0.5f;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("OUTPUT_VECTOR3")]
    public Vector3 OutputVector3() {
        return Vector3.Lerp(a, b, k);
    }

    [Markdown]
    public string Info = "";

    public override void OnUpdate() {
        Info = "Output:  \n" + OutputVector3().ToString();
        BroadcastDataInput(nameof(Info));
    }

}

[NodeType(
    Id = "QuaternionSlider",
    Title = "Quaternion Lerp Slider",
    Category = "Slider")]
public class QuaternionLerpSliderNode : Node {

    /* DATA INPUTS */
    [DataInput]
    [Label("A")]
    public Quaternion a = Quaternion.identity;

    [DataInput]
    [Label("B")]
    public Quaternion b = Quaternion.Euler(-180, 0, 0);

    [DataInput]
    [FloatSlider(0, 1)]
    [Label("A <--------> B")]
    public float k = 0.5f;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("OUTPUT_QUATERNION")]
    public Quaternion OutputQuaternion() {
        Quaternion normalizedA = Quaternion.Normalize(a);
        Quaternion normalizedB = Quaternion.Normalize(b);
        return Quaternion.Slerp(normalizedA, normalizedB, k);
    }

    [Markdown]
    public string Info = "";

    public override void OnUpdate() {
        Info = "Output:  \n" + OutputQuaternion().ToString();
        BroadcastDataInput(nameof(Info));
    }

}