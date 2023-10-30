using Godot;
using Godot.Collections;


public partial class SceneTransitioner : Node
{

    public void TransitionToWithLoading(string scene, string loadingScene, TransitionData data)
    {
        data.IsLoadingScreen = true;
        data.ScenePath = scene;

        TransitionTo(scene, loadingScene, data);
    }

    public void TransitionTo(string scene, string transition, TransitionData data)
    {
        SceneTransition transitionScene = ResourceLoader.Load<PackedScene>(transition).Instantiate() as SceneTransition;

        transitionScene.Data = data;
        transitionScene.Data.TargetScene = scene;
        transitionScene.EmitSignal(SceneTransition.SignalName.StartedTransition, transitionScene.Data.ToDictionary());

        GetViewport().AddChild(transitionScene);
        transitionScene.FinishedTransition += OnFinishedTransition;
    }

    public void ChangeToFile(string path)
    {
        GetTree().ChangeSceneToFile(path);
    }

    public bool SceneIsAvailable(string path)
    {
        return FileAccess.FileExists(path) || ResourceLoader.Exists(path);
    }


    private void OnFinishedTransition(Dictionary data, PackedScene nextScene)
    {
        ChangeToFile((string)data["targetScene"]);
    }

    private bool IsLoadingScreen(Dictionary data)
    {
        return data.ContainsKey("isLoadingScreen") && (bool)data["isLoadingScreen"];
    }
}