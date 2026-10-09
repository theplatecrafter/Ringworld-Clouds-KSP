# Release notes

## Unreleased - manual modpack inclusion

The current local Clouds build is included in the sibling `Ringworld Modpacks` full-size interstellar artifact together with the matching base, Scattering, config and required dependency closure. This combined manual pack is explicitly dependency-inclusive; the standalone Clouds archive remains dependency-free and still requires the base. No external dependency, NetKAN declaration or component version is changed. The pack is an unpublished development snapshot; see its release notes for assembled-pack validation.

## 1.0.1 — October 5, 2026

- Updated release packaging and version reporting. CKAN metadata now lives in the dedicated NetKAN checkout and is not bundled.
- Documents automatic extension activation and the dedicated extension settings panel.
- Requires NivenRingworld >= 1.1.5; recommended with 1.1.7. No new cloud shader effects are introduced by this maintenance release.


## 1.0.0 ? September 30, 2026

Weather-driven cloud volumes, ten configurable cloud families, quality-scaled shape detail, depth clipping, daylight response and a transition to the base distant cloud layer.

This is the first standalone release, extracted from Niven Ringworld's development renderer. Requires **NivenRingworld 1.1.5** and KSP 1.12.5. Harmony is required by the base. Cyla and the other Ringworld extension are optional. Dependencies are installed separately and never bundled.

Extract the ZIP into the KSP root, merging GameData. The base remains usable without this extension. Settings and presets stay in the Ringworld control panel; removing the extension does not remove terrain, water physics or saved vessels.

### Validation and limits

Base-only, each-extension and combined installation tests passed on Windows/Direct3D 11. Full flight scenes used Slow on the development laptop; higher shader modes used small GPU probes. Combined tests passed photo capture/restoration. This is not certification for every GPU or graphics API.

The renderer is original Ringworld code, not an EVE/Scatterer port. See the settings guide for approximations and missing features. CKAN metadata is included in the repository and attached to this release for submission; an attached recipe does not itself establish CKAN availability.
