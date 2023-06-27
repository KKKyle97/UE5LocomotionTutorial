// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LocomotionTutorial : ModuleRules
{
	public LocomotionTutorial(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "EnhancedInput", "GameplayTags", "GameplayAbilities", "GameplayTasks" });
	}
}
