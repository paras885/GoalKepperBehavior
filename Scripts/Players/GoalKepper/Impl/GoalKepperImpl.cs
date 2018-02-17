using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKepperImpl : Player {
	private Location currentLocation;
	private float currentSpeed;
	private float maxSpeed;

	public GoalKepperImpl() {
		maxSpeed = 2.0f; // Unit is in meters. 
	}

	public Location getCurrentLocation () {
		return currentLocation;
	}

	public void setCurrentLocation (Location location) {
		this.currentLocation = location;
	}

	public float getCurrentSpeed () {
		return currentSpeed;
	}

	public float getMaxSpeed () {
		return maxSpeed;
	}

	public void setCurrentSpeed (float currentSpeed) {
		this.currentSpeed = currentSpeed;
	}
}
