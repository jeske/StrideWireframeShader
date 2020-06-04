using Stride.Core;
using Stride.Core.Annotations;
using Stride.Core.Mathematics;
using Stride.Engine;

namespace SinglePassWireframe
{
    /// <summary>
    /// Enables wireframe over mesh (SinglePassWireframeRenderFeature must be enabled in Graphics Compositor)
    /// </summary>
    public class WireframeScript : SyncScript
    {
        /// <summary>
        /// Enables or disables wireframe over mesh
        /// </summary>
        [DataMember(10)]
        public bool Enabled = true;

        /// <summary>
        /// Width of wireframe lines
        /// </summary>
        [DataMember(20)]
        [DataMemberRange(0.0, 10.0, 0.01f, 1.0f, 2)]
        public float LineWidth = 1.0f;

        /// <summary>
        /// Color of wireframe lines
        /// </summary>
        [DataMember(30)]
        public Color3 Color = new Color3(1.0f, 1.0f, 0.25f);

        public override void Update() { }
    }
}
