using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;


[NodeType(
    Id = "hanekit-25ccfb90-4f6d-4eea-9051-5c9e9b919668",
    Title = "Integer Slider",
    Category = "Slider")]
public class IntegerSliderNode : Node {

    /* DATA INPUTS */
    [DataInput]
    [Label("A")]
    public int A = 0;

    [DataInput]
    [Label("B")]
    public int B = 10;

    [DataInput]
    [FloatSlider(0, 1)]
    [Label("A <--------> B")]
    public float K = 0.5f;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("OUTPUT_INTEGER")]
    public int OutputInteger() {
        var result = A + K * (B - A);
        return (int)result;
    }

    /* DATA DISPLAY */
    [Markdown]
    public string Info = "";

    /* LIFECYCLE EVENTS */
    protected override void OnCreate() {
        base.OnCreate();
        Info = "Output: " + OutputInteger().ToString();
        BroadcastDataInput(nameof(Info));
        WatchAll(new[] {
            nameof(A), 
            nameof(B),
            nameof(K),
        }, () => {
            Info = "Output: " + OutputInteger().ToString();
            BroadcastDataInput(nameof(Info));
        });
    }

}

[NodeType(
    Id = "hanekit-3d303b22-109c-4eb7-acc8-9b24549d2297",
    Title = "Float Slider",
    Category = "Slider")]
public class FloatSliderNode : Node {

    /* DATA INPUTS */
    [DataInput]
    [Label("A")]
    public float A = 0f;

    [DataInput]
    [Label("B")]
    public float B = 1f;

    [DataInput]
    [FloatSlider(0, 1)]
    [Label("A <--------> B")]
    public float K = 0.5f;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("OUTPUT_FLOAT")]
    public float OutputFloat() {
        return  A + K * (B - A);
    }

    /* DATA DISPLAY */
    [Markdown]
    public string Info = "";

    /* LIFECYCLE EVENTS */
    protected override void OnCreate() {
        Info = "Output: " + OutputFloat().ToString();
        BroadcastDataInput(nameof(Info));
        base.OnCreate();
        WatchAll(new[] {
            nameof(A), 
            nameof(B),
            nameof(K),
        }, () => {
            Info = "Output: " + OutputFloat().ToString();
            BroadcastDataInput(nameof(Info));
        });
    }

}

[NodeType(
    Id = "hanekit-c37b58b2-9567-422a-a947-d2c28e88304a",
    Title = "Vector3 Lerp Slider",
    Category = "Slider")]
public class Vector3LerpSliderNode : Node {

    /* DATA INPUTS */
    [DataInput]
    [Label("A")]
    public Vector3 A = Vector3.zero;

    [DataInput]
    [Label("B")]
    public Vector3 B = Vector3.one;

    [DataInput]
    [FloatSlider(0, 1)]
    [Label("A <--------> B")]
    public float K = 0.5f;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("OUTPUT_VECTOR3")]
    public Vector3 OutputVector3() {
        return Vector3.Lerp(A, B, K);
    }

    /* DATA DISPLAY */
    [Markdown]
    public string Info = "";

    /* LIFECYCLE EVENTS */
    protected override void OnCreate() {
        base.OnCreate();
        Info = "Output:  \n" + OutputVector3().ToString();
        BroadcastDataInput(nameof(Info));
        WatchAll(new[] {
            nameof(A), 
            nameof(B),
            nameof(K),
        }, () => {
            Info = "Output:  \n" + OutputVector3().ToString();
            BroadcastDataInput(nameof(Info));
        });
    }

}

[NodeType(
    Id = "hanekit-f6f98377-7e09-45b9-95dd-bd17da7a17bc",
    Title = "Quaternion Lerp Slider",
    Category = "Slider")]
public class QuaternionLerpSliderNode : Node {

    /* DATA INPUTS */
    [DataInput]
    [Label("A")]
    public Quaternion A = Quaternion.identity;

    [DataInput]
    [Label("B")]
    public Quaternion B = Quaternion.Euler(-180, 0, 0);

    [DataInput]
    [FloatSlider(0, 1)]
    [Label("A <--------> B")]
    public float K = 0.5f;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("OUTPUT_QUATERNION")]
    public Quaternion OutputQuaternion() {
        Quaternion normalizedA = Quaternion.Normalize(A);
        Quaternion normalizedB = Quaternion.Normalize(B);
        return Quaternion.Slerp(normalizedA, normalizedB, K);
    }

    /* DATA DISPLAY */
    [Markdown]
    public string Info = "";

    /* LIFECYCLE EVENTS */
    protected override void OnCreate() {
        base.OnCreate();
        Info = "Output:  \n" + OutputQuaternion().ToString();
        BroadcastDataInput(nameof(Info));
        WatchAll(new[] {
            nameof(A), 
            nameof(B),
            nameof(K),
        }, () => {
            Info = "Output:  \n" + OutputQuaternion().ToString();
            BroadcastDataInput(nameof(Info));
        });
    }

}
