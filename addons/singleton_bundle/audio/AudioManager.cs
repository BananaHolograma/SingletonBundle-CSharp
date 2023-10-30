/*
Created by https://github.com/GodotParadise organization with LICENSE MIT
There are no restrictions on modifying, sharing, or using this component commercially
We greatly appreciate your support in the form of stars, as they motivate us to continue our journey of enhancing the Godot community
***************************************************************************************
This plugin offers a collection of singletons that encompass global resources and functionalities that can enhance your game's utility and accessibility now in C#
*/

using Godot;
using Godot.Collections;
using System.Linq;

public partial class AudioManager : Node
{

    public Array<string> AvailableBuses = new();

    public override void _Ready()
    {
        AvailableBuses = EnumerateAvailableBuses();
    }

    public void ChangeVolume(dynamic bus, float value)
    {
        bus = bus is string v ? AudioServer.GetBusIndex(v) : bus;

        AudioServer.SetBusVolumeDb(bus, Mathf.LinearToDb(value));
    }

    public float GetActualVolumeDBFromBusName(string name)
    {
        int busIndex = AudioServer.GetBusIndex(name);

        if (busIndex == -1)
        {
            GD.PushError($"GodotParadiseSingletonbundle | AudioManager: Cannot retrieve volume for bus name {name}, it does not exists");
            return 0.0f;
        }

        return GetActualVolumeDBFromBusIndex(busIndex);
    }

    public float GetActualVolumeDBFromBusIndex(int busIndex)
    {
        return Mathf.DbToLinear(AudioServer.GetBusVolumeDb(busIndex));
    }

    public Array<string> EnumerateAvailableBuses()
    {
        return (Array<string>)GD.Range(AudioServer.BusCount).Select((int busIndex) => AudioServer.GetBusName(busIndex));
    }
}