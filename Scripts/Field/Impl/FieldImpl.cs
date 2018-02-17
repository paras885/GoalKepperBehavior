using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldImpl : Field {

	private GoalPost goalPost;
	private Player player;
	private Ball ball;
	private int length;
	private int width;
	private PhysicsUtil physicsUtil;

	public FieldImpl() {
		physicsUtil = new PhysicsUtil ();
	}

	public GoalPost getGoalPost () {
		return goalPost;
	}

	public Player getPlayer () {
		return player;
	}

	public Ball getBall () {
		return ball;
	}

	public int getLength () {
		return length;
	}

	public int getWidth () {
		return width;
	}

	public void setGoalPost (GoalPost goalPost) {
		this.goalPost = goalPost;
	}

	public void setPlayer (Player player) {
		this.player = player;
	}

	public void setBall (Ball ball) {
		this.ball = ball;
	}

	public void setLength (int length) {
		this.length = length;
	}

	public void setWidth (int width) {
		this.width = width;
	}

	public Location getNextPositionForBall() {
		return physicsUtil.getNextLocationByCurrentLocationAndVelocity (
				ball.getCurrentLocation (),
				ball.getCurrentVelocity ()
			);
	}
}
