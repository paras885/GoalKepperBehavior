using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulation : MonoBehaviour {

	private InitialConfiguration initialConfiguration;
	private GameObject goalKepperGameObject;
	private GameObject ballGameObject;
	private Ball ball;
	private Player player;
	private GoalKepperBehavior goalKepperBehavior;

	private float zOffset = 0.5f;

	// Use this for initialization
	void Start () {
		initialConfiguration = new InitialConfiguration ();
		ball = initialConfiguration.field.getBall ();
		player = initialConfiguration.field.getPlayer ();
		goalKepperBehavior = new GoalKepperBehavior ();
		goalKepperBehavior.setField (initialConfiguration.field);

		// Initialize all game objects
		goalKepperGameObject = GameObject.Find("GoalKepper");
		ballGameObject = GameObject.Find ("Football");

		Debug.Log ("Goaly position : " + goalKepperGameObject.transform.position + " ball position" + ballGameObject.transform.position);
	}

	// Update is called once per frame
	void Update () {
		if(ballGameObject.GetComponent<BallCollider>().isCollide) {
			return;
		}

		Location goalKepperNextPosition = goalKepperBehavior.getNextPosition ();
		Location ballNextPosition = initialConfiguration.field.getNextPositionForBall ();
		moveGoalKepperGameObject (player.getCurrentLocation (), 
			goalKepperNextPosition, 
			player.getCurrentSpeed());
		moveBallGameObject (ball.getCurrentLocation(), ballNextPosition, 10f);
		player.setCurrentLocation (goalKepperNextPosition);
		ball.setCurrentLocation (ballNextPosition);
	}

	private void moveGoalKepperGameObject(Location currentLocation, Location nextLocation, float speed) {
		float step = speed * Time.deltaTime;
		goalKepperGameObject.transform.position = Vector3.MoveTowards (
			mapLocationToTransformPosition (currentLocation),
			mapLocationToTransformPosition (nextLocation),
			step
		);
	}

	private void moveBallGameObject(Location currentLocation, Location nextLocation, float speed) {
		float step = speed * Time.deltaTime;
		ballGameObject.transform.position = Vector3.MoveTowards (
			mapLocationToTransformPosition (currentLocation),
			mapLocationToTransformPosition (nextLocation),
			step
		);
	}

	private Vector3 mapLocationToTransformPosition(Location location) {
		// loc.x -> transform.z, loc.y -> transform.x;
		return new Vector3(location.y, zOffset, location.x);
	}

	private Vector3 mapVelocityWitUnityVelocity(Velocity velocity) {
		return new Vector3 (velocity.vector.y, zOffset, velocity.vector.x);
	}
 }
