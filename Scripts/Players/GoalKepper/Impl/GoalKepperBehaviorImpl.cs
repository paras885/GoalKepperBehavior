using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKepperBehavior : PlayerBehavior {
	private Field field;
	private Player player;
	private enum Direction
	{
		Left,
		Right,
		Stay
	}
	private PhysicsUtil physicsUtil;

	public GoalKepperBehavior() {
		physicsUtil = new PhysicsUtil ();
	}

	public Location getNextPosition () {
		player = field.getPlayer ();

		return findNextPositionByDirection (whichDirectionPlayerNeedToMove ());
	}

	public void setField(Field field) {
		this.field = field;
	}

	private Location findNextPositionByDirection (Direction direction) {
		if (direction.Equals (Direction.Stay)) {
			return player.getCurrentLocation ();
		}
		Velocity currentVelocityOfGoalKepper = new Velocity (
			player.getCurrentSpeed() * getUnitVectorForGoalKepperByDirection (direction));
		return physicsUtil.getNextLocationByCurrentLocationAndVelocity (
				player.getCurrentLocation (),
				currentVelocityOfGoalKepper
			);
	}

	private Direction whichDirectionPlayerNeedToMove () {
		Location ballNextPosition = field.getNextPositionForBall ();
		Location playerCurrentPosition = player.getCurrentLocation ();

		if (playerCurrentPosition.x < ballNextPosition.x) {
			return Direction.Right;
		} else if (playerCurrentPosition.x > ballNextPosition.x) {
			return Direction.Left;
		} else {
			return Direction.Stay;
		}
	}

	private Vector3 getUnitVectorForGoalKepperByDirection (Direction direction) {
		if (direction.Equals (Direction.Left)) {
			return Vector3.left;
		} else if (direction.Equals (Direction.Right)) {
			return Vector3.right;
		}
		Debug.Log ("Kya chutiyapa h ye!!");
		return Vector3.one; // Code should not to reach here.
	}

}
