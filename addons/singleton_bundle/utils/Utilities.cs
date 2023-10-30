using System;
using Godot;

public partial class Utilities : Node
{
    [Signal]
    public delegate void FrameFreezeEventHandler();

    private Random Random = new();

    public async void FrameFreeze(double timeScale, double duration)
    {
        EmitSignal(SignalName.FrameFreeze);

        double originalTimeScaleValue = Engine.TimeScale;
        Engine.TimeScale = timeScale;

        await ToSignal(GetTree().CreateTimer(duration * timeScale), Timer.SignalName.Timeout);

        Engine.TimeScale = originalTimeScaleValue;
    }

    public string GenerateRandomString(int length, string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789")
    {
        string result = string.Empty;

        if (!string.IsNullOrEmpty(characters) && length > 0)
        {
            foreach (int _ in GD.Range(length))
            {
                result += characters[Random.Next(characters.Length)];
            }
        }

        return result;
    }

    public bool IsValidUrl(string url)
    {
        return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
    }
}