using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;


[NodeType(
    Id = "hanekit-dcf40b15-0479-4745-96c7-c74d969af418",
    Title = "Audio Frequency Interpolation",
    Category = "Hanekit Beta Tools")]
public class AudioFrequencyInterpolationNode : Node {

    /* FUNCTIONS */
    public float CalculateY(float x)
    {
        float x1 = 0;
        float y1 = In0;
        float x2 = 50;
        float y2 = In50;
        float x3 = 100;
        float y3 = In100;
        float a, b, c;

        // 计算系数
        b = ((x2*x2-x3*x3)*(y1-y2)-(x1*x1-x2*x2)*(y2-y3)) / ((x2*x2-x3*x3)*(x1-x2)-(x1*x1-x2*x2)*(x2-x3));
        a = ((y1 - y2) - b * (x1 - x2)) / (x1 * x1 - x2 * x2);
        c = y1 - a * x1 * x1 - b * x1;

        return a*x*x + b*x + c;
    }

    /* DATA INPUTS */
    [DataInput]
    [Label("LOW_PASS")]
    public float In0;

    [DataInput]
    [Label("BAND_PASS")]
    public float In50;

    [DataInput]
    [Label("HIGH_PASS")]
    public float In100;

    [DataInput]
    [Label("SCALE")]
    [FloatSlider(0, 2)]
    public float Scale = 1f;

    [DataInput]
    [Label("OFFSET")]
    [FloatSlider(-5, 5)]
    public float Offset = 0f;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("Low")]
    public float Output0() {
        return Offset + Scale * In0;
    }

    [DataOutput]
    [Label("1 / 4")]
    public float Output25() {
        return Offset + Scale * CalculateY(25);
    }

    [DataOutput]
    [Label("Middle")]
    public float Output50() {
        return Offset + Scale * In50;
    }

    [DataOutput]
    [Label("3 / 4")]
    public float Output75() {
        return Offset + Scale * CalculateY(75);
    }

    [DataOutput]
    [Label("High")]
    public float Output100() {
        return Offset + Scale * In100;
    }

}
