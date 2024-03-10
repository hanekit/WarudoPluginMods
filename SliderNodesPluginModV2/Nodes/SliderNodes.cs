using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;
namespace Warudo.Plugins.SliderNodes {
public abstract class TSliderNode<T> : Node {

    // /* DATA INPUTS */
    // [DataInput]
    // [Label("A")]
    // public T a;

    // [DataInput]
    // [Label("B")]
    // public T b;

    [DataInput]
    [FloatSlider(0, 1)]
    [Label("A <--------> B")]
    public float k = 0.5f;

    // /* DATA OUTPUTS */
    // [DataOutput]
    // [Label("OUTPUT_T")]
    // public T OutputT() {
    //     return (1 - k) * a + k * b;
    // }

    // [Markdown]
    // public string Info = "";

    // public override void OnUpdate() {
    //     Info = "Output: " + OutputT().ToString();
    //     BroadcastDataInput(nameof(Info));
    // }

}

[NodeType(
     Id = "hanekit-3d303b22-109c-4eb7-acc8-9b24549d2297",
     Title = "Float Slider",
     Category = "Slider")]
public class FloatSliderNode : TSliderNode<float> {

    /* DATA INPUTS */
    [DataInput]
    [Label("A")]
    public float a = 0f;

    [DataInput]
    [Label("B")]
    public float b = 1f;

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
     Id = "hanekit-25ccfb90-4f6d-4eea-9051-5c9e9b919668",
     Title = "Integer Slider",
     Category = "Slider")]
public class IntegerSliderNode : TSliderNode<int> {

    /* DATA INPUTS */
    [DataInput]
    [Label("A")]
    public int a = 0;

    [DataInput]
    [Label("B")]
    public int b = 10;

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
    Id = "hanekit-c37b58b2-9567-422a-a947-d2c28e88304a",
    Title = "Vector3 Lerp Slider",
    Category = "Slider")]
public class Vector3LerpSliderNode : TSliderNode<Vector3> {

    /* DATA INPUTS */
    [DataInput]
    [Label("A")]
    public Vector3 a = Vector3.zero;

    [DataInput]
    [Label("B")]
    public Vector3 b = Vector3.one;

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
    Id = "hanekit-f6f98377-7e09-45b9-95dd-bd17da7a17bc",
    Title = "Quaternion Lerp Slider",
    Category = "Slider")]
public class QuaternionLerpSliderNode : TSliderNode<Quaternion> {

    /* DATA INPUTS */
    [DataInput]
    [Label("A")]
    public Quaternion a = Quaternion.identity;

    [DataInput]
    [Label("B")]
    public Quaternion b = Quaternion.Euler(-180, 0, 0);

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
}