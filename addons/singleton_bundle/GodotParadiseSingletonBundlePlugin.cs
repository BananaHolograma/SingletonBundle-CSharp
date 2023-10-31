#if TOOLS
using System;
using System.Collections.Generic;
using Godot;
using Godot.Collections;

[Tool]
public partial class GodotParadiseSingletonBundlePlugin : EditorPlugin
{
	private readonly Setting setting = new(
		$"{ProjectSettings.GetSetting("application/config/name")}/config/godotenv/root_directory",
		"res://",
		PropertyHint.TypeString,
		Variant.Type.String
	);


	public override void _EnterTree()
	{
		SetupSettings();

		AddAutoloadSingleton(AddPrefix("AudioManager"), "res://addons/singleton_bundle/audio/AudioManager.cs");
		AddAutoloadSingleton(AddPrefix("Environment"), "res://addons/singleton_bundle/dotenv/GodotEnv.cs");
		AddAutoloadSingleton(AddPrefix("Utilities"), "res://addons/singleton_bundle/utils/Utilities.cs");
		AddAutoloadSingleton(AddPrefix("VectorWizard"), "res://addons/singleton_bundle/utils/VectorWizard.cs");
		AddAutoloadSingleton(AddPrefix("SceneTransitioner"), "res://addons/singleton_bundle/scene_transition/SceneTransitioner.cs");

		AddCustomType(
			AddPrefix("SceneTransition"),
			"Node",
			GD.Load<Script>("res://addons/singleton_bundle/scene_transition/SceneTransition.cs"),
		 	GD.Load<Texture2D>("res://addons/singleton_bundle/scene_transition/video.png")
		 );
	}

	public override void _ExitTree()
	{
		RemoveAutoloadSingleton(AddPrefix("AudioManager"));
		RemoveAutoloadSingleton(AddPrefix("Environment"));
		RemoveAutoloadSingleton(AddPrefix("Utilities"));
		RemoveAutoloadSingleton(AddPrefix("VectorWizard"));
		RemoveAutoloadSingleton(AddPrefix("SceneTransitioner"));

		RemoveCustomType(AddPrefix("SceneTransition"));
		RemoveSettings();
	}

	private void SetupSettings()
	{
		ProjectSettings.SetSetting(setting.Name, setting.Value);
		ProjectSettings.AddPropertyInfo(new() { { "name", setting.Name }, { "type", (int)setting.Type } });
	}

	private void RemoveSettings()
	{
		if (ProjectSettings.HasSetting(setting.Name))
		{
			ProjectSettings.SetSetting(setting.Name, default);
		}
	}

	private string AddPrefix(string name)
	{
		return $"GodotParadise{name}";
	}
}

public record class Setting
{
	public string Name;
	public string Value;
	public PropertyHint Hint;
	public Variant.Type Type;

	public Setting(string name, string value, PropertyHint hint, Variant.Type type)
	{
		Name = name;
		Value = value;
		Hint = hint;
		Type = type;
	}
}
#endif
