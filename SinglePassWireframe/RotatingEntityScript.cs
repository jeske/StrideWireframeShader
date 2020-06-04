using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;

namespace SinglePassWireframe
{
    public class RotatingEntityScript : SyncScript
    {
        public Vector3 RotationSpeed = new Vector3(1.0f, 2.0f, 1.5f);

        public float RotationSpeedMul = 0.5f;

        public override void Start()
        {
            base.Start();
        }

        public override void Update()
        {
            float deltaTime = (float)Game.UpdateTime.Elapsed.TotalSeconds;
            Vector3 deltaRotation = RotationSpeed * RotationSpeedMul * deltaTime;
            Entity.Transform.Rotation *= Quaternion.RotationYawPitchRoll(deltaRotation.X, deltaRotation.Y, deltaRotation.Z);
        }
    }
}
