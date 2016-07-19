// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class ProceduralMeshDemos : ModuleRules
{
	public ProceduralMeshDemos(TargetInfo Target)
	{
		PublicDependencyModuleNames.AddRange(new string[] 
        {
            "Core",
            "CoreUObject",
            "Engine",
            "InputCore",
            "ProceduralMeshes",
            "RenderCore",
            "ShaderCore",
            "RHI",
            "Kiss_FFT",
            "RuntimeMeshComponent"
        });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

        AddThirdPartyPrivateStaticDependencies(Target, "Kiss_FFT");


        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");
        // if ((Target.Platform == UnrealTargetPlatform.Win32) || (Target.Platform == UnrealTargetPlatform.Win64))
        // {
        //		if (UEBuildConfiguration.bCompileSteamOSS == true)
        //		{
        //			DynamicallyLoadedModuleNames.Add("OnlineSubsystemSteam");
        //		}
        // }
    }
}
