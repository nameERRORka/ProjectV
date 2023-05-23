using UnrealBuildTool;

public class ProjectBTarget : TargetRules
{
	public ProjectBTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProjectB");
	}
}
