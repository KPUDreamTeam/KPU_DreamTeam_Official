using UnrealBuildTool;

public class KPU_DreamTeam_DemoTarget : TargetRules
{
	public KPU_DreamTeam_DemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("KPU_DreamTeam_Demo");
	}
}
