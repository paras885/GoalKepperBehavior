using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialConfiguration {
	private Field _field;
	private Ball ball;
	private GoalPost goalPost;
	private Player player;
	private PlayerFactory playerFactory;

	const int fieldLength = 150; // in meters.
	const int fieldWidth = 150; // in meters.

	public Field field {
		get { return _field; }
	}

	public InitialConfiguration () {
		_field = new FieldImpl ();

		setBallWithInitialConfiguration ();
		setGoalPostWithInitialConfiguration ();
		setGoalKepperWithInitialConfiguration ();

		_field.setBall (ball);
		_field.setGoalPost (goalPost);
		_field.setPlayer (player);
		_field.setLength (fieldLength);
		_field.setWidth (fieldWidth);
	}

	private void setBallWithInitialConfiguration () {
		ball = new BallImpl ();
		ball.setCurrentLocation (new Location(74.5f, 11.0f));
		ball.setCurrentVelocity (new Velocity(new Vector3(-0.15f, -0.5f, 0f)));
	}

	private void setGoalPostWithInitialConfiguration () {
		goalPost = new GoalPostImpl ();
		goalPost.setBottomLeft (new Location(67.68f, 0f));
		goalPost.setBottomRight (new Location(82.32f, 0f));
	}

	private void setGoalKepperWithInitialConfiguration () {
		player = new GoalKepperImpl ();
		player.setCurrentSpeed (0.2f);
		player.setCurrentLocation (new Location(75.0f, 2.0f));
	}
}
