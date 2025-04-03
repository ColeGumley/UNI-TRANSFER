using UnrealBuildTool;

public class classwork2EditorTarget : TargetRules
{
	public classwork2EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("classwork2");
	}
}
