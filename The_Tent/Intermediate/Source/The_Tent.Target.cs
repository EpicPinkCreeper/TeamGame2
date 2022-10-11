using UnrealBuildTool;

public class The_TentTarget : TargetRules
{
	public The_TentTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("The_Tent");
	}
}
