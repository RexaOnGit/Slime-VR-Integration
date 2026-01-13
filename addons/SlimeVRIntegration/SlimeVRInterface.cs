using System;
using Godot;


[Tool]
public partial class SlimeVRInterface : Node
{
    // private SlimeVRClient _slimeVrClient;

    // public SlimeVRInterface()
    // {
    //     _slimeVrClient = new SlimeVRClient();
    //     _slimeVrClient.UsesSkeletalRotation = false;
    //     _slimeVrClient.NewDataReceived += delegate { ClientLoop(); };
    //     _slimeVrClient.Start();
    // }

    // public void ClientLoop()
    // {
    //     try
    //     {
    //         GD.Print(_slimeVrClient.Trackers);
    //     } catch (Exception ex)
    //     {
    //         GD.Print($"ClientLoop error: {ex.Message}");
    //     }
    // }

    public override void _EnterTree()
    {
        GD.Print("Hello World");
    }

    public override void _ExitTree()
    {
        
    }
}