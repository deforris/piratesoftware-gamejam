using Godot;
using System;

public partial class player : CharacterBody2D
{
	public int mySpeed { get; set; } = 400;

	public void GetInput()
	{
		Vector2 inputDirection = Input.GetVector("left", "right", "up", "down");
		Velocity = inputDirection * mySpeed;
	}

	public override void _PhysicsProcess(double delta)
	{
		GetInput();
		MoveAndSlide();
	}
}
