using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;


[NodeType(
    Id = "hanekit-c427abd3-3392-44aa-aff9-374ce9221431",
    Title = "Character Bone Position Weighted Average Node",
    Category = "Hanekit Beta Tools")]
public class CharacterBonePositionWeightedAverageNode : Node {

    /* DATA INPUTS */
    [DataInput]
    [Label("BONE_POSITIONS")]
    public Vector3[] Positions;

    [DataInput]
    [Label("CHARACTER_BONES")]
    public HumanBodyBones[] Bones;

    [DataInput]
    [Label("Weights")]
    public int[] Weights;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("Vector3 Average")]
    public Vector3 OutputPositionWeightedAverageVector3() {
        Vector3 sum = Vector3.zero;
        float totalWeight = 0f;

        for (int i = 0; i < Bones.Length; i++) {
            var boneIndex = (int)Bones[i];
            sum += Positions[boneIndex] * Weights[i];
            totalWeight += Weights[i];
        }

        if (totalWeight == 0)
            return Vector3.zero;;

        return sum / totalWeight;
    }

    [DataOutput]
    [Label("Distance Average")]
    public float OutputPositionWeightedAverageFloat() {
        return OutputPositionWeightedAverageVector3().magnitude;
    }
}
