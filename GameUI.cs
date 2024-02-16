using Godot;
using System;

public partial class GameUI : CanvasLayer
{
	public void Pause()
	{
		GetTree().Paused = true;
	}
	public void Resume()
	{
		GetTree().Paused = false;
	}
}
