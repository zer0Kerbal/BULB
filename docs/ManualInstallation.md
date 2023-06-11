---
permalink: /ManualInstallation.html
title: Manual Installation
description: the flat-pack Kiea instructions, written in Kerbalese, unusally present
tags: installation,directions,page,kerbal,ksp,zer0Kerbal,zedK
---
<!-- ManualInstallation.md v1.0.0.0
Bright Utilitarian Luminescent Beacon (BULB)
created: 10 Jun 2023
updated: 

TEMPLATE: ManualInstallation.md v1.1.9.1
created: 01 Feb 2022
updated: 26 Apr 2023

based upon work by Lisias -->
## [Bright Utilitarian Luminescent Beacon (BULB)][mod]

[Home](./index.md)

Allows the player to alter light colors in flight through a stock-alike interface on the right click menu.

## Installation Instructions

### Using CurseForge/OverWolf app or CKAN

You should be all good! (check for latest version on CurseForge)

### If Downloaded from CurseForge/OverWolf manual download

To install, place the `Alshain` folder inside your Kerbal Space Program's GameData folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**
  * Delete `<KSP_ROOT>/GameData/Alshain/BULB`
* Extract the package's `Alshain` folder into your KSP's GameData folder as follows:
  * `<PACKAGE>/Alshain` --> `<KSP_ROOT>/GameData`
    * Overwrite any preexisting folder/file(s).
  * you should end up with `<KSP_ROOT>/GameData/Alshain/BULB`

### If Downloaded from SpaceDock / GitHub / other

To install, place the `GameData` folder inside your Kerbal Space Program folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**
  * Delete `<KSP_ROOT>/GameData/Alshain/BULB`
* Extract the package's `GameData` folder into your KSP's root folder as follows:
  * `<PACKAGE>/GameData` --> `<KSP_ROOT>`
    * Overwrite any preexisting folder/file(s).
  * you should end up with `<KSP_ROOT>/GameData/Alshain/BULB`

## The following file layout must be present after installation

```markdown
<KSP_ROOT>
  + [GameData]
    + [Alshain]
      + [AquilaEnterprises]
        + [Agencies]
          ...
        + [Flags]
          ...
        + [Localization]
          ...
        ...
      + [BULB]
        + [Compatibility]
          ...
        + [Config]
          ...
        + [Localization]
          ...
        + [Plugins]
          ...
        * #.#.#.#.htm
        * Attributions.htm
        * BULB.version
        * changelog.md
        * GPL-3.0.txt
        * ManualInstallation.htm
        * readme.htm
      ...
    ...
    * [ModularManagement][MM] or [Module Manager][omm]
    * ModuleManager.ConfigCache
  * KSP.log
  ...
```

### Dependencies

* [ModularManagement][MM] or [Module Manager][omm]

[MM]: https://www.curseforge.com/kerbal/ksp-mods/ModularManagement "ModularManagement (MM)"
[omm]: https://forum.kerbalspaceprogram.com/index.php?/topic/50533-*/ "Module Manager"

THIS FILE: CC BY-ND 4.0 by [zer0Kerbal](https://github.com/zer0Kerbal)
  used with express permission from zer0Kerbal

[mod]: https://www.curseforge.com/kerbal/ksp-mods/BULB "Bright Utilitarian Luminescent Beacon (BULB)"