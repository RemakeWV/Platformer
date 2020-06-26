// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TP_Platformer : ModuleRules
{
	public TP_Platformer(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
