using Godot;
using Godot.Collections;


public partial class SceneTransition : Node
{
    [Signal]
    public delegate void StartedTransitionEventHandler(Dictionary data);
    [Signal]
    public delegate void FinishedTransitionEventHandler(Dictionary data, PackedScene nextScene);

    public TransitionData Data;
    public Array Progress = new() { 0 };
    public ResourceLoader.ThreadLoadStatus LoadStatus = ResourceLoader.ThreadLoadStatus.Failed;

    public override void _EnterTree()
    {
        EmitSignal(SignalName.StartedTransition, Data.ToDictionary());
    }

    public override void _Ready()
    {
        if (IsLoadingScreen())
        {
            ResourceLoader.LoadThreadedRequest(Data.ScenePath);
        }

    }

    public override void _Process(double delta)
    {
        if (IsLoadingScreen())
        {
            LoadStatus = ResourceLoader.LoadThreadedGetStatus(Data.ScenePath, Progress);

            if (LoadStatus.Equals(ResourceLoader.ThreadLoadStatus.Loaded))
            {
                EmitSignal(SignalName.FinishedTransition, Data.ToDictionary(), ResourceLoader.LoadThreadedGet(Data.ScenePath));
                QueueFree();
            }
        }
    }

    public bool IsLoadingScreen()
    {
        return Data.IsLoadingScreen;
    }

    public static explicit operator SceneTransition(Resource v)
    {
        throw new System.NotImplementedException();
    }

    public static implicit operator Resource(SceneTransition v)
    {
        throw new System.NotImplementedException();
    }
}

public record TransitionData
{
    public string ScenePath { get; set; } = string.Empty;
    public string TargetScene { get; set; } = string.Empty;
    public bool IsLoadingScreen { get; set; } = false;

    public TransitionData(string scenePath, string targetScene, bool isLoadingScreen = false)
    {
        ScenePath = scenePath;
        TargetScene = targetScene;
        IsLoadingScreen = isLoadingScreen;
    }

    public Dictionary ToDictionary()
    {
        return new() {
            { "scenePath", ScenePath },
            { "targetScene", TargetScene },
            { "isLoadingScreen", IsLoadingScreen }
         };
    }
}