using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;


[NodeType(
    Id = "hanekit-35001bf6-f8f4-42e0-b18a-dfe8bced79cc",
    Title = "Vector3 List Offset Vector3",
    Category = "Hanekit Beta Tools")]
public class Vector3ListOffsetVector3Node : Node {

    /* DATA INPUTS */
    [DataInput]
    [Label("VECTOR3_LIST")]
    public Vector3[] vector3List;

    [DataInput]
    [Label("Offset factor")]
    public Vector3 factor = Vector3.one;

    [DataInput]
    [Label("OFFSET")]
    public Vector3 offset;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("VECTOR3_LIST")]
    public Vector3[] OutputVector3List() {
        Vector3[] newVector3List = new Vector3[vector3List.Length];
        var factorOffset = Vector3.Scale(factor, offset);

        for (int i = 0; i < vector3List.Length; i++)
        {
            newVector3List[i] = vector3List[i] + factorOffset;
        }

        return newVector3List;
    }

}
