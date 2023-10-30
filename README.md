<p align="center">
	<img width="256px" src="https://github.com/GodotParadise/SingletonBundle-CSharp/blob/main/icon.jpg" alt="GodotParadiseSingletonBundle-CSharp logo" />
	<h1 align="center">Godot Paradise SingletonBundle-CSharp</h1>
	
[![LastCommit](https://img.shields.io/github/last-commit/GodotParadise/SingletonBundle-CSharp?cacheSeconds=600)](https://github.com/GodotParadise/SingletonBundle-CSharp/commits)
[![Stars](https://img.shields.io/github/stars/godotparadise/SingletonBundle-CSharp)](https://github.com/GodotParadise/SingletonBundle-CSharp/stargazers)
[![Total downloads](https://img.shields.io/github/downloads/GodotParadise/SingletonBundle-CSharp/total.svg?label=Downloads&logo=github&cacheSeconds=600)](https://github.com/GodotParadise/SingletonBundle-CSharp/releases)
[![License](https://img.shields.io/github/license/GodotParadise/SingletonBundle-CSharp?cacheSeconds=2592000)](https://github.com/GodotParadise/SingletonBundle-CSharp/blob/main/LICENSE.md)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat&logo=github)](https://github.com/godotparadise/SingletonBundle-CSharp/pulls)
[![](https://img.shields.io/discord/1167079890391138406.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/XqS7C34x)
</p>

[![es](https://img.shields.io/badge/lang-es-yellow.svg)](https://github.com/GodotParadise/SingletonBundle-CSharp/blob/main/locale/README.es-ES.md)

- - -

This plugin offers a collection of singletons that encompass global resources and functionalities that can enhance your game's utility and accessibility.
- [Requirements](#requirements)
- [✨Installation](#installation)
	- [Automatic (Recommended)](#automatic-recommended)
	- [Manual](#manual)
	- [CSharp version](#csharp-version)
- [Getting Started](#getting-started)
	- [🧙‍♂️ Vector Wizard](#️-vector-wizard)
		- [normalize\_vector(value: Vector2) -\> Vector2:](#normalize_vectorvalue-vector2---vector2)
		- [normalize\_diagonal\_vector(direction: Vector2) -\> Vector2:](#normalize_diagonal_vectordirection-vector2---vector2)
		- [is\_diagonal\_direction(direction: Vector2) -\> bool:](#is_diagonal_directiondirection-vector2---bool)
		- [generate\_random\_direction() -\> Vector2:](#generate_random_direction---vector2)
		- [generate\_random\_angle(min\_angle\_range: float = 0.0, max\_angle\_range: float = 360.0) -\> float:](#generate_random_anglemin_angle_range-float--00-max_angle_range-float--3600---float)
		- [generate\_random\_directions\_on\_angle\_range(origin: Vector2 = Vector2.UP, min\_angle\_range: float = 0.0, max\_angle\_range: float = 360.0, num\_directions: int = 10) -\> Array\[Vector2\]:](#generate_random_directions_on_angle_rangeorigin-vector2--vector2up-min_angle_range-float--00-max_angle_range-float--3600-num_directions-int--10---arrayvector2)
		- [translate\_x\_axis\_to\_vector(axis: float) -\> Vector2:](#translate_x_axis_to_vectoraxis-float---vector2)
		- [distance\_manhattan\_v2(a: Vector2, b: Vector2) -\> float](#distance_manhattan_v2a-vector2-b-vector2---float)
		- [distance\_chebyshev\_v2(a: Vector2, b: Vector2) -\> float:](#distance_chebyshev_v2a-vector2-b-vector2---float)
		- [length\_manhattan\_v2(a : Vector2) -\> float:](#length_manhattan_v2a--vector2---float)
		- [length\_chebyshev\_v2(a : Vector2) -\> float:](#length_chebyshev_v2a--vector2---float)
		- [closest\_point\_on\_line\_clamped\_v2(a: Vector2, b: Vector2, c: Vector2) -\> Vector2:](#closest_point_on_line_clamped_v2a-vector2-b-vector2-c-vector2---vector2)
		- [closest\_point\_on\_line\_v2(a: Vector2, b: Vector2, c: Vector2) -\> Vector2:](#closest_point_on_line_v2a-vector2-b-vector2-c-vector2---vector2)
		- [distance\_manhattan\_v3(a: Vector3, b: Vector3) -\> float:](#distance_manhattan_v3a-vector3-b-vector3---float)
		- [distance\_chebyshev\_v3(a: Vector3, b: Vector3) -\> float:](#distance_chebyshev_v3a-vector3-b-vector3---float)
		- [length\_manhattan\_v3(a: Vector3) -\> float:](#length_manhattan_v3a-vector3---float)
		- [length\_chebyshev\_v3(a: Vector3) -\> float:](#length_chebyshev_v3a-vector3---float)
		- [closest\_point\_on\_line\_v3(a: Vector3, b: Vector3, c: Vector3) -\> Vector3:](#closest_point_on_line_v3a-vector3-b-vector3-c-vector3---vector3)
		- [closest\_point\_on\_line\_clamped\_v3(a: Vector3, b: Vector3, c: Vector3) -\> Vector3:](#closest_point_on_line_clamped_v3a-vector3-b-vector3-c-vector3---vector3)
		- [closest\_point\_on\_line\_normalized\_v3(a: Vector3, b: Vector3, c: Vector3) -\> float:](#closest_point_on_line_normalized_v3a-vector3-b-vector3-c-vector3---float)
	- [🕶️ General utilities](#️-general-utilities)
		- [func generate\_random\_string(length: int, characters: String =  "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"):](#func-generate_random_stringlength-int-characters-string---abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz0123456789)
		- [is\_valid\_url(url: String) -\> bool:](#is_valid_urlurl-string---bool)
		- [frame\_freeze(time\_scale: float, duration: float):](#frame_freezetime_scale-float-duration-float)
	- [⚙️ Environment variables](#️-environment-variables)
		- [Variable tracker](#variable-tracker)
		- [Example of use](#example-of-use)
		- [Loading variables from other files](#loading-variables-from-other-files)
		- [Signals](#signals)
		- [get\_var(key: String) -\> String](#get_varkey-string---string)
		- [get\_var\_or\_null(key: String)](#get_var_or_nullkey-string)
		- [set\_var(key: String, value: String = "") -\> void](#set_varkey-string-value-string-----void)
		- [remove\_var(key: String)-\> void](#remove_varkey-string--void)
		- [create\_environment\_file(filename: String = ".env", overwrite: bool = false) -\> void](#create_environment_filefilename-string--env-overwrite-bool--false---void)
		- [load\_env\_file(filename: String = ".env") -\> void](#load_env_filefilename-string--env---void)
		- [flush\_environment\_variables(filename: String = ".env", except: Array\[String\] = \[\]) -\> void](#flush_environment_variablesfilename-string--env-except-arraystring-----void)
		- [add\_var\_to\_file(filename: String, key: String, value: String = "") -\> void](#add_var_to_filefilename-string-key-string-value-string-----void)
	- [🎬 Scene transitioner](#-scene-transitioner)
		- [Transition with loading screen](#transition-with-loading-screen)
		- [GodotParadiseSceneTransicioner](#godotparadisescenetransicioner)
			- [transition\_to(scene, transition: PackedScene, data: Dictionary = {})](#transition_toscene-transition-packedscene-data-dictionary--)
			- [transition\_to\_with\_loading(scene: String, loading\_scene: PackedScene, data: Dictionary = {})](#transition_to_with_loadingscene-string-loading_scene-packedscene-data-dictionary--)
		- [GodotParadiseSceneTransition](#godotparadisescenetransition)
			- [Variables](#variables)
			- [Signals](#signals-1)
	- [🎵 Audio](#-audio)
		- [Accessible normal variables](#accessible-normal-variables)
		- [change\_volume(bus, value: float) -\> void](#change_volumebus-value-float---void)
		- [get\_actual\_volume\_db\_from\_bus\_name(name: String) -\> float](#get_actual_volume_db_from_bus_namename-string---float)
		- [get\_actual\_volume\_db\_from\_bus\_index(index: int) -\> float](#get_actual_volume_db_from_bus_indexindex-int---float)
		- [Functional Example:](#functional-example)
- [✌️You are welcome to](#️you-are-welcome-to)
- [🤝Contribution guidelines](#contribution-guidelines)
- [📇Contact us](#contact-us)

# Requirements
📢 We don't currently give support to Godot 3+ as we focus on future stable versions from version 4 onwards
* Godot 4+

# ✨Installation
## Automatic (Recommended)
You can download this plugin from the official [Godot asset library](https://godotengine.org/asset-library/asset/2039) using the AssetLib tab in your godot editor. Once installed, you're ready to get started
##  Manual 
To manually install the plugin, create an **"addons"** folder at the root of your Godot project and then download the contents from the **"addons"** folder of this repository
## GDScript version
This plugin has also been written in GDscript and you can find it on [SingletonBundle](https://github.com/GodotParadise/SingletonBundle)

# Getting Started
Each singleton is separated by a class name that defines its utility. This classes are autoloaded by Godot and added to the root scene make them globally available in all scenes of your project.

## 🧙‍♂️ Vector Wizard
A set of useful vector utilities that you are likely to use in your day-to-day work as a game developer. The functions that are marked as `v2` means that applies to `Vector2` and `v3` that applies to `Vector3`. If v3 functions **have no description**, it means that they do exactly the same thing but applied in a 3-dimensional space.

### Vector2 NormalizeVector(Vector2 value)
Normalize the vector only if it's not normalized and also changes if it's diagonal vector and do the proper normalization. Returns the vector
`GodotParadiseVectorWizard.NormalizeVector(Vector2(30, -40)) # returns Vector2(1, -1)`

### Vector2 NormalizeDiagonalVector(Vector2 direction)
A diagonal vector requires additional treatment, which can be applied using this function.
`GodotParadiseVectorWizard.NormalizeDiagonalVector(Vector2(-0.7444, 0.7444))`

### bool IsDiagonalDirection(Vector2 direction)
Performs a basic check and returns whether the direction passed as a parameter is diagonal. This function is used internally by the `normalize_diagonal_vector` function.
`GodotParadiseVectorWizard.is_diagonal_direction(Vector2(1, -1))`

### Vector2 GenerateRandomDirection()
Simple random Vector2 direction generator, use this function if you need a random direction in some behaviour of your game. The result is normalized

### GenerateRandomAngle(float minAngleRange = 0.0f, float maxAngleRange = 360.0f)
Generate a random angle between a range provided, the unit is on degrees
```py
# Between 90º and 120º
GodotParadiseVectorWizard.generate_random_angle(90, 120) # 117º
```

### GenerateRandomDirectionsOnAngleRange(Vector2 origin, float minAngleRange = 0.0f, float maxAngleRange = 360.0f, int numDirections = 10)
This function generate a n random directions in a Array[Vector2] format from an starting vector point defining the min and max angles:
```py
# 5 Random directions from Vector down (0, 1) between 90º and 180º
GodotParadiseVectorWizard.GenerateRandomDirectionsOnAngleRange(Vector2.Down, 90.0f, 180.0f, 5)

# 25 random directions from the actual player global position between 0 and 360º
GodotParadiseVectorWizard.GenerateRandomDirectionsOnAngleRange(player.GlobalPosition, 0.0f, 360.0f, 25)
```

### Vector2 TranslateXAxisToVector(float axis)
Translate a value that usually comes from [Input.GetAxis](https://docs.godotengine.org/en/stable/classes/class_input.html#class-input-method-get-axis) into a direction Vector2.
`Vector2 horizontalDirection = GodotParadiseVectorWizard.TranslateXAxisToVector(Input.GetAxis("ui_left", "ui_right"))`

### float DistanceManhattanV2(Vector2 a, Vector2 b)
Also known as the "city distance" or "L1 distance". It measures the distance between two points as the sum of the absolute differences of their coordinates in each dimension.

*Examples on where can be useful:*

**Path of a character in a maze:** In a maze game, you can use the Manhattan distance to calculate the distance between a character's current position and a potential exit. This will help you determine the direction in which the character should move to reach the exit with the least amount of moves, as it only allows moves in straight lines, such as up, down, left and right.

**Sliding puzzle:** In puzzle games where you must move pieces to solve a puzzle, the Manhattan distance is used to calculate how far a piece is from its target position. The closer a piece is to its correct position, the more it will "fit" into the puzzle.

### float DistanceChebysevV2(Vector2 a, Vector2 b)
*Examples on where can be useful:*

**Movement of a king in chess:** In a game of chess, the king moves in any direction *(horizontally, vertically or diagonally)*. The Chebyshev distance is used to determine how many moves it takes for the king to move from its current position to a target square, since the king can move in any of these directions.

**Movement in a turn-based strategy game:** In a turn-based strategy game, such as Civilization, where units can move in several directions, the Chebyshev distance can be used to calculate the distance between two locations on the map and determine how many turns it would take to get from one to the other.

### float LengthManhattanV2(Vector2 a)
The `LengthManhattanV2` function calculates the length or magnitude of a two-dimensional vector a using the Manhattan distance. Manhattan distance is determined by summing the absolute differences of the x and y coordinates of the vector. The result is a scalar value that represents the total distance traveled in terms of vertical and horizontal movements, which is useful in situations where movements occur in straight lines along orthogonal axes.

### float LengthChebysevV2(Vector2 a, Vector2 b)
The `LengthChebysevV2` function calculates the length or magnitude of a two-dimensional vector a using the Chebyshev distance. Chebyshev distance is determined by taking the maximum of the absolute differences between the x and y coordinates of the vector. The result is a scalar value that represents the maximum distance traveled in terms of movements in any direction, whether vertical, horizontal, or diagonal. This metric is useful in situations where movements can occur in multiple directions.

### Vector2 ClosestPointOnLineClampedV2(Vector2 a, Vector2 b, Vector2 c)
This function is specifically designed to find the closest point on a line segment, ensuring that the result lies within the boundaries of the segment. It's particularly useful in scenarios where it's essential to constrain the closest point to the line. 

For example, in a drawing application, you can employ this function to accurately snap a point to the nearest position on a line when creating freehand drawings.

### Vector2 ClosestPointOnLineV2(Vector2 a, Vector2 b, Vector2 c)
In contrast to the `closest_point_on_line_clamped` function, this variant is intended to identify the closest point on a line segment without imposing any restrictions on its location within or outside the segment. This makes it versatile in situations where you need to find the nearest point on a line but don't require it to be confined to the segment. 

For instance, in a CAD application, you might use this function to locate the closest point on a sketch line to a user-defined point.

### float DistanceManhattanV3(Vector3 a, Vector3 b)
### float DistanceChebysevV3(Vector3 a, Vector3 b)
### float LengthManhattanV3(Vector3 a)
### float LengthChebysevV3(Vector3 a, Vector3 b)
### Vector3 ClosestPointOnLineClampedV3(Vector3 a, Vector3 b, Vector3 c)
### Vector3 ClosestPointOnLineV3(Vector3 a, Vector3 b, Vector3 c)
### float ClosestPointOnLineNormalizedV3(Vector3 a, Vector3 b, Vector3 c)

## 🕶️ General utilities
Utilities that do not have a particular location and belong to a more global scope.

### string GenerateRandomString(int length, string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789")
You can use this function to generate a random string with a specified length and character list. For instance, you can utilize this function to create invitation codes for your multiplayer rooms:
`string invitationCode = GodotParadiseUtilities.GenerateRandomString(4, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789") # returns YMZ2`

### bool IsValidUrl(string url)
As the String class from Godot lack this validation you can use the following one:
`GodotParadiseUtilities.is_valid_url("https://example.com") # true`

### async void StartFrameFreeze(double timeScale, double duration)
To achieve a slow-motion effect you can use this function that receives the time scale *(as time goes by frame by frame)* and the duration of the freeze in seconds.
```py
# Time scale 0.05
# Duration 0.5 sec
GodotParadiseUtilities.StartFrameFreeze(0.05, 0.5)
```
Here you can see an example that trigger a frame freeze when a character jumps:
```py
func handle_jump():
	if Input.is_action_just_pressed("jump"):
		player.jump()
		GodotParadiseUtilities.StartFrameFreeze(0.05, 1)
```
`FrameFreezed` signal is emitted when the effect starts in case you want to listen to it to perform other actions such as triggering animations.
 Here you can see a basic example:
 ```py
 func _ready():
	GodotParadiseUtilities.StartFrameFreeze.connect(OnFrameFreezed)

func OnFrameFreezed():
	AnimatedSprite.Play("juicy_hurt")
	 #...
 ```


## ⚙️ Environment variables
To keep environment variables secure, avoid hard-coding sensitive information into your source code. By utilizing environment variables, you can ensure that such information remains protected.

Environment variables provide a standardized and crucial method for effectively managing sensitive information within your software projects. These variables serve as a secure repository for storing a wide range of confidential data, including but not limited to API keys, access tokens, database credentials, and configuration settings.

You can access all features by using the `GodotParadiseEnvironment` class in any part of your code. This class provides extra functionality while maintaining compatibility with `OS.GetEnvironment()` and `OS.SetEnvironment()` for runtime variable management.
By default, this class looks for `.env` files in the root of your project `res://` To modify this path, you can use:
`GodotParadiseEnvironment.EnvironmentFilesPath = "res://project"`

or set the value on the ***Project settings -> GodotEnv -> Root directory:***
![godotenv_settings](https://github.com/GodotParadise/SingletonBundle-CSharp/blob/main/images/godotenv_settings.png)

### Variable tracker
For internal execution convenience, the plugin tracks active variables without storing their values in array, as storing sensitive content in this array can risk data leaks or unauthorized access. This approach allows you to verify which variables have been read and loaded into memory without exposing their values:

`GodotEnvironment.EnvironmentVariableTracker # could return ["ADDRESS", "PORT", "SERVER_ID]`


### Example of use
```py
# .env file
ADDRESS=127.0.0.1
PORT=9492

SERVER_ID=1919

# random_script.gd
GodotEnvironment.LoadEnvFile(".env")

GodotEnvironment.GetVar("PORT") # Returns an empty string if does not exists
# or
GodotEnvironment.GetVarOrNull("PORT") # Returns null instead
```
**You only need to load your environment variables once**, and there's no need to load them in every `_Ready()` function in your nodes. If you have duplicate variables, the value used will be the one from the last occurrence. Therefore, it's important to review your files carefully to avoid unintentional overwriting.
```dotenv
ADDRESS=127.0.0.1
ADDRESS=192.168.1.55 # This is the one that will be assigned as it overwrites the previous one
```

### Loading variables from other files
This class supports reading multiple environment files. For production, it's highly advisable to refrain from including the `.env` file in your source code repository. Instead, consider providing on the repository an `.env.example` file with blank values for the keys used. This strategy enables you to duplicate the file and input the values in your local environment, thereby averting the inadvertent exposure of sensitive information.
```dotenv
# .env.example
ADDRESS=
PORT=
SERVER_NAME=

# random_script.gd
GodotEnvironment.LoadEnvFile(".env.example")
GodotEnvironment.LoadEnvFile(".env.dev")
GodotEnvironment.LoadEnvFile(".env.staging")
# ...
```

### Signals
```py
signal VariableAdded(string key)
signal VariableRemoved(string key)
signal VariableReplaced(string key)
signal EnvFileLoaded(string filename)
```

### string GetVar(string key)
This is an alternative to `OS.GetEnvironment(key)` : `GodotParadiseEnvironment.GetVar("SERVER_PORT")`

### string GetVarOrNull(string key)
Retrieve the value of an environment variable by its key or null it if it doesn't: `GodotEnvironment.GetVarOrNull("SERVER_PORT")`

### void SetVar(string key, string value = "")
Set a environment variable on the runtime process, this is an alternative to `OS.SetEnvironment(key, value)`:
`GodotEnvironment.SetVar("API_KEY", "991918291921")`

### void RemoveVar(string key)
Remove a variable from the runtime process `GodotEnvironment.RemoveVar("API_KEY")`

### void CreateEnvironmentFile(string filename = ".env", bool overwrite = false)
Create an environment file with the specified filename. If it already exists, it can be overwritten
```py
GodotEnvironment.CreateEnvironmentFile(".env")
GodotEnvironment.AddVarToFile("env", "PORT", 3000)
GodotEnvironment.AddVarToFile("env", "ENCRYPTION_ALGORITHM", 'SHA256')
```

### LoadEnvFile(filename: String = ".env") -> void
Read an `.env file` and set the valid environment variables to be accessible in the code:
`GodotEnvironment.LoadEnvFile(".env.example")`

### void FlushEnvironmentVariables(string filename = ".env", Array<string> except = null)
Remove environment variables from the current process runtime. You can add the keys that you do not want to be deleted in this process as second parameter:
```py
GodotEnvironment.FlushEnvironmentVariables(".env")
GodotEnvironment.FlushEnvironmentVariables(".env", ["IP_ADDRESS", "COUNTRY"])
```

### void AddVarToFile(string filename, string key, string value = "")
Add a key-value pair to an environment file and set the environment variable
```py
GodotEnvironment.AddVarToFile("env", "PORT", 4500)
GodotEnvironment.AddVarToFile("env", "APP_NAME", 'FightingTournament')
```

## 🎬 Scene transitioner
This handler facilitates seamless transitions between scenes, offering the option to include a loading screen, particularly useful for larger scenes.

The singleton can be accessed through `GodotParadiseSceneTransitioner`. This manager utilizes the foundational class GodotParadiseSceneTransition to manage scene transitions.

To effectively utilize this system, you are required to create your transition scenes by extending the foundational class `GodotParadiseSceneTransition`.

These transition scenes should incorporate the essential signals and parameters necessary for seamless integration with the singleton.

The `GodotParadiseSceneTransition` primarily functions as a container for managing additional parameters and emitting the appropriate signals. 
For example, consider a real use case, such as a fade scene where you can specify the animation name to choose between different types of fades *(e.g., 'fade_in' or 'fade_out').*

```csharp
// This is your transition_scene

public partial class YourTransitionScene : GodotParadiseSceneTransition {

	public AnimationPlayer animationPlayer;

	public override _Ready() {
		animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
		animationPlayer.Play(data["animation"])

		animationPlayer.AnimationFinished += OnAnimationFinished;
	}

	private void OnAnimationFinished(string name) {
		if(AnimationPlayer.GetAnimationList().Contains(name)) {
			EmitSignal(SignalName.FinishedTransition, data);
			QueueFree();
		}
	}
}
```
This is an example on how to use the transitioner, the `TargetScene` parameter can be provided as either a `PackedScene` or the `file path` to the desired scene:
```csharp
PackedScene TargetScene = ResourceLoader.Load<PackedScene>("res://example.tscn") # or raw string "res://example.tscn"
PackedScene yourTransitionScene = ResourceLoader.Load<PackedScene>("res://transitions/fade.tscn")

GodotParadiseSceneTransitioner.TransitionTo(target_scene, yourTransitionScene, new(){{"animation", "fade_in"}})
```
It's important to note that the `FinishedTransition` signal must be manually emitted. This design choice provides flexibility in determining precisely when a transition is considered complete.

### Transition with loading screen
This class offers a function designed for working with a loading screen as a transition. To utilize this functionality, your custom loading scene must also extend from `GodotParadiseSceneTransition` to receive progression data. 

***In this case, the `FinishedTransition` signal is emitted after the progress value reachs 1 when the scene load is completed.***

This feature is particularly beneficial for large scenes where loading times may be longer. When providing the scene, it should be passed as a file path since our class internally leverages the [ResourceLoader](https://docs.godotengine.org/en/stable/classes/class_resourceloader.html)

```csharp
PackedScene TargetScene = ResourceLoader.Load<PackedScene>("res://large_scene_example.tscn") # or raw string "res://example.tscn"
PackedScene loadingScene = ResourceLoader.Load<PackedScene>("res://transitions/loading.tscn")

GodotParadiseSceneTransitioner.TransitionToWithLoading(target_scene, loading)
```

In the loading scene, you gain access to progress and load status data retrieved from the [ResourceLoader](https://docs.godotengine.org/en/stable/classes/class_resourceloader.html), which you can utilize to display relevant information. Below is a basic example to demonstrate this functionality.
To ensure proper functionality, it's essential to call the parent `_Process()` function; failing to do so will result in the information not being updated:
```csharp
// res://transitions/loading.tscn
public partial class YourLoadingTransitionScene : GodotParadiseSceneTransition {
	ProgressBar progressBar;

	public override _Ready() {
		progressBar = GetNode<ProgressBar>("CenterContainer/ProgressBar");
	}

	public override void _Process(double delta) {
		base._Process(delta);
		progressBar.Value = progress[0];
	}
}

```
### GodotParadiseSceneTransicioner
#### transition_to(scene, transition: PackedScene, data: Dictionary = {})
The primary function responsible for initiating the transition to the target scene is the `TransitionTo` function. Any data passed to this function will be accessible within the transition scene, enabling the incorporation of external parameters as needed.
It is focused on transitioning pre-loaded scenes.

The `Scene` parameter can be received as `PackedScene` or `String file path`.

It's worth noting that the transition scene is added to the viewport, not the scene tree. This approach ensures that the transition will execute even if nodes in the main tree are freed

#### void TransitionToWithLoading(string scene, string loadingScene, TransitionData data)
It behaves identically to `TransitionTo`, but with one key distinction: the scene parameter must be provided as a file path string. This requirement is due to the transitioner's utilization of the [ResourceLoader](https://docs.godotengine.org/en/stable/classes/class_resourceloader.html) for scene loading

### GodotParadiseSceneTransition
#### Variables
- public TransitionData Data;
- public Array Progress;
- public ResourceLoader.ThreadLoadStatus LoadStatus

`TransitionData` is a custom class that transport specific parameters for the transition:
```csharp
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
```

```py
enum  ThreadLoadStatus:

● THREAD_LOAD_INVALID_RESOURCE = 0
#The resource is invalid, or has not been loaded with load_threaded_request().
● THREAD_LOAD_IN_PROGRESS = 1
# The resource is still being loaded.
● THREAD_LOAD_FAILED = 2
# Some error occurred during loading and it failed.
● THREAD_LOAD_LOADED = 3
# The resource was loaded successfully and can be accessed via load_threaded_get().
```
#### Signals
- *StartedTransition(Dictionary data)*
- *FinishedTransition(Dictionary data, PackedScene nextScene)* `NextScene` it's only provided on `TransitionToWithLoading`

## 🎵 Audio
Several helper functions for managing the volume levels of various buses in your game.

### Accessible normal variables
- public Array<string> AvailableBuses

Here is an array list of the available buses set up in your project, for example:
```csharp
GodotParadiseAudioManager.AvailableBuses # returns ["Master", "Music", "SFX"]
```

### void ChangeVolume(dynamic bus, float value)
Change the volume of selected `BusIndex` if it exists. Can receive the bus parameter as name or index.
```py
GodotParadiseAudioManager.ChangeVolume(1, 0.5f)
# or
GodotParadiseAudioManager.ChangeVolume("Music", 0.5f)
```
### float GetActualVolumeDBFromBusName(string name)
Retrieve the current volume value for the selected bus by its name. If the `BusName` does not exist in your project, it will raise an error and return a value of 0.0.

```csharp
GodotParadiseAudioManager.GetActualVolumeDBFromBusName("Music")
```

### float GetActualVolumeDBFromBusIndex(int busIndex)
Retrieve the current volume value for the selected bus by its index.
```csharp
GodotParadiseAudioManager.GetActualVolumeDBFromBusIndex(1)
# or
GodotParadiseAudioManager.GetActualVolumeDBFromBusIndex(AudioServer.GetBusIndex("Music"))
```

### Functional Example: 
Let's demonstrate how these functions can assist us in audio management within our game:
```csharp

public partial class YourUIScene : Control {
	HSlider Music;
	HSlider SFX;

	public override _Ready() {
		Music = GetNode<HSlider>("Parameters/VBoxContainer/HorizontalContainer/Sliders/Music");

		SFX = GetNode<HSlider>("Parameters/VBoxContainer/HorizontalContainer/Sliders/SFX");

		Music.Value = GodotParadiseAudioManager.GetActualVolumeDBFromBusName("Music")
		SFX.Value = GodotParadiseAudioManager.GetActualVolumeDBFromBusName("SFX")
	}

	private void OnMusicValueChanged(float value) {
		GodotParadiseAudioManager.ChangeVolume("Music", value)
	}

	private void OnMusicValueChanged(float value) {
		GodotParadiseAudioManager.ChangeVolume("SFX", value)
	}
}
```

# ✌️You are welcome to
- [Give feedback](https://github.com/GodotParadise/SingletonBundle-CSharp/pulls)
- [Suggest improvements](https://github.com/GodotParadise/SingletonBundle-CSharp/issues/new?assignees=BananaHolograma&labels=enhancement&template=feature_request.md&title=)
- [Bug report](https://github.com/GodotParadise/SingletonBundle-CSharp/issues/new?assignees=BananaHolograma&labels=bug%2C+task&template=bug_report.md&title=)

GodotParadise is available for free.

If you're grateful for what we're doing, please consider a donation. Developing GodotParadise requires massive amount of time and knowledge, especially when it comes to Godot. Even $1 is highly appreciated and shows that you care. Thank you!

- - -
# 🤝Contribution guidelines
**Thank you for your interest in Godot Paradise!**

To ensure a smooth and collaborative contribution process, please review our [contribution guidelines](https://github.com/GodotParadise/SingletonBundle-CSharp/blob/main/CONTRIBUTING.md) before getting started. These guidelines outline the standards and expectations we uphold in this project.

**📓Code of Conduct:** We strictly adhere to the [Godot code of conduct](https://godotengine.org/code-of-conduct/) in this project. As a contributor, it is important to respect and follow this code to maintain a positive and inclusive community.

- - -

# 📇Contact us
If you have built a project, demo, script or example with this plugin let us know and we can publish it here in the repository to help us to improve and to know that what we do is useful.
