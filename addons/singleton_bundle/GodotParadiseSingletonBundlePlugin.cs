#if TOOLS
using System.Collections.Generic;
using Godot;

[Tool]
public partial class GodotParadiseSingletonBundlePlugin : EditorPlugin
{

	private Dictionary<string, dynamic> setting = new(){
		{"name", $"{ProjectSettings.GetSetting("application/config/name")}/config/godotenv/root_directory"},
		{"value", "res://"},
		{"hint", PropertyHint.TypeString},
		{"type", Variant.Type.String},
	};


	public override void _EnterTree()
	{
		SetupSettings();
		AddAutoloadSingleton(AddPrefix("AudioManager"), "res://addons/singleton_bundle/audio/AudioManager.cs");
		AddAutoloadSingleton(AddPrefix("Environment"), "res://addons/singleton_bundle/dotenv/GodotEnv.cs");
	}

	public override void _ExitTree()
	{
		RemoveAutoloadSingleton(AddPrefix("AudioManager"));
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
#endif
