using UnityEngine;
using Warudo.Core;
using Warudo.Core.Attributes;
using Warudo.Plugins.Core.Assets;
using Warudo.Plugins.Core.Assets.Mixins;

namespace Warudo.Plugins.RotatingAnchorAssetNamespace.Assets {

    [AssetType(
         Id = "hanekit-97014cb2-e185-480b-a114-955b2aff975e",
         Title = "ROTATING_ANCHOR",
         Category = "SPECIAL_ANCHOR")]
    public class RotatingAnchorAsset : GameObjectAsset {

        [DataInput]
        [Label("BASIC_ROTATION")]
        public Vector3 BasicRotation = new Vector3(0, 0, 0);

        [Section("SELF_ROTATION")]

        [DataInput]
        [Label("ENABLE_ROTATION")]
        public bool EnableRotation = false;

        [DataInput]
        [Label("ROTATE_AXIS")]
        public Vector3 RotateAxis = new Vector3(0, 1, 0);

        [Trigger]
        [Label("SET_TO_X_AXIS")]
        public void SetToXAxis() {
            RotateAxis = new Vector3(1, 0, 0);
            BroadcastDataInput(nameof(RotateAxis));
            ResetRotation();
        }

        [Trigger]
        [Label("SET_TO_Y_AXIS")]
        public void SetToYAxis() {
            RotateAxis = new Vector3(0, 1, 0);
            BroadcastDataInput(nameof(RotateAxis));
            ResetRotation();
        }

        [Trigger]
        [Label("SET_TO_Z_AXIS")]
        public void SetToZAxis() {
            RotateAxis = new Vector3(0, 0, 1);
            BroadcastDataInput(nameof(RotateAxis));
            ResetRotation();
        }

        [DataInput]
        [FloatSlider(-1440, 1440)]
        [Label("ROTATE_SPEED")]
        public float Speed = 360;

        [Mixin]
        public Attachable Attachable;

        private void ResetRotation() {
            Transform.Rotation = BasicRotation;
            BroadcastDataInput(nameof(Transform));
        }

        protected override void OnCreate() {
            base.OnCreate();
            // Transform.HideScale = true;
            Watch("BasicRotation", ResetRotation);
            Watch("RotateAxis", ResetRotation);
            Watch("EnableRotation", ResetRotation);
        }

        protected override GameObject CreateGameObject() {
            GameObject gameObject = new GameObject("Anchor " + base.Name);
            Attachable.Initialize(gameObject);
            return gameObject;
        }

        public override void OnUpdate() {
            base.OnUpdate();
            if (EnableRotation) {
                float Angle = Speed * Time.deltaTime;
                Transform.RotationQuaternion *= Quaternion.AngleAxis(Angle, RotateAxis);
                // Transform.HideScale = true;
                BroadcastDataInput(nameof(Transform));
            }
        }

    }

}
