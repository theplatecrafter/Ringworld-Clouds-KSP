using UnityEngine;
namespace NivenRingworld.Extensions {
 internal sealed class CloudProvider : ICloudProvider {
  public AssetBundle Assets {get{return ExtensionAssets.Acquire();}}
  public Shader AtmosphereShader {get{return ExtensionAssets.Shader("CloudAtmosphere");}}
  public ICloudLayer Create(Material material){return new CloudVolumeController(material,ExtensionAssets.Acquire());}
 }
}
