using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;


[NodeType(
    Id = "hanekit-076d758f-22b8-4032-9fa1-56f202241b15",
    Title = "Look Rotation",
    Category = "Hanekit Beta Tools")]
public class LookRotationNode : Node {

    /* DATA INPUTS */
    [DataInput]
    [Label("Forward Direction")]
    public Vector3 forwardDirection = Vector3.forward;

    [DataInput]
    [Label("Upwards Direction")]
    public Vector3 upwardsDirection = Vector3.up;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("QUATERNION")]
    public Quaternion OutputQuaternion() {
        if (forwardDirection == Vector3.zero) {
            return Quaternion.identity;
        }
        else {
            return Quaternion.LookRotation(forwardDirection, upwardsDirection);
        }
    }

    [DataOutput]
    [Label("EULER_ANGLES")]
    public Vector3 OutputVector3() {
        return OutputQuaternion().eulerAngles;
    }

}
