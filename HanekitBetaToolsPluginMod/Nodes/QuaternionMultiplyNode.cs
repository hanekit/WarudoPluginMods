using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;


[NodeType(
    Id = "hanekit-e8578c44-9291-48ee-9d1d-54ee26d240ea",
    Title = "Quaternion Multiply",
    Category = "Hanekit Beta Tools")]
public class QuaternionMultiplyNode : Node {

    /* DATA INPUTS */
    [DataInput]
    [Label("A")]
    public Quaternion quaternionA;

    [DataInput]
    [Label("B")]
    public Quaternion quaternionB;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("Output Quaternion")]
    public Quaternion OutputQuaternion() {
        return quaternionA * quaternionB;
    }

}
