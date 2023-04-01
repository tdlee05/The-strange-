using UnrealBuildTool;

public class TheStrangeTarget : TargetRules
{
	public TheStrangeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TheStrange");
	}
}
