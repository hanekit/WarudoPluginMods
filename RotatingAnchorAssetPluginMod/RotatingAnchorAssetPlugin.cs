using Warudo.Core.Attributes;
using Warudo.Core.Plugins;
using Warudo.Plugins.RotatingAnchorAssetNamespace.Assets;

namespace Warudo.Plugins.RotatingAnchorAssetNamespace {

    [PluginType(
        Id = "hanekit.RotatingAnchorAssetPlugin",
        Name = "ROTATING_ANCHOR_ASSET_PLUGIN_NAME",
        Description = "ROTATING_ANCHOR_ASSET_PLUGIN_DESCRIPTION",
        Author = "hanekit",
        Version = "1.0.0",
        AssetTypes = new[] {
            typeof(RotatingAnchorAsset),
        }
    )]
    public class RotatingAnchorAssetPlugin : Plugin { }

}
