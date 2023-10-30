#if TOOLS
using System.Collections.Generic;
using Godot;
using Godot.Collections;

[Tool]
public partial class GodotParadiseSingletonBundlePlugin : EditorPlugin
{
	private Setting setting = new($"{ProjectSettings.GetSetting("application/config/name")}/config/godotenv/root_directory", "res://", PropertyHint.TypeString, Variant.Type.String);


	public override void _EnterTree()
	{
		SetupSettings();

		AddAutoloadSingleton(AddPrefix("AudioManager"), "res://addons/singleton_bundle/audio/AudioManager.cs");
		AddAutoloadSingleton(AddPrefix("Environment"), "res://addons/singleton_bundle/dotenv/GodotEnv.cs");
		AddAutoloadSingleton(AddPrefix("Utilities"), "res//addons/singleton_bundle/utils/Utilities.cs");
	}

	public override void _ExitTree()
	{
		RemoveAutoloadSingleton(AddPrefix("AudioManager"));
		RemoveAutoloadSingleton(AddPrefix("Environment"));
		RemoveAutoloadSingleton(AddPrefix("Utilities"));

		RemoveSettings();
	}

	private void SetupSettings()
	{
		ProjectSettings.SetSetting(setting["name"], setting["value"]);
		ProjectSettings.AddPropertyInfo(new() { { "name", setting["name"] }, { "type", setting["type"] } });
	}

	private void RemoveSettings()
	{
		if (ProjectSettings.HasSetting(setting["name"]))
		{
			ProjectSettings.SetSetting(setting["name"], null);
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
