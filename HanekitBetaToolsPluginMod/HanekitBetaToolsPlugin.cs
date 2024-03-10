using Warudo.Core.Attributes;
using Warudo.Core.Plugins;

namespace Warudo.Plugins.HanekitBetaTools {

    [PluginType(
        Id = "hanekit.HanekitBetaToolsPlugin",
        Name = "Hanekit Beta Tools Plugin",
        Description = "Hanekit Beta Tools.",
        Author = "hanekit",
        Version = "2024.03.08",
        NodeTypes = new[] {
            typeof(AudioFrequencyInterpolationNode),
            typeof(CharacterBonePositionWeightedAverageNode),
            typeof(LookRotationNode),
            typeof(QuaternionMultiplyNode),
            typeof(Vector3ListOffsetVector3Node),
        }
    )]
    public class HanekitBetaToolsPlugin : Plugin { }

}
