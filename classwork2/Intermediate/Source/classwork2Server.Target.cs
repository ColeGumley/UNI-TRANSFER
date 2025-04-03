using UnrealBuildTool;

public class classwork2ServerTarget : TargetRules
{
	public classwork2ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("classwork2");
	}
}
