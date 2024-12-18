// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class GraduationWorkTarget : TargetRules
{
	public GraduationWorkTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;

		ExtraModuleNames.AddRange( new string[] { "GraduationWork" } );
	}
}