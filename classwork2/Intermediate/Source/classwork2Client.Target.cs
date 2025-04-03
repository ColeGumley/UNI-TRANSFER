using UnrealBuildTool;

public class classwork2ClientTarget : TargetRules
{
	public classwork2ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("classwork2");
	}
}
