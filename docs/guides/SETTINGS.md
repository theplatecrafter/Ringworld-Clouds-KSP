# Cloud settings

With Ringworld Clouds installed, **Settings ? Ringworld extensions ? Ringworld Clouds** enables local cloud volumes. Apply settings, then save the game to retain the choice. Each ring stores its own switch. Disabling volumes keeps the base mod's lightweight clouds and weather; set cloud amount to zero to remove clouds altogether.

| Cloud mode | Features |
| --- | --- |
| Layers only | Base lightweight local and full-ring cloud layers, no cloud ray marching |
| Economy | Shaped low clouds and storm towers, depth-clipped volumes and self-shadowing |
| Balanced | Economy plus fine erosion, upper cloud layers and additional scattered light |
| Detailed | Balanced plus curl distortion and another scattered-light approximation |

Slow and lower presets select Layers only. Mid selects Economy, Good/Strong select Balanced, and Beefy through Absolute Cow select Detailed. Cloud step count, range and render resolution determine rendering cost. Presets preserve the extension switch; photo mode can use a temporary preset.

The shared Ringworld weather field controls coverage, cloud-family blending and precipitation. Billows use generated fBm/Worley shape noise, with erosion and irregular edges. Universal-time wind and upward motion continue during time warp; night follows the shadow panels. Far clouds remain a cheaper layer with coverage and distance blending, not full-volume rendering across the entire ring. Very large cloud ranges therefore do not provide unlimited detail at a fixed rendering cost.

## Cloud types

`GameData/RingworldClouds/CloudTypes.cfg` defines ten families: stratocumulus, cumulus, cumulonimbus, cirrus, cirrostratus, altocumulus, nimbostratus, stratus, altostratus and cirrocumulus. The weather selects and blends families rather than rendering every type equally at all times.

Altitudes are metres above the mean ring floor. `shape0` through `shape3` define coverage at normalized heights 0, 1/3, 2/3 and 1. Other values control density, erosion, powder lighting, ambient fill and curl. Restart KSP after editing configs. Invalid values fall back to defaults, and shader-stability bounds still apply. Adding an arbitrary new family requires renderer changes; the supported names are fixed.

## Limits and related features

This is original Ringworld rendering inspired by EVE's public feature descriptions. It is not EVE Redux or Volumetric Clouds V5 and does not require either. There is no claim of visual or feature parity. Planetary EVE configs cannot configure this cylindrical renderer.

Rain, snow, lightning and the weather simulation belong to the base mod. This extension supplies cloud volumes; Ringworld Scattering separately supplies enhanced water and distant atmosphere. Ground/object cloud shadows, wet surfaces, windshield droplets, temporal reprojection and light-volume caching remain future work.

For known interoperability limits, see the base mod's [integration matrix](https://github.com/theplatecrafter/Ring-World-KSP-mod/blob/main/docs/developers/VISUAL-INTEGRATIONS.md).
