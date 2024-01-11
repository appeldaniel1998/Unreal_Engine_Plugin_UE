using UnrealBuildTool;

public class UDP_CommunicationsTarget : TargetRules
{
	public UDP_CommunicationsTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("UDP_Communications");
	}
}
