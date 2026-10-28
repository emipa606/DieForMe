# GitHub Copilot Instructions for Die for me (Continued) Mod

## Mod Overview and Purpose

Die for me (Continued) is an update to the Huddicles mod, adding new features and improving existing ones. The mod adds the Dead Mans Switch (DMS), a device that turns pawns into walking, talking bombs. When a pawn with a DMS installed dies, the bomb is set off, creating various explosive effects.

## Key Features and Systems

### Dead Mans Switch (DMS)
- **High Explosive DMS**: Creates a powerful explosion when triggered.
- **Incendiary DMS**: Sets the area on fire when triggered.
- **EMP DMS**: Disrupts electronic devices in the area when triggered.
- **Firefoam DMS**: Creates a large foam area that can suppress fires.
- **Antigrain DMS**: Hypothetical future implementation that is supposed to be highly damaging.

### Kill Switches
- Installed in the brain, these can be set off at any time to control pawns.

### Achievements
- Adds new achievements to the game.

### Future Implementations
- Antigrain Warhead DMS
- Kill switches
- Raiders with explosive implants

## Coding Patterns and Conventions

### C# Files
- **Hediff_AntigrainDeadManSwitch.cs**: Contains the logic for the Antigrain DMS.
- **Hediff_EMPDeadManSwitch.cs**: Contains the logic for the EMP DMS.
- **Hediff_FirefoamDeadManSwitch.cs**: Contains the logic for the Firefoam DMS.
- **Hediff_HighExplosiveDeadManSwitch.cs**: Contains the logic for the High Explosive DMS.
- **Hediff_IncendiaryDeadManSwitch.cs**: Contains the logic for the Incendiary DMS.

Each Hediff class implements the `Notify_PawnDied` method, which is called when the pawn with the DMS dies.

### XML Files
- **DFM_BodyParts.xml**: Contains the definitions for body parts.
- **HediffDefs_DeadManSwitches.xml**: Contains the definitions for the DMS hediffs.
- **Recipe_DMSInstalls.xml**: Contains the recipe definitions for installing DMS.
- **ResearchProjects_DFM.xml**: Contains the research project definitions for DMS.
- **DMSCategories.xml**: Contains the definitions for thing categories related to DMS.

## XML Integration

The mod integrates with RimWorld's XML system to define new hediffs, recipes, research projects, and body parts. Each XML file contains a series of `<Def>` elements that define the properties of the respective game elements.

### Example XML Snippet
xml
<Def>
  <defName>Hediff_AntigrainDeadManSwitch</defName>
  <label>Antigrain DMS</label>
  <description>A highly explosive Dead Mans Switch.</description>
  <isBad>true</isBad>
  <stages>
    <Stage>
      <label>Active</label>
      <severity>1.0</severity>
    </Stage>
  </stages>
</Def>


## Harmony Patching

The mod uses Harmony patching to inject custom logic into existing RimWorld code. Harmony is a popular framework for patching and modding games based on the .NET framework.

### Example Harmony Patch
csharp
using HarmonyLib;
using Verse;

namespace DieForMe
{
    [HarmonyPatch(typeof(Pawn_DamageTracker), "Notify_DamageTaken")]
    public static class Pawn_DamageTracker_Notify_DamageTaken_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Pawn __instance, DamageInfo dinfo)
        {
            // Custom logic for handling damage
        }
    }
}


## Suggestions for Copilot

### General Suggestions
- **Useful Snippets**: Create Copilot snippets for common tasks, such as creating new hediff definitions or patching methods.
- **Example Code**: Provide examples of how to implement new DMS types or kill switches.
- **XML Templates**: Share XML templates for defining new hediffs, recipes, and research projects.

### Specific Suggestions
- **Hediff Definitions**: Copilot could suggest XML snippets for defining new hediff types with specific properties.
- **Patch Methods**: Copilot could suggest Harmony patch methods for injecting custom logic into existing RimWorld code.
- **Achievement Definitions**: Copilot could suggest XML snippets for defining new achievements.

### Example Copilot Snippet
xml
<!-- Hediff Definition Template -->
<Def>
  <defName>YOUR_HEDIFF_NAME</defName>
  <label>YOUR_HEDIFF_LABEL</label>
  <description>YOUR_HEDIFF_DESCRIPTION</description>
  <isBad>true</isBad>
  <stages>
    <Stage>
      <label>Active</label>
      <severity>1.0</severity>
    </Stage>
  </stages>
</Def>


By following these guidelines, Copilot can be a valuable tool for mod developers working on the Die for me (Continued) mod, helping to streamline the development process and improve the overall mod experience.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

