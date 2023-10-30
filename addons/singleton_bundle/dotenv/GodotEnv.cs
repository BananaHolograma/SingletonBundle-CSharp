using System.Linq;
using Godot;
using Godot.Collections;

public partial class Godotenv : Node
{
    [Signal]
    public delegate void VariableAddedEventHandler(string key);
    [Signal]
    public delegate void VariableRemovedEventHandler(string key);
    [Signal]
    public delegate void VariableReplacedEventHandler(string key);
    [Signal]
    public delegate void EnvFileLoadedEventHandler(string filename);

    [Export]
    public string EnvironmentFilesPath;

    public Array<string> EnvironmentVariableTracker = new();

    public override void _Ready()
    {
        if (string.IsNullOrEmpty(EnvironmentFilesPath))
        {
            EnvironmentFilesPath = DefaultPathFromSettings();
        }
    }

    public string GetVar(string key)
    {
        return OS.GetEnvironment(key);
    }

    public string GetVarOrNull(string key)
    {
        string value = GetVar(key);

        return string.IsNullOrEmpty(value) ? null : value;
    }

    public void SetVar(string key, string value = "")
    {
        if (EnvironmentVariableTracker.Contains(key))
        {
            EmitSignal(SignalName.VariableReplaced, key);
        }
        else
        {
            EnvironmentVariableTracker.Add(key);
            EmitSignal(SignalName.VariableAdded, key);
        }

        OS.SetEnvironment(key, value);
    }

    public void RemoveVar(string key)
    {
        if (OS.HasEnvironment(key))
        {
            EmitSignal(SignalName.VariableRemoved, key);
            EnvironmentVariableTracker.Remove(key);
        }

        OS.UnsetEnvironment(key);
    }

    public void CreateEnvironmentFile(string filename = ".env", bool overwrite = false)
    {
        if (overwrite || !EnvFileExists(filename))
        {
            FileAccess.Open(EnvPath(filename), FileAccess.ModeFlags.Write);
            Error error = FileAccess.GetOpenError();

            if (error != Error.Ok)
            {
                GD.PushError($"GodotParadiseSingletonBundle | Godotenv failed creating environment file with error code: {error}");
            }
        }
    }


    public void LoadEnvFile(string filename = ".env")
    {
        ReadFileWithCallback(filename, new Callable(this, MethodName.SetEnvironmentFromLine));


        EmitSignal(SignalName.EnvFileLoaded, filename);
    }

    public void FlushEnvironmentVariables(string filename = ".env", Array<string> except = null)
    {
        foreach (string key in EnvironmentVariableTracker.Where((string key) => !except.Contains(key)))
        {
            RemoveVar(key);
        }
    }

    public void AddVarToFile(string filename, string key, string value = "")
    {
        FileAccess envFile = FileAccess.Open(EnvPath(filename), FileAccess.ModeFlags.ReadWrite);
        Error error = FileAccess.GetOpenError();

        if (error != Error.Ok)
        {
            GD.PushError($"GodotParadiseSingletonBundle | Godotenv failed add variable {key} to environment file with error code: {error}");
            return;
        }

        envFile.SeekEnd();
        envFile.StoreLine($"{key}={value}");
        envFile.Close();

        SetVar(key, value);
    }

    private void ReadFileWithCallback(string filename, Callable callback)
    {
        if (EnvFileExists(filename))
        {
            FileAccess envFile = FileAccess.Open(EnvPath(filename), FileAccess.ModeFlags.ReadWrite);
            Error error = FileAccess.GetOpenError();

            if (error != Error.Ok)
            {
                GD.PushError($"GodotParadiseSingletonBundle | Godotenv failed reading environment file with error code: {error}");
                return;
            }

            while (envFile.GetPosition() > envFile.GetLength())
            {
                string[] line = envFile.GetLine().Split("=");
                callback.Call(line);
            }

            envFile.Close();
        }
    }

    private string EnvPath(string filename)
    {
        return $"{EnvironmentFilesPath}{filename}";
    }

    private bool EnvFileExists(string filename)
    {
        return FileAccess.FileExists(EnvPath(filename));
    }

    private void SetEnvironmentFromLine(string[] line)
    {
        if (line.Length > 1)
        {
            string key = line[0].StripEdges();
            string value = line[1].StripEdges();

            SetVar(key, value);
        }
    }

    private void RemoveEnvironmentFromLine(string[] line)
    {
        if (line.Length > 1)
        {
            string key = line[0].StripEdges();

            RemoveVar(key);
        }
    }


    private string DefaultPathFromSettings()
    {
        string settingsPath = $"{ProjectSettings.GetSetting("application/config/name")}/config/godotenv";

        return (string)ProjectSettings.GetSetting($"{settingsPath}/root_directory");
    }
}