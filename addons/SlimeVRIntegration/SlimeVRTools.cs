#if TOOLS
using Godot;
using System;

[Tool]
public partial class SlimeVRTools : EditorPlugin
{
	public override void _EnterTree()
	{
		var script = GD.Load<Script>("res://addons/SlimeVRIntegration/SlimeVRInterface.cs");
		var texture = GD.Load<Texture2D>("res://addons/SlimeVRIntegration/Node.svg");
		AddCustomType("SlimeVRInterface", "Node", script, texture);
	}

	public override void _ExitTree()
	{
		// Clean-up of the plugin goes here.
		RemoveCustomType("SlimeVRInterface");
	}
}
#endif
